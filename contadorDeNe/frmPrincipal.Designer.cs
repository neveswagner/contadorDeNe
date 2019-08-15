namespace contadorDeNe
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.neBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qtdLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startCronometroBtn = new System.Windows.Forms.Button();
            this.pausarCronometroBtn = new System.Windows.Forms.Button();
            this.cronometroTextoLbl = new System.Windows.Forms.Label();
            this.mediaNePorHoraLbl = new System.Windows.Forms.Label();
            this.mediaNeHoraTextoLbl = new System.Windows.Forms.Label();
            this.mediaNeMinutoTextoLbl = new System.Windows.Forms.Label();
            this.cronometroLbl = new System.Windows.Forms.Label();
            this.mediaNeMinutoLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.relogioLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pausadoLbl = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // neBtn
            // 
            this.neBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.neBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.neBtn.Location = new System.Drawing.Point(104, 217);
            this.neBtn.Name = "neBtn";
            this.neBtn.Size = new System.Drawing.Size(143, 30);
            this.neBtn.TabIndex = 0;
            this.neBtn.Text = "Você Ouviu um NÉ ?";
            this.neBtn.UseVisualStyleBackColor = false;
            this.neBtn.Click += new System.EventHandler(this.neBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.qtdLbl);
            this.panel1.Controls.Add(this.neBtn);
            this.panel1.Location = new System.Drawing.Point(21, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 253);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "quando ouvir a palavra \"NÉ\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precione a tecla \'enter\'";
            // 
            // qtdLbl
            // 
            this.qtdLbl.AutoSize = true;
            this.qtdLbl.Font = new System.Drawing.Font("Cambria", 110.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdLbl.Location = new System.Drawing.Point(100, 41);
            this.qtdLbl.Name = "qtdLbl";
            this.qtdLbl.Size = new System.Drawing.Size(160, 173);
            this.qtdLbl.TabIndex = 0;
            this.qtdLbl.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.startCronometroBtn);
            this.panel2.Controls.Add(this.pausarCronometroBtn);
            this.panel2.Controls.Add(this.cronometroTextoLbl);
            this.panel2.Controls.Add(this.mediaNePorHoraLbl);
            this.panel2.Controls.Add(this.mediaNeHoraTextoLbl);
            this.panel2.Controls.Add(this.mediaNeMinutoTextoLbl);
            this.panel2.Controls.Add(this.cronometroLbl);
            this.panel2.Controls.Add(this.mediaNeMinutoLbl);
            this.panel2.Location = new System.Drawing.Point(423, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 253);
            this.panel2.TabIndex = 2;
            // 
            // startCronometroBtn
            // 
            this.startCronometroBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.startCronometroBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startCronometroBtn.Location = new System.Drawing.Point(118, 217);
            this.startCronometroBtn.Name = "startCronometroBtn";
            this.startCronometroBtn.Size = new System.Drawing.Size(109, 30);
            this.startCronometroBtn.TabIndex = 12;
            this.startCronometroBtn.Text = "Start Cronometro";
            this.startCronometroBtn.UseVisualStyleBackColor = false;
            this.startCronometroBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pausarCronometroBtn
            // 
            this.pausarCronometroBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pausarCronometroBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pausarCronometroBtn.Location = new System.Drawing.Point(3, 217);
            this.pausarCronometroBtn.Name = "pausarCronometroBtn";
            this.pausarCronometroBtn.Size = new System.Drawing.Size(109, 30);
            this.pausarCronometroBtn.TabIndex = 3;
            this.pausarCronometroBtn.Text = "Pausar Cronometro";
            this.pausarCronometroBtn.UseVisualStyleBackColor = false;
            this.pausarCronometroBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cronometroTextoLbl
            // 
            this.cronometroTextoLbl.AutoSize = true;
            this.cronometroTextoLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cronometroTextoLbl.Location = new System.Drawing.Point(53, 8);
            this.cronometroTextoLbl.Name = "cronometroTextoLbl";
            this.cronometroTextoLbl.Size = new System.Drawing.Size(117, 22);
            this.cronometroTextoLbl.TabIndex = 11;
            this.cronometroTextoLbl.Text = "Cronometro";
            // 
            // mediaNePorHoraLbl
            // 
            this.mediaNePorHoraLbl.AutoSize = true;
            this.mediaNePorHoraLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaNePorHoraLbl.Location = new System.Drawing.Point(94, 170);
            this.mediaNePorHoraLbl.Name = "mediaNePorHoraLbl";
            this.mediaNePorHoraLbl.Size = new System.Drawing.Size(31, 32);
            this.mediaNePorHoraLbl.TabIndex = 10;
            this.mediaNePorHoraLbl.Text = "0";
            // 
            // mediaNeHoraTextoLbl
            // 
            this.mediaNeHoraTextoLbl.AutoSize = true;
            this.mediaNeHoraTextoLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaNeHoraTextoLbl.Location = new System.Drawing.Point(19, 135);
            this.mediaNeHoraTextoLbl.Name = "mediaNeHoraTextoLbl";
            this.mediaNeHoraTextoLbl.Size = new System.Drawing.Size(198, 22);
            this.mediaNeHoraTextoLbl.TabIndex = 8;
            this.mediaNeHoraTextoLbl.Text = "Media de Né por Hora";
            // 
            // mediaNeMinutoTextoLbl
            // 
            this.mediaNeMinutoTextoLbl.AutoSize = true;
            this.mediaNeMinutoTextoLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaNeMinutoTextoLbl.Location = new System.Drawing.Point(10, 71);
            this.mediaNeMinutoTextoLbl.Name = "mediaNeMinutoTextoLbl";
            this.mediaNeMinutoTextoLbl.Size = new System.Drawing.Size(216, 22);
            this.mediaNeMinutoTextoLbl.TabIndex = 6;
            this.mediaNeMinutoTextoLbl.Text = "Media de Né por Minuto";
            // 
            // cronometroLbl
            // 
            this.cronometroLbl.AutoSize = true;
            this.cronometroLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cronometroLbl.Location = new System.Drawing.Point(59, 30);
            this.cronometroLbl.Name = "cronometroLbl";
            this.cronometroLbl.Size = new System.Drawing.Size(111, 32);
            this.cronometroLbl.TabIndex = 5;
            this.cronometroLbl.Text = "0:00:00";
            // 
            // mediaNeMinutoLbl
            // 
            this.mediaNeMinutoLbl.AutoSize = true;
            this.mediaNeMinutoLbl.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaNeMinutoLbl.Location = new System.Drawing.Point(94, 93);
            this.mediaNeMinutoLbl.Name = "mediaNeMinutoLbl";
            this.mediaNeMinutoLbl.Size = new System.Drawing.Size(31, 32);
            this.mediaNeMinutoLbl.TabIndex = 4;
            this.mediaNeMinutoLbl.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // relogioLbl
            // 
            this.relogioLbl.AutoSize = true;
            this.relogioLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relogioLbl.Location = new System.Drawing.Point(570, 325);
            this.relogioLbl.Name = "relogioLbl";
            this.relogioLbl.Size = new System.Drawing.Size(55, 15);
            this.relogioLbl.TabIndex = 3;
            this.relogioLbl.Text = "0:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Atual:";
            // 
            // pausadoLbl
            // 
            this.pausadoLbl.AutoSize = true;
            this.pausadoLbl.BackColor = System.Drawing.Color.Transparent;
            this.pausadoLbl.Font = new System.Drawing.Font("Cambria", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausadoLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.pausadoLbl.Location = new System.Drawing.Point(657, 9);
            this.pausadoLbl.Name = "pausadoLbl";
            this.pausadoLbl.Size = new System.Drawing.Size(581, 156);
            this.pausadoLbl.TabIndex = 3;
            this.pausadoLbl.Text = "Pausado";
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(678, 349);
            this.Controls.Add(this.pausadoLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.relogioLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de NÉ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPrincipal_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button neBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label qtdLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label relogioLbl;
        private System.Windows.Forms.Label cronometroLbl;
        private System.Windows.Forms.Label mediaNeMinutoTextoLbl;
        public System.Windows.Forms.Label mediaNeMinutoLbl;
        private System.Windows.Forms.Label cronometroTextoLbl;
        public System.Windows.Forms.Label mediaNePorHoraLbl;
        private System.Windows.Forms.Label mediaNeHoraTextoLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pausarCronometroBtn;
        private System.Windows.Forms.Button startCronometroBtn;
        public System.Windows.Forms.Label pausadoLbl;
        private System.Windows.Forms.Timer timer2;
    }
}

