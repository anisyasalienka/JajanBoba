using System;
using MySql.Data.MySqlClient;

namespace JajanBoba
{
    class Data
    {
        public void Input(string Nama, string Pesanan, int Harga)
        {
            Connect conn = new Connect();
            using (conn.Connection)
            {
                conn.Connection.Open();
                DateTime Tanggal = DateTime.Now;
                MySqlCommand command = conn.Connection.CreateCommand();
                command.CommandText = System.Data.CommandType.Text.ToString();
                command.CommandText = "insert into tb_datapesanan(Nama, Pesanan, Harga) Values('" + Nama + "', '" + Pesanan + "','" + Harga + "')";
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Pesanan telah ditambahkan ke dalam data pesanan");
                }
                conn.Connection.Close();

            }
        }
        public void Output()
        {
            Connect conn = new Connect();
            using (conn.Connection)
            {
                try
                {
                    conn.Connection.Open();

                    MySqlCommand command = conn.Connection.CreateCommand();
                    command.CommandText = System.Data.CommandType.Text.ToString();
                    command.CommandText = "Select * from tb_datapesanan";

                    MySqlDataReader reader = command.ExecuteReader();

                    var data = "Id\tNama\t\t\tPesanan\t\t\tHarga\t\tTanggal";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data += Environment.NewLine + reader.GetInt32(0) + " |\t" + reader.GetString(1) + " \t|"
                            + reader.GetString(2) + "\t|" + reader.GetInt32(3) + "\t |" + reader.GetDateTime(4);
                        }
                    }
                    Console.WriteLine(data);

                    conn.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    System.Console.WriteLine("Error!" + ex.Message.ToString());
                }
            }
        }
    }
}
