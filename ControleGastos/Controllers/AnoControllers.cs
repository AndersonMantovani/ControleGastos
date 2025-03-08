using ControleGastos.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ControleGastos.Controllers
{
    class AnoControllers
    {
        public int Inserir(Anos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO ano ([ano]) VALUES (@ano)";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Ano;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }

        }

        public List<Anos>Buscar (Anos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * WHERE ano = @ano";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Ano;
                cn.Connection = con;

                SqlDataReader dr;
                List<Anos> lista = new List<Anos>();
                dr = cn.ExecuteReader();

                if (dr.Read())
                {
                    while (dr.Read())
                    {
                        Anos dado = new Anos();
                        dado.Id_ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        lista.Add(dado);
                    }
                    
                }
                return lista;
            }
            
        }

        public List<Anos> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Configuração;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * From ano";
                cn.Connection = con;

                SqlDataReader dr;
                List<Anos> lista = new List<Anos>();
                dr = cn.ExecuteReader();

                if (dr.Read())
                {
                    while (dr.Read())
                    {
                        Anos dado = new Anos();
                        dado.Id_ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        lista.Add(dado);
                    }

                }
                return lista;
            }

        }
    }
}
