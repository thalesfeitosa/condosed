using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace CondoSed
{
    public class CadPessoasClass
    {
        Conexao con = new Conexao();
        NpgsqlCommand command = new NpgsqlCommand();

        public String mensagem;


        public CadPessoasClass(string idpessoa, string nmpessoa, string nmbloco, string nmunidade, string telefone, bool proprietario, string nmproprietario, string nmmoradores, string nmmoradores2, string nmmoradores3, string nmmoradores4, string parentesco, string parentesco2, string parentesco3, string parentesco4, DateTime datanascimento, DateTime datanascimento2, DateTime datanascimento3, DateTime datanascimento4, bool vagagaragem, string veiculomarca, string veiculomarca2, string veiculomarca3, string veiculotipo, string veiculotipo2, string veiculotipo3, string veiculomodelo, string veiculomodelo2, string veiculomodelo3, string veiculoplaca, string veiculoplaca2, string veiculoplaca3, bool animais, string animalespecie, string animalespecie2, string animalespecie3, string animalquantidade, string emergencianome, string emergencianome2, string telefoneemergencia, string telefoneemergencia2)
        {

            // comando sql - insert, update, delete
            command.CommandText = "Insert into system.usuarios (idpessoa,nmpessoa,  nmbloco,  nmunidade,  telefone,  proprietario,  nmproprietario,  nmmoradores,  nmmoradores2,  nmmoradores3,  nmmoradores4,  parentesco,  parentesco2,  parentesco3, , parentesco4,  datanascimento,  datanascimento2,  datanascimento3,  datanascimento4,  vagagaragem,  veiculomarca,  veiculomarca2,  veiculomarca3,  veiculotipo,  veiculotipo2,  veiculotipo3,  veiculomodelo,  veiculomodelo2,  veiculomodelo3,  veiculoplaca,  veiculoplaca2,  veiculoplaca3,  animais,  animalespecie,  animalespecie2,  animalespecie3,  animalquantidade,  emergencianome,  emergencianome2,  telefoneemergencia,  telefoneemergencia2)" +
" values(@idpessoa, @nmpessoa, @nmbloco, @nmunidade, @telefone, @proprietario, @nmproprietario, @nmmoradores, @nmmoradores2, @nmmoradores3, @nmmoradores4, @parentesco, @parentesco2, @parentesco3,@ ,@ parentesco4, @datanascimento, @datanascimento2, @datanascimento3, @datanascimento4, @vagagaragem, @veiculomarca, @veiculomarca2, @veiculomarca3, @veiculotipo, @veiculotipo2, @veiculotipo3, @veiculomodelo, @veiculomodelo2, @veiculomodelo3, @veiculoplaca, @veiculoplaca2, @veiculoplaca3, @animais, @animalespecie, @animalespecie2, @animalespecie3, @animalquantidade, @emergencianome, @emergencianome2, @telefoneemergencia, @telefoneemergencia2) ";



            // parametros insert
            command.Parameters.AddWithValue("@idpessoa", idpessoa);
            command.Parameters.AddWithValue("@nmpessoa", nmpessoa);
            command.Parameters.AddWithValue("@nmbloco", nmbloco);
            command.Parameters.AddWithValue("@nmunidade", nmunidade);
            command.Parameters.AddWithValue("@telefone", telefone);
            command.Parameters.AddWithValue("@proprietario", proprietario);
            command.Parameters.AddWithValue("@nmproprietario", nmproprietario);
            command.Parameters.AddWithValue("@nmmoradores", nmmoradores);
            command.Parameters.AddWithValue("@nmmoradores2", nmmoradores2);
            command.Parameters.AddWithValue("@nmmoradores3", nmmoradores3);
            command.Parameters.AddWithValue("@nmmoradores4", nmmoradores4);
            command.Parameters.AddWithValue("@parentesco", parentesco);
            command.Parameters.AddWithValue("@parentesco2", parentesco2);
            command.Parameters.AddWithValue("@parentesco3", parentesco3);
            command.Parameters.AddWithValue("@parentesco4", parentesco4);
            command.Parameters.AddWithValue("@datanascimento", datanascimento);
            command.Parameters.AddWithValue("@datanascimento2", datanascimento2);
            command.Parameters.AddWithValue("@datanascimento3", datanascimento3);
            command.Parameters.AddWithValue("@datanascimento4", datanascimento4);
            command.Parameters.AddWithValue("@vagagaragem", vagagaragem);
            command.Parameters.AddWithValue("@veiculomarca", veiculomarca);
            command.Parameters.AddWithValue("@veiculomarca2", veiculomarca2);
            command.Parameters.AddWithValue("@veiculomarca3", veiculomarca3);
            command.Parameters.AddWithValue("@veiculotipo", veiculotipo);
            command.Parameters.AddWithValue("@veiculotipo2", veiculotipo2);
            command.Parameters.AddWithValue("@veiculotipo3", veiculotipo3);
            command.Parameters.AddWithValue("@veiculomodelo", veiculomodelo);
            command.Parameters.AddWithValue("@veiculomodelo2", veiculomodelo2);
            command.Parameters.AddWithValue("@veiculomodelo3", veiculomodelo3);
            command.Parameters.AddWithValue("@veiculoplaca", veiculoplaca);
            command.Parameters.AddWithValue("@veiculoplaca2", veiculoplaca2);
            command.Parameters.AddWithValue("@veiculoplaca3", veiculoplaca3);
            command.Parameters.AddWithValue("@animais", animais);
            command.Parameters.AddWithValue("@animailespecie", animalespecie);
            command.Parameters.AddWithValue("@animailespecie2", animalespecie2);
            command.Parameters.AddWithValue("@animailespecie3", animalespecie3);
            command.Parameters.AddWithValue("@animalquantidade", animalquantidade);
            command.Parameters.AddWithValue("@emergencianome", emergencianome);
            command.Parameters.AddWithValue("@emergencianome2", emergencianome2);
            command.Parameters.AddWithValue("@telefoneemergencia", telefoneemergencia);
            command.Parameters.AddWithValue("@telefoneemergencia2", telefoneemergencia2);

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
