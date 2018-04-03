namespace Content_Aware_Server
{
    partial class server_modify
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
            this.gbServerDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServerDesc = new System.Windows.Forms.TextBox();
            this.tbServerName = new System.Windows.Forms.TextBox();
            this.btnDeleteServer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.tbServerMAC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbServerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbServerDetails
            // 
            this.gbServerDetails.Controls.Add(this.label3);
            this.gbServerDetails.Controls.Add(this.label2);
            this.gbServerDetails.Controls.Add(this.tbServerDesc);
            this.gbServerDetails.Controls.Add(this.tbServerName);
            this.gbServerDetails.Controls.Add(this.btnDeleteServer);
            this.gbServerDetails.Controls.Add(this.btnClose);
            this.gbServerDetails.Controls.Add(this.btnUpdateDetails);
            this.gbServerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServerDetails.Location = new System.Drawing.Point(12, 117);
            this.gbServerDetails.Name = "gbServerDetails";
            this.gbServerDetails.Size = new System.Drawing.Size(811, 397);
            this.gbServerDetails.TabIndex = 0;
            this.gbServerDetails.TabStop = false;
            this.gbServerDetails.Text = "Enter Server Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // tbServerDesc
            // 
            this.tbServerDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServerDesc.Location = new System.Drawing.Point(199, 115);
            this.tbServerDesc.Multiline = true;
            this.tbServerDesc.Name = "tbServerDesc";
            this.tbServerDesc.Size = new System.Drawing.Size(453, 262);
            this.tbServerDesc.TabIndex = 5;
            // 
            // tbServerName
            // 
            this.tbServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServerName.Location = new System.Drawing.Point(199, 60);
            this.tbServerName.Name = "tbServerName";
            this.tbServerName.Size = new System.Drawing.Size(453, 38);
            this.tbServerName.TabIndex = 4;
            // 
            // btnDeleteServer
            // 
            this.btnDeleteServer.Location = new System.Drawing.Point(689, 60);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(116, 107);
            this.btnDeleteServer.TabIndex = 3;
            this.btnDeleteServer.Text = "Delete Server";
            this.btnDeleteServer.UseVisualStyleBackColor = true;
            this.btnDeleteServer.Click += new System.EventHandler(this.btnDeleteServer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(689, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 99);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(689, 173);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(116, 99);
            this.btnUpdateDetails.TabIndex = 1;
            this.btnUpdateDetails.Text = "Update Server";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.Location = new System.Drawing.Point(701, 12);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(116, 99);
            this.btnGetDetails.TabIndex = 1;
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // tbServerMAC
            // 
            this.tbServerMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbServerMAC.Location = new System.Drawing.Point(211, 40);
            this.tbServerMAC.Name = "tbServerMAC";
            this.tbServerMAC.Size = new System.Drawing.Size(453, 34);
            this.tbServerMAC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter MAC";
            // 
            // server_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbServerMAC);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.gbServerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "server_modify";
            this.Text = "Modify Server";
            this.Load += new System.EventHandler(this.server_modify_Load);
            this.gbServerDetails.ResumeLayout(false);
            this.gbServerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbServerDetails;
        private System.Windows.Forms.Button btnDeleteServer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.TextBox tbServerMAC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbServerDesc;
        private System.Windows.Forms.TextBox tbServerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}