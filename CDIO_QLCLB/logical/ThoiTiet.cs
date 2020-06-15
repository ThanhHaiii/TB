using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CDIO_QLCLB.logical;
using System.Net;
using System.Xml;
using System.IO;
using System.Globalization;

namespace CDIO_QLCLB.logical
{
    class ThoiTiet
    {
        private const string API_KEY = "c7055ce01673bc05bf8af1cb09e60bd2";
        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;

        List<caseData.dataThoiTiet> dsThoiTiet = new List<caseData.dataThoiTiet>();
        logical.DiaPhuong diaphuong = new DiaPhuong();
        string diaPhuong;
        public void loadXML()
        {
            diaPhuong = diaphuong.TenHuyen();
            string url = ForecastUrl.Replace("@LOC@", diaPhuong + ",vn");
            url = url.Replace("@QUERY@", "q");

            using (WebClient client = new WebClient())
            {
                try
                {
                    napThoiTiet(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown error\n" + ex.Message);
                }
            }
        }

        private void DisplayError(WebException exception)
        {
            try
            {
                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                MessageBox.Show(message_node.InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error\n" + ex.Message);
            }
        }

        private double doiNhiet(string nhietvao)
        {
            if (nhietvao.Length == 2)
            {
                return (((float.Parse(nhietvao)) - 32) / 1.8);
            }
            string nhietdo = nhietvao.Split('.')[0].ToString() + "," + nhietvao.Split('.')[1];
            return (((float.Parse(nhietdo)) - 32) / 1.8);
        }

        private double doiTocDoGio(string tocDoVao)
        {
            return (float.Parse(tocDoVao) * 1.609);
        }

        private string dichHuongGio(string huongGioEng)
        {
            switch (huongGioEng)
            {
                case "South": return "Nam";
                case "East": return "Đông";
                case "West": return "Tây";
                case "North": return "Bắc";
                case "NorthEast": return "Đông bắc";
                case "East-northeast": return "Đông - đông bắc";
                case "South-southeast": return "Nam - đông nam";
                case "South-southwest": return "Nam - tây nam";
                case "SouthEast": return "Đông Nam";
                case "East-southeast": return "Đông - đông nam";
                case "Southwest": return "Tây nam";
                case "West-southwest": return "Tây - tây nam";
            }
            return huongGioEng;
        }

        private double chuyenApSuat(string apSuat)
        {
            return Math.Round((double.Parse(apSuat)/1013), 2);
        }

        private void napThoiTiet(string xml)
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);
            foreach (XmlNode xmlnode in xml_doc.SelectNodes("//time"))
            {
                caseData.dataThoiTiet dtThoiTiet = new caseData.dataThoiTiet();
                dtThoiTiet.NgayGio =
                    DateTime.Parse(xmlnode.Attributes["from"].Value,
                        null, DateTimeStyles.AssumeUniversal);
                dtThoiTiet.BieuTuong = xmlnode.SelectSingleNode("symbol").Attributes["name"].Value;
                dtThoiTiet.HuongGio = dichHuongGio(xmlnode.SelectSingleNode("windDirection").Attributes["name"].Value);
                dtThoiTiet.NhietDo = Math.Round(doiNhiet(xmlnode.SelectSingleNode("temperature").Attributes["value"].Value),2);
                dtThoiTiet.MaxNhietDo = Math.Round(doiNhiet(xmlnode.SelectSingleNode("temperature").Attributes["max"].Value),2);
                dtThoiTiet.MinNhietDo = Math.Round(doiNhiet(xmlnode.SelectSingleNode("temperature").Attributes["min"].Value),2);
                dtThoiTiet.NhietDoCamNhan = doiNhiet(xmlnode.SelectSingleNode("feels_like").Attributes["value"].Value);
                dtThoiTiet.DoAmKK = int.Parse(xmlnode.SelectSingleNode("humidity").Attributes["value"].Value);
                dtThoiTiet.ApSuat = chuyenApSuat(xmlnode.SelectSingleNode("pressure").Attributes["value"].Value);
                dtThoiTiet.LuongMay = int.Parse(xmlnode.SelectSingleNode("clouds").Attributes["all"].Value);
                dtThoiTiet.TocDoGio = Math.Round(doiTocDoGio(xmlnode.SelectSingleNode("windSpeed").Attributes["mps"].Value), 2);
                dsThoiTiet.Add(dtThoiTiet);
            }
            caseData.DataTam.DuLieu.diaPhuong = diaPhuong;
        }

        public List<caseData.dataThoiTiet> layDSThoiTiet()
        {
            return dsThoiTiet;
        }
    }

}
