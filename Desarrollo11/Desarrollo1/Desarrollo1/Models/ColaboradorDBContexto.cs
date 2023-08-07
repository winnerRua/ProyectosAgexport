using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Desarrollo1.Models
{
    public class ColaboradorDBContexto
    {
        //Método que lista todos los colaboradores
        public List<Colaborador> ObtenerColaborador()
        {
            List<Colaborador> listaCol = new List<Colaborador>();
            string strConnec = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConnec))
            {
                conn.Open();

                SqlCommand comand = conn.CreateCommand();
                comand.CommandText = "SP_ObtenerColaborador";
                comand.CommandType = CommandType.StoredProcedure;

                SqlDataReader dataRead = comand.ExecuteReader();

                while (dataRead.Read())
                {
                    int id = dataRead.GetInt32(0);
                    string nombres = dataRead.GetString(1).Trim();
                    string apellidos = dataRead.GetString(2).Trim();
                    string genero = dataRead.GetString(3).Trim();
                    string estadoCivil = dataRead.GetString(4).Trim();
                    DateTime fechaNac = dataRead.GetDateTime(5);
                    int edad = dataRead.GetInt32(6);
                    long dpi = dataRead.GetInt64(7);
                    long igss = dataRead.GetInt64(8);
                    long irtra = dataRead.GetInt64(9);
                    string pasaporte = dataRead.GetString(10).Trim();
                    string departamento = dataRead.GetString(11).Trim();
                    string municipio = dataRead.GetString(12).Trim();
                    string direccionResi = dataRead.GetString(13).Trim();

                    Colaborador colabora = new Colaborador(id, nombres, apellidos, genero, estadoCivil, fechaNac, edad, dpi, igss, irtra, pasaporte, departamento, municipio, direccionResi);

                    listaCol.Add(colabora);
                }

                dataRead.Close();
                conn.Close();
            }
            return listaCol;
        }

        //Método que agrega colaborador
        public bool AgregarColaborador(Colaborador colabora)
        {
            bool res = false;

            string strConnec = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConnec))
            {
                SqlCommand command = conn.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter(command);
                command.CommandText = "SP_AgregarColaborador";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@nombres", colabora.Nombres);
                command.Parameters.AddWithValue("@apellidos", colabora.Apellidos);
                command.Parameters.AddWithValue("@genero", colabora.Genero);
                command.Parameters.AddWithValue("@estadoCivil", colabora.EstadoCivil);
                command.Parameters.AddWithValue("@fechaNacimiento", colabora.FechaNacimiento);
                command.Parameters.AddWithValue("@edad", colabora.Edad);
                command.Parameters.AddWithValue("@dpi", colabora.DPI);
                command.Parameters.AddWithValue("@igss", colabora.IGSS);
                command.Parameters.AddWithValue("@irtra", colabora.IRTRA);
                command.Parameters.AddWithValue("@pasaporte", colabora.Pasaporte);
                command.Parameters.AddWithValue("@departamento", colabora.Departamento);
                command.Parameters.AddWithValue("@municipio", colabora.Municipio);
                command.Parameters.AddWithValue("@direccionResidencia", colabora.DireccionResidencia);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    command.Parameters.Clear();
                    conn.Close();
                }

                return res;
            }
        }

        //Método que actualiza/modifica colaborador
        public bool ActualizaColaborador(int idColaborador, Colaborador colabora)
        {
            bool res = false;

            string strConnec = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConnec))
            {
                SqlCommand command = conn.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter(command);
                command.CommandText = "SP_ActualizaColaborador";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@colaboradorId", colabora.ColaboradorId);
                command.Parameters.AddWithValue("@nombres", colabora.Nombres);
                command.Parameters.AddWithValue("@apellidos", colabora.Apellidos);
                command.Parameters.AddWithValue("@genero", colabora.Genero);
                command.Parameters.AddWithValue("@estadoCivil", colabora.EstadoCivil);
                command.Parameters.AddWithValue("@fechaNacimiento", colabora.FechaNacimiento);
                command.Parameters.AddWithValue("@edad", colabora.Edad);
                command.Parameters.AddWithValue("@dpi", colabora.DPI);
                command.Parameters.AddWithValue("@igss", colabora.IGSS);
                command.Parameters.AddWithValue("@irtra", colabora.IRTRA);
                command.Parameters.AddWithValue("@pasaporte", colabora.Pasaporte);
                command.Parameters.AddWithValue("@departamento", colabora.Departamento);
                command.Parameters.AddWithValue("@municipio", colabora.Municipio);
                command.Parameters.AddWithValue("@direccionResidencia", colabora.DireccionResidencia);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    command.Parameters.Clear();
                    conn.Close();
                }

                return res;
            }
        }

        //Método que borra colaborador
        public bool BorraColaborador(int idColaborador)
        {
            bool res = false;

            string strConnec = ConfigurationManager.ConnectionStrings["BDLocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strConnec))
            {
                SqlCommand command = conn.CreateCommand();
                SqlDataAdapter adp = new SqlDataAdapter(command);
                command.CommandText = "SP_BorrarColaborador";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@colaboradorId", idColaborador);
                //command.Parameters.AddWithValue("@nombres", colabora.Nombres);
                //command.Parameters.AddWithValue("@appellidos", colabora.Apellidos);
                //command.Parameters.AddWithValue("@genero", colabora.Genero);
                //command.Parameters.AddWithValue("@estadoCivil", colabora.EstadoCivil);
                //command.Parameters.AddWithValue("@fechaNacimiento", colabora.FechaNacimiento);
                //command.Parameters.AddWithValue("@edad", colabora.Edad);
                //command.Parameters.AddWithValue("@dpi", colabora.DPI);
                //command.Parameters.AddWithValue("@igss", colabora.IGSS);
                //command.Parameters.AddWithValue("@irtra", colabora.IRTRA);
                //command.Parameters.AddWithValue("@pasaporte", colabora.Pasaporte);
                //command.Parameters.AddWithValue("@departamento", colabora.Departamento);
                //command.Parameters.AddWithValue("@municipio", colabora.Municipio);
                //command.Parameters.AddWithValue("@direccionResidencia", colabora.DireccionResidencia);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    command.Parameters.Clear();
                    conn.Close();
                }

                return res;
            }
        }
    }
}