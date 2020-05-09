namespace CardsGenerator
{
    partial class SelectQRLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectQRLocationForm));
            this.SelectBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackgroundPic = new System.Windows.Forms.PictureBox();
            this.comboBoxZoom = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(533, 740);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(156, 50);
            this.SelectBtn.TabIndex = 7;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(695, 740);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(156, 50);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.BackgroundPic);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 722);
            this.panel1.TabIndex = 9;
            // 
            // BackgroundPic
            // 
            this.BackgroundPic.Location = new System.Drawing.Point(3, 3);
            this.BackgroundPic.Name = "BackgroundPic";
            this.BackgroundPic.Size = new System.Drawing.Size(100, 50);
            this.BackgroundPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackgroundPic.TabIndex = 2;
            this.BackgroundPic.TabStop = false;
            this.BackgroundPic.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.BackgroundPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.BackgroundPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // comboBoxZoom
            // 
            this.comboBoxZoom.FormattingEnabled = true;
            this.comboBoxZoom.Location = new System.Drawing.Point(1174, 743);
            this.comboBoxZoom.Name = "comboBoxZoom";
            this.comboBoxZoom.Size = new System.Drawing.Size(121, 24);
            this.comboBoxZoom.TabIndex = 10;
            // 
            // SelectQRLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 802);
            this.Controls.Add(this.comboBoxZoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SelectBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectQRLocationForm";
            this.Text = "SelectQRLocationForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BackgroundPic;
        private System.Windows.Forms.ComboBox comboBoxZoom;
    }
}