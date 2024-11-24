namespace VD2
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblHo = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHo = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoTen = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Blue;
            this.lblHoTen.Location = new System.Drawing.Point(12, 9);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(776, 42);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Ho va Ten";
            this.lblHoTen.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(91, 81);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(46, 16);
            this.lblHo.TabIndex = 1;
            this.lblHo.Text = "Ho Lot";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(91, 158);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Ten";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(231, 74);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(326, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(231, 158);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(326, 22);
            this.txtTen.TabIndex = 4;
            // 
            // btnHo
            // 
            this.btnHo.Location = new System.Drawing.Point(153, 215);
            this.btnHo.Name = "btnHo";
            this.btnHo.Size = new System.Drawing.Size(75, 23);
            this.btnHo.TabIndex = 5;
            this.btnHo.Text = "Ho";
            this.btnHo.UseVisualStyleBackColor = true;
            this.btnHo.Click += new System.EventHandler(this.btnHo_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(322, 215);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(75, 23);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "Ten";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoTen
            // 
            this.btnHoTen.Location = new System.Drawing.Point(482, 215);
            this.btnHoTen.Name = "btnHoTen";
            this.btnHoTen.Size = new System.Drawing.Size(104, 23);
            this.btnHoTen.TabIndex = 7;
            this.btnHoTen.Text = "Ho va ten";
            this.btnHoTen.UseVisualStyleBackColor = true;
            this.btnHoTen.Click += new System.EventHandler(this.btnHoTen_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(322, 286);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "Thoat";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnHoTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHo);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblHo);
            this.Controls.Add(this.lblHoTen);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHo;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoTen;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

