using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
   public class ThongKeBUS
    {
        private static ThongKeBUS instance;

        public static ThongKeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeBUS();
                }
                return instance;
            }
        }

        public DataTable getAll()
        {
            return ThongKeDAO.Instance.getData();
        }
    }
}
