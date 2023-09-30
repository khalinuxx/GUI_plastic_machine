namespace Machine_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comPort = new System.Windows.Forms.ComboBox();
            this.monit = new System.Windows.Forms.Label();
            this.outin = new System.Windows.Forms.Label();
            this.funct = new System.Windows.Forms.Label();
            this.keys = new System.Windows.Forms.Label();
            this.Inje = new System.Windows.Forms.Label();
            this.moule = new System.Windows.Forms.Label();
            this.cur1 = new Machine_GUI.CUR();
            this.pre1 = new Machine_GUI.PRE();
            this.temp1 = new Machine_GUI.TEMP(this.serialPort1);
            this.scw1 = new Machine_GUI.SCW();
            this.keY11 = new Machine_GUI.KEY1();
            this.prod1 = new Machine_GUI.Prod();
            this.mem1 = new Machine_GUI.MEM();
            this.rec1 = new Machine_GUI.REC();
            this.fuc1 = new Machine_GUI.FUC();
            this.userControl11 = new Machine_GUI.UserControl1();
            this.ouT11 = new Machine_GUI.OUT1();
            this.iN21 = new Machine_GUI.IN2();
            this.ouT21 = new Machine_GUI.OUT2();
            this.prog_Ver1 = new Machine_GUI.Prog_Ver();
            this.keY41 = new Machine_GUI.KEY4();
            this.keY31 = new Machine_GUI.KEY3();
            this.keY21 = new Machine_GUI.KEY2();
            this.inj1 = new Machine_GUI.INJ();
            this.cor1 = new Machine_GUI.COR();
            this.eje1 = new Machine_GUI.EJE();
            this.uni1 = new Machine_GUI.UNI();
            this.mol1 = new Machine_GUI.MOL(this.serialPort1);
            this.alrec1 = new Machine_GUI.ALREC();
            this.alarm1 = new Machine_GUI.ALARM();
            this.spc1 = new Machine_GUI.SPC();
            this.moniT21 = new Machine_GUI.MONIT2();
            this.moniT11 = new Machine_GUI.MONIT1();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(7, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hide";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Siemens Sans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 73);
            this.label1.TabIndex = 17;
            this.label1.Text = "MEGALIGHT";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM15";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comPort
            // 
            this.comPort.FormattingEnabled = true;
            this.comPort.Location = new System.Drawing.Point(760, 12);
            this.comPort.Name = "comPort";
            this.comPort.Size = new System.Drawing.Size(92, 21);
            this.comPort.TabIndex = 96;
            this.comPort.Visible = false;
            // 
            // monit
            // 
            this.monit.AutoSize = true;
            this.monit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monit.ForeColor = System.Drawing.Color.Black;
            this.monit.Location = new System.Drawing.Point(33, 55);
            this.monit.Name = "monit";
            this.monit.Size = new System.Drawing.Size(55, 16);
            this.monit.TabIndex = 102;
            this.monit.Text = "MONIT";
            // 
            // outin
            // 
            this.outin.AutoSize = true;
            this.outin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outin.ForeColor = System.Drawing.Color.Black;
            this.outin.Location = new System.Drawing.Point(33, 96);
            this.outin.Name = "outin";
            this.outin.Size = new System.Drawing.Size(42, 16);
            this.outin.TabIndex = 102;
            this.outin.Text = "InOut";
            // 
            // funct
            // 
            this.funct.AutoSize = true;
            this.funct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funct.ForeColor = System.Drawing.Color.Black;
            this.funct.Location = new System.Drawing.Point(33, 136);
            this.funct.Name = "funct";
            this.funct.Size = new System.Drawing.Size(40, 16);
            this.funct.TabIndex = 102;
            this.funct.Text = "Func";
            // 
            // keys
            // 
            this.keys.AutoSize = true;
            this.keys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keys.ForeColor = System.Drawing.Color.Black;
            this.keys.Location = new System.Drawing.Point(33, 180);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(41, 16);
            this.keys.TabIndex = 102;
            this.keys.Text = "Keys";
            // 
            // Inje
            // 
            this.Inje.AutoSize = true;
            this.Inje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inje.ForeColor = System.Drawing.Color.Black;
            this.Inje.Location = new System.Drawing.Point(33, 221);
            this.Inje.Name = "Inje";
            this.Inje.Size = new System.Drawing.Size(30, 16);
            this.Inje.TabIndex = 102;
            this.Inje.Text = "INJ";
            // 
            // moule
            // 
            this.moule.AutoSize = true;
            this.moule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moule.ForeColor = System.Drawing.Color.Black;
            this.moule.Location = new System.Drawing.Point(33, 261);
            this.moule.Name = "moule";
            this.moule.Size = new System.Drawing.Size(49, 16);
            this.moule.TabIndex = 102;
            this.moule.Text = "MOUL";
            // 
            // cur1
            // 
            this.cur1.Location = new System.Drawing.Point(135, 12);
            this.cur1.Name = "cur1";
            this.cur1.Size = new System.Drawing.Size(613, 443);
            this.cur1.TabIndex = 22;
            this.cur1.Visible = false;
            // 
            // pre1
            // 
            this.pre1.Location = new System.Drawing.Point(135, 12);
            this.pre1.Name = "pre1";
            this.pre1.Size = new System.Drawing.Size(613, 443);
            this.pre1.TabIndex = 21;
            this.pre1.Visible = false;
            // 
            // temp1
            // 
            this.temp1.Location = new System.Drawing.Point(135, 12);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(613, 443);
            this.temp1.TabIndex = 20;
            this.temp1.Visible = false;
            // 
            // scw1
            // 
            this.scw1.Location = new System.Drawing.Point(135, 12);
            this.scw1.Name = "scw1";
            this.scw1.Size = new System.Drawing.Size(613, 443);
            this.scw1.TabIndex = 19;
            this.scw1.Visible = false;
            // 
            // keY11
            // 
            this.keY11.Location = new System.Drawing.Point(135, 12);
            this.keY11.Name = "keY11";
            this.keY11.Size = new System.Drawing.Size(613, 443);
            this.keY11.TabIndex = 12;
            this.keY11.Visible = false;
            // 
            // prod1
            // 
            this.prod1.Location = new System.Drawing.Point(135, 12);
            this.prod1.Name = "prod1";
            this.prod1.Size = new System.Drawing.Size(613, 443);
            this.prod1.TabIndex = 11;
            this.prod1.Visible = false;
            // 
            // mem1
            // 
            this.mem1.Location = new System.Drawing.Point(135, 12);
            this.mem1.Name = "mem1";
            this.mem1.Size = new System.Drawing.Size(613, 443);
            this.mem1.TabIndex = 10;
            this.mem1.Visible = false;
            // 
            // rec1
            // 
            this.rec1.Location = new System.Drawing.Point(135, 12);
            this.rec1.Name = "rec1";
            this.rec1.Size = new System.Drawing.Size(613, 443);
            this.rec1.TabIndex = 9;
            this.rec1.Visible = false;
            // 
            // fuc1
            // 
            this.fuc1.Location = new System.Drawing.Point(135, 12);
            this.fuc1.Name = "fuc1";
            this.fuc1.Size = new System.Drawing.Size(613, 443);
            this.fuc1.TabIndex = 8;
            this.fuc1.Visible = false;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(135, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(544, 415);
            this.userControl11.TabIndex = 2;
            this.userControl11.Visible = false;
            // 
            // ouT11
            // 
            this.ouT11.Location = new System.Drawing.Point(135, 12);
            this.ouT11.Name = "ouT11";
            this.ouT11.Size = new System.Drawing.Size(544, 415);
            this.ouT11.TabIndex = 5;
            this.ouT11.Visible = false;
            // 
            // iN21
            // 
            this.iN21.Location = new System.Drawing.Point(135, 12);
            this.iN21.Name = "iN21";
            this.iN21.Size = new System.Drawing.Size(544, 415);
            this.iN21.TabIndex = 4;
            this.iN21.Visible = false;
            // 
            // ouT21
            // 
            this.ouT21.Location = new System.Drawing.Point(135, 12);
            this.ouT21.Name = "ouT21";
            this.ouT21.Size = new System.Drawing.Size(544, 415);
            this.ouT21.TabIndex = 6;
            this.ouT21.Visible = false;
            // 
            // prog_Ver1
            // 
            this.prog_Ver1.Location = new System.Drawing.Point(135, 12);
            this.prog_Ver1.Name = "prog_Ver1";
            this.prog_Ver1.Size = new System.Drawing.Size(613, 443);
            this.prog_Ver1.TabIndex = 16;
            this.prog_Ver1.Visible = false;
            // 
            // keY41
            // 
            this.keY41.Location = new System.Drawing.Point(135, 12);
            this.keY41.Name = "keY41";
            this.keY41.Size = new System.Drawing.Size(613, 443);
            this.keY41.TabIndex = 15;
            this.keY41.Visible = false;
            // 
            // keY31
            // 
            this.keY31.Location = new System.Drawing.Point(135, 12);
            this.keY31.Name = "keY31";
            this.keY31.Size = new System.Drawing.Size(613, 443);
            this.keY31.TabIndex = 14;
            this.keY31.Visible = false;
            // 
            // keY21
            // 
            this.keY21.Location = new System.Drawing.Point(135, 12);
            this.keY21.Name = "keY21";
            this.keY21.Size = new System.Drawing.Size(613, 443);
            this.keY21.TabIndex = 13;
            this.keY21.Visible = false;
            // 
            // inj1
            // 
            this.inj1.BackColor = System.Drawing.Color.White;
            this.inj1.Location = new System.Drawing.Point(135, 12);
            this.inj1.Name = "inj1";
            this.inj1.Size = new System.Drawing.Size(613, 443);
            this.inj1.TabIndex = 23;
            // 
            // cor1
            // 
            this.cor1.Location = new System.Drawing.Point(135, 12);
            this.cor1.Name = "cor1";
            this.cor1.Size = new System.Drawing.Size(613, 443);
            this.cor1.TabIndex = 24;
            // 
            // eje1
            // 
            this.eje1.Location = new System.Drawing.Point(135, 12);
            this.eje1.Name = "eje1";
            this.eje1.Size = new System.Drawing.Size(613, 443);
            this.eje1.TabIndex = 25;
            // 
            // uni1
            // 
            this.uni1.Location = new System.Drawing.Point(135, 12);
            this.uni1.Name = "uni1";
            this.uni1.Size = new System.Drawing.Size(613, 443);
            this.uni1.TabIndex = 27;
            // 
            // mol1
            // 
            this.mol1.BackColor = System.Drawing.Color.White;
            this.mol1.Location = new System.Drawing.Point(135, 12);
            this.mol1.Name = "mol1";
            this.mol1.Size = new System.Drawing.Size(613, 443);
            this.mol1.TabIndex = 26;
            // 
            // alrec1
            // 
            this.alrec1.BackColor = System.Drawing.Color.White;
            this.alrec1.Location = new System.Drawing.Point(135, 12);
            this.alrec1.Name = "alrec1";
            this.alrec1.Size = new System.Drawing.Size(613, 443);
            this.alrec1.TabIndex = 101;
            this.alrec1.Visible = false;
            // 
            // alarm1
            // 
            this.alarm1.BackColor = System.Drawing.Color.White;
            this.alarm1.Location = new System.Drawing.Point(135, 12);
            this.alarm1.Name = "alarm1";
            this.alarm1.Size = new System.Drawing.Size(613, 443);
            this.alarm1.TabIndex = 100;
            this.alarm1.Visible = false;
            // 
            // spc1
            // 
            this.spc1.Location = new System.Drawing.Point(135, 12);
            this.spc1.Name = "spc1";
            this.spc1.Size = new System.Drawing.Size(613, 443);
            this.spc1.TabIndex = 99;
            this.spc1.Visible = false;
            // 
            // moniT21
            // 
            this.moniT21.BackColor = System.Drawing.Color.White;
            this.moniT21.Location = new System.Drawing.Point(135, 12);
            this.moniT21.Name = "moniT21";
            this.moniT21.Size = new System.Drawing.Size(613, 443);
            this.moniT21.TabIndex = 98;
            this.moniT21.Visible = false;
            // 
            // moniT11
            // 
            this.moniT11.BackColor = System.Drawing.Color.White;
            this.moniT11.Location = new System.Drawing.Point(135, 12);
            this.moniT11.Name = "moniT11";
            this.moniT11.Size = new System.Drawing.Size(613, 443);
            this.moniT11.TabIndex = 97;
            this.moniT11.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 477);
            this.Controls.Add(this.moule);
            this.Controls.Add(this.Inje);
            this.Controls.Add(this.funct);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.outin);
            this.Controls.Add(this.monit);
            this.Controls.Add(this.comPort);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cur1);
            this.Controls.Add(this.pre1);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.scw1);
            this.Controls.Add(this.keY11);
            this.Controls.Add(this.prod1);
            this.Controls.Add(this.mem1);
            this.Controls.Add(this.rec1);
            this.Controls.Add(this.fuc1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.ouT11);
            this.Controls.Add(this.iN21);
            this.Controls.Add(this.ouT21);
            this.Controls.Add(this.prog_Ver1);
            this.Controls.Add(this.keY41);
            this.Controls.Add(this.keY31);
            this.Controls.Add(this.keY21);
            this.Controls.Add(this.inj1);
            this.Controls.Add(this.cor1);
            this.Controls.Add(this.eje1);
            this.Controls.Add(this.uni1);
            this.Controls.Add(this.mol1);
            this.Controls.Add(this.alrec1);
            this.Controls.Add(this.alarm1);
            this.Controls.Add(this.spc1);
            this.Controls.Add(this.moniT21);
            this.Controls.Add(this.moniT11);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.IO.Ports.SerialPort serialPort1;
        private UserControl1 userControl11;
        private IN2 iN21;
        private OUT1 ouT11;
        private OUT2 ouT21;
        private System.Windows.Forms.Button button3;
        private FUC fuc1;
        private REC rec1;
        private MEM mem1;
        private Prod prod1;
        private KEY1 keY11;
        private KEY2 keY21;
        private KEY3 keY31;
        private KEY4 keY41;
        private Prog_Ver prog_Ver1;
        private System.Windows.Forms.Label label1;
        private SCW scw1;
        private TEMP temp1;
        private PRE pre1;
        private CUR cur1;
        private INJ inj1;
        private COR cor1;
        private EJE eje1;
        private MOL mol1;
        private UNI uni1;
        private System.Windows.Forms.ComboBox comPort;
        private MONIT1 moniT11;
        private MONIT2 moniT21;
        private SPC spc1;
        private ALARM alarm1;
        private ALREC alrec1;
        private System.Windows.Forms.Label monit;
        private System.Windows.Forms.Label outin;
        private System.Windows.Forms.Label funct;
        private System.Windows.Forms.Label keys;
        private System.Windows.Forms.Label Inje;
        private System.Windows.Forms.Label moule;
        
    }
}

