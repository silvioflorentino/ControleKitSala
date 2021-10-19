using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleKitSala
{
    public partial class TelaControles : Form
    {
        public TelaControles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String codKitSala = tbCodigoSala.Text;
            String codFun = tbCodigoFun.Text;
            DateTime dataHora = DateTime.Now;

            

            MessageBox.Show("Deseja Retirar a sala:" 
                + codKitSala + 
                dataHora.ToString());
        }
    }
}
