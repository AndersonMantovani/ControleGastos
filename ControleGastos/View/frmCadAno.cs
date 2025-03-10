using ControleGastos.Entidades;
using ControleGastos.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControleGastos.View
{
    public partial class frmCadAno : Form
    {
        Anos obj = new Anos();

        public frmCadAno()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            try
            {
                List<Anos> lista = new List<Anos>();
                lista = new AnoModel().Listar();
                //dg.AutoGenerateColumns = false;
                dg.Columns[0].Visible = false;
                dg.Columns[1].HeaderText = "Ano";
                dg.DataSource = lista;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível listar os dados" + ex);
            }
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            txtAno.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtAno.Text == "")
            {
                MessageBox.Show("Insira um ano !!");
                return;
            }

            salvar();
            btnSalvar.Enabled = false;
            txtAno.Enabled=false;
            txtAno.Text = "";
        }

        private void salvar()
        {
            try
            {
                obj.Ano = Convert.ToInt32(txtAno.Text);
                int x = AnoModel.Inserir(obj);
                if (x > 0)
                {
                    MessageBox.Show("Inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Não Inserido");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não Inserido" + ex);
            }
           
        }
    }
}
