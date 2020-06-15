using CDIO_QLCLB.GUI;
using DevExpress.XtraBars.ToastNotifications;
using SimpleBroker;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CDIO_QLCLB.BLL
{
    class BLL_MainForm
    {
        frm_MainForm frm_mainform;
        logical.ThongBaoDKMoi tbMoi = new logical.ThongBaoDKMoi();
        DAL.DAL_MainClass dalmain = new DAL.DAL_MainClass();
        protected internal ToastNotificationsManager toastNotifiManager;
        private System.ComponentModel.IContainer components = null;

        public BLL_MainForm()
        {
        }

        public BLL_MainForm(frm_MainForm form)
        {
            frm_mainform = form;

        }

        public void loadIndex()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_Index"] == null)
                {
                    GUI.frm_Home frmcreateaccount = new frm_Home(frm_mainform);
                    frmcreateaccount.Show();
                }
                else
                {
                    Application.OpenForms["frm_Index"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadAttendance()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_Attendance"] == null)
                {
                    GUI.frm_Attendance frmAttendance = new frm_Attendance(frm_mainform);
                    frmAttendance.Show();
                }
                else
                {
                    Application.OpenForms["frm_Attendance"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadcreateaccount()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_CreateAccount"] == null)
                {
                    GUI.frm_CreateAccount frmindex = new frm_CreateAccount(frm_mainform);
                    frmindex.Show();
                }
                else
                {
                    Application.OpenForms["frm_CreateAccount"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadTeamList()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_TeamManager"] == null)
                {
                    GUI.frm_TeamManager frmteamList = new frm_TeamManager(frm_mainform);
                    frmteamList.Show();
                }
                else
                {
                    Application.OpenForms["frm_TeamManager"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadMissionTeam()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_MissionTeam"] == null)
                {
                    GUI.frm_MissionTeam frm_Mission = new frm_MissionTeam(frm_mainform);
                    frm_Mission.Show();
                }
                else
                {
                    Application.OpenForms["frm_MissionTeam"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadcreatTeam()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_AddTeam"] == null)
                {
                    GUI.frm_AddTeam frmcreateteam = new frm_AddTeam(frm_mainform);
                    frmcreateteam.Show();
                }
                else
                {
                    Application.OpenForms["frm_AddTeam"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadmodify()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_ModifyTeam"] == null)
                {
                    GUI.frm_ModifyTeam frmmodify = new frm_ModifyTeam(frm_mainform);
                    frmmodify.Show();
                }
                else
                {
                    Application.OpenForms["frm_ModifyTeam"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadmemberlist()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_MemberList"] == null)
                {
                    GUI.frm_MemberList frmindex = new frm_MemberList(frm_mainform);
                    frmindex.Show();
                }
                else
                {
                    Application.OpenForms["frm_MemberList"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadaddMember()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_AddMember"] == null)
                {
                    GUI.frm_AddMember frmaddmember = new frm_AddMember(frm_mainform);
                    frmaddmember.Show();
                }
                else
                {
                    Application.OpenForms["frm_AddMember"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadMessan()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_Messange"] == null)
                {
                    GUI.frm_Messange frmmessange = new frm_Messange(frm_mainform);
                    frmmessange.Show();
                }
                else
                {
                    Application.OpenForms["frm_Messange"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void loadTT()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_ThongBao"] == null)
                {
                    GUI.frm_Messange frmmessange = new frm_Messange(frm_mainform);
                    frmmessange.Show();
                }
                else
                {
                    Application.OpenForms["frm_ThongBao"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string getName(string id)
        {
            string sqlquery = "select (HoThanhVien +' ' +TenThanhVien+' - '+ right(MSSV,4)) as HoTen from ThanhVien where IDThanhVien = " + id;
            return dalmain.getname(sqlquery);
        }

        public void loadPlanningDetails()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_PlanningDetails"] == null)
                {
                    GUI.frm_PlanningDetails frmchitietkehoach = new frm_PlanningDetails(frm_mainform);
                    frmchitietkehoach.Show();
                }
                else
                {
                    Application.OpenForms["frm_PlanningDetails"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void toastnotifiManager()
        {
            caseData.txtRead txtread = new caseData.txtRead();
            logical.GgSheetAPI ggsheet = new logical.GgSheetAPI();
            string[] idTable = txtread.readfile(0);
            IList<IList<Object>> values = ggsheet.docfile(idTable[1], idTable[2]);
            for (int i = values.Count - 1; i >= 0; i--)
            {
                var row = values[i];
                if (row.Count < 13 && row.Count > 0)
                {
                    DateTime sigupTime = Convert.ToDateTime(row[0]);
                    DateTime datenow = DateTime.Now;
                    TimeSpan timeSpan = datenow - sigupTime;
                    if (timeSpan.TotalSeconds < 30)
                    {
                        DevExpress.XtraBars.ToastNotifications.ToastNotification toastNotification1 = new DevExpress.XtraBars.ToastNotifications.ToastNotification();
                        toastNotifiManager = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
                        toastNotifiManager.ApplicationId = row[0].ToString();
                        toastNotifiManager.ApplicationName = "CLB Tình nguyện Sinh viên Duy Tân";
                        toastNotification1.Body = row[2].ToString() + " " + row[3].ToString();
                        toastNotification1.Header = "Đăng ký thành viên mới";
                        toastNotification1.ID = "faf7a0e2-d33b-46fb-8b40-6eb35e31192a";
                        toastNotification1.Image = global::CDIO_QLCLB.Properties.Resources.logo;
                        toastNotification1.Template = DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText03;
                        toastNotification1.Body2 = "https://www.facebook.com/CLBTinhNguyenSinhVienDuyTan";
                        toastNotifiManager.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] { toastNotification1 });

                        toastNotifiManager.ShowNotification(toastNotifiManager.Notifications[0]);
                    }
                }
                else
                {
                    break;
                }
            }
        }
        public void loadAddMeetings()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_AddMeetings"] == null)
                {
                    GUI.frm_AddMeetings frmaddmeetings = new frm_AddMeetings(frm_mainform);
                    frmaddmeetings.Show();
                }
                else
                {
                    Application.OpenForms["frm_AddMeetings"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadNotification()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_Notification"] == null)
                {
                    GUI.frm_Notification frmcNotification = new frm_Notification(frm_mainform);
                    frmcNotification.Show();
                }
                else
                {
                    Application.OpenForms["frm_Notification"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void loadBirth()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_BirthDay"] == null)
                {
                    GUI.frm_BirthDay frmcNotification = new frm_BirthDay(frm_mainform);
                    frmcNotification.Show();
                }
                else
                {
                    Application.OpenForms["frm_BirthDay"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loadSignUp()
        {
            xoaToanBoFormCon();
            try
            {
                if (Application.OpenForms["frm_MemberInfo"] == null)
                {
                    GUI.frm_MemberInfo frmcSignUp = new frm_MemberInfo(frm_mainform);
                    frmcSignUp.Show();
                }
                else
                {
                    Application.OpenForms["frm_MemberInfo"].Activate();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void xoaToanBoFormCon()
        {
            foreach (Form frm in frm_mainform.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }

        public void logout()
        {
            frm_mainform.Hide();
        }
    }
}
