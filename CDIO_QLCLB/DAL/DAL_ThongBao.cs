using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.DAL
{
    class DAL_ThongBao
    {
        DAL.SQLClass sql = new SQLClass();
        public DataTable getTable(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public int them(string sqlquery)
        {
            return sql.ThemSuaXoa(sqlquery);
        }

        public string getIDVuaThem(string sqlquery)
        {
            return sql.layMotCell(sqlquery).ToString();
        }
        public int xoa(string sqlquery)
        {
            return sql.ThemSuaXoa(sqlquery);
        }
    }
}
