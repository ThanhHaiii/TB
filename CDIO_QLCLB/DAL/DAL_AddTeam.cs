using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.DAL
{
    class DAL_AddTeam
    {
        SQLClass sql = new SQLClass();

        public DataTable loadData(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public int addData(string sqlquery)
        {
            return sql.ThemSuaXoa(sqlquery);
        }

        public string addTeam(string tenNhom, string idLeader)
        {
            return sql.addTeam(tenNhom, idLeader);
        }

        public string layID(string sqlquery)
        {
            return sql.layMotCell(sqlquery).ToString();
        }
    }
}
