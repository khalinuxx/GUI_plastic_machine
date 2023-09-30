using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_GUI
{
    public partial class MOL : UserControl
    {

        private int comboBox2Focused = 0;
        private System.IO.Ports.SerialPort serialPort1;
        public MOL(System.IO.Ports.SerialPort serialPort1)
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;

            this.serialPort1 = serialPort1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox25.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox5.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox4.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox1.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox6.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox9.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox26.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox6.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox1.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox27.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox7.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox4.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox2.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox28.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox9.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox1.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox3.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox7.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox5.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox9.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox6.Focus();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox4.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox11.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox5.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox7.Focus();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox7.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox13.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox11.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox11.Focus();
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox9.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox10.Focus();
            }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("d1 " + textBox12.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                comboBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox13.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox14.Focus();
            }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("d2 " + textBox13.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox16.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox12.Focus();
            }
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("d3 " + textBox14.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox11.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox16.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox12.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox13.Focus();
            }
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                comboBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox21.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox20.Focus();
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                comboBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox22.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox19.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox17.Focus();
            }
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox16.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox23.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox18.Focus();
            }
        }



        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox17.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox25.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox22.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox24.Focus();
            }
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox16.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox17.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox19.Focus();
            }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox26.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox23.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox21.Focus();
            }
        }

        private void textBox23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox19.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox27.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox22.Focus();
            }
        }

        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox28.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox21.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox23.Focus();
            }
        }

        private void textBox25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("d4 " + textBox25.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox21.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox1.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox26.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox28.Focus();
            }
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("d5 " + textBox26.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox22.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox27.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox25.Focus();
            }
        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("d6 " + textBox27.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox23.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox28.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox26.Focus();
            }
        }

        private void textBox28_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("d7 " + textBox28.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox4.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox25.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox27.Focus();
            }
        }


        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                comboBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                comboBox2.Focus();
            }
        }

        private void Pressure_TextChange(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {

                int box_num = 0;
                Int32.TryParse(textBox.Text, out box_num);
                if ((box_num < 0) && (textBox1.Text != ""))
                {
                    textBox.Text = "0";

                }
                else if ((box_num > 150) && (textBox.Text != ""))
                {

                    textBox.Text = "150";
                }
                else
                { //Do nothing
                }
            }
        }

        private void speed_TextChange(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {

                int box_num = 0;
                Int32.TryParse(textBox.Text, out box_num);
                if ((box_num < 0) && (textBox1.Text != ""))
                {
                    textBox.Text = "0";

                }
                else if ((box_num > 100) && (textBox.Text != ""))
                {

                    textBox.Text = "100";
                }
                else
                { //Do nothing
                }
            }
        }

        private void NUMONLY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                comboBox2Focused = 1-comboBox2Focused;
                comboBox2.SelectedIndex = comboBox2Focused;

            }

                if (e.KeyCode.Equals(Keys.Up))
                {

                    e.Handled = true;
                    textBox12.Focus();

                }
                if (e.KeyCode.Equals(Keys.Down))
                {

                    e.Handled = true;
                    textBox17.Focus();
                }
            
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox16.Focus();
             
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox16.Focus();
                
            }
        }
    }
}
