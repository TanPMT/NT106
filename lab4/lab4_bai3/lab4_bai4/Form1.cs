using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Security.Policy;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.IO;
using System.Net;

namespace lab4_bai4
{
    public partial class Form1 : Form
    {
        private const string V = "test.html";
        private String url = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "https://" + address;
                /*webBrowser1.Navigate(address);*/
                url = address;
                tbAddress.Text = "";
            }
            else
            {
                try
                {
                    /*webBrowser1.Navigate(address);*/
                    url = address;
                    tbAddress.Text = "";
                }
                catch (System.UriFormatException)
                {
                    return;
                }
            }
        }

        private void tbAddress_TextChanged(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Navigate(tbAddress.Text);
            }
        }

        private void btnDowHTML_Click(object sender, EventArgs e)
        {
            Navigate(tbAddress.Text);
            string folderPath = tbPath.Text;
            DownloadSource(url,folderPath);
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);
            string source = document.DocumentNode.OuterHtml;
            Source openSourcePage = new Source(source);
            openSourcePage.Show();
        }
        

        void DownloadSource(string url, string folderPath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);

            // Lưu source HTML của trang vào tệp tin
            string fileName = Path.GetFileName(url) + ".html";
            string filePath = Path.Combine(folderPath, fileName);
            File.WriteAllText(filePath, document.DocumentNode.OuterHtml);

            // Tạo danh sách các tệp cần tải xuống
            List<string> fileUrls = new List<string>();

            // Thêm tất cả các hình ảnh vào danh sách
            var imgNodes = document.DocumentNode.SelectNodes("//img");
            if (imgNodes != null)
            {
                foreach (HtmlNode imgNode in imgNodes)
                {
                    string imgUrl = imgNode.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(imgUrl))
                    {
                        fileUrls.Add(imgUrl);
                    }
                }
            }

            // Thêm tất cả các liên kết tệp vào danh sách
            var linkNodes = document.DocumentNode.SelectNodes("//link[@rel='stylesheet' or @type='text/css' or @rel='icon']");
            if (linkNodes != null)
            {
                foreach (HtmlNode linkNode in linkNodes)
                {
                    string linkUrl = linkNode.GetAttributeValue("href", "");
                    if (!string.IsNullOrEmpty(linkUrl))
                    {
                        fileUrls.Add(linkUrl);
                    }
                }
            }

            // Thêm tất cả các script vào danh sách
            var scriptNodes = document.DocumentNode.SelectNodes("//script");
            if (scriptNodes != null)
            {
                foreach (HtmlNode scriptNode in scriptNodes)
                {
                    string scriptUrl = scriptNode.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(scriptUrl))
                    {
                        fileUrls.Add(scriptUrl);
                    }
                }
            }

            // Tải xuống các tệp cần thiết
            DownloadFiles(fileUrls, folderPath);
        }

        void DownloadFiles(List<string> fileUrls, string folderPath)
        {
            using (var client = new WebClient())
            {
                foreach (string fileUrl in fileUrls)
                {
                    try
                    {
                        string fileName = Path.GetFileName(fileUrl);
                        string filePath = Path.Combine(folderPath, fileName);
                        client.DownloadFile(fileUrl, filePath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error downloading file '{fileUrl}': {ex.Message}");
                    }
                }
            }
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);
            string source = document.DocumentNode.OuterHtml;
            Source openSourcePage = new Source(source);
            openSourcePage.Show();
        }
    }
}
