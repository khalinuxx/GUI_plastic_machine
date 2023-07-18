namespace Machine_GUI
{
    partial class Prod
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
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.Black;
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.ForeColor = System.Drawing.Color.White;
            this.textBox26.Location = new System.Drawing.Point(371, 389);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 1;
            this.textBox26.Text = "MEMORY";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.Black;
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.ForeColor = System.Drawing.Color.White;
            this.textBox25.Location = new System.Drawing.Point(277, 389);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(100, 20);
            this.textBox25.TabIndex = 2;
            this.textBox25.Text = "RECORD";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.White;
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.ForeColor = System.Drawing.Color.Black;
            this.textBox24.Location = new System.Drawing.Point(178, 389);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 20);
            this.textBox24.TabIndex = 3;
            this.textBox24.Text = "PRODUCT";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.Black;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.ForeColor = System.Drawing.Color.White;
            this.textBox23.Location = new System.Drawing.Point(80, 389);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 20);
            this.textBox23.TabIndex = 4;
            this.textBox23.Text = "FUC/TIME";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox23);
            this.Name = "Prod";
            this.Size = new System.Drawing.Size(613, 443);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
    }
}
