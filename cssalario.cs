using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcc_senai
{
    public class cssalario
    {
        public int id_financeiro { get; set; }
        public int salario { get; set; }
        public int gasto { get; set; }
        public int sobra { get; set; }
        

        MySqlConnection con = new MySqlConnection("server=127.0.0.1; port=3306; database=tcc_senai; user=root; password=; charset=uft8");
        public List<cssalario> listacssalario()
        {
            List<cssalario> li = new List<cssalario>();
            string mysql = "SELECT * FROM financeiro";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cssalario sa = new cssalario();
                sa.id_financeiro = Convert.ToInt32(dr["id_financeiro"]);
                sa.salario = Convert.ToInt32(dr["salario"]);
                sa.gasto = Convert.ToInt32(dr["gasto"]);
                sa.sobra = Convert.ToInt32(dr["sobra"]);
                li.Add(sa);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Atualizar(string salario, string gasto)
        {
            string mysql = "UPDATE financeiro SET salario='" + salario + "', gasto='" + gasto + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Inserir(string salario, string gasto, string sobra)
        {
            string mysql = "INSERT INTO financeiro(salario,gasto,sobra) VALUES ('" + salario + "', '" + gasto + "', '" + sobra + "')";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(mysql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
