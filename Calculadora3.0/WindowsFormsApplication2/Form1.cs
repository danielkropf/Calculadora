using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int pont = 0;
        double num;
        double num2;

        bool jabuti = false;

        double result;

        bool ok = false;
        
        string operacao;

        int operation;

        public Form1()
        {
            InitializeComponent();
        }
        public double rec(double var) {
            if (var == 0)
                return 1;

            return var * rec(var - 1);
        }
        public static int FibonacciI(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }
        public static double FibonacciR(double x)
        {
            if (x <= 2)
            {
                return 1;
            }
            return FibonacciR(x - 1) + FibonacciR(x - 2);
        }

        private void PamonhaDoce(object sender, EventArgs e)
        {
            if (jabuti)
            {
                conta.Text = "";
                operacao = "";
                resultado.Text = "";
                pont = 0;
                jabuti = false;
            }
            if (!jabuti)
            {
                Button digito = sender as Button;
                resultado.Text += digito.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vilgula(object sender, EventArgs e)
        {
            Button ponto = sender as Button;
            if (pont < 1) { 
                resultado.Text += ponto.Text;
                pont += 1;
            }
        }

        private void adicao(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " + ";
            conta.Text = operacao;

            operation = 1;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void subtracao(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " - ";
            conta.Text = operacao;

            operation = 2;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void vezes(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " * ";
            conta.Text = operacao;

            operation = 3;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void divisao(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " / ";
            conta.Text = operacao;

            operation = 4;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void resto(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " resto ";
            conta.Text = operacao;

            operation = 5;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void porcentagem(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " % ";
            conta.Text = operacao;

            operation = 6;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void potencia(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " ^ ";
            conta.Text = operacao;

            operation = 7;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void raiz(object sender, EventArgs e)
        {
            operacao += resultado.Text;
            operacao += " √";
            conta.Text = operacao;

            operation = 8;
            num = Convert.ToDouble(resultado.Text);
            resultado.Text = "";
            pont = 0;
        }

        private void seno(object sender, EventArgs e)
        {
            operacao += "Seno de ";
            operacao += resultado.Text;
            operacao += " = ";
            conta.Text = operacao;

            operation = 9;
            num = Math.Sin(Convert.ToDouble(resultado.Text));
            resultado.Text = Convert.ToString(num);
            jabuti = true;
        }

        private void cos(object sender, EventArgs e)
        {
            operacao += "Cos de ";
            operacao += resultado.Text;
            operacao += " = ";
            conta.Text = operacao;

            operation = 10;
            num = Math.Cos(Convert.ToDouble(resultado.Text));
            resultado.Text = Convert.ToString(num);
            jabuti = true;
        }

        private void tangente(object sender, EventArgs e)
        {
            operacao += "Tangente de ";
            operacao += resultado.Text;
            operacao += " = ";
            conta.Text = operacao;

            operation = 11;
            num = Math.Tan(Convert.ToDouble(resultado.Text));
            resultado.Text = Convert.ToString(num);
            jabuti = true;
        }
        private void FatorI_Click(object sender, EventArgs e)
        {
            operacao += "Fatoração Iterativa de ";
            operacao += resultado.Text;
            operacao += " = ";
            conta.Text = operacao;


            num = Convert.ToDouble(resultado.Text);
            result = num;
            for (int i = 0; i < (num - 1); i++)
            {
                result = result * (num - (i + 1));
            }
            resultado.Text = Convert.ToString(result);
        }
        private void FatorR_Click(object sender, EventArgs e)
        {
            operacao += "Fatoração Recursiva de ";
            operacao += resultado.Text;
            operacao += " = ";
            conta.Text = operacao;

            num = Convert.ToDouble(resultado.Text);
            resultado.Text = Convert.ToString(rec(num));
        }
        private void FiboI_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(resultado.Text);
            for (int i = 0; i < num; i++)
            {
                resultado.Text = Convert.ToString(FibonacciI(i));
            }
        }
        private void FiboR_Click(object sender, EventArgs e)
        {
            num = Convert.ToDouble(resultado.Text);
  
            resultado.Text = Convert.ToString(FibonacciR(num));
        }


        private void deleteall(object sender, EventArgs e)
        {
            Button limpar = sender as Button;
            resultado.Text = null;
            pont = 0;
            operation = 0;
            operacao = "";
            conta.Text = operacao;
        }

        private void deleteLast(object sender, EventArgs e)
        {
            if (!ok)
            {
                resultado.Text = null;
            }
        }

        private void deleteLetter(object sender, EventArgs e)
        {
            if (!ok)
            {
                int boxLength = resultado.Text.Length - 1;

                if (boxLength >= 0)
                {
                    resultado.Text = resultado.Text.Substring(0, boxLength);
                }
            }
        }

        private void igual(object sender, EventArgs e)
        {
            if (Convert.ToDouble(operation) > 0)
            {
                ok = true;
                num2 = Convert.ToDouble(resultado.Text);

                if (operation == 1)
                {
                    operacao += resultado.Text;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = num + num2;
                }
                if (operation == 2)
                {
                    operacao += resultado.Text;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = num - num2;
                }
                if (operation == 3)
                {
                    operacao += resultado.Text;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = num * num2;
                }
                if (operation == 4)
                {
                    operacao += resultado.Text;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = num / num2;
                }
                if (operation == 5)
                {
                    operacao += resultado.Text;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = num % num2;
                }
                if (operation == 6)
                {
                    operacao = resultado.Text;
                    operacao += "% de ";
                    operacao += num;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = num / 100 * num2;
                }
                if (operation == 7)
                {
                    operacao += resultado.Text;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = Math.Pow(num, num2);
                }
                if (operation == 8)
                {
                    operacao += resultado.Text;
                    operacao += " = ";
                    conta.Text = operacao;
                    result = Math.Pow(num, 1 / num2);
                }

                resultado.Text = Convert.ToString(result);
                jabuti = true;
            }

        }

        

        
    }
}