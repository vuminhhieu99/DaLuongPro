using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B16_VMHieu_NDHung
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void linkLabelBackgroundWorker_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBackroundWorker form = new FormBackroundWorker();
            form.Show();
        }

        private void linkLabelThreads_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMultiThreads form = new FormMultiThreads();
            form.Show();
        }
    }
}
