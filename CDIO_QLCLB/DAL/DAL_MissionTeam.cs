using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.DAL
{
    class DAL_MissionTeam
    {
        SQLClass sql = new SQLClass();

        public DataTable getData(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public int addMission(string sqlquery)
        {
            return sql.ThemSuaXoa(sqlquery);
        }

        public string getName(string sqlquery)
        {
            return sql.layMotCell(sqlquery).ToString();
        }
    }
}
