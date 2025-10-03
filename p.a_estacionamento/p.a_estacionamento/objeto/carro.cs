using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p.a_estacionamento.objeto
{
    internal class carro
    {
        public int id;
        public string nome;
        public string modelo;
        public string cor;
        public string placa;

        public bool cadastrar(conexao conexao)
        {
            bool resultado = false;

            string sql = "insert into financeiro (nome, modelo, cor, placa)" +
                " values(@nome, @modelo, @cor, @placa)";
            string[] campos = { "@nome", "@modelo", "@cor", "@placa" };
            object[] valores = { nome, modelo, cor, placa };
            if (conexao.cadastrar(campos, valores, sql) >= 1)
            {
                resultado = true;
            }
            return resultado;

        }
    }
}
