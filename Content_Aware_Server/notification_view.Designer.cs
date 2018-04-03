namespace Content_Aware_Server
{
    partial class notification_view
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgNotifications = new System.Windows.Forms.DataGridView();
            this.serverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Servers List";
            // 
            // dgNotifications
            // 
            this.dgNotifications.AllowUserToAddRows = false;
            this.dgNotifications.AllowUserToDeleteRows = false;
            this.dgNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNotifications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverID,
            this.serverName,
            this.serverDescription,
            this.time});
            this.dgNotifications.Location = new System.Drawing.Point(12, 43);
            this.dgNotifications.Name = "dgNotifications";
            this.dgNotifications.ReadOnly = true;
            this.dgNotifications.RowTemplate.Height = 24;
            this.dgNotifications.Size = new System.Drawing.Size(677, 362);
            this.dgNotifications.TabIndex = 8;
            // 
            // serverID
            // 
            this.serverID.HeaderText = "Notification ID";
            this.serverID.Name = "serverID";
            this.serverID.ReadOnly = true;
            // 
            // serverName
            // 
            this.serverName.HeaderText = "Server ID";
            this.serverName.Name = "serverName";
            this.serverName.ReadOnly = true;
            // 
            // serverDescription
            // 
            this.serverDescription.HeaderText = "Description";
            this.serverDescription.Name = "serverDescription";
            this.serverDescription.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(705, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 126);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(705, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 126);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(705, 279);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 126);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // notification_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgNotifications);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Name = "notification_view";
            this.Text = "notification_view";
            this.Load += new System.EventHandler(this.notification_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgNotifications;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}