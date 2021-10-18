using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleKitSala
{
    public partial class TelaKitSala : Form
    {
        public TelaKitSala()
        {
            InitializeComponent();
        }

        private void btnSalvarKitSala_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(Conexao.conectar());
            SqlCommand comando = new SqlCommand("pCadastrarKitSala", conexao);
            comando.CommandType = CommandType.StoredProcedure;
            MessageBox.Show(checkBoxApagador.Enabled.ToString());
            try
            {
                byte apagador = 0;

                if(checkBoxApagador.Checked == true)
                {
                    apagador = 1;
                }

                MessageBox.Show(apagador.ToString());

                comando.Parameters.AddWithValue("@sala", tbKitSala.Text);
                comando.Parameters.AddWithValue("@controleAr", checkBoxConAr.Text);
                comando.Parameters.AddWithValue("@controleDataShow", checkBoxConData.Text);
                comando.Parameters.AddWithValue("@apagador", apagador);
                comando.Parameters.AddWithValue("@chave", checkBoxChave.Text);
                comando.Parameters.AddWithValue("@canetaoAzul", checkBoxAzul.Text);
                comando.Parameters.AddWithValue("@canetaoPreto", checkBoxPreto.Text);


                SqlParameter codigo = comando.Parameters.Add("@codigo", SqlDbType.Int);
                codigo.Direction = ParameterDirection.Output;

                conexao.Open();
                comando.ExecuteNonQuery();

                var resposta = MessageBox.Show("Kit Sala cadastrado com sucesso. ," +
                    "Deseja cadastrar outro Kit Sala?",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    tbKitSala.Clear();
              
                }
                else
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Kit Sala não cadastrado", "Atenção");
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }

        }
    }
}
