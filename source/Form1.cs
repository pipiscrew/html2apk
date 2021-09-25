using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace html2apk
{
    public partial class Form1 : Form
    {

      internal  string javaFilePath = General.GetFullPathFromWindows("java.exe");
      internal string apkToolFilePath = Path.Combine(Application.StartupPath, "tools", "apktool.jar");
      internal string signerFilePath = Path.Combine(Application.StartupPath, "tools", "uber-apk-signer-0.2.0.jar");
      internal string compilePath = Path.Combine(Application.StartupPath, "compile");

        public Form1()
        {
            InitializeComponent();

            this.Text = Application.ProductName + " v" + Application.ProductVersion;

            cmbOrientation.SelectedIndex = 0;

            General.SendMessage(txtNamespace.Handle, General.EM_SETCUEBANNER, 0, "com.google.com");
            General.SendMessage(txtAppName.Handle, General.EM_SETCUEBANNER, 0, "Gmail");
        }


        private void btnGeneratePRJ_Click(object sender, EventArgs e)
        {
            string templateAndroidManifestFilePath = Path.Combine(Application.StartupPath, "tools", "template", "AndroidManifest.xml");


            #region " validations "

            if (javaFilePath == null)
            {
                General.Mes("Can't find 'java.exe', please install JRE, operation aborted", MessageBoxIcon.Exclamation);
                return;
            }

            if (Directory.Exists(compilePath))
            {
                General.Mes(compilePath + "\n\nalready exists, please delete and try again, operation aborted", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtNamespace.Text))
            {
                General.Mes("Please fill the namespace, operation aborted!", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtAppName.Text))
            {
                General.Mes("Please fill the application name, operation aborted!", MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(apkToolFilePath))
            {
                General.Mes(string.Format("Can't find {0}, operation aborted", apkToolFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(signerFilePath))
            {
                General.Mes(string.Format("Can't find {0}, operation aborted", signerFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(signerFilePath))
            {
                General.Mes(string.Format("Can't find {0}, operation aborted", signerFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(templateAndroidManifestFilePath))
            {
                General.Mes(string.Format("Can't find {0}, operation aborted", templateAndroidManifestFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            #endregion


            string templatePath = Path.Combine(Application.StartupPath, "tools", "template");
            
            //delete
            //if (Directory.Exists(compilePath))
            //    Directory.Delete(compilePath, true);

            //copy template
            General.DirectoryCopy(templatePath, compilePath, true);

            string androidManifestFilePath = Path.Combine(Application.StartupPath, "compile", "AndroidManifest.xml");
            string stringsFilePath = Path.Combine(Application.StartupPath, "compile", "res", "values", "strings.xml");
            txtNamespace.Text = txtNamespace.Text.Trim();

            #region " validations "

            if (!File.Exists(androidManifestFilePath))
            {
                General.Mes(string.Format("Can't find {0}, operation aborted", androidManifestFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            if (!File.Exists(stringsFilePath))
            {
                General.Mes(string.Format("Can't find {0}, operation aborted", stringsFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            #endregion

            ///// AndroidManifest.xml [start]
            string g = File.ReadAllText(androidManifestFilePath);
            g = g.Replace("{namespace}", txtNamespace.Text);
            g = g.Replace("{ver}", txtVersion.Value.ToString());

            if (chSplash.Checked)
                g = g.Replace("{splashscreen}", html2apk.Properties.Resources.Splashscreen);
            else
                g = g.Replace("{splashscreen}", html2apk.Properties.Resources.MainActivity);


            //mainactivity + splashscreenactivity
            g = g.Replace("{orientation}", cmbOrientation.Text);
            File.WriteAllText(androidManifestFilePath, g);
            //

            ///// strings.xml
            g = File.ReadAllText(stringsFilePath);
            g = g.Replace("{appname}", txtAppName.Text.Trim());
            File.WriteAllText(stringsFilePath, g);


            //replace namespace to smali files
            ReplaceAllSmaliNamespace();


            string assetsDir = Path.Combine(compilePath, "assets");

           if ( General.Mes(string.Format("Project successfully built! \n\n Copy your HTML files to {0} \n\n After use the 'Build PRJ' button to generate an APK\n\n Do you like to browse 'assets' folder ?", assetsDir),MessageBoxIcon.Information, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            Process.Start("explorer.exe", string.Format("/select,\"{0}\"", assetsDir));
        }

        internal void ReplaceAllSmaliNamespace()
        {
            string namespaceTXT = txtNamespace.Text.Replace(".", "/");
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "BuildConfig.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "MainActivity$1.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "MainActivity.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$attr.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$dimen.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$drawable.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$id.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$layout.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$menu.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$string.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R$style.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "R.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "SplashScreen$1.smali"), namespaceTXT);
            ReplaceSmaliNamespace(Path.Combine(Application.StartupPath, "compile", "smali", "SplashScreen.smali"), namespaceTXT);
        }

        internal void ReplaceSmaliNamespace(string filepath, string newNamespace)
        {
            string g = File.ReadAllText(filepath).Replace("com/pipiscrew/webview", newNamespace);
            File.WriteAllText(filepath, g);
        }

        internal static bool Compile(string exeFilepath, string args)
        {
            try
            {
                Process msbProcess = new Process();
                msbProcess.StartInfo.FileName = Path.GetFileName(exeFilepath);
                msbProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(exeFilepath);
                msbProcess.StartInfo.Arguments = args;

                msbProcess.Start();
                msbProcess.WaitForExit();

                if (msbProcess.ExitCode != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                General.Mes(ex.Message, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void btnBuildDirect_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(compilePath))
            {
                General.Mes("Please use the first button to build the files, operation aborted!", MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtNamespace.Text))
            {
                General.Mes("Please fill the namespace, operation aborted!", MessageBoxIcon.Exclamation);
                return;
            }

            //compile
            string apkFilePath = Path.Combine(Application.StartupPath, txtNamespace.Text + ".apk");
            if (File.Exists(apkFilePath))
            {
                General.Mes(string.Format("Can {0} already exists, operation aborted", apkFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            //apktool
            bool assemblyResult = Compile(javaFilePath, string.Format("-jar \"{0}\" b \"{1}\" --output \"{2}\"", apkToolFilePath, compilePath, apkFilePath));

            if (!assemblyResult)
            {
                General.Mes(string.Format("Something wrong APK is not assembled!", apkFilePath), MessageBoxIcon.Exclamation);
                return;
            }

            //sign
            bool signResult = Compile(javaFilePath, string.Format("-jar \"{0}\" -a \"{1}\"", signerFilePath, apkFilePath));

            if (!signResult)
            {
                General.Mes("APK is assembled but couldn't sign it!", MessageBoxIcon.Exclamation);
                return;
            }
            else
                General.Mes(string.Format("Please use the \n\n{0}-aligned-debugSigned.apk\n\nis near the application", txtNamespace.Text));
        }

    }
}
