namespace Calcuator
{
    partial class FormAbout
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
            this.labelVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabelIcons8 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabelUserManual = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "민의 계산";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(51, 70);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(89, 15);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "버전 0.7.0.4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "(c) 2020 이종민 All rights reserved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "이 프로그램에서 사용한 이미지는 ICONS8 사이트의 이미지 입니다";
            // 
            // linkLabelIcons8
            // 
            this.linkLabelIcons8.AutoSize = true;
            this.linkLabelIcons8.Location = new System.Drawing.Point(51, 216);
            this.linkLabelIcons8.Name = "linkLabelIcons8";
            this.linkLabelIcons8.Size = new System.Drawing.Size(133, 15);
            this.linkLabelIcons8.TabIndex = 4;
            this.linkLabelIcons8.TabStop = true;
            this.linkLabelIcons8.Text = "https://Icons8.com";
            this.linkLabelIcons8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabelUserManual
            // 
            this.linkLabelUserManual.AutoSize = true;
            this.linkLabelUserManual.Location = new System.Drawing.Point(417, 39);
            this.linkLabelUserManual.Name = "linkLabelUserManual";
            this.linkLabelUserManual.Size = new System.Drawing.Size(102, 15);
            this.linkLabelUserManual.TabIndex = 6;
            this.linkLabelUserManual.TabStop = true;
            this.linkLabelUserManual.Text = "사용자 메뉴얼";
            this.linkLabelUserManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUserManual_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 337);
            this.Controls.Add(this.linkLabelUserManual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabelIcons8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.label1);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ㅊ";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabelIcons8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabelUserManual;
    }
}