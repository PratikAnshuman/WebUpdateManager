
namespace WebUpdateManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grdColSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurrVersionCap = new System.Windows.Forms.Label();
            this.lblCurrversionVal = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(110, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Version";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grdColSerial,
            this.grdColVersion,
            this.grdColDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(775, 305);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // grdColSerial
            // 
            this.grdColSerial.DataPropertyName = "SL";
            this.grdColSerial.HeaderText = "Sl. ";
            this.grdColSerial.Name = "grdColSerial";
            this.grdColSerial.ReadOnly = true;
            // 
            // grdColVersion
            // 
            this.grdColVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdColVersion.DataPropertyName = "VERSION";
            this.grdColVersion.HeaderText = "Version";
            this.grdColVersion.Name = "grdColVersion";
            this.grdColVersion.ReadOnly = true;
            // 
            // grdColDate
            // 
            this.grdColDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grdColDate.DataPropertyName = "DATE";
            this.grdColDate.HeaderText = "Date";
            this.grdColDate.Name = "grdColDate";
            this.grdColDate.ReadOnly = true;
            // 
            // lblCurrVersionCap
            // 
            this.lblCurrVersionCap.AutoSize = true;
            this.lblCurrVersionCap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrVersionCap.Location = new System.Drawing.Point(12, 13);
            this.lblCurrVersionCap.Name = "lblCurrVersionCap";
            this.lblCurrVersionCap.Size = new System.Drawing.Size(92, 14);
            this.lblCurrVersionCap.TabIndex = 4;
            this.lblCurrVersionCap.Text = "Current Version";
            // 
            // lblCurrversionVal
            // 
            this.lblCurrversionVal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrversionVal.AutoSize = true;
            this.lblCurrversionVal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrversionVal.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrversionVal.Location = new System.Drawing.Point(110, 13);
            this.lblCurrversionVal.Name = "lblCurrversionVal";
            this.lblCurrversionVal.Size = new System.Drawing.Size(11, 14);
            this.lblCurrversionVal.TabIndex = 5;
            this.lblCurrversionVal.Text = " ";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(12, 389);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Take Backup";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.Location = new System.Drawing.Point(229, 391);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(11, 14);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblCurrversionVal);
            this.Controls.Add(this.lblCurrVersionCap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Version Update";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCurrVersionCap;
        private System.Windows.Forms.Label lblCurrversionVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn grdColDate;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblProgress;
    }
}

