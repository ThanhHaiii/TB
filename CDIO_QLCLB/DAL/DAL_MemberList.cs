using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_MemberList
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
