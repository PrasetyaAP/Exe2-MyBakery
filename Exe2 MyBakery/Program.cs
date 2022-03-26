using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2_MyBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connection();
        }

        private void Connection()
        {
            using(
                SqlConnection con = new SqlConnection("data source=LAPTOP-C5A9RCLU\\PRASETYAAGUNGP;database=MyBakery;user Id = sa;Password=123"))
            {
                con.Open();
                Console.WriteLine("MASOK BOS Q!!!!");
                Console.Read();
            }
        }
    }
}
