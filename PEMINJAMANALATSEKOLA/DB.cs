using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace PEMINJAMANALATSEKOLA
{
    class DB
    {
        public static MySqlConnection koneksi = new MySqlConnection("server=127.0.0.1; username='root'; password=''; database='db_p_alatsekolah' ");
        public static DataSet ds = new DataSet();
        public static MySqlDataAdapter da;
        public static MySqlCommand perintah;
        public static void crud(string naonweh)
        {
            Console.WriteLine(naonweh);
            ds.Tables.Clear();
            perintah = new MySqlCommand(naonweh, koneksi);
            da = new MySqlDataAdapter(perintah);
            da.Fill(ds);
        }
        public static int execute(string query)
        {
            if (koneksi.State != System.Data.ConnectionState.Open)
                koneksi.Open();

            MySqlCommand cmd = new MySqlCommand(query, koneksi);
            int rowsAffected = cmd.ExecuteNonQuery();

            koneksi.Close();
            return rowsAffected;
        }
    }
}
