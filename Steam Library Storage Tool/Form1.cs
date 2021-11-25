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

namespace Steam_Library_Storage_Tool
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        
        string selectedDirectory;
        double fileSizeFormat = 1073741824.00;
        string fileSizeFormatNotation = " GB";
        private static long GetDirectorySize(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            return di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double directorySize = Math.Round(GetDirectorySize(selectedDirectory) / 1073741824.00, 2);
            label1.Text = "Directory size: " + directorySize.ToString() + " GB";
            label2.Text = "Total disk space: " + Math.Round(new DriveInfo(@"C:\").TotalSize / 1073741824.00, 2) + " GB";
            label3.Text = "Free disk space: " + Math.Round(new DriveInfo(@"C:\").TotalFreeSpace / 1073741824.00, 2) + " GB";
            string[] subdirectories = Directory.GetDirectories(selectedDirectory);
            string[] files = Directory.GetFiles(selectedDirectory);
            listView1.Items.Clear();
            groupBox1.Text = selectedDirectory;
            foreach (string subd in subdirectories)
            {
                listView1.Items.Add(new ListViewItem(new[] { subd.Remove(0, selectedDirectory.Length + 1) + @"\", Math.Round(GetDirectorySize(subd) / fileSizeFormat, 2).ToString() + fileSizeFormatNotation}));
                
            }
            foreach (string file in files)
            {
                listView1.Items.Add(new ListViewItem(new[] { file.Remove(0, selectedDirectory.Length + 1), Math.Round(new FileInfo(file).Length / fileSizeFormat, 2).ToString() + fileSizeFormatNotation}));
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void selectDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog directorySelector = new FolderBrowserDialog();
            directorySelector.ShowDialog();
            selectedDirectory = directorySelector.SelectedPath;
        }

        private void gBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileSizeFormat = 1073741824.00;
            fileSizeFormatNotation = " GB";
        }

        private void mBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileSizeFormat = 1048576.00;
            fileSizeFormatNotation = " MB";
        }

        private void kBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileSizeFormat = 1024.00;
            fileSizeFormatNotation = " KB";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
