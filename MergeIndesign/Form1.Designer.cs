namespace MergeIndesign
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
            this.btnIndesign = new System.Windows.Forms.Button();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFSize = new System.Windows.Forms.ComboBox();
            this.chkFit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnIndesign
            // 
            this.btnIndesign.Location = new System.Drawing.Point(274, 234);
            this.btnIndesign.Name = "btnIndesign";
            this.btnIndesign.Size = new System.Drawing.Size(226, 40);
            this.btnIndesign.TabIndex = 0;
            this.btnIndesign.Text = "InDesign Process";
            this.btnIndesign.UseVisualStyleBackColor = true;
            this.btnIndesign.Click += new System.EventHandler(this.btnIndesign_Click);
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(16, 33);
            this.txtLabel.Multiline = true;
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(484, 58);
            this.txtLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customized Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.cmbColor.Location = new System.Drawing.Point(20, 186);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(227, 24);
            this.cmbColor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Font Family";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Items.AddRange(new object[] {
            "Broadway",
            "Myriad Pro",
            "Chiller",
            "Verdana"});
            this.cmbFont.Location = new System.Drawing.Point(21, 133);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(226, 24);
            this.cmbFont.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Results";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(13, 307);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(505, 84);
            this.lstResult.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Font Size";
            // 
            // cmbFSize
            // 
            this.cmbFSize.FormattingEnabled = true;
            this.cmbFSize.Items.AddRange(new object[] {
            "50",
            "75",
            "90",
            "100",
            "120"});
            this.cmbFSize.Location = new System.Drawing.Point(274, 133);
            this.cmbFSize.Name = "cmbFSize";
            this.cmbFSize.Size = new System.Drawing.Size(213, 24);
            this.cmbFSize.TabIndex = 10;
            // 
            // chkFit
            // 
            this.chkFit.AutoSize = true;
            this.chkFit.Location = new System.Drawing.Point(274, 186);
            this.chkFit.Name = "chkFit";
            this.chkFit.Size = new System.Drawing.Size(101, 21);
            this.chkFit.TabIndex = 11;
            this.chkFit.Text = "Fit to frame";
            this.chkFit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 395);
            this.Controls.Add(this.chkFit);
            this.Controls.Add(this.cmbFSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.btnIndesign);
            this.Name = "Form1";
            this.Text = "Customized Art Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIndesign;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFSize;
        private System.Windows.Forms.CheckBox chkFit;
    }
}

