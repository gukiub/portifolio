using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AgendaDoAluno
{
    class conexaocomMysql
    {
            public MySqlConnection conexao;

            
          
            public conexaocomMysql()
            {
                conexao = new MySqlConnection("server=localhost;database=cadastro_agenda;uid=root;pwd=root");



                conexao.Open();
                

            }
            
            }
    }

