using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_UserInfo
    {
        DAL.SQLClass sqlclass = new SQLClass();

        public DataTable layTTThanhVien(string sqlquery)
        {
            return sqlclass.getDataBase(sqlquery);
        }

        public string layChucVu(string sqlquery)
        {
            return sqlclass.layMotCell(sqlquery).ToString();
        }
    }
}
