namespace YourNamespace
{
    partial class MainForm
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
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtReqBody = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(666, 41);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(494, 548);
            this.txtResponse.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(95, 16);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(459, 32);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://localhost:8000/products";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(571, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PATCH",
            "PUT",
            "DELETE"});
            this.cbMethod.Location = new System.Drawing.Point(12, 22);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(73, 21);
            this.cbMethod.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(884, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "label1";
            // 
            // txtReqBody
            // 
            this.txtReqBody.Location = new System.Drawing.Point(12, 105);
            this.txtReqBody.Multiline = true;
            this.txtReqBody.Name = "txtReqBody";
            this.txtReqBody.Size = new System.Drawing.Size(542, 304);
            this.txtReqBody.TabIndex = 6;
            this.txtReqBody.Text = " {\r\n        \"name\": \"newItem\",\r\n        \"InStock\": true\r\n    }";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 601);
            this.Controls.Add(this.txtReqBody);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtResponse);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtReqBody;
    }
}

