namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txb_chuoiKiTu = new System.Windows.Forms.TextBox();
            this.lb_ketQua = new System.Windows.Forms.Label();
            this.btn_maHoa = new System.Windows.Forms.Button();
            this.btn_giaiMa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_khoa = new System.Windows.Forms.TextBox();
            this.txb_ketQua = new System.Windows.Forms.TextBox();
            this.rbt_matran = new System.Windows.Forms.RichTextBox();
            this.btn_matran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi ký tự";
            // 
            // txb_chuoiKiTu
            // 
            this.txb_chuoiKiTu.Location = new System.Drawing.Point(288, 67);
            this.txb_chuoiKiTu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txb_chuoiKiTu.Name = "txb_chuoiKiTu";
            this.txb_chuoiKiTu.Size = new System.Drawing.Size(442, 45);
            this.txb_chuoiKiTu.TabIndex = 0;
            // 
            // lb_ketQua
            // 
            this.lb_ketQua.AutoSize = true;
            this.lb_ketQua.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ketQua.Location = new System.Drawing.Point(55, 261);
            this.lb_ketQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_ketQua.Name = "lb_ketQua";
            this.lb_ketQua.Size = new System.Drawing.Size(129, 33);
            this.lb_ketQua.TabIndex = 2;
            this.lb_ketQua.Text = "Kết quả";
            // 
            // btn_maHoa
            // 
            this.btn_maHoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_maHoa.Location = new System.Drawing.Point(148, 366);
            this.btn_maHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_maHoa.Name = "btn_maHoa";
            this.btn_maHoa.Size = new System.Drawing.Size(175, 58);
            this.btn_maHoa.TabIndex = 3;
            this.btn_maHoa.Text = "Mã hóa";
            this.btn_maHoa.UseVisualStyleBackColor = true;
            this.btn_maHoa.Click += new System.EventHandler(this.btn_maHoa_Click);
            // 
            // btn_giaiMa
            // 
            this.btn_giaiMa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_giaiMa.Location = new System.Drawing.Point(443, 366);
            this.btn_giaiMa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_giaiMa.Name = "btn_giaiMa";
            this.btn_giaiMa.Size = new System.Drawing.Size(166, 58);
            this.btn_giaiMa.TabIndex = 4;
            this.btn_giaiMa.Text = "Giải mã";
            this.btn_giaiMa.UseVisualStyleBackColor = true;
            this.btn_giaiMa.Click += new System.EventHandler(this.btn_giaiMa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập khóa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txb_khoa
            // 
            this.txb_khoa.Location = new System.Drawing.Point(288, 167);
            this.txb_khoa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txb_khoa.Name = "txb_khoa";
            this.txb_khoa.Size = new System.Drawing.Size(442, 45);
            this.txb_khoa.TabIndex = 1;
            // 
            // txb_ketQua
            // 
            this.txb_ketQua.Location = new System.Drawing.Point(288, 261);
            this.txb_ketQua.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txb_ketQua.Name = "txb_ketQua";
            this.txb_ketQua.Size = new System.Drawing.Size(442, 45);
            this.txb_ketQua.TabIndex = 2;
            // 
            // rbt_matran
            // 
            this.rbt_matran.Location = new System.Drawing.Point(788, 80);
            this.rbt_matran.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbt_matran.Name = "rbt_matran";
            this.rbt_matran.Size = new System.Drawing.Size(273, 214);
            this.rbt_matran.TabIndex = 11;
            this.rbt_matran.Text = "";
            // 
            // btn_matran
            // 
            this.btn_matran.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matran.Location = new System.Drawing.Point(745, 366);
            this.btn_matran.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_matran.Name = "btn_matran";
            this.btn_matran.Size = new System.Drawing.Size(316, 58);
            this.btn_matran.TabIndex = 5;
            this.btn_matran.Text = "Hiển thị ma trận";
            this.btn_matran.UseVisualStyleBackColor = true;
            this.btn_matran.Click += new System.EventHandler(this.btn_matran_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 469);
            this.Controls.Add(this.btn_matran);
            this.Controls.Add(this.rbt_matran);
            this.Controls.Add(this.txb_ketQua);
            this.Controls.Add(this.txb_khoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_giaiMa);
            this.Controls.Add(this.btn_maHoa);
            this.Controls.Add(this.lb_ketQua);
            this.Controls.Add(this.txb_chuoiKiTu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Playfair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_chuoiKiTu;
        private System.Windows.Forms.Label lb_ketQua;
        private System.Windows.Forms.Button btn_maHoa;
        private System.Windows.Forms.Button btn_giaiMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_khoa;
        private System.Windows.Forms.TextBox txb_ketQua;
        private System.Windows.Forms.RichTextBox rbt_matran;
        private System.Windows.Forms.Button btn_matran;
    }
}

