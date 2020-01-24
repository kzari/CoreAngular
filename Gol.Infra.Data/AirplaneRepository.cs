using Gol.Domain;
using Gol.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Gol.Infra.Data
{
    public class AirplaneRepository : BaseRepository, IAirplaneRepository
    {
        public Airplane FindAirplane(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Model, Prefix FROM Airplane WHERE Id = @id", con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        return new Airplane()
                        {
                            Id = id,
                            Model = rdr["Model"].ToString(),
                            Prefix = rdr["Prefix"].ToString(),
                        };
                    }

                    return null;
                }
            }
        }

        public IEnumerable<Airplane> GetAirplanes()
        {
            List<Airplane> airplanes = new List<Airplane>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, Model, Prefix FROM Airplane", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var airplane = new Airplane()
                    {
                        Id = Convert.ToInt32(rdr["Id"]),
                        Model = rdr["Model"].ToString(),
                        Prefix = rdr["Prefix"].ToString(),
                    };
                    airplanes.Add(airplane);
                }
                return airplanes;
            }
        }

        public void InsertAirplane(Airplane airplane)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Airplane (Model, Prefix) VALUES (@Model, @Prefix)", con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Model", airplane.Model);
                    cmd.Parameters.AddWithValue("@Prefix", airplane.Prefix);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
