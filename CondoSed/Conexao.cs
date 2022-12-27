using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Npgsql.Internal;
using NpgsqlTypes;


namespace CondoSed
{
    public class Conexao
    {

        NpgsqlConnection conn = new NpgsqlConnection();

        //Construtor
        public Conexao()
        {
            conn.ConnectionString = "Server = localhost; Port = 5432; Database = condosed;User id= postgres; Password = #abc123#";

        }
        //método conectar

        public NpgsqlConnection Connectar()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                
            }
            return conn;

        }

        // método desconectar

        public void desconect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

        }
    }

       





    
}
