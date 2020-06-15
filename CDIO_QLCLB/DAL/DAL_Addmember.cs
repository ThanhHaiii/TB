using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_Addmember
    {
        DAL.SQLClass sql = new SQLClass();
        public DataTable getTable(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public int addMember(string sqlquery)
        {
            return sql.ThemSuaXoa(sqlquery);
        }

        public string getNewID(string sqlquery)
        {
            return sql.layMotCell(sqlquery).ToString();
        }
    }
}
