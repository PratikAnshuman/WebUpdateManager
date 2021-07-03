using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using Renci.SshNet;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp;

namespace WebUpdateManager
{
    public class sftpConnect
    {
        String Host = "192.168.43.198";
        int Port = 22;
        String Username = "tester";
        String Password = "password";
        string localPath = @"F:\DemoProject";
        string remotepath = @"/VersionUpdate";
        public SftpClient sftpClient;

        public delegate void updatePopulationStatus(DataTable dtUpdate);

        public sftpConnect()
        {
            sftpClient = new SftpClient(Host, Port, Username, Password);
        }
        public void listAvailableVersions( )
        {
            DataTable dtVersion = new DataTable();
            dtVersion.Columns.Add("SL");
            dtVersion.Columns.Add("VERSION");
            dtVersion.Columns.Add("DATE");
            using (var sftp = new SftpClient(Host, Port, Username, Password))
            {
                sftp.Connect();
                var filePaths = sftp.ListDirectory(remotepath);
                sftp.Disconnect();

                int cntr = 1;
                foreach (SftpFile sftpFile in filePaths)
                {
                    //if (sftpFile.Name.StartsWith('.')) { continue; }
                    if (sftpFile.IsDirectory) continue;
                    else
                    {
                        DataRow drRow = dtVersion.NewRow();
                        drRow["SL"] = cntr;
                        drRow["VERSION"] = (sftpFile.Name);
                        drRow["DATE"] = (sftpFile.LastWriteTime.ToString("dd/MM/yyyy"));
                        dtVersion.Rows.Add(drRow);
                        cntr++;
                    }
                }

                updatePopulation(dtVersion);
            }
        }

        public event updatePopulationStatus updatePopulation = delegate {

        };

    }
}
