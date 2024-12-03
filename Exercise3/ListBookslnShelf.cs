using Newtonsoft.Json;
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
using static Exercise3.InfoSach;

namespace Exercise3
{
    public partial class ListBooksInShelf : Form
    {
        public class BooksInShelfDto
        {
            [JsonProperty("items")]
            public List<Book> Items { get; set; }
        }

        public class Book
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("volumeInfo")]
            public VolumeInfo VolumeInfo { get; set; }
        }

        public class VolumeInfo
        {
            [JsonProperty("title")]
            public string Title { get; set; }

            [JsonProperty("authors")]
            public string[] Authors { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }

        private readonly string shelfId;
        private readonly HttpClient httpClient;
        public ListBooksInShelf(string shelfId)
        {
            InitializeComponent();
            this.shelfId = shelfId;
            httpClient = new HttpClient();
            ListBooksInShelf_Load(this, EventArgs.Empty);
        }

        private async void ListBooksInShelf_Load(object sender, EventArgs e)
        {
            await LoadBooksInShelfAsync();
        }

        private async Task LoadBooksInShelfAsync()
        {
            try
            {
                var credential = await GoogleOAuthHelper.GetUserCredentialAsync();
                httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", credential.Token.AccessToken);

                string apiUrl = $"https://www.googleapis.com/books/v1/mylibrary/bookshelves/{shelfId}/volumes";
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var books = JsonConvert.DeserializeObject<BooksInShelfDto>(jsonResponse);

                PopulateDataGridView(books);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sách từ kệ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateDataGridView(BooksInShelfDto books)
        {
            dgvBooksInShelf.Rows.Clear();

            if (books?.Items != null)
            {
                foreach (var book in books.Items)
                {
                    dgvBooksInShelf.Rows.Add(
                        book.Id,
                        book.VolumeInfo.Title,
                        string.Join(", ", book.VolumeInfo.Authors ?? new string[] { "Không rõ" }),
                        book.VolumeInfo.Description
                    );
                }
            }
            else
            {
                MessageBox.Show("Không có sách trong kệ này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task RemoveBookFromShelfAsync(string shelfId, string volumeId)
        {
            try
            {
                var credential = await GoogleOAuthHelper.GetUserCredentialAsync();
                httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", credential.Token.AccessToken);

                string apiUrl = $"https://www.googleapis.com/books/v1/mylibrary/bookshelves/{shelfId}/removeVolume?volumeId={volumeId}";

                HttpResponseMessage response = await httpClient.PostAsync(apiUrl, null);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sách đã được xóa khỏi kệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Lỗi khi xóa sách: {errorResponse}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBooksInShelf.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBooksInShelf.SelectedRows[0];
                string volumeId = selectedRow.Cells["ColumnID"].Value?.ToString(); // Lấy ID sách

                if (!string.IsNullOrEmpty(volumeId))
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này khỏi kệ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        await RemoveBookFromShelfAsync(shelfId, volumeId);
                        await LoadBooksInShelfAsync(); // Reload lại danh sách
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
