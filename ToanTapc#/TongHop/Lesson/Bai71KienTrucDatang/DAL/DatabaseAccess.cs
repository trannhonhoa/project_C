using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DatabaseAccess
    {
        string strConc = "Server=DESKTOP-P9L00KA; Database=CSDL_QLSP; User Id = sa; pwd=trannhonhoa";
        public SqlConnection conc = null;
        public void OpenConnection()
        {
            if (conc == null)
                conc = new SqlConnection(strConc);
            if (conc.State == ConnectionState.Closed)
                conc.Open();
        }
        public void CloseConnection()
        {
            if (conc != null && conc.State == ConnectionState.Open)
                conc.Close();
        }
    }
}
