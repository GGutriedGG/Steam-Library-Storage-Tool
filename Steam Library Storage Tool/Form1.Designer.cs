
namespace Steam_Library_Storage_Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Size = new System.Windows.Forms.ColumnHeader();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Relative = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory size:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate size";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDirectoryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectDirectoryToolStripMenuItem
            // 
            this.selectDirectoryToolStripMenuItem.Name = "selectDirectoryToolStripMenuItem";
            this.selectDirectoryToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.selectDirectoryToolStripMenuItem.Text = "Select directory";
            this.selectDirectoryToolStripMenuItem.Click += new System.EventHandler(this.selectDirectoryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gBToolStripMenuItem,
            this.mBToolStripMenuItem,
            this.kBToolStripMenuItem,
            this.bytesToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // gBToolStripMenuItem
            // 
            this.gBToolStripMenuItem.Name = "gBToolStripMenuItem";
            this.gBToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.gBToolStripMenuItem.Text = "GB";
            this.gBToolStripMenuItem.Click += new System.EventHandler(this.gBToolStripMenuItem_Click);
            // 
            // mBToolStripMenuItem
            // 
            this.mBToolStripMenuItem.Name = "mBToolStripMenuItem";
            this.mBToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.mBToolStripMenuItem.Text = "MB";
            this.mBToolStripMenuItem.Click += new System.EventHandler(this.mBToolStripMenuItem_Click);
            // 
            // kBToolStripMenuItem
            // 
            this.kBToolStripMenuItem.Name = "kBToolStripMenuItem";
            this.kBToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.kBToolStripMenuItem.Text = "KB";
            this.kBToolStripMenuItem.Click += new System.EventHandler(this.kBToolStripMenuItem_Click);
            // 
            // bytesToolStripMenuItem
            // 
            this.bytesToolStripMenuItem.Name = "bytesToolStripMenuItem";
            this.bytesToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.bytesToolStripMenuItem.Text = "Bytes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 407);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate size";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Size,
            this.Relative});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 375);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 80;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total disk space:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Free disk space:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Files",
            "Folders"});
            this.comboBox1.Location = new System.Drawing.Point(362, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Relative
            // 
            this.Relative.Text = "Relative";
            this.Relative.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bytesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader Relative;
    }
}

