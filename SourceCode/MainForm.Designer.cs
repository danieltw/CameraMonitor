namespace CameraMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.ddlVideoDevice = new System.Windows.Forms.ComboBox();
            this.RealTimeMonitor = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkTopMost = new System.Windows.Forms.CheckBox();
            this.labStatus = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealTimeMonitor)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.RealTimeMonitor, 0, 0);
            this.tlpMain.Controls.Add(this.btnPlayStop, 0, 1);
            this.tlpMain.Controls.Add(this.btnSnapshot, 1, 1);
            this.tlpMain.Controls.Add(this.ddlVideoDevice, 2, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.Size = new System.Drawing.Size(567, 355);
            this.tlpMain.TabIndex = 0;
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayStop.BackgroundImage = global::CameraMonitor.Properties.Resources.PLAY;
            this.btnPlayStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayStop.FlatAppearance.BorderSize = 0;
            this.btnPlayStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayStop.Location = new System.Drawing.Point(1, 320);
            this.btnPlayStop.Margin = new System.Windows.Forms.Padding(1);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(34, 34);
            this.btnPlayStop.TabIndex = 0;
            this.btnPlayStop.UseVisualStyleBackColor = false;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.BackgroundImage = global::CameraMonitor.Properties.Resources.PHOTO;
            this.btnSnapshot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSnapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSnapshot.FlatAppearance.BorderSize = 0;
            this.btnSnapshot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSnapshot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSnapshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnapshot.Location = new System.Drawing.Point(37, 320);
            this.btnSnapshot.Margin = new System.Windows.Forms.Padding(1);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(34, 34);
            this.btnSnapshot.TabIndex = 1;
            this.btnSnapshot.UseVisualStyleBackColor = true;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // ddlVideoDevice
            // 
            this.ddlVideoDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlVideoDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVideoDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlVideoDevice.Font = new System.Drawing.Font("新細明體", 10F);
            this.ddlVideoDevice.FormattingEnabled = true;
            this.ddlVideoDevice.Location = new System.Drawing.Point(73, 326);
            this.ddlVideoDevice.Margin = new System.Windows.Forms.Padding(1);
            this.ddlVideoDevice.Name = "ddlVideoDevice";
            this.ddlVideoDevice.Size = new System.Drawing.Size(493, 21);
            this.ddlVideoDevice.TabIndex = 3;
            // 
            // RealTimeMonitor
            // 
            this.RealTimeMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpMain.SetColumnSpan(this.RealTimeMonitor, 3);
            this.RealTimeMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RealTimeMonitor.Location = new System.Drawing.Point(3, 3);
            this.RealTimeMonitor.Name = "RealTimeMonitor";
            this.RealTimeMonitor.Size = new System.Drawing.Size(561, 313);
            this.RealTimeMonitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RealTimeMonitor.TabIndex = 4;
            this.RealTimeMonitor.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chkTopMost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labStatus, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 355);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(567, 21);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chkTopMost
            // 
            this.chkTopMost.AutoSize = true;
            this.chkTopMost.Location = new System.Drawing.Point(3, 3);
            this.chkTopMost.Name = "chkTopMost";
            this.chkTopMost.Size = new System.Drawing.Size(84, 15);
            this.chkTopMost.TabIndex = 0;
            this.chkTopMost.Text = "最上層顯示";
            this.chkTopMost.UseVisualStyleBackColor = true;
            this.chkTopMost.CheckedChanged += new System.EventHandler(this.chkTopMost_CheckedChanged);
            // 
            // labStatus
            // 
            this.labStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(103, 4);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(461, 12);
            this.labStatus.TabIndex = 1;
            this.labStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 376);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Video Monitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RealTimeMonitor)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.ComboBox ddlVideoDevice;
        private System.Windows.Forms.PictureBox RealTimeMonitor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox chkTopMost;
        private System.Windows.Forms.Label labStatus;
    }
}

