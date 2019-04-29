namespace MRK_Udp_Server_HTV
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.setTime = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.powerOff = new System.Windows.Forms.Button();
            this.refreshList = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subnetMaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getwayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registeredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tVsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbUdpHTVDataSet = new MRK_Udp_Server_HTV.DbUdpHTVDataSet();
            this.tVsTableAdapter = new MRK_Udp_Server_HTV.DbUdpHTVDataSetTableAdapters.TVsTableAdapter();
            this.getNetworkInformation = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tVsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUdpHTVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 418);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "لیست تلویزون ها";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn,
            this.subnetMaskDataGridViewTextBoxColumn,
            this.getwayDataGridViewTextBoxColumn,
            this.dNSDataGridViewTextBoxColumn,
            this.registeredDataGridViewCheckBoxColumn,
            this.mACDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tVsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 366);
            this.dataGridView1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(786, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "ذخیره تغییرات";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(786, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "نوسازی لیست";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "لاگ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxLog
            // 
            this.listBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 19;
            this.listBoxLog.Location = new System.Drawing.Point(3, 3);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxLog.Size = new System.Drawing.Size(786, 412);
            this.listBoxLog.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("B Koodak", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 418);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "عملیات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.getNetworkInformation);
            this.splitContainer1.Panel2.Controls.Add(this.back);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.setTime);
            this.splitContainer1.Panel2.Controls.Add(this.restart);
            this.splitContainer1.Panel2.Controls.Add(this.powerOff);
            this.splitContainer1.Panel2.Controls.Add(this.refreshList);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(786, 412);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(262, 412);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // back
            // 
            this.back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back.Dock = System.Windows.Forms.DockStyle.Top;
            this.back.Location = new System.Drawing.Point(0, 192);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(520, 23);
            this.back.TabIndex = 12;
            this.back.Text = "بازگشت";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.right);
            this.panel1.Controls.Add(this.left);
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.down);
            this.panel1.Controls.Add(this.up);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 100);
            this.panel1.TabIndex = 11;
            // 
            // right
            // 
            this.right.Dock = System.Windows.Forms.DockStyle.Right;
            this.right.Location = new System.Drawing.Point(445, 23);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 54);
            this.right.TabIndex = 4;
            this.right.Text = "راست";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.Dock = System.Windows.Forms.DockStyle.Left;
            this.left.Location = new System.Drawing.Point(0, 23);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 54);
            this.left.TabIndex = 3;
            this.left.Text = "چپ";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // enter
            // 
            this.enter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enter.Location = new System.Drawing.Point(0, 23);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(520, 54);
            this.enter.TabIndex = 2;
            this.enter.Text = "تایید";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // down
            // 
            this.down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.down.Location = new System.Drawing.Point(0, 77);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(520, 23);
            this.down.TabIndex = 1;
            this.down.Text = "پایین";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.Dock = System.Windows.Forms.DockStyle.Top;
            this.up.Location = new System.Drawing.Point(0, 0);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(520, 23);
            this.up.TabIndex = 0;
            this.up.Text = "بالا";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // setTime
            // 
            this.setTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.setTime.Location = new System.Drawing.Point(0, 69);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(520, 23);
            this.setTime.TabIndex = 10;
            this.setTime.Text = "تنظیم ساعت با سرور";
            this.setTime.UseVisualStyleBackColor = true;
            this.setTime.Click += new System.EventHandler(this.setTime_Click);
            // 
            // restart
            // 
            this.restart.Dock = System.Windows.Forms.DockStyle.Top;
            this.restart.Location = new System.Drawing.Point(0, 46);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(520, 23);
            this.restart.TabIndex = 9;
            this.restart.Text = "راه اندازی مجدد";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // powerOff
            // 
            this.powerOff.Dock = System.Windows.Forms.DockStyle.Top;
            this.powerOff.Location = new System.Drawing.Point(0, 23);
            this.powerOff.Name = "powerOff";
            this.powerOff.Size = new System.Drawing.Size(520, 23);
            this.powerOff.TabIndex = 8;
            this.powerOff.Text = "خاموش کردن";
            this.powerOff.UseVisualStyleBackColor = true;
            this.powerOff.Click += new System.EventHandler(this.powerOff_Click);
            // 
            // refreshList
            // 
            this.refreshList.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshList.Location = new System.Drawing.Point(0, 0);
            this.refreshList.Name = "refreshList";
            this.refreshList.Size = new System.Drawing.Size(520, 23);
            this.refreshList.TabIndex = 7;
            this.refreshList.Text = "نوسازی";
            this.refreshList.UseVisualStyleBackColor = true;
            this.refreshList.Click += new System.EventHandler(this.refreshList_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            // 
            // subnetMaskDataGridViewTextBoxColumn
            // 
            this.subnetMaskDataGridViewTextBoxColumn.DataPropertyName = "SubnetMask";
            this.subnetMaskDataGridViewTextBoxColumn.HeaderText = "SubnetMask";
            this.subnetMaskDataGridViewTextBoxColumn.Name = "subnetMaskDataGridViewTextBoxColumn";
            // 
            // getwayDataGridViewTextBoxColumn
            // 
            this.getwayDataGridViewTextBoxColumn.DataPropertyName = "Getway";
            this.getwayDataGridViewTextBoxColumn.HeaderText = "Getway";
            this.getwayDataGridViewTextBoxColumn.Name = "getwayDataGridViewTextBoxColumn";
            // 
            // dNSDataGridViewTextBoxColumn
            // 
            this.dNSDataGridViewTextBoxColumn.DataPropertyName = "DNS";
            this.dNSDataGridViewTextBoxColumn.HeaderText = "DNS";
            this.dNSDataGridViewTextBoxColumn.Name = "dNSDataGridViewTextBoxColumn";
            // 
            // registeredDataGridViewCheckBoxColumn
            // 
            this.registeredDataGridViewCheckBoxColumn.DataPropertyName = "registered";
            this.registeredDataGridViewCheckBoxColumn.HeaderText = "registered";
            this.registeredDataGridViewCheckBoxColumn.Name = "registeredDataGridViewCheckBoxColumn";
            // 
            // mACDataGridViewTextBoxColumn
            // 
            this.mACDataGridViewTextBoxColumn.DataPropertyName = "MAC";
            this.mACDataGridViewTextBoxColumn.HeaderText = "MAC";
            this.mACDataGridViewTextBoxColumn.Name = "mACDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // tVsBindingSource
            // 
            this.tVsBindingSource.DataMember = "TVs";
            this.tVsBindingSource.DataSource = this.dbUdpHTVDataSet;
            // 
            // dbUdpHTVDataSet
            // 
            this.dbUdpHTVDataSet.DataSetName = "DbUdpHTVDataSet";
            this.dbUdpHTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tVsTableAdapter
            // 
            this.tVsTableAdapter.ClearBeforeFill = true;
            // 
            // getNetworkInformation
            // 
            this.getNetworkInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.getNetworkInformation.Location = new System.Drawing.Point(0, 215);
            this.getNetworkInformation.Name = "getNetworkInformation";
            this.getNetworkInformation.Size = new System.Drawing.Size(520, 23);
            this.getNetworkInformation.TabIndex = 13;
            this.getNetworkInformation.Text = "اطلاعات تلویزیون";
            this.getNetworkInformation.UseVisualStyleBackColor = true;
            this.getNetworkInformation.Click += new System.EventHandler(this.getNetworkInformation_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "main";
            this.Text = "MRK UDP Server";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_Load_1);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tVsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbUdpHTVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DbUdpHTVDataSet dbUdpHTVDataSet;
        private System.Windows.Forms.BindingSource tVsBindingSource;
        private DbUdpHTVDataSetTableAdapters.TVsTableAdapter tVsTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subnetMaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getwayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn registeredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button setTime;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button powerOff;
        private System.Windows.Forms.Button refreshList;
        private System.Windows.Forms.Button getNetworkInformation;
    }
}

