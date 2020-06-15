using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;

namespace CDIO_QLCLB.logical
{
    class GetToaDo
    {
        private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e) // Find GeoLocation of Device  
        {
            try
            {
                if (e.Status == GeoPositionStatus.Ready)
                {
                    if (watcher.Position.Location.IsUnknown)
                    {
                        caseData.DataTam.DuLieu.kinhdo = "0";
                        caseData.DataTam.DuLieu.vido = "0";
                    }
                    else
                    {
                        caseData.DataTam.DuLieu.vido = watcher.Position.Location.Latitude.ToString();
                        caseData.DataTam.DuLieu.kinhdo = watcher.Position.Location.Longitude.ToString();
                    }
                }
                else
                {
                    caseData.DataTam.DuLieu.kinhdo = "0";
                    caseData.DataTam.DuLieu.vido = "0";
                }
            }
            catch (Exception)
            {
                caseData.DataTam.DuLieu.kinhdo = "0";
                caseData.DataTam.DuLieu.vido = "0";
            }
        }

        public void openGPS()
        {
            watcher = new GeoCoordinateWatcher();
            watcher.StatusChanged += Watcher_StatusChanged;
            watcher.Start();
        }

        public string DoiToaDo(string kinhdo, string vido)
        {
            float gio, phut, giay;
            string toado = "";
            //vĩ độ
            gio = (int)float.Parse(vido);
            phut = ((float.Parse(vido) - gio) * 60);
            giay = (int)((phut - (int)phut) * 60);
            phut = (int)phut;
            toado = gio.ToString();
            if (phut < 10)
            {
                toado += " 0" + phut;
            }
            else
                toado += " " + phut;
            if (giay < 10)
            {
                toado += " 0" + giay + "N, ";
            }
            else
                toado += " " + giay + "N, ";

            //kinh độ
            gio = (int)float.Parse(kinhdo);
            phut = ((float.Parse(kinhdo) - gio) * 60);
            giay = (int)((phut - (int)phut) * 60);
            phut = (int)phut;
            toado += gio;
            if (phut < 10)
                toado += " 0" + phut;
            else
                toado += " " + phut;
            if (giay < 10)
                toado += " 0" + giay + "E";
            else
                toado += " " + giay + "E";
            return toado;
        }
    }
}
