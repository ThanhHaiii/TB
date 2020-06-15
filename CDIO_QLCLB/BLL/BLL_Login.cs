using System;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_Login
    {
        GUI.frm_Login frmlogin;
        SECURITY.BamChuoi bam = new SECURITY.BamChuoi();
        DAL.DAL_Login dallogin = new DAL.DAL_Login();

        public BLL_Login(GUI.frm_Login frm)
        {
            frmlogin = frm;
        }

        public Boolean checkHopLe()
        {
            if (frmlogin.tb_UserName.Text.Length < 6 || frmlogin.tb_PassWd.Text.Length < 6)
            {
                return false;
            }
            else
                return true;
        }

        public string getRandomstring(string userName)
        {
            try
            {
                string sqlquery = "SELECT [RandomString] FROM [TaiKhoan] WHERE [UserName] like '" +
                userName + "' and [DangNhap] = 'false' and [KhoaTaiKhoan] = 'false'";
                return dallogin.layRandomString(sqlquery);
            }
            catch
            {
                return "";
            }
        }

        public void login()
        {
            if (checkHopLe())
            {
                logical.checkConnectServer checkconn = new logical.checkConnectServer();
                string username = bam.maHoaKyTu(frmlogin.tb_UserName.Text);//Mã hóa user name
                string randomString = getRandomstring(username);//Lấy chuỗi random của user name đó
                string passWD = bam.maHoaKyTu((frmlogin.tb_PassWd.Text + randomString));//Mã hóa chuỗi gồm (Mật khẩu nhập vào + chuỗi random trong csdl)
                caseData.DataTam.DuLieu.linkFileGoc = System.Environment.CurrentDirectory;
                caseData.DataTam.DuLieu.linkFileGoc = caseData.DataTam.DuLieu.linkFileGoc.Substring(0, caseData.DataTam.DuLieu.linkFileGoc.Length - 9);
                string sqlquery = "SELECT [IDThanhVien] FROM [TaiKhoan] WHERE [UserName] like '" + username
                    + "' and PassWD like '" + passWD + "';";

                if (!checkconn.checkConnectGoogle())//Kiểm tra kết nối tới máy chủ
                {
                    MessageBox.Show("Kết nối tới Server bị lỗi vui lòng kiểm tra kết nối Internet của bạn và thử lại");
                    return;
                }

                if (randomString.Equals(""))//Chuỗi random rỗng có nghĩa là tên đăng nhập sai
                {
                    MessageBox.Show("Tên đăng nhập không đúng hoặc tài khoản đã bị khóa");
                    return;
                }
                else
                {
                    string id = dallogin.LayMaTV(sqlquery);
                    if (id != null)
                    {
                        caseData.DataTam.DuLieu.ID = id;
                        frm_MainForm frmmain = new frm_MainForm();
                        frmmain.Show();
                        frmlogin.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác");
                    }
                }
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
            frmlogin.tb_PassWd.Text = "";
        }
    }
}
