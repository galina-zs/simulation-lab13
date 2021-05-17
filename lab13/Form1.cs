using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab13
{
    public partial class Form1 : Form
    {
        double U = 1;
        const int p = 5087; // большое простое число
        int M = 2900;       // M = p - 3^n. Берем n = 7, потому что 3^8 > p
        double R;

        double lambda = 0;
        int numberOfExperiments = 0;

        List<double> probs = new List<double>();
        List<double> stat = new List<double>();

        double[] criticalChi = new double [20]{3.8, 6, 7.8, 9.5, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3,
                                               19.7, 21, 22.4, 23.7, 25, 26.3, 27.6, 28.9, 30.1, 31.4};
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            lambda = (double)paramNumericUpDown.Value;
            numberOfExperiments = (int)numberOfExperimentsNumericUpDown.Value;

            probs.Clear();
            stat.Clear();

            FindProbabilities();
            FindStatistics();

            double average = FindAverage();
            double variance = FindVariance(average);

            double averageError = Math.Abs(average - lambda) / Math.Abs(average) * 100;
            double varianceError = Math.Abs(variance - lambda) / Math.Abs(average) * 100;

            double currentCriticalChi;
            double currentChi = FindChi();
            if (stat.Count <= 20)
            {
                currentCriticalChi = criticalChi[stat.Count - 1];
            }
            else
            {
                currentCriticalChi = criticalChi[19];
            }

            if (currentCriticalChi >= currentChi)
            {
                chiLabel.Text = "Chi-squared: " + currentCriticalChi.ToString() + ">= " + currentChi + " hypothesis confirmed";
            }
            else
            {
                chiLabel.Text = "Chi-squared: " + currentCriticalChi.ToString() + "< " + currentChi + " hypothesis not confirmed";
            }

            for (int i = 0; i < stat.Count; i++)
            {                
                chart1.Series[0].Points.AddXY(i + 1, stat[i] / numberOfExperiments);
            }
            averageLabel.Text = "Average: " + average.ToString() +
                                " (error = " + ((int)(averageError)).ToString() + "%)";
            varianceLabel.Text = "Variance: " + variance.ToString() +
                                " (error = " + ((int)(varianceError)).ToString() + "%)";
        }

        private void FindProbabilities()
        {
            int n = 0;
            double minProb = 1;
            double tempProb;
            long factorial = 1;
            double sumOfProbs = 0;

            while (true)
            {
                if (1 - sumOfProbs < minProb && n >= lambda)
                {
                    probs.Add(1 - sumOfProbs);
                    stat.Add(0);
                    return;
                }
                if (n != 0)
                {
                    factorial *= n;
                }
                tempProb = (double)(Math.Pow(lambda, n) / factorial) * (double)Math.Exp(-lambda);
                sumOfProbs += tempProb;
                probs.Add(tempProb);
                stat.Add(0);
                if (tempProb < minProb)
                {
                    minProb = tempProb;
                }
                n++;
            }
        }

        private void FindStatistics()
        {
            double tempR;
            for (int i = 0; i < numberOfExperiments; i++)
            {
                Generator();
                tempR = R;
                for (int j = 0; j < probs.Count; j++)
                {
                    tempR -= probs[j];
                    if (tempR <= 0)
                    {
                        stat[j]++;
                        break;
                    }
                }
            }
        }

        private double FindAverage()
        {
            double average = 0;
            for (int i = 0; i < stat.Count; i++)
            {
                average += stat[i] / numberOfExperiments * (i + 1);
            }
            return average;
        }

        private double FindVariance(double average)
        {
            double variance = 0;
            for (int i = 0; i < stat.Count; i++)
            {
                variance += stat[i] / numberOfExperiments * (i + 1) * (i + 1);
            }
            variance -= average * average;
            return variance;
        }

        private double FindChi()
        {
            double Chi = 0;
            for (int i = 0; i < probs.Count; i++)
            {
                if (probs[i] != 0)
                    Chi += (stat[i] * stat[i]) / (numberOfExperiments * probs[i]);
            }
            Chi -= numberOfExperiments;
            return Chi;
        }

        private void Generator() // метод вычетов. Модификация Коробова
        {
            R = U / p;
            U = (U * M) % p;
        }
    }
}
