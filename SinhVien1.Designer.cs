namespace HaHuyHung_Buoi3_HCN
{
    partial class SinhVien1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txthoten = new TextBox();
            txtdc = new TextBox();
            txtgioitinh = new TextBox();
            txtmssv = new TextBox();
            btnnhap = new Button();
            dtpngaysinh = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(518, 40);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 0;
            label1.Text = "Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(133, 133);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(133, 205);
            label3.Name = "label3";
            label3.Size = new Size(66, 24);
            label3.TabIndex = 2;
            label3.Text = "MSSV:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(133, 277);
            label4.Name = "label4";
            label4.Size = new Size(104, 24);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(133, 359);
            label5.Name = "label5";
            label5.Size = new Size(96, 24);
            label5.TabIndex = 4;
            label5.Text = "Giới Tính:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(133, 439);
            label6.Name = "label6";
            label6.Size = new Size(78, 24);
            label6.TabIndex = 5;
            label6.Text = "Địa chỉ:";
            // 
            // txthoten
            // 
            txthoten.Location = new Point(301, 128);
            txthoten.Margin = new Padding(3, 4, 3, 4);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(354, 27);
            txthoten.TabIndex = 6;
            // 
            // txtdc
            // 
            txtdc.Location = new Point(301, 433);
            txtdc.Margin = new Padding(3, 4, 3, 4);
            txtdc.Name = "txtdc";
            txtdc.Size = new Size(354, 27);
            txtdc.TabIndex = 7;
            // 
            // txtgioitinh
            // 
            txtgioitinh.Location = new Point(301, 353);
            txtgioitinh.Margin = new Padding(3, 4, 3, 4);
            txtgioitinh.Name = "txtgioitinh";
            txtgioitinh.Size = new Size(354, 27);
            txtgioitinh.TabIndex = 8;
            // 
            // txtmssv
            // 
            txtmssv.Location = new Point(301, 200);
            txtmssv.Margin = new Padding(3, 4, 3, 4);
            txtmssv.Name = "txtmssv";
            txtmssv.Size = new Size(354, 27);
            txtmssv.TabIndex = 10;
            // 
            // btnnhap
            // 
            btnnhap.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnhap.Location = new Point(826, 123);
            btnnhap.Margin = new Padding(3, 4, 3, 4);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(162, 51);
            btnnhap.TabIndex = 11;
            btnnhap.Text = "Nhập";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += btnnhap_Click;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Location = new Point(301, 274);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(354, 27);
            dtpngaysinh.TabIndex = 12;
            // 
            // SinhVien1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtpngaysinh);
            Controls.Add(btnnhap);
            Controls.Add(txtmssv);
            Controls.Add(txtgioitinh);
            Controls.Add(txtdc);
            Controls.Add(txthoten);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SinhVien1";
            Size = new Size(1202, 660);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txthoten;
        private TextBox txtdc;
        private TextBox txtgioitinh;
        private TextBox txtmssv;
        private Button btnnhap;
        private DateTimePicker dtpngaysinh;
    }
}
