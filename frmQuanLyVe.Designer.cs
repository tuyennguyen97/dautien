namespace QuanLyChuyenBay
{
    partial class frmQuanLyVe
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhe_So = new System.Windows.Forms.TextBox();
            this.txtLoai_Ve = new System.Windows.Forms.TextBox();
            this.txtMa_So_Ve = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia_Ve = new System.Windows.Forms.TextBox();
            this.txtChuyen_Bay_So = new System.Windows.Forms.TextBox();
            this.dtGVe = new System.Windows.Forms.DataGridView();
            this.Tichket_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flight_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quản lý vé máy bay";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGhe_So
            // 
            this.txtGhe_So.Location = new System.Drawing.Point(176, 115);
            this.txtGhe_So.Name = "txtGhe_So";
            this.txtGhe_So.Size = new System.Drawing.Size(148, 20);
            this.txtGhe_So.TabIndex = 12;
            // 
            // txtLoai_Ve
            // 
            this.txtLoai_Ve.Location = new System.Drawing.Point(446, 81);
            this.txtLoai_Ve.Name = "txtLoai_Ve";
            this.txtLoai_Ve.Size = new System.Drawing.Size(148, 20);
            this.txtLoai_Ve.TabIndex = 13;
            // 
            // txtMa_So_Ve
            // 
            this.txtMa_So_Ve.Location = new System.Drawing.Point(176, 81);
            this.txtMa_So_Ve.Name = "txtMa_So_Ve";
            this.txtMa_So_Ve.Size = new System.Drawing.Size(148, 20);
            this.txtMa_So_Ve.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chuyến bay số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ghế số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Loại vé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã số vé";
            // 
            // txtGia_Ve
            // 
            this.txtGia_Ve.Location = new System.Drawing.Point(446, 115);
            this.txtGia_Ve.Name = "txtGia_Ve";
            this.txtGia_Ve.Size = new System.Drawing.Size(148, 20);
            this.txtGia_Ve.TabIndex = 13;
            // 
            // txtChuyen_Bay_So
            // 
            this.txtChuyen_Bay_So.Location = new System.Drawing.Point(176, 158);
            this.txtChuyen_Bay_So.Name = "txtChuyen_Bay_So";
            this.txtChuyen_Bay_So.Size = new System.Drawing.Size(148, 20);
            this.txtChuyen_Bay_So.TabIndex = 13;
            // 
            // dtGVe
            // 
            this.dtGVe.AllowUserToDeleteRows = false;
            this.dtGVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tichket_Number,
            this.Flight_Number,
            this.Ticket_Class,
            this.Ticket_Price,
            this.Seat_Number});
            this.dtGVe.Location = new System.Drawing.Point(57, 196);
            this.dtGVe.Name = "dtGVe";
            this.dtGVe.ReadOnly = true;
            this.dtGVe.Size = new System.Drawing.Size(537, 150);
            this.dtGVe.TabIndex = 15;
            // 
            // Tichket_Number
            // 
            this.Tichket_Number.HeaderText = "Mã số vé";
            this.Tichket_Number.Name = "Tichket_Number";
            this.Tichket_Number.ReadOnly = true;
            // 
            // Flight_Number
            // 
            this.Flight_Number.HeaderText = "Chuyến bay số";
            this.Flight_Number.Name = "Flight_Number";
            this.Flight_Number.ReadOnly = true;
            // 
            // Ticket_Class
            // 
            this.Ticket_Class.HeaderText = "Loại vé";
            this.Ticket_Class.Name = "Ticket_Class";
            this.Ticket_Class.ReadOnly = true;
            // 
            // Ticket_Price
            // 
            this.Ticket_Price.HeaderText = "Giá vé";
            this.Ticket_Price.Name = "Ticket_Price";
            this.Ticket_Price.ReadOnly = true;
            // 
            // Seat_Number
            // 
            this.Seat_Number.HeaderText = "Ghế số";
            this.Seat_Number.Name = "Seat_Number";
            this.Seat_Number.ReadOnly = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(455, 380);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(335, 380);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(216, 380);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 18;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(95, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 426);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtGVe);
            this.Controls.Add(this.txtGhe_So);
            this.Controls.Add(this.txtChuyen_Bay_So);
            this.Controls.Add(this.txtGia_Ve);
            this.Controls.Add(this.txtLoai_Ve);
            this.Controls.Add(this.txtMa_So_Ve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "frmQuanLyVe";
            this.Text = "Quản lý vé";
            ((System.ComponentModel.ISupportInitialize)(this.dtGVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhe_So;
        private System.Windows.Forms.TextBox txtLoai_Ve;
        private System.Windows.Forms.TextBox txtMa_So_Ve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia_Ve;
        private System.Windows.Forms.TextBox txtChuyen_Bay_So;
        private System.Windows.Forms.DataGridView dtGVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tichket_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flight_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat_Number;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnReset;
    }
}