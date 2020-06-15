using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_AddMeeting
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
    }

}
