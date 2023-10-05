namespace Quanlysach
{
    partial class FormSach
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
            this.Masach = new System.Windows.Forms.Label();
            this.Gia = new System.Windows.Forms.Label();
            this.Tensach = new System.Windows.Forms.Label();
            this.Soluong = new System.Windows.Forms.Label();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.dtgsach = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsach)).BeginInit();
            this.SuspendLayout();
            // 
            // Masach
            // 
            this.Masach.AutoSize = true;
            this.Masach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masach.Location = new System.Drawing.Point(95, 22);
            this.Masach.Name = "Masach";
            this.Masach.Size = new System.Drawing.Size(52, 15);
            this.Masach.TabIndex = 0;
            this.Masach.Text = "Mã sách";
            // 
            // Gia
            // 
            this.Gia.AutoSize = true;
            this.Gia.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gia.Location = new System.Drawing.Point(441, 22);
            this.Gia.Name = "Gia";
            this.Gia.Size = new System.Drawing.Size(26, 15);
            this.Gia.TabIndex = 0;
            this.Gia.Text = "Giá";
            // 
            // Tensach
            // 
            this.Tensach.AutoSize = true;
            this.Tensach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tensach.Location = new System.Drawing.Point(95, 56);
            this.Tensach.Name = "Tensach";
            this.Tensach.Size = new System.Drawing.Size(56, 15);
            this.Tensach.TabIndex = 0;
            this.Tensach.Text = "Tên sách";
            // 
            // Soluong
            // 
            this.Soluong.AutoSize = true;
            this.Soluong.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soluong.Location = new System.Drawing.Point(441, 56);
            this.Soluong.Name = "Soluong";
            this.Soluong.Size = new System.Drawing.Size(57, 15);
            this.Soluong.TabIndex = 0;
            this.Soluong.Text = "Số lượng";
            // 
            // txtmasach
            // 
            this.txtmasach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmasach.Location = new System.Drawing.Point(184, 23);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(126, 22);
            this.txtmasach.TabIndex = 1;
            // 
            // txttensach
            // 
            this.txttensach.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensach.Location = new System.Drawing.Point(184, 57);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(126, 22);
            this.txttensach.TabIndex = 1;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(528, 22);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(126, 22);
            this.txtgia.TabIndex = 1;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(528, 56);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(126, 22);
            this.txtsoluong.TabIndex = 1;
            // 
            // dtgsach
            // 
            this.dtgsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsach.Location = new System.Drawing.Point(108, 134);
            this.dtgsach.Name = "dtgsach";
            this.dtgsach.RowHeadersWidth = 51;
            this.dtgsach.RowTemplate.Height = 24;
            this.dtgsach.Size = new System.Drawing.Size(562, 188);
            this.dtgsach.TabIndex = 2;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(108, 353);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(81, 33);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Location = new System.Drawing.Point(259, 353);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(81, 33);
            this.btncapnhat.TabIndex = 3;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(402, 353);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(81, 33);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(546, 353);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(81, 33);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgsach);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.Soluong);
            this.Controls.Add(this.Tensach);
            this.Controls.Add(this.Gia);
            this.Controls.Add(this.Masach);
            this.Name = "FormSach";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Masach;
        private System.Windows.Forms.Label Gia;
        private System.Windows.Forms.Label Tensach;
        private System.Windows.Forms.Label Soluong;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.DataGridView dtgsach;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
    }
}

