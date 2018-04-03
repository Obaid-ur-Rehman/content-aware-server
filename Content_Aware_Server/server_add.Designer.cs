namespace Content_Aware_Server
{
    partial class server_add
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
            this.btnAddServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerDesc = new System.Windows.Forms.TextBox();
            this.txtMACAddress = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btnCloseServerAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(121, 245);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(127, 43);
            this.btnAddServer.TabIndex = 0;
            this.btnAddServer.Text = "Add Department";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MAC Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department";
            // 
            // txtServerDesc
            // 
            this.txtServerDesc.Location = new System.Drawing.Point(121, 97);
            this.txtServerDesc.Multiline = true;
            this.txtServerDesc.Name = "txtServerDesc";
            this.txtServerDesc.Size = new System.Drawing.Size(260, 130);
            this.txtServerDesc.TabIndex = 4;
            // 
            // txtMACAddress
            // 
            this.txtMACAddress.Location = new System.Drawing.Point(121, 55);
            this.txtMACAddress.Name = "txtMACAddress";
            this.txtMACAddress.Size = new System.Drawing.Size(260, 22);
            this.txtMACAddress.TabIndex = 5;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(121, 15);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(260, 22);
            this.txtServerName.TabIndex = 6;
            // 
            // btnCloseServerAdd
            // 
            this.btnCloseServerAdd.Location = new System.Drawing.Point(254, 245);
            this.btnCloseServerAdd.Name = "btnCloseServerAdd";
            this.btnCloseServerAdd.Size = new System.Drawing.Size(127, 43);
            this.btnCloseServerAdd.TabIndex = 7;
            this.btnCloseServerAdd.Text = "Close";
            this.btnCloseServerAdd.UseVisualStyleBackColor = true;
            this.btnCloseServerAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // server_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 363);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseServerAdd);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.txtMACAddress);
            this.Controls.Add(this.txtServerDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "server_add";
            this.Text = "Add new Department";
            this.Load += new System.EventHandler(this.server_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerDesc;
        private System.Windows.Forms.TextBox txtMACAddress;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btnCloseServerAdd;
    }
}