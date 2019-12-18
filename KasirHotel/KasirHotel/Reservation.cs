using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace KasirHotel
{
    //class untuk proses yang terjadi pada reservasi keseluruhan
    class Reservation
    {
        CONNECT conn = new CONNECT();


        // fungsi checkin
        public bool insertRsv(String name, String phone, String address, String room, String checkin, String checkout, int Price)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservation`(`name`, `phone`, `address`, `room`, `checkin`, `checkout`, `price`) VALUES (@name,@phone,@address,@room,@checkin,@checkout,@price)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @name,@phone,@address,@room,@checkin,@checkout,@price
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;
            command.Parameters.Add("@checkin", MySqlDbType.Date).Value = checkin;
            command.Parameters.Add("@checkout", MySqlDbType.Date).Value = checkout;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}
