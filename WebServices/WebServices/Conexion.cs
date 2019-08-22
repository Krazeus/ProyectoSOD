using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace WebServices
{
    public class Conexion
    {
      
      public DataSet Open()
        {

            string cadena = System.Configuration.ConfigurationManager.AppSettings["conexion"].ToString();
            SqlConnection cn = new SqlConnection(cadena);
            SqlCommand comand;
            //SqlDataReader dr;
            DataSet ds;
            try
            {
                cn.Open();
                string consulta = "Select * from dbo.Usuario";
                //comand = new SqlCommand(consulta,cn);
                //dr = comand.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(consulta,cn);
                ds = new DataSet();
                string valor = "";
                da.Fill(ds);
                
                //while (dr.Read())
                //{ 

                //    valor = dr.GetValue(0).ToString();
                //}

              
                cn.Close();
                return ds;
               
            }
            catch(Exception ex) {
            
                //return ""+ex.ToString();
            }
            return null;
        }
    }
}