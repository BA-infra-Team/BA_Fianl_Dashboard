namespace BA_Dashboard
{
    partial class Filtering_UC
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filtering_UC));
            this.FilterSecondTopPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterContentPanel = new System.Windows.Forms.Panel();
            this.FilterListViewPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FilterThirdTopPanel = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.FilterSecondTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.FilterContentPanel.SuspendLayout();
            this.FilterListViewPanel.SuspendLayout();
            this.FilterThirdTopPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterSecondTopPanel
            // 
            this.FilterSecondTopPanel.BackColor = System.Drawing.Color.White;
            this.FilterSecondTopPanel.Controls.Add(this.groupBox1);
            this.FilterSecondTopPanel.Controls.Add(this.button8);
            this.FilterSecondTopPanel.Controls.Add(this.pictureBox2);
            this.FilterSecondTopPanel.Controls.Add(this.label2);
            this.FilterSecondTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterSecondTopPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterSecondTopPanel.Name = "FilterSecondTopPanel";
            this.FilterSecondTopPanel.Size = new System.Drawing.Size(1644, 62);
            this.FilterSecondTopPanel.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 79);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1647, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 28);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(68, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "검색화면";
            // 
            // FilterContentPanel
            // 
            this.FilterContentPanel.Controls.Add(this.FilterListViewPanel);
            this.FilterContentPanel.Controls.Add(this.FilterThirdTopPanel);
            this.FilterContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterContentPanel.Location = new System.Drawing.Point(0, 62);
            this.FilterContentPanel.Name = "FilterContentPanel";
            this.FilterContentPanel.Size = new System.Drawing.Size(1644, 839);
            this.FilterContentPanel.TabIndex = 4;
            // 
            // FilterListViewPanel
            // 
            this.FilterListViewPanel.Controls.Add(this.listView1);
            this.FilterListViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterListViewPanel.Location = new System.Drawing.Point(0, 79);
            this.FilterListViewPanel.Name = "FilterListViewPanel";
            this.FilterListViewPanel.Size = new System.Drawing.Size(1644, 760);
            this.FilterListViewPanel.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1644, 760);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FilterThirdTopPanel
            // 
            this.FilterThirdTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(203)))));
            this.FilterThirdTopPanel.Controls.Add(this.groupBox2);
            this.FilterThirdTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilterThirdTopPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterThirdTopPanel.Name = "FilterThirdTopPanel";
            this.FilterThirdTopPanel.Size = new System.Drawing.Size(1644, 79);
            this.FilterThirdTopPanel.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(619, 44);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(80, 22);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            this.SearchBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBtn_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SearchComboBox);
            this.groupBox2.Location = new System.Drawing.Point(4, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(405, 43);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(180, 21);
            this.SearchTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search By JobType";
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "File Backup",
            "Informix Onbar Backup",
            "Mysql Backup",
            "Oracle RMAN Backup",
            "Physical Backup",
            "Vmware Backup"});
            this.SearchComboBox.Location = new System.Drawing.Point(189, 43);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(180, 20);
            this.SearchComboBox.TabIndex = 7;
            this.SearchComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchComboBox_SelectedIndexChanged);
            // 
            // Filtering_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilterContentPanel);
            this.Controls.Add(this.FilterSecondTopPanel);
            this.Name = "Filtering_UC";
            this.Size = new System.Drawing.Size(1644, 901);
            this.FilterSecondTopPanel.ResumeLayout(false);
            this.FilterSecondTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.FilterContentPanel.ResumeLayout(false);
            this.FilterListViewPanel.ResumeLayout(false);
            this.FilterThirdTopPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FilterSecondTopPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel FilterContentPanel;
        private System.Windows.Forms.Panel FilterThirdTopPanel;
        private System.Windows.Forms.Panel FilterListViewPanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SearchComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SearchBtn;
    }
}
