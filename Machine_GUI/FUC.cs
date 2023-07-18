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
        public FUC()
        {
            InitializeComponent();
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
        }

     
      

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox4.Focus();
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox20.Focus();
            }
        }

      
    }
}
