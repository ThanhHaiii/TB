using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using DevExpress.XtraBars.ToastNotifications;

namespace CDIO_QLCLB.GUI
{
    public partial class frm_Messange : Form
    {
        DAL.DAL_Messange dalmess = new DAL.DAL_Messange();
        BLL.BLL_Messange bllmessange;
        private string idMember;
        private bool teamChat;
        bool sendimage = false;
        Thread listen;
        IPEndPoint IP;
        Socket client;

        protected internal ToastNotificationsManager toastNotifiManager;
        
        protected internal string IdMember { get => idMember; set => idMember = value; }
        protected internal bool TeamChat { get => teamChat; set => teamChat = value; }

        public frm_Messange(Form formParent)
        {
            InitializeComponent();
            this.MdiParent = formParent;
            this.StartPosition = FormStartPosition.Manual;
            CheckForIllegalCrossThreadCalls = false;
            bllmessange = new BLL.BLL_Messange(this);
            Connect();
            bllmessange.loadListMess();
        }

        private void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("35.226.245.201"), 1997);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
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

        void SendID()
        {
            client.Send(Serialize(caseData.DataTam.DuLieu.ID));
        }

        public void Send(string messange, string idStart, string idEnd, string typeOf)
        {
            if (messange != string.Empty)
            {
                client.Send(Serialize(typeOf + "-" + idStart + "-" + idEnd + ":" + messange));
            }
        }

        public void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 10000];
                    client.Receive(data);
                    string message = (string)Deseriliaze(data);
                    string[] idOfsystem = message.Split(':');
                    string[] totalID = idOfsystem[0].Split('-');
                    string typeOf = totalID[0].Trim();
                    string idStart = totalID[1].Trim();
                    string idEnd = totalID[2].Trim();
                    message = message.Substring(idOfsystem[0].Length + 1, message.Length - idOfsystem[0].Length - 1);
                    string hoTenNguoiGui = bllmessange.getName(idStart);

                    if (typeOf == "0")
                    {
                        if (idStart == IdMember)
                        {
                            MessageBox.Show(hoTenNguoiGui + message);
                            bllmessange.addmessReceive(message, hoTenNguoiGui, idStart);
                        }
                        else
                        {
                            bllmessange.loadtitleMessMem(idStart);
                        }
                    }
                    else
                    {
                        if (teamChat)
                        {
                            bllmessange.addmessReceive(message, hoTenNguoiGui, idStart);
                        }
                    }
                }
            }
            catch
            {
                Close();
            }
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

        private void bt_Back_Click(object sender, EventArgs e)
        {
            BLL.BLL_MainForm bllmain = new BLL.BLL_MainForm(this.MdiParent as frm_MainForm);
            bllmain.loadIndex();
            listen.Abort();
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (!teamChat)
                {
                    if (tb_Messange.Text != string.Empty)
                    {
                        client.Send(Serialize("0" + "-" + caseData.DataTam.DuLieu.ID + "-" + IdMember + ":" + tb_Messange.Text.Trim()));
                        bllmessange.addmessSend(tb_Messange.Text.Trim(), "", caseData.DataTam.DuLieu.ID);
                    }
                    tb_Messange.Clear();
                    if (sendimage)
                    {
                        XuLyAnh.MaHoaHinhAnh mha = new XuLyAnh.MaHoaHinhAnh();
                        SECURITY.RandomClass rdm = new SECURITY.RandomClass();
                        caseData.MoFile fopen = new caseData.MoFile();

                        string imageName = rdm.RandomText(20) + ".jpg";
                        pic_DinhKem.Image.Save(imageName);
                        string chuoiAnh = mha.byteToString(mha.AnhSangChuoi(imageName));
                        client.Send(Serialize("0" + "-" + caseData.DataTam.DuLieu.ID + "-" + IdMember + ":" + chuoiAnh));
                        fopen.deleteFile(imageName);
                        bllmessange.addmessSend(chuoiAnh, "", caseData.DataTam.DuLieu.ID);
                        pic_DinhKem.Image = global::CDIO_QLCLB.Properties.Resources.shapes;
                    }
                }
                else
                {
                    if (tb_Messange.Text != string.Empty)
                    {
                        client.Send(Serialize("1" + "-" + caseData.DataTam.DuLieu.ID + "-" + IdMember + ":" + tb_Messange.Text.Trim()));
                        bllmessange.addmessSend(tb_Messange.Text.Trim(), "", caseData.DataTam.DuLieu.ID);
                    }
                    tb_Messange.Clear();
                    if (sendimage)
                    {
                        XuLyAnh.MaHoaHinhAnh mha = new XuLyAnh.MaHoaHinhAnh();
                        SECURITY.RandomClass rdm = new SECURITY.RandomClass();
                        caseData.MoFile fopen = new caseData.MoFile();

                        string imageName = rdm.RandomText(20) + ".jpg";
                        pic_DinhKem.Image.Save(imageName);
                        string chuoiAnh = mha.byteToString(mha.AnhSangChuoi(imageName));
                        client.Send(Serialize("1" + "-" + caseData.DataTam.DuLieu.ID + "-" + IdMember + ":" + chuoiAnh));
                        fopen.deleteFile(imageName);
                        bllmessange.addmessSend(chuoiAnh, "", caseData.DataTam.DuLieu.ID);
                        pic_DinhKem.Image = global::CDIO_QLCLB.Properties.Resources.shapes;
                    }
                }
                sendimage = false;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối máy chủ nhắn tin\nĐang kết nối lại...", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                caseData.DataTam.DuLieu.client = null;
                Connect();
            }
        }

        private void tb_Messange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                bt_Send.PerformClick();
        }

        private void pic_DinhKem_Click(object sender, EventArgs e)
        {
            bllmessange.loadAnh();
            sendimage = true;
        }
    }
}
