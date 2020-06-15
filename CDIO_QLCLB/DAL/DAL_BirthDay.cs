using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_BirthDay
    {
        DAL.SQLClass sql = new SQLClass();
        public DataTable listLoad(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public int themTinNhan(string sqlQuery)
        {
            return sql.ThemSuaXoa(sqlQuery);
        }
    }
}
