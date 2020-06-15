using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.DAL
{
    class DAL_LSTB
    {
        SQLClass sql = new SQLClass();

        public DataTable getList(string sqlQuery)
        {
            return sql.getDataBase(sqlQuery);
        }

        public string getTotal(string sqlquery)
        {
            return sql.layMotCell(sqlquery).ToString();
        }
    }
}
