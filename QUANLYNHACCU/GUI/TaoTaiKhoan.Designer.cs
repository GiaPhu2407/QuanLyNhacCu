
namespace QUANLYNHACCU
{
    partial class FRM_TAOTAIKHOAN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TAOTAIKHOAN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenDN_new = new System.Windows.Forms.TextBox();
            this.txt_MatKhau_new = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.btn_Thoat_new = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu";
            // 
            // txt_TenDN_new
            // 
            this.txt_TenDN_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDN_new.Location = new System.Drawing.Point(178, 38);
            this.txt_TenDN_new.Name = "txt_TenDN_new";
            this.txt_TenDN_new.Size = new System.Drawing.Size(254, 30);
            this.txt_TenDN_new.TabIndex = 3;
            // 
            // txt_MatKhau_new
            // 
            this.txt_MatKhau_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau_new.Location = new System.Drawing.Point(178, 78);
            this.txt_MatKhau_new.Name = "txt_MatKhau_new";
            this.txt_MatKhau_new.Size = new System.Drawing.Size(254, 30);
            this.txt_MatKhau_new.TabIndex = 4;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_DangKy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DangKy.BackgroundImage")));
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DangKy.Location = new System.Drawing.Point(80, 134);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(192, 45);
            this.btn_DangKy.TabIndex = 5;
            this.btn_DangKy.Text = "Đăng Ký Tài Khoản";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_Thoat_new
            // 
            this.btn_Thoat_new.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Thoat_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Thoat_new.BackgroundImage")));
            this.btn_Thoat_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat_new.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat_new.Location = new System.Drawing.Point(308, 134);
            this.btn_Thoat_new.Name = "btn_Thoat_new";
            this.btn_Thoat_new.Size = new System.Drawing.Size(124, 45);
            this.btn_Thoat_new.TabIndex = 6;
            this.btn_Thoat_new.Text = "Thoát";
            this.btn_Thoat_new.UseVisualStyleBackColor = false;
            this.btn_Thoat_new.Click += new System.EventHandler(this.btn_Thoat_new_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_Thoat_new);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_DangKy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MatKhau_new);
            this.groupBox1.Controls.Add(this.txt_TenDN_new);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 207);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Đăng Ký";
            // 
            // FRM_TAOTAIKHOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FRM_TAOTAIKHOAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAOTAIKHOAN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_TenDN_new;
        public System.Windows.Forms.TextBox txt_MatKhau_new;
        public System.Windows.Forms.Button btn_DangKy;
        public System.Windows.Forms.Button btn_Thoat_new;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}