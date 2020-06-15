using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.logical
{
    class DiaPhuong
    {
        DAL.SQLClass sql = new DAL.SQLClass();
        public string TenHuyen()
        
        {
            string GPS = caseData.DataTam.DuLieu.toado;
            string[] chuoiGPS = GPS.Split(' ');
            string sqlquery1 = "SELECT * FROM [QLCLB].[dbo].[Huyen] where ToaDo like '" + chuoiGPS[0] + " " + chuoiGPS[1] + " __N, " + chuoiGPS[3] + " " + chuoiGPS[4] + " __E'";

            DataTable ds = sql.getDataBase(sqlquery1);
            if (ds.Rows.Count > 0)
            {
                return ds.Rows[0]["TenHuyen"].ToString();
            }
            else
            {
                string sqlquery2 = "SELECT * FROM [QLCLB].[dbo].[Huyen] where ToaDo like '" + chuoiGPS[0] + " " + chuoiGPS[1] + " __N, " + chuoiGPS[3] + " " + chuoiGPS[4].Substring(0, 1) + "_ __E'";
                ds = sql.getDataBase(sqlquery2);
                if (ds.Rows.Count > 0)
                {
                    return ds.Rows[0]["TenHuyen"].ToString();
                }
                else
                {
                    string sqlquery3 = "SELECT * FROM [QLCLB].[dbo].[Huyen] where ToaDo like '" + chuoiGPS[0] + " " + chuoiGPS[1].Substring(0, 1) + "_ __N, " + chuoiGPS[3] + " " + chuoiGPS[4] + " __E'";
                    ds = sql.getDataBase(sqlquery3);
                    if (ds.Rows.Count > 0)
                    {
                        return ds.Rows[0]["TenHuyen"].ToString();
                    }
                    else
                    {
                        string sqlquery4 = "SELECT * FROM [QLCLB].[dbo].[Huyen] where ToaDo like '" + chuoiGPS[0] + " " + chuoiGPS[1].Substring(0, 1) + "_ __N, " + chuoiGPS[3] + " " + chuoiGPS[4].Substring(0, 1) + "_ __E'";
                        ds = sql.getDataBase(sqlquery4);
                        if (ds.Rows.Count > 0)
                        {
                            return ds.Rows[0]["TenHuyen"].ToString();
                        }
                        else
                        {
                            string sqlquery5 = "SELECT * FROM [QLCLB].[dbo].[Huyen] where ToaDo like '" + chuoiGPS[0] + " __ __N, " + chuoiGPS[3] + " " + chuoiGPS[4].Substring(0, 1) + "_ __E'";
                            ds = sql.getDataBase(sqlquery5);
                            if (ds.Rows.Count > 0)
                            {
                                return ds.Rows[0]["TenHuyen"].ToString();
                            }
                            else
                            {
                                string sqlquery6 = "SELECT * FROM [QLCLB].[dbo].[Huyen] where ToaDo like '" + chuoiGPS[0] + " __ __N, " + chuoiGPS[3] + " __ __E'";
                                ds = sql.getDataBase(sqlquery6);
                                if (ds.Rows.Count > 0)
                                {
                                    return ds.Rows[0]["TenHuyen"].ToString();
                                }
                            }
                        }
                    }
                }
            }
            return "";
        }
    }
}
