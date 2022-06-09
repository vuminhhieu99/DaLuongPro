using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace B16_VMHieu_NDHung
{
    public partial class FormMultiThreads : Form
    {
        Matrix m; // đối tượng ma trận sẽ thao tác trong chương trình
        int size; // kích thước của ma trận [size x size]
        Thread th1, th2, thrs; // th1,th2 dùng để tính tổng các hàng của ma trận // thrs dùng để thu thập kết quả các hàng, tổng hợp lại, ghi kết quả ra file
        int countComplete; // đếm số hàng của ma trận đã tính toán xong
        string fileResult = "result.txt"; // tên file chứa kết quả tính toán

        public FormMultiThreads()
        {
            InitializeComponent();
        }

        // ----------- Phương thức Đọc ma trận từ file dữ liệu, sử dụng luồng đọc StreamReader --------------------------------------------------
        private void button_ReadFile_Click(object sender, EventArgs e) 
        {
            listViewCounting.Items.Clear(); // làm mới lại danh sách hiển thị tính toán
            try // đọc file dữ liệu với tên file lấy từ textbox_FileName
            {
                using (StreamReader sr = new StreamReader(comboBoxFileName.Text)) 
                {
                    size = Convert.ToInt32(sr.ReadLine()); // lấy kích thước ma trận
                    string textRow = ""; // text lưu giá trị từng hàng của ma trận đọc được
                    string[] splRow; // dùng để tách giá trị từ hàng của ma trận đọc được
                    string textMatrix; // text hiển thị ma trân đọc từ file

                    m = new Matrix(size); // khởi tạo 1 đối tượng ma trận mới với kích thước [size x size]
                    textMatrix = $"Matrix [{size} x {size}]" + "\r\n";

                    // thêm các giá trị đọc được vào vị trí tương ứng của đối tượng ma trận
                    for (int i = 0; i < size; i++) 
                    {
                        textRow = sr.ReadLine();
                        splRow = textRow.Split(' ');
                        for (int j = 0; j < size; j++)
                        {
                            m[i, j] = Convert.ToInt32(splRow[j]);
                        }
                        textMatrix += textRow + "\r\n";
                    }
                    // hiển thị ma trận đọc được lên textbox
                    textBoxMatrix.Text = textMatrix;
                    sr.Close();
                }
            }
            catch(Exception exc) // xử lý ngoại lệ khi gặp lỗi đọc file dữ liệu
            {
                MessageBox.Show("Cannot open file!!!\n\n" + exc.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // -------- Phương thức tính tổng của 1 hàng trong ma trận, nhận đầu vào là 1 đối tượng hàng ma trận (MatrixRow) ----------------------
        // -------- Gắn với 2 thread:   th1 và th2   ------------------------------------------------------------------------------------------
        private void CountRow(object obj)
        {
            MatrixRow mr = (MatrixRow)obj; // ép kiếu đối tượng thành kiểu đối tượng MatrixRow
            
                listViewCounting.Items[mr.RowId].SubItems[2].Text = mr.ThrUse;
           
             // in ra tên luông được sử dụng
            int S = 0;
            // Duyệt qua các phần tử của hàng, tính tổng, liên tục cập nhật giá trị tổng tính được tại cột Sum
            for (int i = 0; i < size; i++)
            {
                S += m[mr.RowId, i];
                listViewCounting.Items[mr.RowId].SubItems[1].Text = S.ToString();
                Thread.Sleep(30);
            }
            // Tính tổng xong, Tick đánh dấu đã hoàn thành, số lượng hàng tính xong tăng thêm 1
            listViewCounting.Items[mr.RowId].SubItems[3].Text = ((char)0x221A).ToString();
            listViewCounting.Items[mr.RowId].ForeColor = System.Drawing.Color.Green;
            countComplete++;
        }

        // --------- Phương thức tính toán ma trận --------------------------------------------------------------------------------------------
        private void button_Start_Click(object sender, EventArgs e)
        {
            // Ktra thông tin ma trận được cung cấp đầy đủ trước khi tính toán
            if (comboBoxFileName.Text.Equals("") || textBoxMatrix.Text.Equals("")) 
                MessageBox.Show("Please load matrix before Start", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                // khởi tạo lại các giá trị tính toán
                listViewCounting.Items.Clear();
                textBoxTotal.Text = "";
                countComplete = 0;
                for (int i = 0; i < size; i++)
                {
                    ListViewItem lvi = new ListViewItem((i + 1).ToString());
                    listViewCounting.Items.Add(lvi);
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                    lvi.SubItems.Add("");
                }
                // sử dụng th1 và th2 để tính toán các hàng (th1 tính các hàng chẵn, th2 tính cách hàng lẻ, liên tục cho đến khi hết ma trận)
                // sử dụng thrs chờ sẵn để thu thập kết quả và ghi kết quả tính toán ra file
                thrs = new Thread(Result);
                thrs.IsBackground = true;
                thrs.Start();

                th1 = new Thread(CountRow);
                th1.IsBackground = true;
                th2 = new Thread(CountRow);
                th2.IsBackground = true;
                th1.Start(new MatrixRow(0, "thr 1"));
                th2.Start(new MatrixRow(1, "thr 2"));

                int i1 = 2, i2 = 3;
                while (i1 < size || i2 < size)
                {
                    if (i1 < size)
                    {
                        th1.Join(); // các lệnh sau th1.Join() chỉ thực hiện khi th1 đã hoàn thành nhiệm vụ hiện tại
                        th1 = new Thread(CountRow);
                        th1.IsBackground = true;
                        th1.Start(new MatrixRow(i1, "thr 1"));
                        i1 += 2; // th1 tính cách hàng chẵn
                    }
                    if (i2 < size)
                    {
                        th2.Join(); // các lệnh sau th2.Join() chỉ thực hiện khi th2 đã hoàn thành nhiệm vụ hiện tại
                        th2 = new Thread(CountRow);
                        th2.IsBackground = true;
                        th2.Start(new MatrixRow(i2, "thr 2"));
                        i2 += 2; // th2 tính các hàng lẻ
                    }
                }

                thrs.Join();
                thrs.Abort();
            }
        }

        // --------- Phương thức Reset lại chương trình, đặt lại các thông số về mặc định, để thực hiện nhiệm vụ mới -------------------------
        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBoxFileName.Text = "";
            textBoxMatrix.Text = "";
            textBoxTotal.Text = "";
            listViewCounting.Items.Clear();
            countComplete = 0;
        }

        // --------- Phương thức tổng hợp kết quả, ghi kết quả ra file -----------------------------------------------------------------------
        // --------- Gắn với thread thrs -----------------------------------------------------------------------------------------------------
        private void Result()
        {
            // vòng lặp vô hạn, đợi đến khi tính xong các hàng của ma trận
            while(1==1)
            {
                if (countComplete == size)
                    break;
            }
            th1.Abort();
            th2.Abort();
            // tổng hợp kết quả tính tổng các hàng, tính ra tổng của tổng các hàng (Total)
            textBoxTotal.Text = "";
            int total = 0;
    
            for (int i = 0; i < size; i++)
            {
                total += Convert.ToInt32(listViewCounting.Items[i].SubItems[1].Text);
                textBoxTotal.Text = total.ToString();
            }

            try // ghi kết quả ra file, sử dụng luồn ghi StreamWriter
            {
                using (StreamWriter sw = new StreamWriter(fileResult))
                {
                    sw.WriteLine($"Matrix [{size}x{size}]");
                    for (int i = 0; i < size; i++)
                        sw.WriteLine(listViewCounting.Items[i].SubItems[1].Text);
                    sw.WriteLine($"Total: {textBoxTotal.Text}\r\n");
                    sw.Close();
                }
            }
            catch (Exception exc) // xử lý ngoại lệ nếu gặp lỗi khi file
            {
                MessageBox.Show("Cannot write into file!!!\n\n" + exc.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

    // class MatrixRow --- đối tượng MatrixRow được truyền vào phương thức CowRow --- phương thức CowRow được gắn với thread để thực hiện tính toán trên từng hàng ma trận
    class MatrixRow
    {
        private int rowId;
        private string thrUse;
        
        public int RowId { get => rowId; set => rowId = value; }
        public string ThrUse { get => thrUse; set => thrUse = value; }

        public MatrixRow(int rowid, string thruse)
        {
            RowId = rowid;
            ThrUse = thruse;
        }
    }
}
