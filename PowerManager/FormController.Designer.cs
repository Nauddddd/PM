namespace PowerManager
{
    partial class FormController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormController));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGiay = new System.Windows.Forms.Label();
            this.lbPhut = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.numGiay = new System.Windows.Forms.NumericUpDown();
            this.numPhut = new System.Windows.Forms.NumericUpDown();
            this.numGio = new System.Windows.Forms.NumericUpDown();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showForm = new System.Windows.Forms.ToolStripMenuItem();
            this.exitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShutDown = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lbGiay);
            this.groupBox1.Controls.Add(this.lbPhut);
            this.groupBox1.Controls.Add(this.lbGio);
            this.groupBox1.Controls.Add(this.numGiay);
            this.groupBox1.Controls.Add(this.numPhut);
            this.groupBox1.Controls.Add(this.numGio);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thời gian";
            // 
            // lbGiay
            // 
            this.lbGiay.AutoSize = true;
            this.lbGiay.Location = new System.Drawing.Point(294, 24);
            this.lbGiay.Name = "lbGiay";
            this.lbGiay.Size = new System.Drawing.Size(43, 20);
            this.lbGiay.TabIndex = 5;
            this.lbGiay.Text = "Giây";
            // 
            // lbPhut
            // 
            this.lbPhut.AutoSize = true;
            this.lbPhut.Location = new System.Drawing.Point(175, 24);
            this.lbPhut.Name = "lbPhut";
            this.lbPhut.Size = new System.Drawing.Size(43, 20);
            this.lbPhut.TabIndex = 4;
            this.lbPhut.Text = "Phút";
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.Location = new System.Drawing.Point(63, 23);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(35, 20);
            this.lbGio.TabIndex = 3;
            this.lbGio.Text = "Giờ";
            // 
            // numGiay
            // 
            this.numGiay.Location = new System.Drawing.Point(248, 21);
            this.numGiay.Name = "numGiay";
            this.numGiay.Size = new System.Drawing.Size(40, 26);
            this.numGiay.TabIndex = 2;
            this.numGiay.ValueChanged += new System.EventHandler(this.numGiay_ValueChanged);
            // 
            // numPhut
            // 
            this.numPhut.Location = new System.Drawing.Point(129, 22);
            this.numPhut.Name = "numPhut";
            this.numPhut.Size = new System.Drawing.Size(40, 26);
            this.numPhut.TabIndex = 1;
            this.numPhut.ValueChanged += new System.EventHandler(this.numPhut_ValueChanged);
            // 
            // numGio
            // 
            this.numGio.Location = new System.Drawing.Point(17, 22);
            this.numGio.Name = "numGio";
            this.numGio.Size = new System.Drawing.Size(40, 26);
            this.numGio.TabIndex = 0;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Image = global::PowerManager.Properties.Resources.restart;
            this.btnRestart.Location = new System.Drawing.Point(147, 79);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 85);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::PowerManager.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 85);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbMax);
            this.groupBox2.Controls.Add(this.lbMin);
            this.groupBox2.Controls.Add(this.trackBarBrightness);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh độ sáng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "50%";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(299, 90);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(50, 20);
            this.lbMax.TabIndex = 2;
            this.lbMax.Text = "100%";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(13, 90);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(30, 20);
            this.lbMin.TabIndex = 1;
            this.lbMin.Text = "0%";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.BackColor = System.Drawing.Color.AliceBlue;
            this.trackBarBrightness.Location = new System.Drawing.Point(16, 45);
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(333, 45);
            this.trackBarBrightness.TabIndex = 0;
            this.trackBarBrightness.Value = 5;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.Menu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Power Manager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showForm,
            this.exitForm});
            this.Menu.Name = "contextMenuStrip1";
            this.Menu.Size = new System.Drawing.Size(159, 48);
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // showForm
            // 
            this.showForm.Image = global::PowerManager.Properties.Resources.home;
            this.showForm.Name = "showForm";
            this.showForm.Size = new System.Drawing.Size(158, 22);
            this.showForm.Text = "Màn hình chính";
            this.showForm.Click += new System.EventHandler(this.showForm_Click);
            // 
            // exitForm
            // 
            this.exitForm.Image = global::PowerManager.Properties.Resources.exit;
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(158, 22);
            this.exitForm.Text = "Exit";
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // btnShutDown
            // 
            this.btnShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutDown.Image = global::PowerManager.Properties.Resources.shutdown;
            this.btnShutDown.Location = new System.Drawing.Point(40, 79);
            this.btnShutDown.Name = "btnShutDown";
            this.btnShutDown.Size = new System.Drawing.Size(71, 85);
            this.btnShutDown.TabIndex = 1;
            this.btnShutDown.Text = "Shutdown";
            this.btnShutDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShutDown.UseVisualStyleBackColor = true;
            this.btnShutDown.Click += new System.EventHandler(this.btnShutDown_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShutDown);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormController";
            this.Text = "Power Manager[DuanTarzan-17T3]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormController_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormController_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGio)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbGiay;
        private System.Windows.Forms.Label lbPhut;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.NumericUpDown numGiay;
        private System.Windows.Forms.NumericUpDown numPhut;
        private System.Windows.Forms.NumericUpDown numGio;
        private System.Windows.Forms.Button btnShutDown;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem showForm;
        private System.Windows.Forms.ToolStripMenuItem exitForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

