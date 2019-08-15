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
    public partial class frmTermoUso : Form
    {

        
        public frmTermoUso()
        {
            InitializeComponent();
        }

        frmPrincipal frmprincipalfrm = (frmPrincipal)Application.OpenForms["frmPrincipal"];
        frmPrincipal frmprincipal = new frmPrincipal();

        private void frmTermoUso_Load(object sender, EventArgs e)
        {
            
            label1.Text ="   Aplicativo feito para uso experimental, feito para contar \na quantidade de né falado pelo aluno Igor da turma de 2018. \nTodos aqueles que desejarem ter acesso aos serviços ofertados \natravés do aplicativo Contador de né deverão, primeiramente, \nse informar sobre as regras que compoem o presente instrumento, \nas quais serão citadas abaixo : \n\n- Usar para contar qualquer tipo de coisa. \n- Nao solicitar o codigo fonte do mesmo. \n- Concordar que o desenvolvedor do mesmo permanecera anonimo. \n\n   Ao utilizar o aplicativo contador de né, o usuário \naceita integralmente as presentes  normas e compromete-se \na observá-las, sob risco de aplicação das penalidades cabíveis \nantes de iniciar qualquer navegação no aplicativo, o usuário \ndevera cientificar-se de  eventuais modificacoes ou atualizacoes \nocorridas neste termo. Caso não concorde com quaisquer das \nregras aqui descrita deve,  imediatamente, abster-se de \nutilizar o aplicativo. ";
            concordoBtn.Enabled = false;
        }

        private void termoUsortbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         //   this.Close();
            Application.Exit();


        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void frmTermoUso_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  Application.Exit();
        }

        private void frmTermoUso_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (termoCbx.Checked == false)
            {
                Application.Exit();
            }
        }

        private void termoCbx_CheckedChanged(object sender, EventArgs e)
        {
            if (termoCbx.Checked == true)
            {
                concordoBtn.Enabled = true;
                naoConcordoBtn.Enabled = false;
            }
            else
            {
                concordoBtn.Enabled = false;
                naoConcordoBtn.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (termoCbx.Checked == true)
            {
                termoCbx.Checked = false;
            }
            else
            {
                termoCbx.Checked = true;
            }
        }
    }
}
