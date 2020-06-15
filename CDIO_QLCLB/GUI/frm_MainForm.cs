using System;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using DevExpress.XtraBars.ToastNotifications;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CDIO_QLCLB
{
    public partial class frm_MainForm : Form
    {
        BLL.BLL_MainForm bll_mainform;
        objInProject.MemberList mblist = new objInProject.MemberList();
        IPEndPoint IP;
        Socket client;
        Thread listen;
        protected internal ToastNotificationsManager toastNotifiManager;

        public frm_MainForm()
        {
            bll_mainform = new BLL.BLL_MainForm(this);
            InitializeComponent();
            Connect();
            ThreadStart thrStart = new ThreadStart(mblist.loadMember);
            Thread thread = new Thread(thrStart);
            thread.IsBackground = true;
            thread.Start();
        }

        public void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("35.226.245.201"), 1997);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                caseData.DataTam.DuLieu.client = client;
                SendID();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        public void Close()
        {
            caseData.DataTam.DuLieu.client.Close();
        }

        void SendID()
        {
            client.Send(Serialize(caseData.DataTam.DuLieu.ID));
        }

        public void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 10000];//Nội dung tin nhắn nhận không quá 10000kb;
                    client.Receive(data);
                    string message = (string)Deseriliaze(data);
                    string[] idOfsystem = message.Split(':');
                    if (idOfsystem[0] != "volunteeraddmember")
                    {
                        if (Application.OpenForms["frm_Messange"] == null)
                        {
                            string typeOf = idOfsystem[0].Split('-')[0].Trim();
                            string idStart = idOfsystem[0].Split('-')[1].Trim();
                            string idEnd = idOfsystem[0].Split('-')[2].Trim();
                            message = message.Substring(message.Split(':')[0].Length + 1, message.Length - message.Split(':')[0].Length - 1);
                            string hoTenNguoiGui = bll_mainform.getName(idStart);
                            notifyMessange(message, hoTenNguoiGui);
                        }
                    }
                }
            }
            catch
            {
                Close();
                MessageBox.Show("Lỗi kết nối máy chủ nhắn tin\nThử kết nối lại...", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                caseData.DataTam.DuLieu.client = null;
                Connect();
            }
        }

        private void notifyMessange(string message, string hotennguoigui)
        {
            DevExpress.XtraBars.ToastNotifications.ToastNotification toastNotification1 = new DevExpress.XtraBars.ToastNotifications.ToastNotification();
            toastNotifiManager = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            toastNotifiManager.ApplicationId = hotennguoigui;
            toastNotifiManager.ApplicationName = "CLB Tình nguyện Sinh viên Duy Tân";
            toastNotification1.Body = message;
            toastNotification1.Header = "Tin nhắn mới";
            toastNotification1.ID = "faf7a0e2-d33b-46fb-8b40-6eb35e31192a";
            toastNotification1.Image = global::CDIO_QLCLB.Properties.Resources.logo;
            toastNotification1.Template = DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText03;
            toastNotification1.Body2 = "https://www.facebook.com/CLBTinhNguyenSinhVienDuyTan";
            toastNotifiManager.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] { toastNotification1 });

            toastNotifiManager.ShowNotification(toastNotifiManager.Notifications[0]);
        }

        private byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        private object Deseriliaze(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        private void frm_MainForm_Load_1(object sender, EventArgs e)
        {
            caseData.DataTam.DuLieu.linkFileGoc = System.Environment.CurrentDirectory;
            caseData.DataTam.DuLieu.ChieuNgangFormChinh = Screen.PrimaryScreen.WorkingArea.Width;
            caseData.DataTam.DuLieu.ChieuDocFormChinh = Screen.PrimaryScreen.WorkingArea.Height; caseData.DataTam.DuLieu.linkFileGoc = System.Environment.CurrentDirectory;
            caseData.DataTam.DuLieu.linkFileGoc = caseData.DataTam.DuLieu.linkFileGoc.Substring(0, caseData.DataTam.DuLieu.linkFileGoc.Length - 9);
            bll_mainform.loadIndex();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll_mainform.loadIndex();
            if (!listen.IsAlive)
            {
                listen.Resume();
            }
        }

        private void qLĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll_mainform.loadaddMember();
            if (!listen.IsAlive)
            {
                listen.Resume();
            }
        }

        private void qLDanhSáchThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll_mainform.loadmemberlist();
            if (!listen.IsAlive)
            {
                listen.Resume();
            }
        }

        private void frm_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
            notify_VolunteerDTU.Visible = true;
            notify_VolunteerDTU.ShowBalloonTip(10);
            this.ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
        }

        private void notify_VolunteerDTU_DoubleClick(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Maximized;
            bll_mainform.loadIndex();
            notify_VolunteerDTU.Visible = false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void mởGiaoDiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            WindowState = FormWindowState.Maximized;
            bll_mainform.loadIndex();
            notify_VolunteerDTU.Visible = false;
        }

        private void loadThongBao_Tick(object sender, EventArgs e)
        {
            bll_mainform.toastnotifiManager();
        }

        private void nhắnTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listen.Suspend();
            bll_mainform.loadMessan();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bll_mainform.loadcreateaccount();
            if (!listen.IsAlive)
            {
                listen.Resume();
            }
        }
    }
}
