using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_Messange
    {
        SQLClass sql = new SQLClass();

        public DataTable getMess(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public string getHoTen(string sqlquery)
        {
            return sql.layMotCell(sqlquery).ToString();
        }
    }
}
