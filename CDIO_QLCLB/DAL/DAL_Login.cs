namespace CDIO_QLCLB.DAL
{
    class DAL_Login
    {
        SQLClass sqlclass = new SQLClass();
        public string LayMaTV(string sqlquery)
        {
            try
            {
                return sqlclass.layMotCell(sqlquery).ToString();
            }catch{
                return null;
            }
        }

        public string layRandomString(string sqlquery)
        {
            return sqlclass.layMotCell(sqlquery).ToString();
        }
    }
}
