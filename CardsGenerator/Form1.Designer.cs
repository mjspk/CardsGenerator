namespace CardsGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.QRCodePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackgroundPic = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultPic = new System.Windows.Forms.PictureBox();
            this.PickBackgroundBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.GenerateCountBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPic)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCodePic
            // 
            this.QRCodePic.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QRCodePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QRCodePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QRCodePic.Location = new System.Drawing.Point(460, 51);
            this.QRCodePic.Name = "QRCodePic";
            this.QRCodePic.Size = new System.Drawing.Size(289, 289);
            this.QRCodePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRCodePic.TabIndex = 0;
            this.QRCodePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QR Code";
            // 
            // BackgroundPic
            // 
            this.BackgroundPic.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPic.Location = new System.Drawing.Point(4, 51);
            this.BackgroundPic.Name = "BackgroundPic";
            this.BackgroundPic.Size = new System.Drawing.Size(450, 289);
            this.BackgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundPic.TabIndex = 2;
            this.BackgroundPic.TabStop = false;
            this.BackgroundPic.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.BackgroundPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.BackgroundPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(750, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // ResultPic
            // 
            this.ResultPic.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResultPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResultPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultPic.Location = new System.Drawing.Point(755, 51);
            this.ResultPic.Name = "ResultPic";
            this.ResultPic.Size = new System.Drawing.Size(450, 289);
            this.ResultPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ResultPic.TabIndex = 4;
            this.ResultPic.TabStop = false;
            // 
            // PickBackgroundBtn
            // 
            this.PickBackgroundBtn.Location = new System.Drawing.Point(3, 347);
            this.PickBackgroundBtn.Name = "PickBackgroundBtn";
            this.PickBackgroundBtn.Size = new System.Drawing.Size(156, 50);
            this.PickBackgroundBtn.TabIndex = 6;
            this.PickBackgroundBtn.Text = "Pick Up Background";
            this.PickBackgroundBtn.UseVisualStyleBackColor = true;
            this.PickBackgroundBtn.Click += new System.EventHandler(this.PickBackgroundBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(530, 346);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(156, 50);
            this.GenerateBtn.TabIndex = 7;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // GenerateCountBox
            // 
            this.GenerateCountBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenerateCountBox.FormattingEnabled = true;
            this.GenerateCountBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.GenerateCountBox.Location = new System.Drawing.Point(930, 347);
            this.GenerateCountBox.Name = "GenerateCountBox";
            this.GenerateCountBox.Size = new System.Drawing.Size(156, 24);
            this.GenerateCountBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Results :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenerateCountBox);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.PickBackgroundBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultPic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackgroundPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QRCodePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CardsGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QRCodePic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackgroundPic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ResultPic;
        private System.Windows.Forms.Button PickBackgroundBtn;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.ComboBox GenerateCountBox;
        private System.Windows.Forms.Label label4;
    }
}

