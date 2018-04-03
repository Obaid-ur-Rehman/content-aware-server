namespace Content_Aware_Server
{
    partial class notification_modify
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
            this.tbNotiID = new System.Windows.Forms.TextBox();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.gbServerDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNotiDesc = new System.Windows.Forms.TextBox();
            this.btnDeleteNoti = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.gbServerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter ID";
            // 
            // tbNotiID
            // 
            this.tbNotiID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotiID.Location = new System.Drawing.Point(215, 42);
            this.tbNotiID.Name = "tbNotiID";
            this.tbNotiID.Size = new System.Drawing.Size(453, 34);
            this.tbNotiID.TabIndex = 6;
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.Location = new System.Drawing.Point(705, 14);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(116, 99);
            this.btnGetDetails.TabIndex = 5;
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click);
            // 
            // gbServerDetails
            // 
            this.gbServerDetails.Controls.Add(this.label3);
            this.gbServerDetails.Controls.Add(this.tbNotiDesc);
            this.gbServerDetails.Controls.Add(this.btnDeleteNoti);
            this.gbServerDetails.Controls.Add(this.btnClose);
            this.gbServerDetails.Controls.Add(this.btnUpdateDetails);
            this.gbServerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServerDetails.Location = new System.Drawing.Point(16, 119);
            this.gbServerDetails.Name = "gbServerDetails";
            this.gbServerDetails.Size = new System.Drawing.Size(811, 397);
            this.gbServerDetails.TabIndex = 4;
            this.gbServerDetails.TabStop = false;
            this.gbServerDetails.Text = "Enter Server Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // tbNotiDesc
            // 
            this.tbNotiDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotiDesc.Location = new System.Drawing.Point(199, 60);
            this.tbNotiDesc.Multiline = true;
            this.tbNotiDesc.Name = "tbNotiDesc";
            this.tbNotiDesc.Size = new System.Drawing.Size(453, 317);
            this.tbNotiDesc.TabIndex = 5;
            // 
            // btnDeleteNoti
            // 
            this.btnDeleteNoti.Location = new System.Drawing.Point(658, 60);
            this.btnDeleteNoti.Name = "btnDeleteNoti";
            this.btnDeleteNoti.Size = new System.Drawing.Size(147, 107);
            this.btnDeleteNoti.TabIndex = 3;
            this.btnDeleteNoti.Text = "Delete Notification";
            this.btnDeleteNoti.UseVisualStyleBackColor = true;
            this.btnDeleteNoti.Click += new System.EventHandler(this.btnDeleteNoti_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(658, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 99);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(658, 173);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(147, 99);
            this.btnUpdateDetails.TabIndex = 1;
            this.btnUpdateDetails.Text = "Update Notification";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // notification_modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 528);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNotiID);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.gbServerDetails);
            this.Name = "notification_modify";
            this.Text = "notification_modify";
            this.gbServerDetails.ResumeLayout(false);
            this.gbServerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNotiID;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.GroupBox gbServerDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNotiDesc;
        private System.Windows.Forms.Button btnDeleteNoti;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateDetails;
    }
}