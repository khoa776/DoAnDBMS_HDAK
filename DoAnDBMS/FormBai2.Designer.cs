namespace DoAnDBMS
{
    partial class FormBai2
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(78, 26);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(650, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÀI 2 - GIẢI PHƯƠNG TRÌNH BẬC 2";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(103, 121);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(71, 23);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Hệ số a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(328, 121);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(72, 23);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Hệ số b:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(554, 121);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(70, 23);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "Hệ số c:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(103, 156);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(170, 30);
            this.txtA.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(553, 156);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(170, 30);
            this.txtC.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(328, 156);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(170, 30);
            this.txtB.TabIndex = 6;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(103, 331);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKetQua.Size = new System.Drawing.Size(620, 75);
            this.txtKetQua.TabIndex = 7;
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.Location = new System.Drawing.Point(208, 226);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(180, 45);
            this.btnGiai.TabIndex = 8;
            this.btnGiai.Text = "Giải phương trình";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(428, 226);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 45);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Location = new System.Drawing.Point(103, 436);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(160, 35);
            this.btnKetNoi.TabIndex = 11;
            this.btnKetNoi.Text = "Kết nối CSDL";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(103, 296);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(73, 23);
            this.lblKetQua.TabIndex = 12;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 585);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnKetNoi);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormBai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 2 - Giải phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.Label lblKetQua;
    }
}