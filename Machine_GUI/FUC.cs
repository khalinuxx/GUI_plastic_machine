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
    public partial class FUC : UserControl
    {
        public int comboBox1Focused = 0,combo2=0, combo3 = 0, combo4 = 0, combo5 = 0;
        public FUC()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox8.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox22.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                comboBox1.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                comboBox1.Focus();

            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox4.Focus();
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


        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox18.Focus();
            }

            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox8.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                comboBox4.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                comboBox4.Focus();

            }
        }

  
        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                comboBox5.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                comboBox5.Focus();
            }
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox22.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                comboBox5.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                comboBox5.Focus();
            }
        }

     
      

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                comboBox5.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                comboBox1.Focus();
            }
        }

        private void comboBox5_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    combo5 = 1 - combo5;
                    comboBox5.SelectedIndex = combo5;
                }

                if (e.KeyCode.Equals(Keys.Up))
                {

                    e.Handled = true;
                    comboBox4.Focus();

                }
                if (e.KeyCode.Equals(Keys.Down))
                {

                    e.Handled = true;
                    textBox22.Focus();
                }

                if (e.KeyCode.Equals(Keys.Right))
                {
                    e.Handled = true;
                    textBox18.Focus();

                }
                if (e.KeyCode.Equals(Keys.Left))
                {
                    e.Handled = true;
                    textBox18.Focus();

                }
            
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                combo2 = 1 - combo2;
                comboBox2.SelectedIndex = combo2;
            }

            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                comboBox1.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                comboBox3.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox8.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox8.Focus();

            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                comboBox1Focused = 1 - comboBox1Focused;
                comboBox1.SelectedIndex = comboBox1Focused;
            }

            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                textBox22.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                comboBox2.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox4.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox4.Focus();

            }
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                combo3 = 1 - combo3;
                comboBox3.SelectedIndex = combo3;
            }

            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                comboBox2.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                comboBox4.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox8.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox8.Focus();

            }
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                combo4 = 1 - combo4;
                comboBox4.SelectedIndex = combo4;
            }

            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                comboBox3.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                comboBox5.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox14.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox14.Focus();

            }
        }


    }
}
