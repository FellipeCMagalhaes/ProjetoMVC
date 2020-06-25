using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMVC.DAL;


namespace ProjetoMVC.BLL
{
    class tblClienteBLL
    {

        private DALMVC daoBanco = new DALMVC();

        public Boolean Autenticar(int? cpf, string nome, string nome_mae)
        {
            string consulta = string.Format($@"select * from tbl_cliente where cpf_cliente = '{cpf}' and nome_cliente = '{nome}' and nome_mae = '{nome_mae}';");
            DataTable dt = daoBanco.ExecutarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
