using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CDIO_QLCLB.DAL
{
    class DAL_ExportMember
    {
        SQLClass sQLClass = new SQLClass();

        public DataTable GetDataTable(string sqlquery)
        {
            return sQLClass.getDataBase(sqlquery);
        }
    }
}
