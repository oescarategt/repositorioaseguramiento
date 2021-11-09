using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Libreria
{
    public class Utilidades
    {
        public static DataSet ejecutar(string cmd)
        {
            SqlConnection Con= new SqlConnection("Data Source=DESKTOP-SKCBF3Q ; Initial Catalog = Impresoras3D; integrated Security = true");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);


            Con.Close();

            return DS;
        }

    }
}
