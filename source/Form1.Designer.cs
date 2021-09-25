namespace html2apk
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
            this.chSplash = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrientation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGeneratePRJ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.NumericUpDown();
            this.btnBuildDirect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // chSplash
            // 
            this.chSplash.AutoSize = true;
            this.chSplash.Location = new System.Drawing.Point(16, 156);
            this.chSplash.Name = "chSplash";
            this.chSplash.Size = new System.Drawing.Size(342, 19);
            this.chSplash.TabIndex = 0;
            this.chSplash.Text = "Splashscreen (res\\drawable-nodpi-v4\\splash.jpg (720x1280))";
            this.chSplash.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Force Orientation : ";
            // 
            // cmbOrientation
            // 
            this.cmbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrientation.FormattingEnabled = true;
            this.cmbOrientation.Items.AddRange(new object[] {
            "user",
            "portrait",
            "landscape"});
            this.cmbOrientation.Location = new System.Drawing.Point(127, 118);
            this.cmbOrientation.Name = "cmbOrientation";
            this.cmbOrientation.Size = new System.Drawing.Size(121, 23);
            this.cmbOrientation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Namespace : ";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(127, 10);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(231, 23);
            this.txtNamespace.TabIndex = 4;
            this.txtNamespace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(127, 44);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(231, 23);
            this.txtAppName.TabIndex = 6;
            this.txtAppName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Application Name : ";
            // 
            // btnGeneratePRJ
            // 
            this.btnGeneratePRJ.Location = new System.Drawing.Point(13, 193);
            this.btnGeneratePRJ.Name = "btnGeneratePRJ";
            this.btnGeneratePRJ.Size = new System.Drawing.Size(345, 36);
            this.btnGeneratePRJ.TabIndex = 7;
            this.btnGeneratePRJ.Text = "Generate PRJ";
            this.btnGeneratePRJ.UseVisualStyleBackColor = true;
            this.btnGeneratePRJ.Click += new System.EventHandler(this.btnGeneratePRJ_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "VersionCode :";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(127, 80);
            this.txtVersion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(55, 23);
            this.txtVersion.TabIndex = 9;
            this.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVersion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuildDirect
            // 
            this.btnBuildDirect.Location = new System.Drawing.Point(13, 235);
            this.btnBuildDirect.Name = "btnBuildDirect";
            this.btnBuildDirect.Size = new System.Drawing.Size(345, 36);
            this.btnBuildDirect.TabIndex = 10;
            this.btnBuildDirect.Text = "Build PRJ from \'compile\' folder";
            this.btnBuildDirect.UseVisualStyleBackColor = true;
            this.btnBuildDirect.Click += new System.EventHandler(this.btnBuildDirect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 280);
            this.Controls.Add(this.btnBuildDirect);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGeneratePRJ);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOrientation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chSplash);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chSplash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrientation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeneratePRJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtVersion;
        private System.Windows.Forms.Button btnBuildDirect;
    }
}

