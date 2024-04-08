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
    public partial class frmProdutoras : Form
    {
        int registroAtual = 0;
        int totalRegistros = 0;
        DataTable dtProdutor = new DataTable();
        bool novo;
        String connectionString = @"Server=DARNASSUS\MOTORHEAD; Database=db_230058;User Id=230058;Password=Ra1542687";
        public frmProdutoras()
        {
            InitializeComponent();
        }

        private void navegar()
        {
            txtCodprod.Text = dtProdutor.Rows[registroAtual][0].ToString();
            txtProd.Text = dtProdutor.Rows[registroAtual][1].ToString();
            txtTelprod.Text = dtProdutor.Rows[registroAtual][2].ToString();
            txtEmailprod.Text = dtProdutor.Rows[registroAtual][3].ToString();
        }

        private void frmProdutoras_Load(object sender, EventArgs e)
        {
            txtCodprod.Enabled = false;
            btnSalvar.Enabled = false;
            txtProd.Enabled = false;
            txtEmailprod.Enabled = false;
            txtTelprod.Enabled = false;
            string sql = "SELECT * FROM tb_produtor";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtProdutor.Load(reader);
                    totalRegistros = dtProdutor.Rows.Count;
                    registroAtual = 0;
                    navegar();
                }
            }catch(Exception ex)
            {
         
                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }   
        }
              
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if(registroAtual < totalRegistros - 1)
            {
                registroAtual = totalRegistros - 1;
                navegar();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (registroAtual< totalRegistros - 1)
            {
                registroAtual++;
                navegar();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if(registroAtual > 0)
            {
                registroAtual--;
                navegar();
            }
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if(registroAtual > 0)
            {
                registroAtual = 0;
                navegar();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            txtProd.Enabled = true;
            txtEmailprod.Enabled = true;
            txtTelprod.Enabled = true;
            txtCodprod.Text = "";
            txtProd.Text = "";
            txtTelprod.Text = "";
            txtEmailprod.Text = "";
            btnExcluir.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnUltimo.Enabled = false;
            btnAlterar.Enabled = false;
            novo = true;
            txtProd.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO tb_produtor (nomeProd, telprod, emailProd)"
                    + "VALUES('" + txtProd.Text + "', '" + txtTelprod.Text + "', '" + txtEmailprod.Text + "')";
                //MessageBox.Show(sql);
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Produtora cadastrada com sucesso!!");
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
            else
            {
                string sql = "UPDATE tb_produtor SET nomeProd ='" + txtProd.Text + "', emailProd ='"
                + txtEmailprod.Text + "', telProd = '" + txtTelprod.Text + "' WHERE codProd=" + txtCodprod.Text;
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Produtora alterada com sucesso!!");
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
            txtCodprod.Enabled = false;
            btnSalvar.Enabled = false;
            txtProd.Enabled = false;
            txtEmailprod.Enabled = false;
            txtTelprod.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            carregar();
        }

        private void carregar()
        {
            dtProdutor = new DataTable();
            string sql = "SELECT * FROM tb_produtor";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtProdutor.Load(reader);
                    totalRegistros = dtProdutor.Rows.Count;
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
            string sql = "DELETE FROM tb_produtor  WHERE codProd="+ txtCodprod.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Produtora apagada com sucesso!!");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            btnSalvar.Enabled = false;
            txtProd.Enabled = false;
            txtEmailprod.Enabled = false;
            txtTelprod.Enabled = false;
            txtCodprod.Enabled = false;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;

            carregar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            novo = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            txtProd.Enabled = true;
            txtEmailprod.Enabled = true;
            txtTelprod.Enabled = true;
            btnPrimeiro.Enabled = false;
            btnUltimo.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            carregar();
        }
    }
}
