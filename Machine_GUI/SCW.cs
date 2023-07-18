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
    public partial class SCW : UserControl
    {
        public SCW()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox19.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox4.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox13.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox1.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox5.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox14.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox16.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox6.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox15.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox19.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox5.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox7.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox1.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox4.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox6.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox8.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox2.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox5.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox16.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox9.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox3.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox19.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox8.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox4.Focus();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox7.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox9.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox11.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox5.Focus();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox8.Focus();
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
                textBox6.Focus();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox11.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox13.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox7.Focus();
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox10.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox12.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox8.Focus();
            }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox11.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox15.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox9.Focus();
            }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox1.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox10.Focus();
            }
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox13.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox15.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox11.Focus();
            }
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
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
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox12.Focus();
            }
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox17.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox16.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox21.Focus();
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox17.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox19.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox22.Focus();
            }
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox1.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
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
                textBox15.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox21.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox16.Focus();
            }
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox22.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox17.Focus();
            }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox21.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox23.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox18.Focus();
            }
        }

        private void textBox23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox22.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox19.Focus();
            }
        }

        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox23.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox13.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right) || e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox19.Focus();
            }
        }
    }
}
