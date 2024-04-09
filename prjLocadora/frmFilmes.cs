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

namespace prjLocadora
{
    public partial class frmFilmes : Form
    {
        int registroAtual = 0;
        int totalRegistros = 0;
        DataTable dtFilmes = new DataTable();
        bool novo;
        String connectionString = @"Server=DARNASSUS\MOTORHEAD; Database=db_230058;User Id=230058;Password=Ra1542687";
        public frmFilmes()
        {
            InitializeComponent();
        }

        private void navegar()
        {
            txtCodFilme.Text = dtFilmes.Rows[registroAtual][0].ToString();
            txtTituloFilme.Text = dtFilmes.Rows[registroAtual][1].ToString();
            txtAnoFilme.Text = dtFilmes.Rows[registroAtual][2].ToString();
            cbbProdutora.Text = dtFilmes.Rows[registroAtual][3].ToString();
            cbbGenero.Text = dtFilmes.Rows[registroAtual][4].ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFilmes_Load(object sender, EventArgs e)
        {
            txtCodFilme.Enabled = false;
            btnSalvar.Enabled = false;
            txtTituloFilme.Enabled = false;
            cbbGenero.Enabled = false;
            cbbProdutora.Enabled = false;
            string sql = "SELECT * FROM tb_filme";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtFilmes.Load(reader);
                    totalRegistros = dtFilmes.Rows.Count;
                    registroAtual = 0;
                    navegar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM tb_filme  WHERE idFilme=" + txtCodFilme.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Filme apagado com sucesso!!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            dtFilmes = new DataTable();
            this.frmFilmes_Load(this,e);
            
        }

        private void txtCodFilme_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            txtTituloFilme.Enabled = true;
            txtAnoFilme.Enabled = true;
            cbbGenero.Enabled = true;
            cbbProdutora.Enabled = true;
            txtCodFilme.Text = "";
            txtTituloFilme.Text = "";
            txtAnoFilme.Text = "";
            cbbProdutora.Text = "";
            cbbGenero.Text = "";
            btnExcluir.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            btnAlterar.Enabled = false;
            novo = true;
            txtTituloFilme.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(novo)
            {
                string sql = "INSERT INTO tbfilme(Título, " +
                    "Lançamento,Produtora,genêro) VALUES('" +
                    txtTituloFilme.Text + "', " + txtAnoFilme.Text +
                    ", '" + cbbProdutora.SelectedValue.ToString() +
                    ", '" + cbbGenero.Text + "')";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    InvalidTimeZoneException - cmd.ExecuteNonQuery();
                    if (i > 0)
                    {

                    }
                }
            }
            else
            {

            }
        }
    }
}
