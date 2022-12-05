using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;


namespace CondoSed
{
    public class Conexao
    {

        NpgsqlConnection PGcon = new NpgsqlConnection();

        static String Servidor = "localhost";
        static String Bd = "condosed";
        static String Usuario = "postgres";
        static String Password = "#abc123#";
        static String Porta = "5432";

        String Connect = "server" + Servidor + ";" + "Porta" + Porta + ";" + "User" + Usuario + ";" + "Password" + Password + ";" + "Database" + Bd + ";";

        public NpgsqlConnection EstabeleceConexao()
        {
            try
            {
                PGcon.ConnectionString = Connect;
                PGcon.Open();
                MessageBox.Show("Conexão Realizada com Sucesso");
            }
            catch(NpgsqlException e )
            {
                MessageBox.Show("Erro ao Conectar ao Banco de Dados!!" + e.ToString());  
            }
            return PGcon;
        }




    }
}
