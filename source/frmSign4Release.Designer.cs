namespace html2apk
{
    partial class frmSign4Release
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSign4Release));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKeyStoreAlias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeyStore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAPK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtKeyStoreAlias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtKeyStore);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAPK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " details : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "sign for release";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKeyStoreAlias
            // 
            this.txtKeyStoreAlias.Location = new System.Drawing.Point(133, 122);
            this.txtKeyStoreAlias.Name = "txtKeyStoreAlias";
            this.txtKeyStoreAlias.Size = new System.Drawing.Size(176, 23);
            this.txtKeyStoreAlias.TabIndex = 0;
            this.txtKeyStoreAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alias :";
            // 
            // txtKeyStore
            // 
            this.txtKeyStore.AllowDrop = true;
            this.txtKeyStore.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyStore.Location = new System.Drawing.Point(33, 93);
            this.txtKeyStore.Name = "txtKeyStore";
            this.txtKeyStore.Size = new System.Drawing.Size(276, 23);
            this.txtKeyStore.TabIndex = 3;
            this.txtKeyStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKeyStore.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.txtKeyStore.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "KeyStore :";
            // 
            // txtAPK
            // 
            this.txtAPK.AllowDrop = true;
            this.txtAPK.BackColor = System.Drawing.SystemColors.Window;
            this.txtAPK.Location = new System.Drawing.Point(33, 42);
            this.txtAPK.Name = "txtAPK";
            this.txtAPK.Size = new System.Drawing.Size(276, 23);
            this.txtAPK.TabIndex = 2;
            this.txtAPK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAPK.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.txtAPK.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Unsigned APK : ";
            // 
            // frmSign4Release
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSign4Release";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign for Release";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKeyStoreAlias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAPK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}