using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_Home
    {
        DAL.SQLClass sql = new SQLClass();
        public DataTable getPlan(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }

        public object lay1cell(string sqlquery)
        {
            return sql.layMotCell(sqlquery);
        }
    }
}
