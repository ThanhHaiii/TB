using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace CDIO_QLCLB.XuLyChuoi
{
    class checkKyTu
    {
        public string DetectChar(string input,string idThanhVien)
        {
            DAL.SQLClass sql = new DAL.SQLClass();
            string sqlquery = "SELECT [IDThanhVien] as ID,[HoThanhVien] + ' ' + [TenThanhVien] as HoTen,[NgaySinh], [MSSV],Khoa,Lop,NgaySinh,SDT FROM [ThanhVien] where IDThanhVien = " + idThanhVien;
            DataTable dt = sql.getDataBase(sqlquery);
            if (dt.Rows.Count < 1)
            {
                sqlquery = "SELECT [IDThanhVien] as ID,[HoThanhVien] + ' ' + [TenThanhVien] as HoTen,[NgaySinh], [MSSV],Khoa,Lop,NgaySinh,SDT FROM [ThanhVien] where MSSV = '" + idThanhVien + "'";
                dt = sql.getDataBase(sqlquery);
            }
            input = input.Replace("\r\n", " ");
            input = input.Trim();
            string ketQua = "";
            int endsrt = 0;
            string[] str = { "<HoTen>", "<MSSV>", "<Khoa>", "<Lop>", "<NgaySinh>" };
            for(int i = 0; i < 5; i++)
            {
                int inLeng = input.Length;
                string clonein = input;
                do
                {
                    int vi_tri = clonein.IndexOf(str[i]);
                    if (vi_tri > -1)
                    {
                        endsrt = vi_tri;
                        int demKyTu = 0;
                        while (endsrt < inLeng && (char)input[endsrt] != ' ')
                        {
                            demKyTu++;
                            endsrt++;
                        }

                        string temp = "";
                        switch (i)
                        {
                            case 0: temp = dt.Rows[0]["HoTen"].ToString(); break;
                            case 1: temp = dt.Rows[0]["MSSV"].ToString(); break;
                            case 2: temp = dt.Rows[0]["Khoa"].ToString(); break;
                            case 3: temp = dt.Rows[0]["Lop"].ToString(); break;
                            case 4: temp = dt.Rows[0]["NgaySinh"].ToString(); break;

                        }
                        string chuoia = clonein.Substring(0, vi_tri) + temp;
                        ketQua =chuoia + clonein.Substring((vi_tri + demKyTu), inLeng - (vi_tri + demKyTu));
                        clonein = input.Substring(endsrt, inLeng - endsrt);
                    }
                    else
                    {
                        endsrt = inLeng;
                    }
                } while (endsrt < inLeng);
                input = ketQua;
            }

            return ketQua;
        }
    }
}