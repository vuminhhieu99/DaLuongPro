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
    public partial class FormBackroundWorker : Form
    {
        string fileResult = "result.txt"; // tên file chứa kết quả tính toán
        Matrix m;
        int size;       //  kích thước ma trận
        bool[] completedRow;     //   mảng trạng thái của hàng ma trậm
        

        public FormBackroundWorker()
        {
            InitializeComponent();
        }

        // khởi tạo giá trị ban đầu của các hàng ma trậm
        public void initializationItem()
        {
            ListViewItem[] item = new ListViewItem[size];

            for (int i = 0; i < size; i++) 
            {
                item[i] = new ListViewItem();
                item[i].Text = (i + 1).ToString();
                item[i].SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
                item[i].SubItems.Add(new ListViewItem.ListViewSubItem());

            }
            listView1.Items.AddRange(item);

            completedRow = new bool[size];
            for (int i = 0; i < size; i++)
            {
                completedRow[i] = false;
            }
        }

        // đọc file 
        private void button_ReadFile_Click(object sender, EventArgs e)
        {

            try
            {
                listView1.Items.Clear();
                
                using (StreamReader sr = new StreamReader(comboBoxFileName.Text))
                {
                    size = Convert.ToInt32(sr.ReadLine());
                    string textRow = "";
                    string[] strRow = new string[size];
                    string[] splRow;
                    string textMatrix;

                    m = new Matrix(size);
                    textMatrix = $"Matrix size: {size} x {size}" + "\r\n";
                    for (int i = 0; i < size; i++)
                    {
                        textRow = sr.ReadLine();
                        textMatrix += textRow + "\r\n";
                        strRow[i] = textRow;
                        splRow = textRow.Split(' ');
                        for (int j = 0; j < size; j++)
                        {
                            m[i, j] = Convert.ToInt32(splRow[j]);
                        }
                    }
                    textBox_Matrix.Text = textMatrix;
                    sr.Close();

                }
                initializationItem();


            }
            catch(Exception exc)
            {
                MessageBox.Show("Cannot open file\n" + exc.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //bắt đầu công việc
        private void button_Start_Click(object sender, EventArgs e)
        {
            
            for(int i=0; i<size; i++)
            {
                if (!completedRow[i] && !backgroundWorker1.IsBusy)
                {                          
                    backgroundWorker1.RunWorkerAsync(i); // i nay se dc invoke
                    completedRow[i] = true;
                    break;                                        
                }
            }
            
            for (int i = 0; i < size; i++)
            {
                
                if (!completedRow[i] && !backgroundWorker2.IsBusy)
                {
                    backgroundWorker2.RunWorkerAsync(i);
                    completedRow[i] = true;
                    break;
                }
            }
            if (!backgroundWorkerTotal.IsBusy)
            {
                backgroundWorkerTotal.RunWorkerAsync(listView1);
            }

        }


        // hàm làm việc của thread 1 
        // hàm tính toán tổng 1 hàng của ma trận
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int r = ((int)e.Argument);
            int S;

            try
            {
                do 
                {
                    if (!backgroundWorker1.CancellationPending)
                    {
                        S = 0;
                        listView1.Invoke(new MethodInvoker(delegate () 
                        {
                            listView1.Items[r].SubItems[1].Text = S.ToString();
                            listView1.Items[r].SubItems[2].Text = "Thread 1" ;
                        }));
                        // tính tổng 1 hàng được chọn
                        for (int i = 0; i < size; i++)
                        {
                            if (backgroundWorker1.CancellationPending)
                            {
                                completedRow[r] = false;
                                break;
                            }
                            S += m[r, i];     

                            listView1.Invoke(new MethodInvoker(delegate ()
                            {

                                listView1.Items[r].SubItems[1].Text = S.ToString();

                            }));
                            Thread.Sleep(40);

                        }
                        if (backgroundWorker1.CancellationPending)
                        {
                            break;
                        }
                        // hoàn thành tỉnh tổng 1 hàng
                        listView1.Invoke(new MethodInvoker(delegate ()
                        {
                            listView1.Items[r].ForeColor = System.Drawing.Color.Red;
                            listView1.Items[r].BackColor = System.Drawing.Color.PaleGreen;
                        }));

                        // kiểm tra các hàng chưa được tính để chạy hàng đó
                        for (int j = 0; j <= size; j++)
                        {
                            if (j == size)
                            {
                                return;
                            }
                            if (!completedRow[j])
                            {
                                r = j;
                                completedRow[j] = true;
                                break;
                            }
                        }
                    }
                    else { break; }

                } while (true);
            }
             
        
             catch (Exception ex)
            {
                //backgroundWorker1.CancelAsync();
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
                    
               
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)

        {
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
           

        }
        // hàm làm việc của thread 2 , tương tự thread 1
        // hàm tính toán tổng 1 hàng của ma trận
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int r = ((int)e.Argument);
            int S = 0;
            try
            {
                do
                {
                    if (!backgroundWorker2.CancellationPending)
                    {
                        S = 0;
                        listView1.Invoke(new MethodInvoker(delegate () 
                        {
                            listView1.Items[r].SubItems[1].Text = S.ToString();
                            listView1.Items[r].SubItems[2].Text = "Thread 2" ;
                        })); 
                        // tính tổng 1 hàng được chọn
                        for (int i = 0; i < size; i++)
                        {

                            if (backgroundWorker2.CancellationPending)
                            {
                                completedRow[r] = false;
                                break;
                            }
                            S += m[r, i];
                            
                            
                            listView1.Invoke(new MethodInvoker(delegate ()
                            {

                                listView1.Items[r].SubItems[1].Text = S.ToString();

                            }));
                            Thread.Sleep(70);
                        }
                        if (backgroundWorker2.CancellationPending)
                        {
                            break;
                        }
                        //hoàn thành tính tổng 1 hàng
                        listView1.Invoke(new MethodInvoker(delegate ()
                        {
                            listView1.Items[r].ForeColor = System.Drawing.Color.Red;
                            listView1.Items[r].BackColor = System.Drawing.Color.Aqua;

                        }));
                        // kiểm tra các hàng chưa được tính để chạy hàng đó
                        for (int j = 0; j <= size; j++)
                        {
                            if (j == size)
                            {
                                return;
                            }
                            if (!completedRow[j])
                            {
                                r = j;
                                completedRow[r] = true;
                                break;
                            }
                        }
                    }
                    else { break; }
                } while (true);
                
            }
            catch (Exception ex)
            {
                //backgroundWorker1.CancelAsync();
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
         
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_FileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Matrix_TextChanged(object sender, EventArgs e)
        {

        }

        //khởi động lại việc tính toán của các thread
        private void button_Restart_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.IsBusy)
                 backgroundWorker1.CancelAsync();
            if (backgroundWorker2.IsBusy)
                backgroundWorker2.CancelAsync();
            listView1.Items.Clear();
            initializationItem();
            if (backgroundWorkerTotal.IsBusy)
                backgroundWorkerTotal.CancelAsync();
            textBoxTotal.Text = "";
            progressBar1.Value = 0;
            progressBar1.Update();

        }

        //tạm dừng việc tính toán
        private void buttonPause_Click(object sender, EventArgs e)
        {
            if(buttonPause.Text == "Pause")
            {
                buttonPause.Text = "Continue";
                if (backgroundWorker1.IsBusy)
                    backgroundWorker1.CancelAsync();
                if (backgroundWorker2.IsBusy)
                    backgroundWorker2.CancelAsync();
                if (backgroundWorkerTotal.IsBusy)
                    backgroundWorkerTotal.CancelAsync();
                return;
            }

            if (buttonPause.Text == "Continue")
            {
                buttonPause.Text = "Pause";
                button_Start_Click(sender, e);
                return;
            }
        }

        // hàm làm việc của thread tính tổng các hàng
        private void backgroundWorkerTotal_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 0;            
            int count;
            int maxCount = -1;
            int maxTotal = -1;            
                while(true){
                    if (!backgroundWorkerTotal.CancellationPending)
                    {
                        count = 0;
                        total = 0;
                    for (int i = 0; i < size; i++)
                    {
                        if (backgroundWorkerTotal.CancellationPending)
                        {
                            break;
                        }
                        if (completedRow[i])
                        {
                            listView1.Invoke(new MethodInvoker(delegate ()

                            {
                                int c;
                                if (int.TryParse(listView1.Items[i].SubItems[1].Text, out c))
                                {
                                    total += c;
                                }
                            }));

                            textBoxTotal.Invoke(new MethodInvoker(delegate ()                           
                            {
                                if(maxTotal < total)
                                {
                                    maxTotal = total;
                                    textBoxTotal.Text = maxTotal.ToString();
                                }
                               
                            }));
                            count++;
                            if (maxCount < count)
                            {
                                maxCount = count;
                                backgroundWorkerTotal.ReportProgress(maxCount * 100 / size);
                            }
                        }               

                    }
                    if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy)
                    {
                        MessageBox.Show("all thread completed!");
                        try // ghi kết quả ra file, sử dụng luồn ghi StreamWriter
                        {
                            using (StreamWriter sw = new StreamWriter(fileResult))
                            {
                                sw.WriteLine($"Matrix [{size}x{size}]");
                                for (int i = 0; i < size; i++)
                                     listView1.Invoke(new MethodInvoker(delegate ()
                                     {
                                         sw.WriteLine(listView1.Items[i].SubItems[1].Text);
                                     }));
                                textBoxTotal.Invoke(new MethodInvoker(delegate ()
                                {
                                    sw.WriteLine($"Total: {textBoxTotal.Text}\r\n");
                                }));                               
                                sw.Close();
                            }
                        }
                        catch (Exception exc) // xử lý ngoại lệ nếu gặp lỗi khi file
                        {
                            MessageBox.Show("Cannot write into file!!!\n\n" + exc.Message, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        break;
                    }
                           
                        Thread.Sleep(20);
                    }
                    else
                    {
                        break;
                    }
                }         
           
        }

        // cập nhật các tiến trình
        private void backgroundWorkerTotal_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage ;
            progressBar1.Update();
        }

       
    }
}
