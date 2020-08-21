using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinik
{
   public class Baglanti
    {
        public static SqlConnection Baglantiyap()
        {
            SqlConnection Baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
            Baglanti.Open();
            Console.WriteLine("ServerVersion: {0}", Baglanti.ServerVersion);
            Console.WriteLine("State: {0}", Baglanti.State);
            return Baglanti;
        }
        public static void BaglantiBitir(SqlConnection baglanti)
        {
            if (baglanti == null)
            {
                return;
            }
            if (baglanti.State != ConnectionState.Closed && baglanti.State != ConnectionState.Broken)
            {
                baglanti.Close();
            }
            baglanti.Dispose();
        }
    }
}
