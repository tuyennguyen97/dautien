namespace QuanLyChuyenBay
{
    partial class frmQuanLyChuyenBay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa_So_Chuyen_Bay = new System.Windows.Forms.TextBox();
            this.txtThanh_Pho_Khoi_Hanh = new System.Windows.Forms.TextBox();
            this.txtThanh_Pho_Den = new System.Windows.Forms.TextBox();
            this.dTThoi_Gian_Khoi_Hanh = new System.Windows.Forms.DateTimePicker();
            this.dTThoi_Gian_Den = new System.Windows.Forms.DateTimePicker();
            this.dtGChuyen_Bay = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Flight_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGChuyen_Bay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số chuyến bay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thành phố đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thành phố khởi hành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian khởi hành";
            // 
            // txtMa_So_Chuyen_Bay
            // 
            this.txtMa_So_Chuyen_Bay.Location = new System.Drawing.Point(161, 51);
            this.txtMa_So_Chuyen_Bay.Name = "txtMa_So_Chuyen_Bay";
            this.txtMa_So_Chuyen_Bay.Size = new System.Drawing.Size(148, 20);
            this.txtMa_So_Chuyen_Bay.TabIndex = 1;
            // 
            // txtThanh_Pho_Khoi_Hanh
            // 
            this.txtThanh_Pho_Khoi_Hanh.Location = new System.Drawing.Point(161, 85);
            this.txtThanh_Pho_Khoi_Hanh.Name = "txtThanh_Pho_Khoi_Hanh";
            this.txtThanh_Pho_Khoi_Hanh.Size = new System.Drawing.Size(148, 20);
            this.txtThanh_Pho_Khoi_Hanh.TabIndex = 1;
            // 
            // txtThanh_Pho_Den
            // 
            this.txtThanh_Pho_Den.Location = new System.Drawing.Point(431, 51);
            this.txtThanh_Pho_Den.Name = "txtThanh_Pho_Den";
            this.txtThanh_Pho_Den.Size = new System.Drawing.Size(148, 20);
            this.txtThanh_Pho_Den.TabIndex = 1;
            // 
            // dTThoi_Gian_Khoi_Hanh
            // 
            this.dTThoi_Gian_Khoi_Hanh.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dTThoi_Gian_Khoi_Hanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTThoi_Gian_Khoi_Hanh.Location = new System.Drawing.Point(161, 131);
            this.dTThoi_Gian_Khoi_Hanh.Name = "dTThoi_Gian_Khoi_Hanh";
            this.dTThoi_Gian_Khoi_Hanh.Size = new System.Drawing.Size(148, 20);
            this.dTThoi_Gian_Khoi_Hanh.TabIndex = 2;
            // 
            // dTThoi_Gian_Den
            // 
            this.dTThoi_Gian_Den.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dTThoi_Gian_Den.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTThoi_Gian_Den.Location = new System.Drawing.Point(431, 85);
            this.dTThoi_Gian_Den.Name = "dTThoi_Gian_Den";
            this.dTThoi_Gian_Den.Size = new System.Drawing.Size(148, 20);
            this.dTThoi_Gian_Den.TabIndex = 2;
            // 
            // dtGChuyen_Bay
            // 
            this.dtGChuyen_Bay.AllowUserToDeleteRows = false;
            this.dtGChuyen_Bay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGChuyen_Bay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flight_Number,
            this.Departure_City,
            this.Departure_Time,
            this.Arrival_City,
            this.Arrival_Time});
            this.dtGChuyen_Bay.Location = new System.Drawing.Point(42, 180);
            this.dtGChuyen_Bay.Name = "dtGChuyen_Bay";
            this.dtGChuyen_Bay.ReadOnly = true;
            this.dtGChuyen_Bay.Size = new System.Drawing.Size(545, 150);
            this.dtGChuyen_Bay.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(208, 359);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 4;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(327, 359);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(447, 359);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quản lý chuyến bay";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Flight_Number
            // 
            this.Flight_Number.HeaderText = "Mã số chuyến bay";
            this.Flight_Number.Name = "Flight_Number";
            this.Flight_Number.ReadOnly = true;
            // 
            // Departure_City
            // 
            this.Departure_City.HeaderText = "Thành phố khởi hành";
            this.Departure_City.Name = "Departure_City";
            this.Departure_City.ReadOnly = true;
            // 
            // Departure_Time
            // 
            this.Departure_Time.HeaderText = "Thời gian khởi hành";
            this.Departure_Time.Name = "Departure_Time";
            this.Departure_Time.ReadOnly = true;
            // 
            // Arrival_City
            // 
            this.Arrival_City.HeaderText = "Thành phố đến";
            this.Arrival_City.Name = "Arrival_City";
            this.Arrival_City.ReadOnly = true;
            // 
            // Arrival_Time
            // 
            this.Arrival_Time.HeaderText = "Thời gian đến";
            this.Arrival_Time.Name = "Arrival_Time";
            this.Arrival_Time.ReadOnly = true;
            // 
            // frmQuanLyChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 404);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtGChuyen_Bay);
            this.Controls.Add(this.dTThoi_Gian_Den);
            this.Controls.Add(this.dTThoi_Gian_Khoi_Hanh);
            this.Controls.Add(this.txtThanh_Pho_Khoi_Hanh);
            this.Controls.Add(this.txtThanh_Pho_Den);
            this.Controls.Add(this.txtMa_So_Chuyen_Bay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyChuyenBay";
            this.Text = "Quản lý chuyến bay";
            ((System.ComponentModel.ISupportInitialize)(this.dtGChuyen_Bay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMa_So_Chuyen_Bay;
        private System.Windows.Forms.TextBox txtThanh_Pho_Khoi_Hanh;
        private System.Windows.Forms.TextBox txtThanh_Pho_Den;
        private System.Windows.Forms.DateTimePicker dTThoi_Gian_Khoi_Hanh;
        private System.Windows.Forms.DateTimePicker dTThoi_Gian_Den;
        private System.Windows.Forms.DataGridView dtGChuyen_Bay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival_Time;
    }
}

