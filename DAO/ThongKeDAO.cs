using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
     public class ThongKeDAO : DBConnect
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeDAO();
                }
                return instance;
            }
        }

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            try
            {
                Con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT MAHD, NGAY, TONGTIEN FROM HOADON", Con);
                da.Fill(dt);
            }
            catch (Exception)
            {

                Con.Close();
            }

            Con.Close();
            return dt;
        }
    }
}
