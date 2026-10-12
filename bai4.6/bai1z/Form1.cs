using System.ComponentModel;
using System.Text;

namespace bai1z
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Student> _students = new();
        private readonly BindingSource _bindingSource = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Du lieu mau
            _students.Add(new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" });
            _students.Add(new Student { StudentId = "SV002", FullName = "Trần Thị Bích", Age = 21, Gender = "Nữ" });
            _students.Add(new Student { StudentId = "SV003", FullName = "Lê Hoàng Cường", Age = 19, Gender = "Nam" });

            // BindingSource lam trung gian giua BindingList va cac control
            _bindingSource.DataSource = _students;
            dgvStudents.DataSource = _bindingSource;

            // Binding 2 chieu: control nhap lieu <-> dong dang chon tren luoi
            txtStudentId.DataBindings.Add("Text", _bindingSource, nameof(Student.StudentId), true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", _bindingSource, nameof(Student.FullName), true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", _bindingSource, nameof(Student.Age), true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("SelectedItem", _bindingSource, nameof(Student.Gender), true, DataSourceUpdateMode.OnPropertyChanged);

            // Khi chuyen dong thi nap anh avatar tuong ung
            _bindingSource.CurrentChanged += (s, ev) => LoadAvatar();

            if (dgvStudents.Columns[nameof(Student.AvatarPath)] is DataGridViewColumn col)
                col.HeaderText = "Ảnh đại diện";

            LoadAvatar();
        }

        private Student? CurrentStudent => _bindingSource.Current as Student;

        private void LoadAvatar()
        {
            picAvatar.Image?.Dispose();
            picAvatar.Image = null;

            string? path = CurrentStudent?.AvatarPath;
            if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                // Doc qua stream de khong khoa file anh
                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                picAvatar.Image = Image.FromStream(fs);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var sv = new Student
            {
                StudentId = $"SV{_students.Count + 1:D3}",
                FullName = "Sinh viên mới",
                Age = 18,
                Gender = "Nam"
            };
            _bindingSource.Add(sv);
            _bindingSource.Position = _students.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CurrentStudent is null)
            {
                MessageBox.Show("Không có sinh viên nào được chọn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên '{CurrentStudent.FullName}'?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                _bindingSource.RemoveCurrent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ket thuc chinh sua dang do de day du lieu tu control vao doi tuong
            _bindingSource.EndEdit();
            dgvStudents.Refresh();
            MessageBox.Show("Đã cập nhật thông tin sinh viên.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            if (CurrentStudent is null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên trước khi chọn ảnh.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var ofd = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                FilterIndex = 1
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentStudent.AvatarPath = ofd.FileName;
                LoadAvatar();
                dgvStudents.Refresh();
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Xuất danh sách sinh viên ra CSV",
                Filter = "CSV file (*.csv)|*.csv",
                FileName = "DanhSachSinhVien.csv",
                DefaultExt = "csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("StudentId,FullName,Age,Gender,AvatarPath");
                foreach (var sv in _students)
                {
                    sb.AppendLine(string.Join(',',
                        EscapeCsv(sv.StudentId),
                        EscapeCsv(sv.FullName),
                        sv.Age.ToString(),
                        EscapeCsv(sv.Gender),
                        EscapeCsv(sv.AvatarPath)));
                }

                // UTF-8 co BOM de Excel hien thi dung tieng Viet
                File.WriteAllText(sfd.FileName, sb.ToString(), new UTF8Encoding(true));
                MessageBox.Show($"Đã xuất {_students.Count} sinh viên ra file:\n{sfd.FileName}",
                    "Xuất CSV thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeCsv(string? value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
                return $"\"{value.Replace("\"", "\"\"")}\"";
            return value;
        }
    }
}
