using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double a = 0;
        public double b = 0;
        public double c = 0;
        public double d = 0;
        public double aDuble = 0;
        public double bDuble = 0;
        public double cDuble = 0;
        public double dDuble = 0;
        public int mode = 1;
        public string str = "";
        public string predstr = "";
        public bool pressYes = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button19_Click(object sender, EventArgs e) // равно
        {
            calculating();

            if (textBox5.Text != "не является простым числом")
            {
                textBox5.Text = "";
                predstr = "=";
                //Calculate calk = calculate();
                if ((b == 0) && (c == 0) && (d == 0)) // если все равны нулю то выводится первое
                {
                    textBox5.Text = a.ToString();
                }
                else
                {
                    if (a != 0)
                    {
                        textBox5.Text += a.ToString();
                    }
                    if (b != 0)
                    {
                        if (b > 0)
                        {
                            textBox5.Text += '+';
                        }
                        textBox5.Text += b.ToString() + 'i';
                    }
                    if (c != 0)
                    {
                        if (c > 0)
                        {
                            textBox5.Text += '+';
                        }
                        textBox5.Text += c.ToString() + 'j';
                    }
                    if (d != 0)
                    {
                        if (d > 0)
                        {
                            textBox5.Text += '+';
                        }
                        textBox5.Text += d.ToString() + 'k';
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (predstr == "=")
            {
                textBox1.Text = textBox5.Text;
            }
            textBox5.Text = "mod";
            calculating();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            str += (sender as Button).Text;
            textBox1.Text = str;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (predstr == "=")
            {
                textBox1.Text = textBox5.Text;
            }
            textBox5.Text = (sender as Button).Text;
            calculating();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (predstr == "=")
            {
                textBox1.Text = textBox5.Text;
            }
            textBox5.Text = (sender as Button).Text;
            calculating();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (predstr == "=")
            {
                textBox1.Text = textBox5.Text;
            }
            textBox5.Text = (sender as Button).Text;
            calculating();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (predstr == "=")
            {
                textBox1.Text = textBox5.Text;
            }
            textBox5.Text = (sender as Button).Text;
            calculating();
        }


        private void button21_Click(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            mode = 3;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            mode = 4;
        }

        public Calculate SetValues()
        {
            Calculate cal = new Calculate() { aCalculate = a, bCalculate = b, cCalculate = c, dCalculate = d, text5 = textBox5.Text, pred = predstr, mode2 = mode };
            return cal;
        }

        public void calculating()
        {
            Calculate val = SetValues();
            val.calc(str);
            aDuble = val.aDuble2;
            bDuble = val.bDuble2;
            cDuble = val.cDuble2;
            dDuble = val.dDuble2;
            textBox5.Text = val.text5;
            predstr = val.pred;
        }


    }

    public class Calculate
    {
        public double aCalculate;
        public double bCalculate;
        public double cCalculate;
        public double dCalculate;
        public double aDuble2;
        public double bDuble2;
        public double cDuble2;
        public double dDuble2;
        public string text5;
        public string pred;
        public int mode2;
        public void calc(string str3)
        {
            string str = str3;
            bool predYes = false;
            if (pred == "=")
            {
                predYes = true;
                pred = "";
                aCalculate = 0;
                bCalculate = 0;
                cCalculate = 0;
                dCalculate = 0;
                Console.WriteLine("sdfsdf");
            }
            if (mode2 == 1) //обычный
            {
                double.TryParse(str, out bCalculate);
                if (pred == "-")
                {
                    aCalculate -= bCalculate;
                }
                if ((pred == "+") || (pred == "") || (pred == null))
                {
                    aCalculate += bCalculate;
                }
                if (pred == "*")
                {
                    aCalculate *= bCalculate;
                }
                if (pred == "/")
                {
                    aCalculate /= bCalculate;
                }
                Console.WriteLine(aCalculate);
                bCalculate = 0;

            }

            if (mode2 == 2) //комплекс
            {
                if (((text5 == "+") || (text5 == "-") || (text5 == "*") || (text5 == "/")) && (predYes))
                {
                    aCalculate = aDuble2;
                    bCalculate = bDuble2;
                }
                else
                if (str[str.Length - 1] == 'i')
                {
                    string str1 = "";
                    for (int i = 0; i < (str.Length - 1); i++)
                    {
                        str1 += str[i];
                    }
                    str = str1;
                    double aprob;
                    double.TryParse(str, out aprob);
                    if ((pred == "+") || (pred == "") || (pred == null))
                    {
                        bCalculate += aprob;
                    }
                    if (pred == "-")
                    {
                        bCalculate -= aprob;
                    }
                    if (pred == "*")
                    {
                        double bprob = aCalculate;
                        aCalculate = -bCalculate * aprob;
                        bCalculate = bprob * aprob;
                    }
                    if (pred == "/")
                    {
                        double bprob = aCalculate;
                        aCalculate = -bCalculate / aprob;
                        bCalculate = bprob / aprob;
                    }
                }
                else
                {
                    double aprob;
                    double.TryParse(str, out aprob);
                    if (pred == "-")
                    {
                        aCalculate -= aprob;
                    }
                    if ((pred == "+") || (pred == "") || (pred == null))
                    {
                        aCalculate += aprob;
                    }
                    if (pred == "*")
                    {
                        aCalculate *= aprob;
                        bCalculate *= aprob;
                    }
                    if (pred == "/")
                    {
                        aCalculate /= aprob;
                        bCalculate /= aprob;
                    }

                }

            }


            if (mode2 == 3) //ква
            {
                if (((text5 == "+") || (text5 == "-") || (text5 == "*") || (text5 == "/")) && (predYes))
                {
                    aCalculate = aDuble2;
                    bCalculate = bDuble2;
                    cCalculate = cDuble2;
                    dCalculate = dDuble2;
                }
                else
                if (str[str.Length - 1] == 'i')
                {
                    string str1 = "";
                    for (int i = 0; i < (str.Length - 1); i++)
                    {
                        str1 += str[i];
                    }
                    str = str1;
                    double aprob;
                    double.TryParse(str, out aprob);
                    if ((pred == "+") || (pred == "") || (pred == null))
                    {
                        bCalculate += aprob;
                    }
                    if (pred == "-")
                    {
                        bCalculate -= aprob;
                    }
                    if (pred == "*")
                    {
                        double bprob = aCalculate;
                        double bprob1 = bCalculate;
                        double bprob2 = cCalculate;
                        double bprob3 = dCalculate;
                        aCalculate = -bprob1 * aprob;
                        bCalculate = bprob * aprob;
                        dCalculate = -bprob2 * aprob;
                        cCalculate = bprob3 * aprob;
                    }
                    if (pred == "/")
                    {
                        double bprob = aCalculate;
                        double bprob1 = bCalculate;
                        double bprob2 = cCalculate;
                        double bprob3 = dCalculate;
                        aCalculate = -bprob1 / aprob;
                        bCalculate = bprob / aprob;
                        dCalculate = -bprob2 / aprob;
                        cCalculate = bprob3 / aprob;
                    }
                }
                else
                if (str[str.Length - 1] == 'j')
                {
                    string str1 = "";
                    for (int i = 0; i < (str.Length - 1); i++)
                    {
                        str1 += str[i];
                    }
                    str = str1;
                    double aprob;
                    double.TryParse(str, out aprob);
                    if ((pred == "+") || (pred == "") || (pred == null))
                    {
                        cCalculate += aprob;
                    }
                    if (pred == "-")
                    {
                        cCalculate -= aprob;
                    }
                    if (pred == "*")
                    {
                        double bprob = aCalculate;
                        double bprob1 = bCalculate;
                        double bprob2 = cCalculate;
                        double bprob3 = dCalculate;
                        aCalculate = -bprob2 * aprob;
                        cCalculate = bprob * aprob;
                        dCalculate = bprob1 * aprob;
                        bCalculate = -bprob3 * aprob;
                    }
                    if (pred == "/")
                    {
                        double bprob = aCalculate;
                        double bprob1 = bCalculate;
                        double bprob2 = cCalculate;
                        double bprob3 = dCalculate;
                        aCalculate = -bprob2 / aprob;
                        cCalculate = bprob / aprob;
                        dCalculate = bprob1 / aprob;
                        bCalculate = -bprob3 / aprob;
                    }
                }
                else
                if (str[str.Length - 1] == 'k')
                {
                    string str1 = "";
                    for (int i = 0; i < (str.Length - 1); i++)
                    {
                        str1 += str[i];
                    }
                    str = str1;
                    double aprob;
                    double.TryParse(str, out aprob);
                    if ((pred == "+") || (pred == "") || (pred == null))
                    {
                        dCalculate += aprob;
                    }
                    if (pred == "-")
                    {
                        dCalculate -= aprob;
                    }
                    if (pred == "*")
                    {
                        double bprob = aCalculate;
                        double bprob1 = bCalculate;
                        double bprob2 = cCalculate;
                        double bprob3 = dCalculate;
                        aCalculate = -bprob3 * aprob;
                        dCalculate = bprob * aprob;
                        cCalculate = -bprob1 * aprob;
                        bCalculate = bprob2 * aprob;
                    }
                    if (pred == "/")
                    {
                        double bprob = aCalculate;
                        double bprob1 = bCalculate;
                        double bprob2 = cCalculate;
                        double bprob3 = dCalculate;
                        aCalculate = -bprob3 / aprob;
                        dCalculate = bprob / aprob;
                        cCalculate = -bprob1 / aprob;
                        bCalculate = bprob2 / aprob;
                    }
                }
                else
                {
                    //double aprob = a;
                    //double.TryParse(str, out a);
                    //a += aprob;
                    double aprob;
                    double.TryParse(str, out aprob);
                    if (pred == "-")
                    {
                        aCalculate -= aprob;
                    }
                    if ((pred == "+") || (pred == "") || (pred == null))
                    {
                        aCalculate += aprob;
                    }
                    if (pred == "*")
                    {
                        aCalculate *= aprob;
                        bCalculate *= aprob;
                        cCalculate *= aprob;
                        dCalculate *= aprob;
                    }
                    if (pred == "/")
                    {
                        aCalculate /= aprob;
                        bCalculate /= aprob;
                        cCalculate /= aprob;
                        dCalculate /= aprob;
                    }
                }
            }

            if (mode2 == 4) //мод
            {
                if (((text5 == "mod")) && (predYes))
                {
                    aCalculate = aDuble2;
                    bCalculate = bDuble2;
                    cCalculate = cDuble2;
                    dCalculate = dDuble2;
                    Console.WriteLine("1usl");
                }
                else
                if (pred == "mod")
                {
                    double aprob;
                    double.TryParse(str, out aprob);
                    double sqr = Math.Sqrt(aprob);
                    bool breakYes = false;
                    for (int i = 2; i < sqr + 1; i++)
                    {
                        if ((Math.Truncate(aprob) == aprob) && (Math.Truncate(aprob) % i == 0))
                        {
                            aCalculate = 0;
                            bCalculate = 0;
                            cCalculate = 0;
                            dCalculate = 0;
                            text5 = "не является простым числом";
                            Console.WriteLine("Не является простым числом");
                            breakYes = true;
                            break;
                        }
                    }
                    if (breakYes == false)
                    {
                        aCalculate = Math.Truncate(aCalculate) % Math.Truncate(aprob);
                        Console.WriteLine(aprob);
                    }
                    Console.WriteLine("2usl");
                }
                else
                if ((pred == "") || (pred == null))
                {
                    double.TryParse(str, out bCalculate);
                    aCalculate += bCalculate;
                    bCalculate = 0;
                }

            }
            str = "";
            pred = text5;
            aDuble2 = aCalculate;
            bDuble2 = bCalculate;
            cDuble2 = cCalculate;
            dDuble2 = dCalculate;
        }
    }

}
