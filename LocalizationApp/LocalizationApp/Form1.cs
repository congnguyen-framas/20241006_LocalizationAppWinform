using System.Globalization;

namespace LocalizationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            _btnLangues.Click += _btnLangues_Click;
        }

        private void _btnLangues_Click(object? sender, EventArgs e)
        {
            if (_btnLangues.Text== "Tiếng Anh")
            {
                // Ví dụ chuyển sang tiếng Việt
                ChangeLanguage("en");

                _btnLangues.Text = "Vietnamese";
            }
            else
            {
                // Ví dụ chuyển sang tiếng Việt
                ChangeLanguage("vi");

                _btnLangues.Text = "Tiếng Anh";
            }
        }

        private void ChangeLanguage(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            this.Controls.Clear(); // Xóa tất cả các control hiện tại
            InitializeComponent(); // Tạo lại form với ngôn ngữ mới
            Form1_Load(null, null);
        }
    }
}
