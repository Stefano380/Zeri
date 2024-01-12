using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Approsimazione_zeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double Funzione(double x)
        {
            return x*x;
        }

        static double Derivata(double x)
        {
            double h = 0.00000001;
            return (Funzione(x + h) - Funzione(x)) / h;
        }

        Point[] points;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static double MetodoBisezione(double estremoa, double estremob)
        {
            double yA;
            double yB;
            double M = double.NaN;
            double yM;

            for (int i = 0; i < 1000; i++)
            {
                M = (estremob + estremoa) / 2;
                yM = Funzione(M);
                yA = Funzione(estremoa);
                yB = Funzione(estremob);

                if (yM == 0)
                    {
                        return M;
                    }
                    else if (yA*yM < 0)
                    {
                        estremob = M;
                    }
                    else if (yB*yM < 0)
                    {
                        estremoa = M;
                    }
                    else if(yA * yM < yB * yM)
                    {
                        estremob= M;
                    }
                    else
                    {
                        estremoa = M;
                    }
            }
            return M;
        }

        public static double MetodoSecanti(double estremoa, double estremob)
        {
            double yA;
            double yB;
            double ZeroRetta = 0;

            double m;
            double q;

            for (int i = 0; i < 1000; i++)
            {
                yA = Funzione(estremoa);
                yB = Funzione(estremob);

                m = (yB - yA) / (estremob - estremoa);
                q = yA - m * estremoa;

                ZeroRetta = (-q) / m;
                if (Funzione(ZeroRetta) > 0)
                {
                    estremob = ZeroRetta;
                }
                else
                {
                    estremoa = ZeroRetta;
                }
            }
            return ZeroRetta;
        }

        public static double MetodoTangenti(double estremoa, double estremob)
        {
            double X0;

            if((Derivata(estremoa) * estremoa - Funzione(estremoa)) / Derivata(estremoa)>estremoa && (Derivata(estremoa) * estremoa - Funzione(estremoa)) / Derivata(estremoa) < estremob)
            {
                X0 = (Derivata(estremoa) * estremoa - Funzione(estremoa)) / Derivata(estremoa);
            }
            else
            {
                X0 = (Derivata(estremob) * estremob - Funzione(estremob)) / Derivata(estremob);
            }

            for (int i = 0; i<100; i++)
            {
                X0 = (Derivata(X0) * X0 - Funzione(X0)) / Derivata(X0);
            }
            return X0;
        }

        private void btnDisegna_Click(object sender, EventArgs e)
        {
            int d = this.ClientSize.Width;

            points = new Point[d];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i,(int)(-Funzione(i-d/2) + this.ClientSize.Height / 2));
            }

            Graphics a = this.CreateGraphics();

            a.DrawCurve(new Pen(Color.Red), points);

            a.DrawLine(new Pen(Color.Black), this.ClientSize.Width / 2, 0, this.ClientSize.Width / 2, this.ClientSize.Height);
            a.DrawLine(new Pen(Color.Black), 0, this.ClientSize.Height / 2, this.ClientSize.Width, this.ClientSize.Height / 2);
        }

        private void btnBisezione_Click(object sender, EventArgs e)
        {
            double estremoa = double.Parse(textBox1.Text);
            double estremob = double.Parse(textBox2.Text);

            double soluzione = MetodoBisezione(estremoa, estremob);
            MessageBox.Show(string.Format("{0}", soluzione));
        }

        private void btnSecanti_Click(object sender, EventArgs e)
        {
            double estremoa = double.Parse(textBox1.Text);
            double estremob = double.Parse(textBox2.Text);

            double soluzione = MetodoSecanti(estremoa, estremob);
            MessageBox.Show(string.Format("{0}", soluzione));
        }

        private void btnTangenti_Click(object sender, EventArgs e)
        {
            double estremoa = double.Parse(textBox1.Text);
            double estremob = double.Parse(textBox2.Text);

            double soluzione = MetodoTangenti(estremoa, estremob);
            MessageBox.Show(string.Format("{0}", soluzione));
        }
    }
}
