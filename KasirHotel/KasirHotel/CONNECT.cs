using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace KasirHotel
{
    // class untuk menghubungkan dengan mysql
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=KasirHotel");

        // fungsi untuk mendapatkan koneksi ke mysql
        public MySqlConnection getConnection()
        {
            return connection;
        }

        // fungsi untuk terhubung ke database
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // fungsi untuk memutuskan hubungan ke database
        public void closeConnection()
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
