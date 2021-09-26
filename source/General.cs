using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace html2apk
{
    public static class General
    {
        internal static string javaFilePath = General.GetFullPathFromWindows("java.exe");
        internal static string signerFilePath = Path.Combine(Application.StartupPath, "tools", "uber-apk-signer-0.2.0.jar");

        //Check if EXE exists to environment path
        public static string GetFullPathFromWindows(string exeName)
        { //https://try2explore.com/questions/10229289
            if (exeName.Length >= MAX_PATH)
                throw new ArgumentException(string.Format("The executable name '{0}' must have less than {MAX_PATH} characters.", exeName));

            StringBuilder sb = new StringBuilder(exeName, MAX_PATH);
            return PathFindOnPath(sb, null) ? sb.ToString() : null;
        }

        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        static extern bool PathFindOnPath([In, Out] StringBuilder pszFile, [In] string[] ppszOtherDirs);

        private const int MAX_PATH = 260;
        //

        //Placeholder for textboxes
        public const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        //

        public static DialogResult Mes(string descr, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxButtons butt = MessageBoxButtons.OK)
        {
            if (descr.Length > 0)
                return MessageBox.Show(descr, Application.ProductName, butt, icon);
            else
                return DialogResult.OK;
        }

        internal static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {   //https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        internal static bool Run(string exeFilepath, string args)
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

    }
}
