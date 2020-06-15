using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.DAL
{
    class DAL_ModifyTeam
    {
        SQLClass sql = new SQLClass();

        public DataTable loadData(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public int modify(string sqlquery)
        {
            return sql.ThemSuaXoa(sqlquery);
        }
    }
}
