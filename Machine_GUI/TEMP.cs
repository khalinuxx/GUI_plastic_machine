using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Machine_GUI
{
    
    public partial class TEMP : UserControl
    {
        private System.IO.Ports.SerialPort serialPort1;
        public TEMP(System.IO.Ports.SerialPort serialPort1)
        {
            InitializeComponent();
            textBox2.Focus();


            this.serialPort1 = serialPort1;

        }



       

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t1 " + textBox2.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox37.Focus();
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
                textBox20.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t5 "+ textBox3.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox45.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox15.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox21.Focus();
            }
        }

 

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t2 " + textBox5.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox8.Focus();
            }
        }



    

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t3 " + textBox8.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox5.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox11.Focus();
            }
        }

      

      

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t4 " + textBox11.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox36.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox8.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox14.Focus();
            }
        }



      

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox15.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox11.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox17.Focus();
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
                textBox49.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox18.Focus();
            }
        }

        

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox38.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
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
                textBox17.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox50.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox15.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox21.Focus();
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
                textBox51.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox3.Focus();
            }
        }

 





        private void textBox37_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t7 " + textBox37.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox49.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox14.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox39.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox38.Focus();
            }
        }

        private void textBox38_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t8 " + textBox38.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox50.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox17.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox39.Focus();
            }
        }

        private void textBox39_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t9 " + textBox39.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox51.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox20.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox38.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox37.Focus();
            }
        }

        private void textBox45_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                serialPort1.WriteLine("t6 " + textBox45.Text);
            }
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox3.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox49.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox51.Focus();
            }
        }

     


       

        private void textBox49_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox15.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox37.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox50.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox45.Focus();
            }
        }

        private void textBox50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox18.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox38.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox51.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox49.Focus();
            }
        }

        private void textBox51_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox21.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox39.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox45.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox50.Focus();
            }
        }

        private void TEMP_Load(object sender, EventArgs e)
        {
           // SerialPort serialport1 = new SerialPort(); // Initialize your SerialPort instance

            //TEMP userControl = new TEMP();
            //userControl.serialPort1 = serialPort1;
            // Add the user control to your form's controls
           // Controls.Add(userControl); // Add it to the appropriate container
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Up))
            {
                e.Handled = true;
                textBox39.Focus();
            }
            if (e.KeyCode.Equals(Keys.Down))
            {
                e.Handled = true;
                textBox21.Focus();
            }
            if (e.KeyCode.Equals(Keys.Right))
            {
                e.Handled = true;
                textBox2.Focus();
            }
            if (e.KeyCode.Equals(Keys.Left))
            {
                e.Handled = true;
                textBox17.Focus();
            }
        }

      
        private void TempetureLimit(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {

                int box_num = 0;
                Int32.TryParse(textBox.Text, out box_num);
                if ((box_num < 0) && (textBox1.Text != ""))
                {
                    textBox.Text = "0";

                }
                else if ((box_num > 400) && (textBox.Text != ""))
                {

                    textBox.Text = "400";
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
    }
}
