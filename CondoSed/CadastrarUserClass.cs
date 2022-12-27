using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Npgsql;
using NpgsqlTypes;


namespace CondoSed
{
    public class CadastrarUserClass
    {
        Conexao con = new Conexao();
        NpgsqlCommand command = new NpgsqlCommand();
        
        public String mensagem;

        public CadastrarUserClass(string nmusuario, string senha, string funcao)
        {
                      
            // comando sql - insert, update, delete
            command.CommandText = "Insert into system.usuarios (nmusuario, senha, funcao) values (@nmusuario, @senha, @funcao) ";


            // parametros insert
            command.Parameters.AddWithValue("@nmusuario", nmusuario);
            command.Parameters.AddWithValue("@senha", senha);
            command.Parameters.AddWithValue("@funcao", funcao);

           

            //conectar com BD
            try
            {
                command.Connection = con.Connectar();

                //executar comando
                command.ExecuteNonQuery();

                con.desconect();

               

                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastro Realizado Com Sucesso";

            }

            catch (NpgsqlException error)
            {
                this.mensagem = "Erro de Conexão com bd" + error;
            }

        }

       
    }
}
