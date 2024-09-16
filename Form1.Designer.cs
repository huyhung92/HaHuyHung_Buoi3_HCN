namespace HaHuyHung_Buoi3_HCN
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
            label1 = new Label();
            label2 = new Label();
            txtcd = new TextBox();
            txtcr = new TextBox();
            btnnhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(86, 65);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 0;
            label1.Text = "Chiều dài:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(86, 114);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 1;
            label2.Text = "Chiều rộng:";
            label2.Click += label2_Click;
            // 
            // txtcd
            // 
            txtcd.Location = new Point(196, 61);
            txtcd.Name = "txtcd";
            txtcd.Size = new Size(165, 23);
            txtcd.TabIndex = 2;
            // 
            // txtcr
            // 
            txtcr.Location = new Point(196, 110);
            txtcr.Name = "txtcr";
            txtcr.Size = new Size(165, 23);
            txtcr.TabIndex = 3;
            // 
            // btnnhap
            // 
            btnnhap.Location = new Point(409, 166);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(101, 31);
            btnnhap.TabIndex = 4;
            btnnhap.Text = "Nhập";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += btnnhap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnnhap);
            Controls.Add(txtcr);
            Controls.Add(txtcd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcd;
        private TextBox txtcr;
        private Button btnnhap;
    }
}
