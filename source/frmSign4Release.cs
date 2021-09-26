using System;
using System.IO;
using System.Windows.Forms;

namespace html2apk
{
    public partial class frmSign4Release : Form
    {
        public frmSign4Release()
        {
            InitializeComponent();

            General.SendMessage(txtAPK.Handle, General.EM_SETCUEBANNER, 0, "drag & drop unsigned .apk");
            General.SendMessage(txtKeyStore.Handle, General.EM_SETCUEBANNER, 0, "drag & drop .keystore or .jks");
        }

        #region TextBox DragDrop

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            TextBox x =  (sender as TextBox);

            if ( (x.Name.Equals("txtAPK") && FileList[0].ToLower().EndsWith(".apk")) || 
             ( x.Name.Equals("txtKeyStore") && ( FileList[0].ToLower().EndsWith(".keystore") || FileList[0].ToLower().EndsWith(".jks"))) )
                x.Text = FileList[0];
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            txtKeyStoreAlias.Text = txtKeyStoreAlias.Text.Trim();

            if (txtAPK.Text.Length == 0 || txtKeyStore.Text.Length == 0 || txtKeyStoreAlias.Text.Length == 0)
            {
                General.Mes("Please fill all textboxes!", MessageBoxIcon.Exclamation);
                return;
            }
            else if (!File.Exists(txtAPK.Text) || !File.Exists(txtKeyStore.Text))
            {
                General.Mes("APK or keystore file doesn't exist!", MessageBoxIcon.Exclamation);
                return;
            }
            else if (General.javaFilePath == null)
            {
                General.Mes("Can't find 'java.exe', please install JRE, operation aborted", MessageBoxIcon.Exclamation);
                return;
            }
            else if (!File.Exists(General.signerFilePath))
            {
                General.Mes(string.Format("Can't find {0}, operation aborted", General.signerFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            bool signResult = General.Run(General.javaFilePath, string.Format("-jar \"{0}\" -a \"{1}\" --ks \"{2}\" --ksAlias {3}", General.signerFilePath, txtAPK.Text, txtKeyStore.Text, txtKeyStoreAlias.Text));

            if (!signResult)
            {
                General.Mes("APK couldn't be signed for release!", MessageBoxIcon.Exclamation);
                return;
            }
            else
                General.Mes(string.Format("Signed successfully! A new APK generated :\n\n{0}-aligned-signed.apk\n\nis near the application", Path.GetFileNameWithoutExtension(txtAPK.Text)));

        }
    }
}
