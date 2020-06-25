using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMVC.DAL;
using ProjetoMVC.DTO;
using ProjetoMVC.BLL;

namespace ProjetoMVC.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

            private DALMVC dao = new DALMVC();
    


        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                tbl_clienteDTO cliente = new tbl_clienteDTO();

                cliente.Cpf_cliente = int.Parse(txtCpfA11.Text.Trim());
                cliente.Nome_cliente = txtNomeA11.Text.Trim();
                cliente.Nome_mae = txtNomeMaeA11.Text.Trim();

                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Nome_mae))
                {
                    MessageBox.Show("Beneficiário Localizado no Banco de dados. Processo em Análise");
                }
                else
                {
                    MessageBox.Show("Beneficiário Não Localizado no Banco de dados.Benefício Negado");
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
