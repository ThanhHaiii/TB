using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_PlanningDetails
    {
        DAL.SQLClass sql = new SQLClass();
        public DataTable getDataPlan(string sqlQuery)
        {
            return sql.getDataBase(sqlQuery);
        }
    }
}
