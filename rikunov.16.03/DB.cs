using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace rikunov._16._03
{
    internal class DBconnection
    {

        static public string DBconn = "host=db.edu.cchgeu.ru; username=pgadmin4@pgadmin.org; database=isp-201o-rikunov; password=pgadmin";
        static public NpgsqlDataAdapter npgDataAdapter;
        static public NpgsqlConnection npgConnection;
        static public NpgsqlCommand npgCommand;


        public DBconnection (string connectionString)
        {
            npgConnection = new NpgsqlConnection(connectionString);
        }

        public static bool ConnectionDB()
        {
            try
            {
                npgConnection = new NpgsqlConnection(DBconn);
                npgConnection.Open();
                npgCommand = new NpgsqlCommand();
                npgCommand.Connection = npgConnection;
                npgDataAdapter = new NpgsqlDataAdapter(npgCommand);
                return true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ошибка соединения базы данных:{ex.Message}");
                return false;
            }
            
        }

        public DataTable GetProduct()
        {
            DataTable dt = new DataTable();

            try
            {
                npgConnection.Open();
                string sql = "SELECT name, product_type, image, worker, number_factory, price, write_up FROM isp-201o-rikunov";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, npgConnection);
                da.Fill(dt);
            }
            finally
            {
                npgConnection.Close();
            }
            return dt;
        }
        public static void CloseDB()
        {
            npgConnection.Close();
        }
        public static NpgsqlConnection getConnection()
        {
            return new
            NpgsqlConnection(DBconn);
        }
    }
}
