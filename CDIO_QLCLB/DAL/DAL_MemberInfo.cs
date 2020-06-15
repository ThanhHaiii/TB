using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_MemberInfo
    {
        DAL.SQLClass sql = new SQLClass();
        public DataTable getTable(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public int updateTable(string sqlQuery)
        {
            return int.Parse(sql.ThemSuaXoa(sqlQuery).ToString());
        }

        public string layID(string sqlquery)
        {
            try
            {
                return sql.layMotCell(sqlquery).ToString();
            }
            catch
            {
                return null;
            }
        }
    }
}
