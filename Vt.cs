using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Kitapcik1920
{
    class Vt
    {

        public static string baglanti = @"Data Source=DESKTOP-HG2TT45\SQLEXPRESS;
                           Initial Catalog=Kitapcik1920;
                           User Id=sa; PAssword=qw-1;";

        public static SqlConnection con = new SqlConnection(baglanti);
    }
}
