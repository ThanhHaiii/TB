using CDIO_QLCLB.XuLyChuoi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_Notification
    {
        GUI.frm_Notification frmnotification;
        DAL.DAL_Notification dalnotifi = new DAL.DAL_Notification();
        LinkLabel linklb_Link = new LinkLabel();
        public BLL_Notification(GUI.frm_Notification frmform)
        {
            frmnotification = frmform;
        }

        public void loadAllNotifi()
        {
            string sqlQuery = "select IDThongBao,TieuDe,NoiDung,NgayDang, NguoiDang, HoThanhVien + ' ' + TenThanhVien as HoTen from ThongBao,ThanhVien where ThongBao.NguoiDang = ThanhVien.IDThanhVien and IDThongBao = " + caseData.DataTam.DuLieu.idTemp;
            DataTable dt = dalnotifi.getNotifi(sqlQuery);
            XuLyChuoi.checkLink checklink = new XuLyChuoi.checkLink();
            List<checkLink> link = checklink.DetectLink(dt.Rows[0]["NoiDung"].ToString());
            frmnotification.lb_PosterFullName.Text = dt.Rows[0]["HoTen"].ToString();
            DateTime ngay = Convert.ToDateTime(dt.Rows[0]["NgayDang"].ToString());
            frmnotification.lb_DateTime.Text = "Thời gian: " + ngay.ToString("dd/MM/yyyy hh:mm:ss tt");
            frmnotification.lb_TieuDe.Text = dt.Rows[0]["TieuDe"].ToString();
            frmnotification.tb_BaiViet.Text = dt.Rows[0]["NoiDung"].ToString();
            int x = 5;
            for(int i = 0; i < link.Count; i++)
            {
                linklb_Link = new LinkLabel();
                linklb_Link.AutoSize = true;
                linklb_Link.LinkColor = System.Drawing.Color.FromArgb(0,0,254);
                linklb_Link.Location = new System.Drawing.Point(x, 26);
                linklb_Link.Name = "linklb" + i;
                linklb_Link.TabIndex = i;
                linklb_Link.TabStop = true;
                linklb_Link.Text = link[i].getContent();
                linklb_Link.Links.Add(0, link[i].getContent().Length, link[i].getContent());
                linklb_Link.LinkClicked += new LinkLabelLinkClickedEventHandler(linkClick);

                frmnotification.pn_Link.Controls.Add(linklb_Link);
                x += linklb_Link.Size.Width + 10;
            }
        }

        private void linkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData as string);
        }
    }
}
