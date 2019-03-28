using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class MathQuiz : Form
    {
        int numA;
        int numB;
        int totalA;
        int randMath;
        int check;
        int Amount = 0;
        //add comments
        public MathQuiz()
        {
            InitializeComponent();
            Start();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        { 
        }

        private void KeyisDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.P || e.KeyChar == 112)
            {
                check = 1;
                checkStart();
                
            }

            else if (e.KeyChar == (char)Keys.M || e.KeyChar == 109)
            {
                check = 2;
                checkStart();
               
            }

            else if (e.KeyChar == (char)Keys.X || e.KeyChar == 120)
            {
                check = 3;
                checkStart();
               
            }

            else if (e.KeyChar == (char)Keys.D || e.KeyChar == 100)
            {
                check = 4;
                checkStart();
               
            }
        }

        public void Start()
        {
            
            Random ranNumber = new Random();
            numA = ranNumber.Next(1, 40);
            numB = ranNumber.Next(1, 50);
            randMath = ranNumber.Next(1, 5);
            Symbol.Image = Properties.Resources.qq;

            if (randMath < Amount)
            {
                Application.Exit();
                Amount++;
            }
            
            switch (randMath)
            {
                case 1:
                    addNum();
                    Console.WriteLine("Your score:" + score);
                    break;
                case 2:
                    subtractNum();
                    Console.WriteLine("Your score:" + score);
                    break;
                case 3:
                    multiplyNum();
                    Console.WriteLine("Your score:" + score);
                    break;
                case 4:
                    divideNum();
                    Console.WriteLine("Your score:" + score);
                    break;
                default:
                    Console.WriteLine("Your score:" + score);
                    break;
            }
            num1.Text = Convert.ToString(numA);
            num2.Text = Convert.ToString(numB);
            total.Text = Convert.ToString(totalA);
        }

        public void addNum()
        {
            totalA = numA + numB;
        }
        public void subtractNum()
        {
            totalA = numA - numB;
        }
        public void multiplyNum()
        {
            totalA = numA * numB;
        }
        public void divideNum()
        {
            totalA = numA / numB;
        }

        public void checkStart()
        {
            if (check == randMath)
            {
                Amount++;

                switch (randMath)
                {
                    case 1:
                        Symbol.Image = Properties.Resources.plus;
                        MessageBox.Show("Correct");
                        score.Text = "score:" + Amount;
                        Start();
                        break;
                    case 2:
                        Symbol.Image = Properties.Resources.minus;
                        MessageBox.Show("Correct");
                        score.Text = "score:" + Amount;
                        Start();
                        break;
                    case 3:
                        Symbol.Image = Properties.Resources.multi;
                        MessageBox.Show("Correct");
                        score.Text = "score:" + Amount;
                        Start();
                        break;
                    case 4:
                        Symbol.Image = Properties.Resources.divide;
                        MessageBox.Show("Correct");
                        score.Text = "score:" + Amount;
                        Start();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wrong Answer");
                Symbol.Image = Properties.Resources.qq;
                Start();
            }
        }
    }
}
 
