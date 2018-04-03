namespace Content_Aware_Server
{
    partial class server_view
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgServers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.serverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgServers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(705, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 126);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(705, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 126);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(705, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(136, 126);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgServers
            // 
            this.dgServers.AllowUserToAddRows = false;
            this.dgServers.AllowUserToDeleteRows = false;
            this.dgServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serverID,
            this.serverName,
            this.serverDescription});
            this.dgServers.Location = new System.Drawing.Point(12, 40);
            this.dgServers.Name = "dgServers";
            this.dgServers.RowTemplate.Height = 24;
            this.dgServers.Size = new System.Drawing.Size(677, 362);
            this.dgServers.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servers List";
            // 
            // serverID
            // 
            this.serverID.HeaderText = "Server MAC";
            this.serverID.Name = "serverID";
            // 
            // serverName
            // 
            this.serverName.HeaderText = "Name";
            this.serverName.Name = "serverName";
            // 
            // serverDescription
            // 
            this.serverDescription.HeaderText = "Description";
            this.serverDescription.Name = "serverDescription";
            // 
            // server_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgServers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Name = "server_view";
            this.Text = "server_view";
            this.Load += new System.EventHandler(this.server_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgServers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverDescription;
    }
}