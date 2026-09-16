using AnalaizerClassLibrary;
using CalcClassBr;
using ErrorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphInterface
{
    public partial class Form1 : Form
    {
        public static string expression = null;
        int memory = 0;
        string result = "0";
        private bool nonNumberEntered = false;
        int timercount = 0;
        bool IstimeOut = false;
        char sign = ' ';
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "1";
            IstimeOut = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "2";
            IstimeOut = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "3";
            IstimeOut = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "4";
            IstimeOut = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "5";
            IstimeOut = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "6";
            IstimeOut = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "7";
            IstimeOut = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "8";
            IstimeOut = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "9";
            IstimeOut = false;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "0";
            IstimeOut = false;
        }

        private void buttonABS_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timercount = 0;
            timer1.Start();
            int count = 0;
            if (IstimeOut == false)
            {
                char temp = Convert.ToChar(textBoxExpression.Text.Substring(textBoxExpression.Text.Length - 1));
                bool check = isNumber(temp);
                long a = 0;
                string numberToConvert = "";

                if (check == true)
                {
                    count++;
                    numberToConvert += temp;
                    while (check == true && textBoxExpression.Text.Length > count)
                    {
                        int from = textBoxExpression.Text.Length - count - 1;
                        temp = textBoxExpression.Text.Substring(from).First();
                        check = isNumber(temp);
                        if (check == true)
                        {
                            numberToConvert = temp + numberToConvert;
                            count++;
                        }
                        else sign = temp;
                    }
                    a = long.Parse(numberToConvert);
                }
                if (sign == '*' || sign == '/' || sign == '(' || sign == ' ')
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count) + "-" + a;
                }
                else if (sign == '+' || sign == 'p')
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count - 1) + "-" + a;
                }
                else if (sign == '-' || sign == 'm')
                {
                    textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - count - 1) + "+" + a;
                }
                else if (sign == ')')
                {
                    textBoxExpression.Text = textBoxExpression.Text;
                }
            }
            else
            {
                textBoxExpression.Text += "-";
                timer1.Stop();
                timercount = 0;
                IstimeOut = false;
            }
        }
        private bool isNumber(char number)
        {
            if (number == '0' || number == '1' || number == '2' || number == '3' ||
           number == '4' || number == '5' || number == '6' || number == '7' || number == '8' || number == '9')
                return true;
            else return false;
        }
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "/";
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "*";
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "-";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "+";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.Text == "")
                textBoxExpression.Text += memory.ToString();
            else if (textBoxExpression.Text.Length > 0)
            {
                bool checkNumber = isNumber(textBoxExpression.Text.Substring(textBoxExpression.Text.Length - 1).FirstOrDefault());
                if (checkNumber == false)
                    textBoxExpression.Text += memory.ToString();
            }
            label2.Text = "Memory";
            textBoxResult.Text = memory.ToString();
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            buttonEqual_Click(sender, e);
            int checkResult = 0;
            if (result == "")
                memory += 0;
            else
            {
                bool isNumber = int.TryParse(result, out checkResult);
                //TryParse переконвертовує введене стрінгове значення в Int32, та заодно перевіряє чи воно інтове, повертає
                //true або false
                if (isNumber == true)
                {
                    if (checkResult + memory >= int.MaxValue || checkResult + memory <= int.MinValue ||
                         checkResult >= int.MaxValue || checkResult <= int.MinValue)
                        MessageBox.Show(ErrorsExpression.ERROR_06);
                    else
                        memory += checkResult;
                }
                else MessageBox.Show($"Error code can't be written into memory!");
            }
        }
        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            textBoxResult.Text = "";
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            label2.Text = "Result";
            timercount = 0;
            IstimeOut = false;
            AnalaizerClass.expression = textBoxExpression.Text;
            string results = AnalaizerClass.Estimate();
            if (results.StartsWith("&"))
            {
                this.textBoxResult.ForeColor = Color.Red;
                this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            }
            else
            {
                this.textBoxResult.ForeColor = Color.Blue;
                this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            }
            textBoxResult.Text = results;

        }
        private void buttonOpenBracket_Click(object sender, EventArgs e)
        {
            IstimeOut = false;
            if (textBoxExpression.Text != "")
            {
                char znak = textBoxExpression.Text.Substring(textBoxExpression.Text.Length - 1).FirstOrDefault();
                bool isZnak = isNumber(znak);
                if (isZnak == false)
                    textBoxExpression.Text += "(";
                else
                    textBoxExpression.Text += "*(";
            }
            else
                textBoxExpression.Text += "(";
        }

        private void buttonCloseBracket_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += ")";
        }
        private void buttonBS_Click(object sender, EventArgs e)
        {
            if (textBoxExpression.Text.Length == 1)
            {
                textBoxExpression.Text = "";
            }
            else if (textBoxExpression.Text.Length > 1)
            {
                textBoxExpression.Text = textBoxExpression.Text.Substring(0, textBoxExpression.Text.Length - 1);
            }
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text = string.Empty;
            textBoxResult.Text = string.Empty;
        }
        private void buttonMod_Click(object sender, EventArgs e)
        {
            textBoxExpression.Text += "%";
        }

        private void textBoxExpression_TextChanged(object sender, EventArgs e)
        {
            expression = textBoxExpression.Text;
            if (textBoxExpression.Text.Length > 1 && textBoxExpression.Text.StartsWith("0"))
            {
                textBoxExpression.Text = textBoxExpression.Text.Substring(1);
            }

            bool checkNumber = false;
            foreach (char item in textBoxExpression.Text)
            {
                checkNumber = isNumber(item);
            }
            if (checkNumber == true || textBoxExpression.Text == "")
            {
                sign = ' ';
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Initialize the flag to false.
            textBoxExpression.Focus();
            nonNumberEntered = false;
            if (e.KeyValue == (char)Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyValue == (char)Keys.Enter)
            {
                textBoxExpression.Focus();
                buttonEqual_Click(sender, e);
            }
            //If shift key was pressed, it's an alowed symbol.
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (e.KeyCode != Keys.Multiply &&
                    e.KeyCode != Keys.Oemplus &&
                    e.KeyCode != Keys.OemOpenBrackets &&
                    e.KeyCode != Keys.OemCloseBrackets &&
                    e.KeyCode != Keys.Add &&
                    e.KeyCode != Keys.Oem102 &&
                    e.KeyCode != Keys.Oem5
                    )
                {
                    nonNumberEntered = false;
                }
                else nonNumberEntered = true;
            }
            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is not backspace or operands
                    if (e.KeyCode != Keys.Back &&
                    e.KeyCode != Keys.OemMinus &&
                    e.KeyCode != Keys.Divide &&
                    e.KeyCode != Keys.OemBackslash &&
                    e.KeyCode != Keys.Multiply &&
                    e.KeyCode != Keys.Oemplus &&
                    e.KeyCode != Keys.OemOpenBrackets &&
                    e.KeyCode != Keys.OemCloseBrackets &&
                    e.KeyCode != Keys.Add &&
                    e.KeyCode != Keys.Oem102 &&
                     e.KeyCode != Keys.Oem4 &&
                     e.KeyCode != Keys.Oem5 &&
                     e.KeyCode != Keys.OemQuestion
                    )
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                    else nonNumberEntered = false;
                }
            }
        }
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            result = textBoxResult.Text;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timercount < 3)
            {
                IstimeOut = false;
                timercount++;
                this.Text = timercount.ToString();
            }
            else if (timercount == 3)
            {
                IstimeOut = true;
                timer1.Stop();
                timercount = 0;
            }
            else
            {
                timer1.Stop();
                timercount = 0;
                IstimeOut = false;
            }
        }
    }
}