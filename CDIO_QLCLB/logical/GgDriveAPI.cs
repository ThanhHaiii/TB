using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace CDIO_QLCLB.logical
{
    class dataRqUpload
    {
        string id, webContentLink, webViewLink;

        public string Id { get => id; set => id = value; }
        public string WebContentLink { get => webContentLink; set => webContentLink = value; }
        public string WebViewLink { get => webViewLink; set => webViewLink = value; }
    }
    class GgDriveAPI
    {
        static string[] ScopesWrite = { "https://www.googleapis.com/auth/drive.file", "https://www.googleapis.com/auth/drive" };
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

        public dataRqUpload uploadFileDriveGoogle(string folderId,string fileName,string fileLink,string type)
        {
            /*Upload file lên Google drive cần đầu vào là ID thư mục cần up ở drive, tên file khi lưu trên drive, đường dẫn tới file trong thư mục, kiểu file
             Chú ý: kiểu file dùng hàm getTypeFile trong caseData đầu vào của hàm getType là đuôi của file cần get
             HÀM TRẢ VỀ 1 object dataRqUpload chứa thông tin của file như Link Download : nằm ở giá trị WebContentLink
             ID file nằm ở giá trị Id, link xem file nằm ở giá trị WebViewLink.
             Khi nối ID vào sau link https://drive.google.com/open?id= sẽ mở được file*/
            UserCredential credential = GetCredential(ScopesWrite);
            var driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "VolunteerDTU"
            });

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = fileName,
                Parents = new List<string>
                {
                    folderId
                }
            };

            FilesResource.CreateMediaUpload request;
            using (var stream = new System.IO.FileStream(fileLink, System.IO.FileMode.Open))
            {
                request = driveService.Files.Create(fileMetadata, stream, type);
                request.Fields = "*";
                request.Upload();
            }
            var rq = request.ResponseBody;
            dataRqUpload req = new dataRqUpload();
            req.Id = rq.Id;
            req.WebContentLink = rq.WebContentLink;
            req.WebViewLink = rq.WebViewLink;
            return req;
        }

        public bool deleteFile(string idFile)
        {
            /*Hàm xóa file trên google.
             Đầu vào là ID File khi xóa thành công thì trả giá trị là true ngược lại thì thông báo lỗi và trả về false*/
            try
            {
                UserCredential credential = GetCredential(ScopesWrite);
                var driveService = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "VolunteerDTU"
                });

                driveService.Files.Delete(idFile).Execute();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public List<dataRqUpload> uploadGGD(string folderID)
        {
            /*Hàm upload google này yêu cầu đầu vào là folderID
             khi chạy hàm sẽ mở cửa sổ chọn file cần upload. bạn có thể chọn nhiều file cùng 1 lúc.
             kết quả trả về 1 List<dataRqUpload> chứa danh sách các file đã được upload*/
            List<dataRqUpload> rqUpload = new List<dataRqUpload>();
            caseData.MoFile openfile = new caseData.MoFile();
            caseData.getTypeFile gettype = new caseData.getTypeFile();
            OpenFileDialog ofile = openfile.moNhieuFile();
            foreach (string fileOpen in ofile.FileNames)
            {
                string filename = System.IO.Path.GetFileName(fileOpen);
                string format = filename.Split('.')[filename.Split('.').Length - 1];
                string fileType = gettype.getType(format);
                dataRqUpload rq = uploadFileDriveGoogle(folderID, filename, fileOpen, fileType + "/" + format);
                rqUpload.Add(rq);
            }
            return rqUpload;
        }
    }
}
