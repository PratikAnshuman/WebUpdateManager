using Renci.SshNet;
using Renci.SshNet.Sftp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace WebUpdateManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string version = File.ReadAllText(@"F:\DemoProject\versioninfo.txt");
            lblCurrversionVal.Text = version;
            localVersion = new Version(version);
            dtVersion.Columns.Add("SL");
            dtVersion.Columns.Add("VERSION");
            dtVersion.Columns.Add("DATE");
            populateVersion();
            sftp.updatePopulation += new sftpConnect.updatePopulationStatus(updatePopulationStatus);
        }

        Version localVersion = new Version("0.0.0");
        sftpConnect sftp = new sftpConnect();
        DataTable dtVersion = new DataTable();
        string projectDirectory = @"DemoProject";
        string localPath = @"F:\DemoProject";
        string remotepath = @"/VersionUpdate";
        string localBackupPath = @"F:\Backup";

        private void populateVersion()
        {

            Thread t = new Thread(new ThreadStart(sftp.listAvailableVersions));
            t.Start();            
        }

        void updatePopulationStatus(DataTable dtUpdate)
        {
            dtVersion = dtUpdate;
            if (dtVersion != null && dtVersion.Rows.Count > 0) dataGridView1.Invoke(new Action(() => dataGridView1.DataSource = dtVersion));
        }

        private List<String> getVersionList()
        {
            List<string> versions = new List<string>();
            foreach (DataRow drRow in dtVersion.Select())
            {
                var serverVersion = new Version(drRow["VERSION"].ToString().Replace(".zip", ""));
                var result = serverVersion.CompareTo(localVersion);
                if (result > 0) versions.Add(drRow["VERSION"].ToString());
            }
            return versions;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            takebackup();
            Download();
            installUpdates();
        }

        private void takebackup()
        {
            if (checkBox1.Checked)
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = Path.Combine(Environment.SystemDirectory, "xcopy.exe");
                proc.StartInfo.Arguments = localPath + " " + Path.Combine(localBackupPath, localVersion.ToString(), projectDirectory) + @"  /E /H /C /I /Y";
                proc.Start();
            }
        }

        private void Download()
        {
            try
            {
                var client = sftp.sftpClient;
                client.Connect();
                foreach (var file in getVersionList())
                {

                    string TargetPath = Path.Combine(localPath, file);
                    string SourcePath = Path.Combine(remotepath, file);
                    using (var stream = new FileStream(TargetPath, FileMode.Create))
                    {
                        SftpFileAttributes attrs = client.GetAttributes(SourcePath);
                        // Set progress bar maximum on foreground thread
                        int max = (int)attrs.Size;
                        progressBar1.Invoke(
                            (MethodInvoker)delegate { progressBar1.Maximum = max; });
                        // Download with progress callback
                        client.DownloadFile(SourcePath, stream, DownloadProgresBar);
                        //MessageBox.Show("Download complete");
                    }
                }
                client.Disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DownloadProgresBar(ulong uploaded)
        {
            // Update progress bar on foreground thread
            progressBar1.Invoke(
                (MethodInvoker)delegate { progressBar1.Value = (int)uploaded; });
        }

        private void installUpdates()
        {
            List<string> versions = getVersionList();
            foreach (string file in versions)
            {
                ZipFile.ExtractToDirectory(Path.Combine(localPath, file), Path.Combine(localPath, file.Replace(".zip", "")), true);
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = Path.Combine(Environment.SystemDirectory, "xcopy.exe");
                proc.StartInfo.Arguments = Path.Combine(localPath, file.Replace(".zip", "")) + " " + localPath + @"  /E /H /C /I /Y";
                if(proc.Start())
                {
                    deletResidue(Path.Combine(localPath, file));
                }
            }
        }

        private void deletResidue(string path)
        {
            System.IO.Directory.Delete(path, true);
            System.IO.Directory.Delete(path.Replace(".zip", ""), true);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName.Equals("VERSION"))
            {
                if (e.Value == null) return;
                e.Value = e.Value.ToString().Replace(".zip", "");
            }
        }
    }
}
