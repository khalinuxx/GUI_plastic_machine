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
    public partial class Prog_Ver : UserControl
    {
        public Prog_Ver()
        {
            InitializeComponent();
        }



        private void NUMONLY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox19.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox20.Focus();

            }
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                textBox15.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                textBox22.Focus();
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

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                textBox17.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                textBox23.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox18.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox19.Focus();

            }
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                textBox18.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                textBox24.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox22.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox23.Focus();

            }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                textBox19.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                textBox25.Focus();
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
                textBox20.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                textBox26.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox21.Focus();

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
                textBox21.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                textBox27.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox25.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox26.Focus();

            }
        }

        private void textBox25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {

                e.Handled = true;
                textBox22.Focus();

            }
            if (e.KeyCode.Equals(Keys.Down))
            {

                e.Handled = true;
                textBox28.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox26.Focus();

            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox24.Focus();

            }
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox23.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox29.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox25.Focus();
            }
        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox24.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox30.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox28.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox29.Focus();
            }
        }

        private void textBox28_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox25.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox31.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox29.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox27.Focus();
            }
        }

        private void textBox29_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox26.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox32.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox27.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox28.Focus();
            }
        }

        private void textBox30_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox27.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox33.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox31.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox32.Focus();
            }
        }

        private void textBox31_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox28.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox34.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox32.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox30.Focus();
            }
        }

        private void textBox32_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox29.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox35.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox30.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox31.Focus();
            }
        }

        private void textBox33_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox30.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox36.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox34.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox35.Focus();
            }
        }

        private void textBox34_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox31.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox37.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox35.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox33.Focus();
            }
        }

        private void textBox35_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox32.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox38.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox33.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox34.Focus();
            }
        }

        private void textBox36_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox33.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox39.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox38.Focus();
            }
        }

        private void textBox37_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox34.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox40.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox38.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox36.Focus();
            }
        }

        private void textBox38_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox35.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox41.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox36.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox37.Focus();
            }
        }

        private void textBox39_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox36.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox42.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox40.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox41.Focus();
            }
        }

        private void textBox40_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox43.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox41.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox39.Focus();
            }
        }

        private void textBox41_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox38.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox44.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox39.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox40.Focus();
            }
        }

        private void textBox42_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox39.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox15.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox43.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox44.Focus();
            }
        }

        private void textBox43_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox40.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox15.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox44.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox42.Focus();
            }
        }

        private void textBox44_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox41.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox17.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox42.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox43.Focus();
            }
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox42.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox18.Focus();
            }

            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox17.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox17.Focus();
            }
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox44.Focus();
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
                textBox15.Focus();
            }
        }
    }
}
