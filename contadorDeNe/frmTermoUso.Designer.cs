namespace contadorDeNe
{
    partial class frmTermoUso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTermoUso));
            this.tituloTermoUsoLbl = new System.Windows.Forms.Label();
            this.concordoBtn = new System.Windows.Forms.Button();
            this.naoConcordoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.termoCbx = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tituloTermoUsoLbl
            // 
            this.tituloTermoUsoLbl.AutoSize = true;
            this.tituloTermoUsoLbl.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTermoUsoLbl.Location = new System.Drawing.Point(68, 30);
            this.tituloTermoUsoLbl.Name = "tituloTermoUsoLbl";
            this.tituloTermoUsoLbl.Size = new System.Drawing.Size(338, 25);
            this.tituloTermoUsoLbl.TabIndex = 1;
            this.tituloTermoUsoLbl.Text = "Termos e condições gerais de uso";
            // 
            // concordoBtn
            // 
            this.concordoBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.concordoBtn.Location = new System.Drawing.Point(103, 526);
            this.concordoBtn.Name = "concordoBtn";
            this.concordoBtn.Size = new System.Drawing.Size(92, 23);
            this.concordoBtn.TabIndex = 2;
            this.concordoBtn.Text = "Concordo";
            this.concordoBtn.UseVisualStyleBackColor = false;
            this.concordoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // naoConcordoBtn
            // 
            this.naoConcordoBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.naoConcordoBtn.Location = new System.Drawing.Point(289, 526);
            this.naoConcordoBtn.Name = "naoConcordoBtn";
            this.naoConcordoBtn.Size = new System.Drawing.Size(99, 23);
            this.naoConcordoBtn.TabIndex = 3;
            this.naoConcordoBtn.Text = "Não Concordo";
            this.naoConcordoBtn.UseVisualStyleBackColor = false;
            this.naoConcordoBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Basic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gentium Basic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Li e concordo com os termos de uso.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // termoCbx
            // 
            this.termoCbx.AutoSize = true;
            this.termoCbx.Location = new System.Drawing.Point(16, 484);
            this.termoCbx.Name = "termoCbx";
            this.termoCbx.Size = new System.Drawing.Size(15, 14);
            this.termoCbx.TabIndex = 6;
            this.termoCbx.UseVisualStyleBackColor = true;
            this.termoCbx.CheckedChanged += new System.EventHandler(this.termoCbx_CheckedChanged);
            // 
            // frmTermoUso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(504, 571);
            this.Controls.Add(this.termoCbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naoConcordoBtn);
            this.Controls.Add(this.concordoBtn);
            this.Controls.Add(this.tituloTermoUsoLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTermoUso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termo de Uso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTermoUso_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTermoUso_FormClosed);
            this.Load += new System.EventHandler(this.frmTermoUso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tituloTermoUsoLbl;
        private System.Windows.Forms.Button concordoBtn;
        private System.Windows.Forms.Button naoConcordoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox termoCbx;
    }
}