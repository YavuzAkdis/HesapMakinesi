namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number;
        string operation;
        private void btn0_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "0";
            }
            else
            {
                label2.Text = label2.Text + "0";
            }


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "1";
            }
            else
            {
                label2.Text = label2.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "2";
            }
            else
            {
                label2.Text = label2.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "3";
            }
            else
            {
                label2.Text = label2.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "4";
            }
            else
            {
                label2.Text = label2.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "5";
            }
            else
            {
                label2.Text = label2.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "6";
            }
            else
            {
                label2.Text = label2.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "7";
            }
            else
            {
                label2.Text = label2.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "8";
            }
            else
            {
                label2.Text = label2.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                label2.Text = "9";
            }
            else
            {
                label2.Text = label2.Text + "9";
            }
        }

        private void btnVirgül_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0" || label2.Text == null)
            {
                 label2.Text = "0,";
            }
        }


        private void btnTopla_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(label2.Text);
            label1.Text = number + " + ";
            label2.Text = "";
            operation = "+";
        }

        private void btnCýkar_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(label2.Text);
            label1.Text = number + " - ";
            label2.Text = "";
            operation = "-";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(label2.Text);
            label1.Text = number + " x ";
            label2.Text = "";
            operation = "x";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(label2.Text);
            label1.Text = number + " / ";
            label2.Text = "";
            operation = "/";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            double number2;
            double sonuc;
            number2 = Convert.ToDouble(label2.Text);
            label2.Text = "";


            if (operation == "+")
            {
                sonuc = number + number2;
                label1.Text = Convert.ToString(sonuc);
                number = sonuc;
            }

            if (operation == "-")
            {
                sonuc = number - number2;
                label1.Text = Convert.ToString(sonuc);
                number = sonuc;
            }
            if (operation == "x")
            {
                sonuc = number * number2;
                label1.Text = Convert.ToString(sonuc);
                number = sonuc;
            }
            if (operation == "/")
            {
                if (number2==0)
                {
                    MessageBox.Show("Hatalý Ýþlem!");
                }
                else
                {
                    sonuc = number / number2;
                    label1.Text = Convert.ToString(sonuc);
                    number = sonuc;
                }
            }
        }

        private void btnTümünüSil_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "0";

        }
    }

}