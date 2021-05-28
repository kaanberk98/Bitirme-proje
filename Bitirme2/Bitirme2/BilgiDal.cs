using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitirme2
{
    
    public class BilgiDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=bitirme;integrated security=true");
        public List<Bilgi> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Bilgiler", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Bilgi> bilgiler = new List<Bilgi>();
            while (reader.Read())
            {
                Bilgi bilgi = new Bilgi
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Age = Convert.ToInt32(reader["Age"]),
                    City = reader["City"].ToString(),


                };
                bilgiler.Add(bilgi);
            }
            reader.Close();
            _connection.Close();
            return bilgiler;


        }
        public List<Bilgi> GetAll3()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from İsimler", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Bilgi> bilgiler = new List<Bilgi>();
            while (reader.Read())
            {
                Bilgi bilgi = new Bilgi
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    
                };
                bilgiler.Add(bilgi);
            }
            reader.Close();
            _connection.Close();
            return bilgiler;
        }
        public List<Bilgi> GetAll4()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Şehirler", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Bilgi> bilgiler = new List<Bilgi>();
            while (reader.Read())
            {
                Bilgi bilgi = new Bilgi
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["City"].ToString(),

                };
                bilgiler.Add(bilgi);
            }
            reader.Close();
            _connection.Close();
            return bilgiler;
        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public DataTable GetAll2()
        {
            
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Bilgiler", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;


        }
        public void Ekle(Bilgi bilgi)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Bilgiler values(@name,@surname,@age,@city)", _connection);
            command.Parameters.AddWithValue("@name", bilgi.Name);
            command.Parameters.AddWithValue("@surname", bilgi.Surname);
            command.Parameters.AddWithValue("@age", bilgi.Age);
            command.Parameters.AddWithValue("@city", bilgi.City);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Güncelle(Bilgi bilgi)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Bilgiler set Name=@name,Surname=@surname,Age=@age,City=@city where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", bilgi.Name);
            command.Parameters.AddWithValue("@surname", bilgi.Surname);
            command.Parameters.AddWithValue("@age", bilgi.Age);
            command.Parameters.AddWithValue("@city", bilgi.City);
            command.Parameters.AddWithValue("@id", bilgi.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Sil(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Bilgiler where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        
    }
}
