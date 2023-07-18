namespace Machine_GUI
{
    partial class COR
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(372, 391);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 38;
            this.textBox4.Text = "UNIT/D-H";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(272, 391);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "CORE";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(177, 391);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = "EJE/BLOW";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(80, 391);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "MOULD";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(46, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 236);
            this.dataGridView1.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CORE";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRE";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SP";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TIME";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "COUNT";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "POSIT";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(372, 341);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(70, 20);
            this.textBox31.TabIndex = 54;
            this.textBox31.Text = "L/S";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(288, 341);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(87, 20);
            this.textBox30.TabIndex = 55;
            this.textBox30.Text = "USE FUNC ";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(372, 315);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(70, 20);
            this.textBox29.TabIndex = 56;
            this.textBox29.Text = "TIME";
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(223, 341);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(70, 20);
            this.textBox28.TabIndex = 57;
            this.textBox28.Text = "OFF";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(288, 315);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(87, 20);
            this.textBox27.TabIndex = 58;
            this.textBox27.Text = "USE FUNC ";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(223, 315);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(70, 20);
            this.textBox26.TabIndex = 59;
            this.textBox26.Text = "OFF";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(155, 341);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(70, 20);
            this.textBox25.TabIndex = 60;
            this.textBox25.Text = "CORE 2";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(155, 315);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(70, 20);
            this.textBox24.TabIndex = 61;
            this.textBox24.Text = "CORE 1";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // COR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox31);
            this.Controls.Add(this.textBox30);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "COR";
            this.Size = new System.Drawing.Size(613, 443);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textBox31;
        public System.Windows.Forms.TextBox textBox29;
        public System.Windows.Forms.TextBox textBox28;
        public System.Windows.Forms.TextBox textBox26;
    }
}
