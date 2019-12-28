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
        public bool insertRsv(String name, String phone, String address, String room, DateTime checkin, DateTime checkout, Int32 deposit)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservation`(`name`, `phone`, `address`, `room`, `checkin`, `checkout`, `deposit`) VALUES (@name,@phone,@address,@room,@checkin,@checkout,@deposit)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @name,@phone,@address,@room,@checkin,@checkout,@deposit
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;
            command.Parameters.Add("@checkin", MySqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@checkout", MySqlDbType.DateTime).Value = checkout;
            command.Parameters.Add("@deposit", MySqlDbType.Int32).Value = deposit;

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

        // fungsi list database reservasi
        public DataTable getRsv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservation`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // fungsi list database booked
        public DataTable getbookedRsv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservation` WHERE `status`='booked'", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // fungsi list database finished
        public DataTable getfinishedRsv()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservation` WHERE `status`='finished'", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // fungsi search id database reservasi
        public DataTable getRsvId(Int32 id)
        {
            MySqlCommand command = new MySqlCommand();
            String selectQuery = "SELECT * FROM `reservation` WHERE `id`=@id";
            command.CommandText = selectQuery;
            command.Connection = conn.getConnection();

            // @id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // fungsi update data reservasi
        public bool updateRsv(Int32 id, String name, String phone, String address, String room, DateTime checkin, DateTime checkout, Int32 deposit, Int32 price, String status )
        {
            MySqlCommand command = new MySqlCommand();
            String updateQuery = "UPDATE `reservation` SET `name`=@name,`phone`=@phone,`address`=@address,`room`=@room,`checkin`=@checkin,`checkout`=@checkout,`deposit`=@deposit,`price`=@price,`status`=@status WHERE `id`=@rid";
            command.CommandText = updateQuery;
            command.Connection = conn.getConnection();

            // @rid,@name,@phone,@address,@room,@checkin,@checkout,@price
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;
            command.Parameters.Add("@checkin", MySqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@checkout", MySqlDbType.DateTime).Value = checkout;
            command.Parameters.Add("@deposit", MySqlDbType.Int32).Value = deposit;
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = price;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

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

        // fungsi hapus reservasi dari database
        public bool deleteRsv(Int32 id)
        {
            MySqlCommand command = new MySqlCommand();
            String deleteQuery = "DELETE FROM `reservation` WHERE `id`=@id";
            command.CommandText = deleteQuery;
            command.Connection = conn.getConnection();

            // @id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            conn.openConnection();
            var result = Convert.ToInt32(command.ExecuteScalar());
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // fungsi search id check out
        public bool checkRsv(Int32 id)
        {
            MySqlCommand command = new MySqlCommand();
            String checkQuery = "SELECT COUNT(*) FROM `reservation` WHERE `id`=@id";
            command.CommandText = checkQuery;
            command.Connection = conn.getConnection();

            // @id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            conn.openConnection();
            var result = Convert.ToInt32(command.ExecuteScalar());
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // fungsi hitung jumlah room kosong
        public Int32 checkRoom()
        {
            MySqlCommand command = new MySqlCommand();
            String checkQuery = "SELECT COUNT(*) FROM `room` WHERE `id_rsv`=''";
            command.CommandText = checkQuery;
            command.Connection = conn.getConnection();

            conn.openConnection();
            var result = Convert.ToInt32(command.ExecuteScalar());

            return result;
        }

        // fungsi check room kosong
        public DataTable emptykRoom()
        {
            MySqlCommand command = new MySqlCommand();
            String roomQuery = "SELECT `room` FROM `room` WHERE `id_rsv`=''";
            command.CommandText = roomQuery;
            command.Connection = conn.getConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // fungsi check id terakhir
        public Int32 chekId()
        {
            MySqlCommand command = new MySqlCommand();
            String lastidQuery = "SELECT `id` FROM `reservation` ORDER BY `id` DESC LIMIT 1";
            command.CommandText = lastidQuery;
            command.Connection = conn.getConnection();

            conn.openConnection();
            var id = Convert.ToInt32(command.ExecuteScalar());

            return id;
        }
        // fungsi check id terakhir dan room's filling
        public bool addRoom(Int32 id, String room)
        {
            MySqlCommand command = new MySqlCommand();

            String addidQuery = "UPDATE `room` SET `id_rsv`=@id WHERE `room`=@room";
            command.CommandText = addidQuery;
            command.Connection = conn.getConnection();

            // @id,@room
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;

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

        // fungsi room's clearing
        public bool clearRoom(String room)
        {
            MySqlCommand command = new MySqlCommand();
            String clearRoom = "UPDATE `room` SET `id_rsv`='' WHERE `room`=@room";
            command.CommandText = clearRoom;
            command.Connection = conn.getConnection();

            // @room
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;

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

// DONE