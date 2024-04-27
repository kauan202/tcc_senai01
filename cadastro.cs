using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using System.Drawing;

namespace Tcc_senai
{
    public class Cliente
    {
        public string id { get; set; }   
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string senha { get; set; }


        MySqlConnection con = new MySqlConnection("server=127.0.0.1; port=3306; database=tcc_senai; user=root; password=; charset=uft8");

        public List<Cliente> listacliente()
        {
            List<Cliente> li = new List<Cliente>();
            string mysql = "SELECT * FROM cadastro";
             con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente cl = new Cliente();
                cl.nome = dr["nome"].ToString();
                cl.cpf = dr["cpf"].ToString();
                cl.email = dr["email"].ToString();
                cl.senha = dr["senha"].ToString();
            }
            dr.Close();
            con.Close();
            return li;
        }
        public void Inserir(string nome, string cpf, string email, string senha)
        {
            string mysql = "INSERT INTO cadastro(nome,cpf,email,senha) VALUES ('" + nome + "', '" + cpf + "', '" + email + "','" + senha + "')";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Atualizar(string nome, string cpf, string email, string senha)
        {
            string mysql = "UPDATE cadastro SET nome='" + nome + "', cpf='" + cpf + "', email='" + email + "', senha='" + senha + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(string cpf)
        {
            string mysql = "DELETE FROM cadastro WHERE cpf='" + cpf + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool RegistroRepetido(string cpf, string email, string senha)
        {
            string mysql = "SELECT * FROM cadastro WHERE cpf= '" + cpf + "' AND email= '" + email + "', AND senha= '" + senha + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return true;
            }
            con.Close();
            return false;
        }
		public bool RegistroRepetido2(string cpf, string email)
		{
			string mysql = "SELECT * FROM cadastro WHERE cpf= '" + cpf + "' AND email= '" + email + "', AND senha= '" + senha + "'";
			con.Open();
			MySqlCommand cmd = new MySqlCommand(mysql, con);
			cmd.ExecuteNonQuery();
			var result = cmd.ExecuteScalar();
			if (result != null)
			{
				return true;
			}
			con.Close();
			return false;
		}
	}
}
