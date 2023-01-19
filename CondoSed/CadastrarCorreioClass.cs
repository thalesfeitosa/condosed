using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;


namespace CondoSed
{
    public class CadastrarCorreioClass
    {
        Conexao ConCorreios = new Conexao();
        NpgsqlCommand command = new NpgsqlCommand();

        public String mensagem;

        public CadastrarCorreioClass(string nmdestinatario, string dsbloco, string dsapt, string nmrecebedordest, string cdrastreamento, string localizacaofisica, string recebedorcondo, bool status)
        {

            // comando sql - insert, update, delete
            command.CommandText = "Insert into condo.encomendas (nmdestinatario, dsbloco, dsapt, nmrecebedordest, cdrastreamento, localizacaofisica, recebedorcondo, status) values (@nmdestinatario, @dsbloco, @dsapt, @nmrecebedordest, @cdrastreamento, @localizacaofisica, @recebedorcondo, @status) ";


            // parametros insert
            command.Parameters.AddWithValue("@nmdestinatario", nmdestinatario );
            command.Parameters.AddWithValue("@dsbloco", dsbloco);
            command.Parameters.AddWithValue("@dsapt", dsapt);
            command.Parameters.AddWithValue("@nmrecebedordest", nmrecebedordest);
            command.Parameters.AddWithValue("@cdrastreamento", cdrastreamento);
            command.Parameters.AddWithValue("@localizacaofisica", localizacaofisica);
            command.Parameters.AddWithValue("@recebedorcondo", recebedorcondo);
            command.Parameters.AddWithValue("@status", status);
            



            //conectar com BD
            try
            {
                command.Connection = ConCorreios.Connectar();

                //executar comando
                command.ExecuteNonQuery();

                ConCorreios.desconect();



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
