using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanSu.Controllers;
using QLNhanSu.Models;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLNhanSu.Views
{
    public partial class frm_QLLuong : Form
    {
        public frm_QLLuong()
        {
            InitializeComponent();
        }
        private QLLuong_ctrl ctrl = new QLLuong_ctrl();
        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export excel file";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuat file thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Co loi xay ra: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ExportExcel(string filePath)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(filePath);
            application.ActiveWorkbook.Saved = true;
        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIfValid();
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIfValid();
        }

        private void frm_QLLuong_Load(object sender, EventArgs e)
        {
            Width = Parent.Width;
            Height = Parent.Height;
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            for (int i = 1; i <= currentMonth; i++)
            {
                comboBoxMonth.Items.Add(i.ToString("D2")); // Thêm tháng dưới dạng 2 chữ số
            }

            comboBoxMonth.SelectedItem = (currentMonth - 1).ToString("D2");

            
            for (int year = 2020; year <= currentYear; year++)
            {
                comboBoxYear.Items.Add(year);
            }

            comboBoxYear.SelectedItem = currentYear;

            LoadDataIfValid();
        }

        private void LoadDataIfValid()
        {
            if (comboBoxMonth.SelectedItem != null && comboBoxYear.SelectedItem != null)
            {
                int selectedMonth = Convert.ToInt32(comboBoxMonth.SelectedItem);
                int selectedYear = Convert.ToInt32(comboBoxYear.SelectedItem);

                // Gọi hàm tải dữ liệu từ cơ sở dữ liệu với tháng và năm đã chọn
                var rs = ctrl.GetAll(selectedMonth, selectedYear);
                switch (rs.ErrCode)
                {
                    case EnumErrcode.Error:
                        MessageBox.Show(rs.ErrDesc, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case EnumErrcode.Empty:
                        MessageBox.Show(rs.ErrDesc, "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case EnumErrcode.Success:
                        // Cập nhật DataGridView
                        UpdateDataGridView(rs.Data);
                        break;
                }
            }
            //else
            //{
            //    // Nếu một trong hai ComboBox không có giá trị, có thể thông báo cho người dùng
            //    MessageBox.Show("Vui lòng chọn đầy đủ thông tin.");
            //}
        }

        // Phương thức cập nhật DataGridView với dữ liệu mới
        private void UpdateDataGridView(List<BangLuongDto> data)
        {
            // Tắt tự động tạo cột
            dataGridView1.AutoGenerateColumns = false;

            // Xóa cột hiện tại (nếu cần)
            dataGridView1.Columns.Clear();

            // Thêm các cột vào DataGridView
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "STT",
            //    Name = "colStt",
            //    ReadOnly = true
            //});
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã Nhân Viên",
                DataPropertyName = "MaNhanVien",
                Name = "colMaNhanVien",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên Nhân Viên",
                DataPropertyName = "TenNhanVien",
                Name = "colTenNhanVien",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Chức Vụ",
                DataPropertyName = "ChucVu",
                Name = "colChucVu",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phòng Ban",
                DataPropertyName = "PhongBan",
                Name = "colPhongBan",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số Ngày Làm",
                DataPropertyName = "SoNgayLam",
                Name = "colSoNgayLam",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số Buổi Vắng",
                DataPropertyName = "Vang",
                Name = "colVang",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số Buổi Tăng Ca",
                DataPropertyName = "TangCa",
                Name = "colTangCa",
                ReadOnly = true
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Lương",
                DataPropertyName = "Luong",
                Name = "colLuong",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0", // Định dạng số nguyên với dấu ngăn cách hàng nghìn
                    Alignment = DataGridViewContentAlignment.MiddleRight // Căn phải
                }
            });

            // Gán dữ liệu vào DataGridView
            dataGridView1.DataSource = data;

            // Cập nhật STT
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    dataGridView1.Rows[i].Cells["colStt"].Value = (i + 1); // Gán giá trị STT
            //}

            dataGridView1.Refresh();
        }
    }
}
