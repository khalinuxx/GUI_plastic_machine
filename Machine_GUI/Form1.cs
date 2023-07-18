using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_GUI
{


    public partial class Form1 : Form
    {

        public delegate void d1(String indata);

        public
        int InOutWin = 0;
        bool InOut = false;

        int FUNCWin = 0;
        bool FUNC = false;

        int KeyWin = 0;
        bool Key = false;

        int INJWin = 0;
        bool INJ = false;

        int MOULWin = 0;
        bool MOUL = false;

        bool MONI = false;

  
        void FUNC_HIDE()
        {

            FUNCWin = 0;
            FUNC = false;

            prod1.Visible=false;
            mem1.Visible = false;
            rec1.Visible = false;
            fuc1.Visible = false;
        }

        void INOUT_HIDE()
        {
            InOutWin = 0;
            InOut = false;

            userControl11.Visible = false;
            ouT11.Visible = false;
            ouT21.Visible = false;
            iN21.Visible = false;

        }

        void MOUL_HIDE()
        {

         MOULWin = 0;
         MOUL = false;

            eje1.Visible = false;
            mol1.Visible = false;
            cor1.Visible = false;
            uni1.Visible = false;

        }

        void  Label_show(Label x)
        {
            moule.BackColor = Color.White;
            moule.ForeColor = Color.Black;

            outin.BackColor = Color.White;
            outin.ForeColor = Color.Black;

            Inje.BackColor = Color.White;
            Inje.ForeColor = Color.Black;

            funct.BackColor = Color.White;
            funct.ForeColor = Color.Black;

            keys.BackColor = Color.White;
            keys.ForeColor = Color.Black;

            monit.BackColor = Color.White;
            monit.ForeColor = Color.Black;

            x.BackColor = Color.Green;
            x.ForeColor = Color.White;
        }


        void KEY_HIDE()
        {
            KeyWin = 0;
            Key = false;
            keY11.Visible = false;
            keY21.Visible = false;
            keY31.Visible = false;
            keY41.Visible = false;
            prog_Ver1.Visible = false;
        }
        void MONIT_HIDE()
        {
            MONI = false;
            moniT11.Visible = false;
            moniT21.Visible = false;
            spc1.Visible = false;
            alarm1.Visible = false;
            alrec1.Visible = false;
        }
        void INJ_HIDE()
        {
            INJWin = 0;
            INJ = false;
            inj1.Visible = false;
            temp1.Visible = false;
            scw1.Visible = false;
            pre1.Visible = false;
            cur1.Visible = false;

        }



            public Form1()
        {
            InitializeComponent();

            FUNC_HIDE();
            INOUT_HIDE();
            KEY_HIDE();
            INJ_HIDE();
            MOUL_HIDE();

            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comPort.Items.Add(s);
            }
            if (comPort.Items.Count > 0)
                comPort.SelectedIndex = comPort.Items.Count - 1;

            serialPort1.PortName = comPort.SelectedItem.ToString();

            serialPort1.Open();

            //arduino reset
           /* serialPort1.DtrEnable = true;
            Thread.Sleep(500);
            serialPort1.DtrEnable = false;*/

        }

        private void info_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InOut)
            {
                if (InOutWin != 3)
                    InOutWin++;

                switch (InOutWin)
                {


                    case 1:
                        iN21.Show();
                        iN21.BringToFront();

                        break;
                    case 2:
                        ouT11.Show();
                        ouT11.BringToFront();

                        break;
                    case 3:
                        ouT21.Show();
                        ouT21.BringToFront();
                        break;
                }
            }

            if (FUNC)
            {
                if (FUNCWin != 3)
                    FUNCWin++;

                switch (FUNCWin)
                {
                    case 1:
                        prod1.Show();
                        prod1.BringToFront();

                        break;
                    case 2:
                        rec1.Show();
                        rec1.BringToFront();

                        break;
                    case 3:
                        mem1.Show();
                        mem1.BringToFront();
                        break;
                }

            }

            if (Key)
            {
                if (KeyWin != 4)
                    KeyWin++;

                switch (KeyWin)
                {
                    case 1:
                        keY21.Show();
                        keY21.BringToFront();
                        break;
                    case 2:
                        keY31.Show();
                        keY31.BringToFront();
                        break;
                    case 3:
                        keY41.Show();
                        keY41.BringToFront();
                        break;
                    case 4:
                        prog_Ver1.Show();
                        prog_Ver1.BringToFront();
                        break;

                }


            }


            if (INJ)
            {
                if (INJWin != 4)
                    INJWin++;

                switch (INJWin)
                {
                    case 1:
                        scw1.Show();
                        scw1.BringToFront();
                        break;
                    case 2:
                        temp1.Show();
                        temp1.BringToFront();

                        break;
                    case 3:
                        pre1.Show();
                        pre1.BringToFront();

                        break;

                    case 4:
                        cur1.Show();
                        cur1.BringToFront();
                        break;

                }

            }

            if (MOUL)
            {
                if (MOULWin != 3)
                    MOULWin++;

                switch (MOULWin)
                {
                    case 1:
                        eje1.Show();
                        eje1.BringToFront();

                        break;
                    case 2:
                        cor1.Show();
                        cor1.BringToFront();

                        break;
                    case 3:
                        uni1.Show();
                        uni1.BringToFront();
                        break;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InOut)
            {
                if (InOutWin != 0)
                    InOutWin--;

                switch (InOutWin)
                {
                    case 0:
                        userControl11.Show();
                        userControl11.BringToFront();
                        break;
                    case 1:
                        iN21.Show();
                        iN21.BringToFront();

                        break;
                    case 2:
                        ouT11.Show();
                        ouT11.BringToFront();

                        break;

                }
            }

            if (FUNC)
            {
                if (FUNCWin != 0)
                    FUNCWin--;

                switch (FUNCWin)
                {
                    case 0:
                        fuc1.Show();
                        fuc1.BringToFront();
                        

                        break;
                    case 1:
                        prod1.Show();
                        prod1.BringToFront();

                        break;
                    case 2:
                        rec1.Show();
                        rec1.BringToFront();

                        break;
                }

            }


            if (Key)
            {
                if (KeyWin != 0)
                    KeyWin--;

                switch (KeyWin)
                {
                    case 0:
                        keY11.Show();
                        keY11.BringToFront();
                        break;
                    case 1:
                        keY21.Show();
                        keY21.BringToFront();
                        break;
                    case 2:
                        keY31.Show();
                        keY31.BringToFront();
                        break;
                    case 3:
                        keY41.Show();
                        keY41.BringToFront();
                        break;

                }
            }

            if (INJ)
            {
                if (INJWin != 0)
                    INJWin--;

                switch (INJWin)
                {
                    case 0:
                        inj1.Show();
                        inj1.BringToFront();
                        break;
                    case 1:
                        scw1.Show();
                        scw1.BringToFront();
                        break;
                    case 2:
                        temp1.Show();
                        temp1.BringToFront();

                        break;
                    case 3:
                        pre1.Show();
                        pre1.BringToFront();

                        break;


                }


            }

            if (MOUL)
            {
                if (MOULWin != 0)
                    MOULWin--;

                switch (MOULWin)
                {
                    case 0:
                        mol1.Show();
                        mol1.BringToFront();
                        break;
                    case 1:
                        eje1.Show();
                        eje1.BringToFront();

                        break;
                    case 2:
                        cor1.Show();
                        cor1.BringToFront();

                        break;
                    
                }


            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            FUNC_HIDE();
            INOUT_HIDE();
            KEY_HIDE();
            INJ_HIDE();
            MOUL_HIDE();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InOut = true ;
            
            userControl11.Show();
            userControl11.BringToFront();
           

            FUNC_HIDE();
            KEY_HIDE();
            INJ_HIDE();
            MOUL_HIDE();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FUNC = true;
           
            fuc1.Show();
            fuc1.BringToFront();

            INOUT_HIDE();
            KEY_HIDE();
            INJ_HIDE();
            MOUL_HIDE();
        }

        private void KeyBut_Click(object sender, EventArgs e)
        {
            keY11.Show();
            keY11.BringToFront();
           
            Key = true;

            FUNC_HIDE();
            INOUT_HIDE();
            INJ_HIDE();
            MOUL_HIDE();

        }

        private void INJ_Click(object sender, EventArgs e)
        {
            inj1.Show();
            inj1.BringToFront();
            INJ = true;
            
            FUNC_HIDE();
            INOUT_HIDE();
            KEY_HIDE();
            MOUL_HIDE();
        }

        private void MOUL_Click(object sender, EventArgs e)
        {
            mol1.Show();
            mol1.BringToFront();
            MOUL = true;
            FUNC_HIDE();
            INOUT_HIDE();
            KEY_HIDE();
            INJ_HIDE();

        }



        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String indata = serialPort1.ReadLine();
            d1 writeit = new d1(Write2Form);
            Invoke(writeit, indata);

        }


        public void Write2Form(String indata)
        {
           char firstchar, sectchar;

            firstchar = indata[0];
            sectchar = indata[1];


            switch (firstchar)
            {
                case 'a':
                    MONI = true;
                    moniT11.Visible = true;
                    
                    INOUT_HIDE();
                    FUNC_HIDE();
                    KEY_HIDE();
                    INJ_HIDE();
                    MOUL_HIDE();
                    Label_show(monit);

                    break;

                case 'b':
                    InOut = true ;
                    

                    userControl11.Visible = true;

                    Label_show(outin);

                    FUNC_HIDE();
                    KEY_HIDE();
                    INJ_HIDE();
                    MOUL_HIDE();
                    MONIT_HIDE();


                    break;
                case 'c':
                    
                    FUNC = true;
                    fuc1.Visible = true ;
                    fuc1.textBox4.Focus();
                    Label_show(funct);
                    INOUT_HIDE();
                    KEY_HIDE();
                    INJ_HIDE();
                    MOUL_HIDE();
                    MONIT_HIDE();

                    break;
                case 'd':
                    keY11.Visible= true;
                    
                    Key = true;

                    FUNC_HIDE();
                    INOUT_HIDE();
                    INJ_HIDE();
                    MOUL_HIDE();
                    MONIT_HIDE();
                    Label_show(keys);


                    break;

                case 'e':
                   
                    inj1.Visible=true ;
                    inj1.textBox1.Focus();
                    INJ = true;

                    FUNC_HIDE();
                    INOUT_HIDE();
                    KEY_HIDE();
                    MOUL_HIDE();
                    MONIT_HIDE();
                    Label_show(Inje);



                    break;
                case 'f':
                    mol1.Visible=true;
                    mol1.textBox1.Focus();
                    MOUL = true;

                    Label_show(moule);
                    FUNC_HIDE();
                    INOUT_HIDE();
                    KEY_HIDE();
                    INJ_HIDE();
                    MONIT_HIDE();


                    break;

                case 'z':

                     if (sectchar == '1')
                     {

                         if (InOut)
                         {
                              

                            userControl11.Visible = true;

                            ouT11.Visible = false;
                            ouT21.Visible = false;
                            iN21.Visible = false;


                        }
                         else if (FUNC)
                         {
                             fuc1.Visible = true;

                            prod1.Visible = false;
                            mem1.Visible = false;
                            rec1.Visible = false;
                            

                        }
                         else if (Key)
                         {
                             keY11.Visible = true;
                            
                            keY21.Visible = false;
                            keY31.Visible = false;
                            keY41.Visible = false;
                            prog_Ver1.Visible = false;

                        }
                         else if (INJ)
                         {
                             inj1.Visible = true;
                             

                            temp1.Visible = false;
                            scw1.Visible = false;
                            pre1.Visible = false;
                            cur1.Visible = false;
                            inj1.textBox1.Focus();

                        }
                         else if (MOUL)
                         {
                            mol1.Visible = true;
                            mol1.textBox1.Focus();

                            eje1.Visible = false;
                            cor1.Visible = false;
                            uni1.Visible = false;
                        }
                         else if (MONI)
                        {
                             moniT11.Visible = true;
                           
                            moniT21.Visible = false;
                            spc1.Visible = false;
                            alarm1.Visible = false;
                            alrec1.Visible = false;
                        }else
                        {//DO NOTHING
                        }
                    }
                     else if (sectchar == '2')
                     {
                         if (InOut)
                         {
                            iN21.Visible = true;

                            userControl11.Visible = false;
                            ouT11.Visible = false;
                            ouT21.Visible = false;


                         }
                         else if (FUNC)
                         {

                             prod1.Visible = true;

                            
                            mem1.Visible = false;
                            rec1.Visible = false;
                            fuc1.Visible = false;

                        }
                         else if (Key)
                         {
                             keY21.Visible = true;

                            keY11.Visible = false;
                            keY31.Visible = false;
                            keY41.Visible = false;
                            prog_Ver1.Visible = false;

                        }
                         else if (INJ)
                         {
                             scw1.Visible = true;
                            scw1.textBox1.Focus();

                            inj1.Visible = false;
                            temp1.Visible = false;
                            pre1.Visible = false;
                            cur1.Visible = false;

                        }
                         else if (MOUL)
                         {
                             eje1.Visible = true;
                            eje1.textBox1.Focus();


                            mol1.Visible = false;
                            cor1.Visible = false;
                            uni1.Visible = false;
                        }
                         else if (MONI)
                        {
                             moniT21.Visible = true;

                            moniT11.Visible = false;
                            spc1.Visible = false;
                            alarm1.Visible = false;
                            alrec1.Visible = false;
                        }else
                        {//DO NOTHING
                        }


                    }
                     else if (sectchar == '3')
                     {

                         if (InOut)
                         {
                             ouT11.Visible = true;

                            userControl11.Visible = false;
                            ouT21.Visible = false;
                            iN21.Visible = false;


                         }
                         else if (FUNC)
                         {
                             rec1.Visible = true;

                            prod1.Visible = false;
                            mem1.Visible = false;
                            fuc1.Visible = false;

                        }
                         else if (Key)
                         {
                             keY31.Visible = true;

                            keY11.Visible = false;
                            keY21.Visible = false;
                            keY41.Visible = false;
                            prog_Ver1.Visible = false;

                        }
                         else if (INJ)
                         {
                             temp1.Visible = true;
                            temp1.textBox1.Focus();

                            inj1.Visible = false;
                            scw1.Visible = false;
                            pre1.Visible = false;
                            cur1.Visible = false;

                        }
                         else if (MOUL)
                         {
                             cor1.Visible = true;
                            cor1.textBox26.Focus();
                            eje1.Visible = false;
                            mol1.Visible = false;
                            uni1.Visible = false;
                        }
                         else if (MONI)
                        {
                             spc1.Visible = true;

                            moniT11.Visible = false;
                            moniT21.Visible = false;
                            alarm1.Visible = false;
                            alrec1.Visible = false;
                        }else
                        {//DO NOTHING
                        }

                    }
                     else if (sectchar == '4')
                     {

                         if (InOut)
                         {
                            ouT21.Visible = true;

                            userControl11.Visible = false;
                            ouT11.Visible = false;
                            iN21.Visible = false;

                         }
                         else if (FUNC)
                         {
                             mem1.Visible = true;

                            prod1.Visible = false;
                            rec1.Visible = false;
                            fuc1.Visible = false;

                        }
                         else if (Key)
                         {
                             keY41.Visible = true;

                            keY11.Visible = false;
                            keY21.Visible = false;
                            keY31.Visible = false;
                         
                            prog_Ver1.Visible = false;

                        }
                         else if (INJ)
                         {
                             pre1.Visible = true;

                            inj1.Visible = false;
                            temp1.Visible = false;
                            scw1.Visible = false;
                            cur1.Visible = false;

                        }
                         else if (MOUL)
                         {
                             uni1.Visible = true;
                            uni1.textBox1.Focus();

                            eje1.Visible = false;
                            mol1.Visible = false;
                            cor1.Visible = false;
                           
                        }
                        else if (MONI)
                        {
                             alarm1.Visible = true;

                            moniT11.Visible = false;
                            moniT21.Visible = false;
                            spc1.Visible = false;
                            alrec1.Visible = false;
                        }else {//DO NOTHING
                               }
                     }
                     else if (sectchar == '5')
                     {

                         if (Key)
                         {
                             prog_Ver1.Visible = true;

                            keY11.Visible = false;
                            keY21.Visible = false;
                            keY31.Visible = false;
                            keY41.Visible = false;
                            

                        }
                         else if (INJ)
                         {
                             cur1.Visible = true;

                            inj1.Visible = false;
                            temp1.Visible = false;
                            scw1.Visible = false;
                            pre1.Visible = false;
                            

                        }
                         else if (MONI)
                         {
                             alrec1.Visible = true;

                            moniT11.Visible = false;
                            moniT21.Visible = false;
                            spc1.Visible = false;
                            alarm1.Visible = false;
                           
                        }else
                        {
                            //Do nothing 
                        }
                     }
                    break;
                    case 'y':

                    if(sectchar == 'B')
                    {
                        SendKeys.Send("{DOWN}");

                    } else if(sectchar == 'H')
                    {
                        SendKeys.Send("{UP}");

                    } else if(sectchar=='D')
                    {
                        SendKeys.Send("{RIGHT}");

                    }
                    else if (sectchar=='G')
                    {
                        SendKeys.Send("{LEFT}");
                    }
                    else{  /*DO NOthing*/   }

                    //SendKeys.Send("{TAB}");
                    break;
                case 'x':
                    SendKeys.SendWait("{BS}");
                    // SendKeys.Send("{B}");
                    break;
                case 'A':
                    SendKeys.Send("{A}");
                    break;
                case 'B':
                    SendKeys.Send("{B}");
                    break;
                case 'C':
                    SendKeys.Send("{C}");
                    break;
                case 'D':
                    SendKeys.Send("{D}");
                    break;
                case 'E':
                    SendKeys.Send("{E}");
                    break;
                case 'F':
                    SendKeys.Send("{F}");
                    break;
                case 'G':
                    SendKeys.Send("{G}");
                    break;
                case 'H':
                    SendKeys.Send("{H}");
                    break;
                case 'I':
                    SendKeys.Send("{I}");
                    break;
                case 'J':
                    SendKeys.Send("{J}");
                    break;
                case 'K':
                    SendKeys.Send("{K}");
                    break;
                case 'L':
                    SendKeys.Send("{L}");
                    break;
                case 'M':
                    SendKeys.Send("{M}");
                    break;
                case 'N':
                    SendKeys.Send("{N}");
                    break;
                case 'O':
                    SendKeys.Send("{O}");
                    break;
                case 'P':
                    SendKeys.Send("{P}");
                    break;
                case 'Q':
                    SendKeys.Send("{Q}");
                    break;
                case 'R':
                    SendKeys.Send("{R}");
                    break;
                case 'S':
                    SendKeys.Send("{S}");
                    break;
                case 'T':
                    SendKeys.Send("{T}");
                    break;
                case 'U':
                    SendKeys.Send("{U}");
                    break;
                case 'V':
                    SendKeys.Send("{V}");
                    break;
                case 'W':
                    SendKeys.Send("{W}");
                    break;
                case 'X':
                    SendKeys.Send("{X}");
                    break;
                case 'Y':
                    SendKeys.Send("{Y}");
                    break;
                case 'Z':
                    SendKeys.Send("{Z}");
                    break;
                case '-':
                    SendKeys.Send("{-}");
                    break;
                case '1':
                    SendKeys.Send("{1}");
                    break;
                case '2':
                    SendKeys.Send("{2}");
                    break;
                case '3':
                    SendKeys.Send("{3}");
                    break;
                case '4':
                    SendKeys.Send("{4}");
                    break;
                case '5':
                    SendKeys.Send("{5}");
                    break;
                case '6':
                    SendKeys.Send("{6}");
                    break;
                case '7':
                    SendKeys.Send("{7}");
                    break;
                case '8':
                    SendKeys.Send("{8}");
                    break;
                case '9':
                    SendKeys.Send("{9}");
                    break;

            }

        }
    }
}
