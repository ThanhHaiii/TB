using System;
using System.Data;
using System.Data.SqlClient;

namespace CDIO_QLCLB.DAL
{
    class SQLClass
    {
        string connStringPersonal = @"Data Source=35.240.152.232;Initial Catalog=QLCLB;User ID=cdioQLCLB;Password=01682319448Huong";
        SqlConnection conn;

        //////SQL Server
        //////IP Server: 35.240.152.232
        //////User: phangochuong74
        //////pass: Fqno{AzXm(5vGL,

        //////Chat Server
        //////IP Server: 35.226.245.201
        //////User: thienkieu1910
        //////pass: j8GDcZX\tlzTqCG

        public SQLClass()
        {
            conn = new SqlConnection(connStringPersonal);
        }

        private void OpenConnect()
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
        }

        private void CloseConnect()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
        }

        public DataTable getDataBase(string sqlQuery)
        {
            SqlDataAdapter ds = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            ds.Fill(dt);
            CloseConnect();
            return dt;
        }

        public string addTeam(string tenNhom, string idLeader)
        {
            try
            {
                OpenConnect();
                SqlCommand sqlCommand = new SqlCommand("createTeam", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@tenNhom", tenNhom));
                sqlCommand.Parameters.Add(new SqlParameter("@nhomTruong", idLeader));
                string request = sqlCommand.ExecuteScalar().ToString();
                CloseConnect();
                return request;
            }
            catch
            {
                return null;
            }
        }

        public DataTable exportComfirmationMember(string idMember)
        {
            try
            {
                DataTable table = new DataTable();
                OpenConnect();
                SqlCommand sqlCommand = new SqlCommand("exportComfirmationMember", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@idMember", idMember));
                using (var da = new SqlDataAdapter(sqlCommand))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    da.Fill(table);
                    CloseConnect();
                    return table;
                }
            }
            catch
            {
                return null;
            }
        }

        public int ThemSuaXoa(string sqlQuery)
        {
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            OpenConnect();
            int ketQua = cmd.ExecuteNonQuery();
            CloseConnect();
            return ketQua;
        }

        public object layMotCell(string sqlQuery)
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            object ketQua = cmd.ExecuteScalar();
            CloseConnect();
            return ketQua;
        }

        public bool ExecBulkCopy(DataTable pDt, string pDesTableName = "")
        {
            try
            {
                if (pDesTableName.Length == 0) pDesTableName = pDt.TableName;
                OpenConnect();
                using (SqlBulkCopy sbc = new SqlBulkCopy(conn))
                {
                    sbc.DestinationTableName = pDesTableName;
                    sbc.WriteToServer(pDt);
                }
                CloseConnect();
                return true;
            }
            catch (Exception)
            {
                CloseConnect();
                return false;
            }
        }
    }
}
