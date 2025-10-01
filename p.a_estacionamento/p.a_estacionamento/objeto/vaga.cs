using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p.a_estacionamento.objeto
{
    public class vaga
    {
        public int id;
        public int numero;
        public string status;
        public DateTime horario;

        public bool cadastrar(conexao conexao)
        {
            bool resultado = false;

            string sql = "insert into financeiro (numero,status,horario)" +
                " values(@numero, @status, @horario)";
            string[] campos = { "@status", "@numero", "@horario" };
            object[] valores = { status, numero, horario };
            if (conexao.cadastrar(campos, valores, sql) >= 1)
            {
                resultado = true;
            }
            return resultado;

        }
    }
}
