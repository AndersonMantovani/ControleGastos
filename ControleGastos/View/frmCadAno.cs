using ControleGastos.Entidades;
using ControleGastos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastos.View
{
    public partial class frmCadAno : Form
    {
        Anos obj = new Anos();

        public frmCadAno()
        {
            InitializeComponent();
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
