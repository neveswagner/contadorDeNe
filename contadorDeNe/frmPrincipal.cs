using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contadorDeNe
{
    public partial class frmPrincipal : Form
    {

        int qtd = 000;

        int hora = 00;
        int minuto = 00;
        int segundo = 00;


        



        public frmPrincipal()
        {
            
            InitializeComponent();
            qtdLbl.Location = new Point(100, 41);
                        startCronometroBtn.Enabled = true;
            pausadoLbl.Visible = false;
            pausarCronometroBtn.Enabled = false;
            neBtn.Enabled = false;



        }

        public void posicao1()
        {
            qtdLbl.Location = new Point(65, 41);
        }

        public void posicao2()
        {
            qtdLbl.Location = new Point(8, 41);
        }


        private void neBtn_Click(object sender, EventArgs e)
        {
            qtd = qtd + 1;


            if (qtd >= 10 && qtd <= 50)
            {
                posicao1();
                qtdLbl.ForeColor = Color.FromArgb(60, 179, 113);
            }
            else if (qtd >= 51 && qtd <= 99)
            {
                posicao1();
                qtdLbl.ForeColor = Color.FromArgb(255, 215, 0);
            }
            else if (qtd >= 100)
            {
                posicao2();
                qtdLbl.ForeColor = Color.FromArgb(255, 127, 80);
            }

            qtdLbl.Text = Convert.ToString(qtd);
        }

        private void frmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.AcceptButton = neBtn;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            relogioLbl.Text = DateTime.Now.ToLongTimeString();

            segundo ++;
            
           


            if(segundo <= 60)
            {

                if (segundo <= 9 )
                {
                    cronometroLbl.Text = Convert.ToString(hora) + ":0" + Convert.ToString(minuto) + ":" +  "0" + Convert.ToString(segundo);

                }
             
                else if(segundo >= 10 || minuto >= 1)
                {
                    cronometroLbl.Text =  Convert.ToString(hora) + ":0" + Convert.ToString(minuto) + ":"  + Convert.ToString(segundo);
                }

                if (minuto >= 10 && segundo <= 9)
                {
                    cronometroLbl.Text = Convert.ToString(hora) + ":" + Convert.ToString(minuto) + ":" + "0" + Convert.ToString(segundo);

                }

                if (minuto >= 10  &&  segundo >= 10)
                {
                    cronometroLbl.Text = Convert.ToString(hora) + ":" + Convert.ToString(minuto) + ":" + Convert.ToString(segundo);

                }

                

                if (segundo == 60)
                {
                    
                    segundo = 00;
                    minuto ++;
                }
                else if (minuto == 60)
                {
                    hora ++;
                    minuto = 0;
                }
            }
            if (qtd >= 1 && minuto >= 1)
            {

                mediaNeMinutoLbl.Text = Convert.ToString( qtd / minuto);
            }
            
            if (qtd >= 1 && hora >= 1)
            {
                mediaNePorHoraLbl.Text = Convert.ToString(qtd / hora);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            neBtn.Enabled = false;
            startCronometroBtn.Enabled = true;
            pausarCronometroBtn.Enabled = false;
            pausadoLbl.Location = new Point(45, 80);
            pausadoLbl.Visible = true;
            timer2.Enabled = true;
            timer2.Start();
            neBtn.Enabled = false;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            neBtn.Enabled = true;
            pausarCronometroBtn.Enabled = true;
            pausadoLbl.Visible = false;
            startCronometroBtn.Enabled = false;
            timer2.Enabled = false;
            timer2.Stop();
            neBtn.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pausadoLbl.Visible == true)
                pausadoLbl.Visible = false;
            else
                pausadoLbl.Visible = true;



        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmTermoUso frmtermouso = new frmTermoUso();
            frmtermouso.ShowDialog();
        }
    }
}

