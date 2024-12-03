using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace Exercise3
{
    public partial class InfoSach : Form
    {
        private static readonly string apiKey = "AIzaSyCoK2Cy7VtrzSxy4HVuqZztELNbRueyiZc";

        private HttpClient httpClient;
        private string bookID;
        public InfoSach(string bookID)
        {
            InitializeComponent();
            this.bookID = bookID;
            httpClient = new HttpClient();
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            await FetchBookDetaildsAsync(bookID);
            await FetchBookShelvesAsync();
            progressBar.Visible = false;
            this.Load += new System.EventHandler(this.Form2_Load);

        }
        public class BookDetails
        {
            public VolumeInfo VolumeInfo { get; set; }
        }

        public class BookshelvesDto
        {
            [JsonProperty("items")]
            public List<BookShelf> Items { get; set; }
        }

        public class BookShelf
        {
            [JsonProperty("id")]
            public string ShelfId { get; set; }

            [JsonProperty("title")]
            public string Name { get; set; }
        }

        public class VolumeInfo
        {
            public string Title { get; set; }
            public string Subtitle { get; set; }
            public string[] Authors { get; set; }
            public string Publisher { get; set; }
            public string PublishedDate { get; set; }
            public string Description { get; set; }
            public int PageCount { get; set; }
            public string Language { get; set; }
            public string[] Categories { get; set; }
            public ImageLinks ImageLinks { get; set; }
        }

        public class ImageLinks
        {
            public string SmallThumbnail { get; set; }
            public string Thumbnail { get; set; }
        }

        private async Task FetchBookDetaildsAsync(string bookId)
        {
            try
            {
                string apiUrl = $"https://www.googleapis.com/books/v1/volumes/{bookId}";
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                // Đọc và phân tích JSON từ API
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var bookDetails = JsonConvert.DeserializeObject<BookDetails>(jsonResponse);

                // Hiển thị thông tin chi tiết sách
                DisplayBookDetails(bookDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayBookDetails(BookDetails bookDetails)
        {
            if (bookDetails != null && bookDetails.VolumeInfo != null)
            {
                var info = bookDetails.VolumeInfo;

                var details = $"Tên sách: {info.Title}\n" +
                              $"Phụ đề: {info.Subtitle}\n" +
                              $"Tác giả: {string.Join(", ", info.Authors ?? new string[] { "Không rõ" })}\n" +
                              $"Nhà xuất bản: {info.Publisher}\n" +
                              $"Mô tả: {info.Description}\n" +
                              $"Số trang: {info.PageCount}\n" +
                              $"Ngày xuất bản: {info.PublishedDate}\n" +
                              $"Ngôn ngữ: {info.Language}\n" +
                              $"Thể loại: {string.Join(", ", info.Categories ?? new string[] { "Không rõ" })}\n";

                rtbBookDetails.Text = details;
                if (info.ImageLinks?.Thumbnail != null)
                {
                    rtbBookDetails.Text += $"\nXem bìa sách tại: {info.ImageLinks.Thumbnail}";
                }
            }
            else
            {
                rtbBookDetails.Text = "Không tìm thấy thông tin chi tiết của sách.";
            }
        }

        public class GoogleOAuthHelper
        {
            private static string[] Scopes = { "https://www.googleapis.com/auth/books" };
            private static string ApplicationName = "Google Books App";

            public static async Task<UserCredential> GetUserCredentialAsync()
            {
                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token";
                    return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.FromStream(stream).Secrets,
                        Scopes,
                        "user",
                        CancellationToken.None,
                        new FileDataStore(credPath, true));
                }
            }
        }
        private async Task FetchBookShelvesAsync()
        {
            try
            {
                // Lấy thông tin xác thực OAuth2
                var credential = await GoogleOAuthHelper.GetUserCredentialAsync();
                httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", credential.Token.AccessToken);

                // Gửi yêu cầu đến API Google Books
                string apiUrl = "https://www.googleapis.com/books/v1/mylibrary/bookshelves";
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                // Đọc và phân tích dữ liệu JSON
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var bookShelvesDto = JsonConvert.DeserializeObject<BookshelvesDto>(jsonResponse);

                // Kiểm tra nếu có dữ liệu
                if (bookShelvesDto?.Items != null && bookShelvesDto.Items.Count > 0)
                {
                    CustomizeDataGridView();
                    dgvBookShelves.DataSource = bookShelvesDto.Items;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kệ sách nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải kệ sách: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CustomizeDataGridView()
        {
            dgvBookShelves.AutoGenerateColumns = false;
            dgvBookShelves.Columns.Clear();

            dgvBookShelves.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ShelfId", // Thuộc tính ánh xạ từ lớp BookShelf
                HeaderText = "ID Kệ Sách",
                Width = 100,
                Name = "ShelfId"
            });

            dgvBookShelves.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name", // Thuộc tính ánh xạ từ lớp BookShelf
                HeaderText = "Tên Kệ Sách",
                Width = 200
            });
        }

        public static async Task<UserCredential> GetUserCredentialAsync()
        {
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token";
                return await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    new[] { "https://www.googleapis.com/auth/books" },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));
            }
        }


        private async Task AddBookToShelfAsync(string shelfId, string volumeId)
        {
            try
            {
                string apiUrl = $"https://www.googleapis.com/books/v1/mylibrary/bookshelves/{shelfId}/addVolume?volumeId={volumeId}&key={apiKey}";
                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, null);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Thêm sách vào kệ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sách vào kệ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddToShelf_Click(object sender, EventArgs e)
        {
            if (dgvBookShelves.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBookShelves.SelectedRows[0];
                string shelfId = selectedRow.Cells["ShelfId"].Value?.ToString();

                if (!string.IsNullOrEmpty(shelfId))
                {
                    await AddBookToShelfAsync(shelfId, bookID);
                }
                else
                {
                    MessageBox.Show("Không thể lấy ID của kệ sách được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một kệ sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dgvBookShelves_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lấy Bookshelf ID từ dòng được chọn
                var selectedRow = dgvBookShelves.Rows[e.RowIndex];
                string shelfId = selectedRow.Cells["ShelfId"].Value?.ToString();
                if (!string.IsNullOrEmpty(shelfId))
                {
                    ListBooksInShelf listBooksInShelf = new ListBooksInShelf(shelfId);
                    listBooksInShelf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không thể lấy ID của kệ sách được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
