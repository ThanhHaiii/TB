using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_TeamList
    {
        SQLClass sql = new SQLClass();

        public DataTable getDatabase(string sqlQuery)
        {
            return sql.getDataBase(sqlQuery);
        }

        public string getCell(string sqlquery)
        {
            try
            {
                return sql.layMotCell(sqlquery).ToString();
            }catch{
                return "0";
            }
        }

        public int deleteMemberTeam(string sqlquery)
        {
            return sql.ThemSuaXoa(sqlquery);
        }
    }
}
