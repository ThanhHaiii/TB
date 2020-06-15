using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_Notification
    {
        DAL.SQLClass sql = new DAL.SQLClass();

        public DataTable getNotifi(string sqlquery)
        {
            return sql.getDataBase(sqlquery);
        }
    }
}
