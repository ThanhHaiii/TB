using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDIO_QLCLB.objInProject
{
    class Member
    {
        string idThanhVien, hoThanhVien, tenThanhVien, tenChucVu,mssv;
        Image avatar;

        public string IdThanhVien { get => idThanhVien; set => idThanhVien = value; }
        public string HoThanhVien { get => hoThanhVien; set => hoThanhVien = value; }
        public string TenThanhVien { get => tenThanhVien; set => tenThanhVien = value; }
        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public string Mssv { get => mssv; set => mssv = value; }
        public Image Avatar { get => avatar; set => avatar = value; }
    }

    class MemberList
    {
        DAL.SQLClass sql = new DAL.SQLClass();
        List<Member> mbList = new List<Member>();
        XuLyAnh.MaHoaHinhAnh convertImage = new XuLyAnh.MaHoaHinhAnh();

        public List<Member> getMemberList()
        {
            return mbList;
        }

        public void addMember(Member mb)
        {
            mbList.Add(mb);
        }

        public void deleteMember(string idMember, List<Member> listseach)
        {
            for(int i = 0; i < listseach.Count; i++)
            {
                if(listseach[i].IdThanhVien == idMember)
                {
                    listseach.Remove(listseach[i]);
                }
            }
            caseData.DataTam.DuLieu.mbList = listseach;
        }

        public List<Member> seachMember(string inputSeach,List<Member> listseach)
        {
            List<Member> newlist = new List<Member>();
            XuLyChuoi.LoaiBoDau loaiBoDau = new XuLyChuoi.LoaiBoDau();
            foreach(Member mb in listseach)
            {
                string hoTen = mb.HoThanhVien + " " + mb.TenThanhVien;
                if(mb.Mssv.ToUpper().Contains(inputSeach.ToUpper()) || loaiBoDau.ConvertToUnsign(hoTen).ToUpper().Contains(loaiBoDau.ConvertToUnsign(inputSeach).ToUpper()))
                {
                    newlist.Add(mb);
                }
            }
            return newlist;
        }

        public List<Member> seachMemberID(DataTable inputID, List<Member> listseach)
        {
            List<Member> newlist = new List<Member>();
            if (listseach == null)
            {
                return null;
            }
            else
            {
                foreach (Member mb in listseach)
                {
                    for (int i = 0; i < inputID.Rows.Count; i++)
                    {
                        if (mb.IdThanhVien == inputID.Rows[i]["IDThanhVien"].ToString())
                        {
                            newlist.Add(mb);
                        }
                    }
                }
                return newlist;
            }
        }

        public void loadMember()
        {
            string sqlquery = "select IDThanhVien,HoThanhVien , TenThanhVien,MSSV,ThanhVien.IDChucVu,AnhDaiDien,TenChucVu from ThanhVien,ChucVu where ChucVu.IDChucVu = ThanhVien.IDChucVu and RoiCLB is null order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien";
            DataTable dt = sql.getDataBase(sqlquery);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Member mb = new Member();
                mb.IdThanhVien = dt.Rows[i]["IDThanhVien"].ToString();
                mb.HoThanhVien = dt.Rows[i]["HoThanhVien"].ToString();
                mb.TenThanhVien = dt.Rows[i]["TenThanhVien"].ToString();
                mb.Mssv = dt.Rows[i]["MSSV"].ToString();
                mb.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();
                if (dt.Rows[i]["AnhDaiDien"].ToString() != "")
                {
                    mb.Avatar = convertImage.ChuoiSangAnh(dt.Rows[i]["AnhDaiDien"].ToString());
                }
                addMember(mb);
            }
            caseData.DataTam.DuLieu.mbList = getMemberList();
        }


        public void addNewMember(string idMember, List<Member> listseach)
        {
            string sqlquery = "select IDThanhVien,HoThanhVien , TenThanhVien,MSSV,ThanhVien.IDChucVu,AnhDaiDien,TenChucVu from ThanhVien,ChucVu where ChucVu.IDChucVu = ThanhVien.IDChucVu and RoiCLB is null and ThanhVien.IDThanhVien = " + idMember + " order by ThanhVien.IDChucVu,TenThanhVien,HoThanhVien";
            DataTable dt = sql.getDataBase(sqlquery);
            Member mb = new Member();
            mb.IdThanhVien = dt.Rows[0]["IDThanhVien"].ToString();
            mb.HoThanhVien = dt.Rows[0]["HoThanhVien"].ToString();
            mb.TenThanhVien = dt.Rows[0]["TenThanhVien"].ToString();
            mb.Mssv = dt.Rows[0]["MSSV"].ToString();
            mb.TenChucVu = dt.Rows[0]["TenChucVu"].ToString();
            if (dt.Rows[0]["AnhDaiDien"].ToString() != "")
            {
                mb.Avatar = convertImage.ChuoiSangAnh(dt.Rows[0]["AnhDaiDien"].ToString());
            }
            listseach.Add(mb);
            caseData.DataTam.DuLieu.mbList = listseach;
        }
    }
}
