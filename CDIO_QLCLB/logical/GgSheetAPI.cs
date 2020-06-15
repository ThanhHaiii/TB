using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using Data = Google.Apis.Sheets.v4.Data;
using System.Windows.Forms;

namespace CDIO_QLCLB.logical
{
    class GgSheetAPI
    {
        static string[] ScopesWrite = { "https://www.googleapis.com/auth/spreadsheets", "https://www.googleapis.com/auth/drive.file", "https://www.googleapis.com/auth/drive" };
        static string[] ScopesRead = { SheetsService.Scope.SpreadsheetsReadonly };

        private UserCredential GetCredential(string[] scopes)
        {
            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                return credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets, scopes, "user", CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
        }
        public IList<IList<Object>> docfile(string spreadsheetId, string range)
        {/*Hàm này cần truyền vào ID Bảng dữ liệu cần đọc (vd ta có link google sheet: 
            https://docs.google.com/spreadsheets/d/1kn1JGyeq_2II0TmO1nbDyOIsvwHlOLqygSsPIgR6YBA/edit#gid=1142370736 ) thì 
            ID của nó là 1kn1JGyeq_2II0TmO1nbDyOIsvwHlOLqygSsPIgR6YBA, và cần tên bảng cần đọc. Hàm sẽ trả về 1 mảng có kiểu dữ liệu IList<IList<Object>>
            dùng foreach để duyệt mảng nhé. cũng có thể chơi for như bình thường 
            CHÚ Ý: TRẢ VỀ MẢNG RĂNG CƯA ĐẤY NHÉ*/
            UserCredential credential = GetCredential(ScopesRead);            
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "VolunteerDTU"
            });
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                return values;
            }
            else
            {
                return null;
            }

        }

        public object writeData(string spreadsheetId, string tenBang, string phamViCell, IList<IList<object>> dataIn)
        {
            checkConnectServer chk = new checkConnectServer();
            if (chk.checkConnectGoogle())
            {
                /*ĐÂY LÀ HÀM GHI DỮ LIỆU VÀO GOOGLE SHEET
             Hàm này cần đầu vào là ID bảng, Tên bảng, phạm vi điền (VD: A52 hoặc A5:A8 (Hàng ngang)) và mảng dữ liệu đầu vào.*/
                UserCredential credential = GetCredential(ScopesWrite);

                var sheetsService = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "VolunteerDTU"
                });
                Data.ValueRange requestBody = new Data.ValueRange();
                requestBody.Values = dataIn;
                string range = "'" + tenBang + "'!" + phamViCell;
                SpreadsheetsResource.ValuesResource.AppendRequest request = sheetsService.Spreadsheets.Values.Append(requestBody, spreadsheetId, range);
                request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
                request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW;
                var response = request.Execute();
                return response;
            }
            else
            {
                MessageBox.Show("Không có kết nối internet");
                return null;
            }
        }

        public object deleteData(string spreadsheetId, string tenBang, string phamViCell)
        {
            /*Xóa dữ liệu trong bảng
             Đầu vào cần có ID bảng, Tên sheet vd: sheet 1, phạm vi cần xóa*/
            UserCredential credential = GetCredential(ScopesWrite);
            var sheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "VolunteerDTU"
            });

            try
            {
                string range = "'" + tenBang + "'!" + phamViCell; ;
                Data.ClearValuesRequest requestBody = new Data.ClearValuesRequest();
                SpreadsheetsResource.ValuesResource.ClearRequest request = sheetsService.Spreadsheets.Values.Clear(requestBody, spreadsheetId, range);
                Data.ClearValuesResponse response = request.Execute();
                return request;
            }
            catch(Exception e)
            {
                return e;
            }
        }
    }
}
