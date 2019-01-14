namespace VnpApp
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblUserFind = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.cboUserFind = new System.Windows.Forms.ListBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(570, 177);
            this.webBrowser1.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 200);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Thời Gian";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(78, 197);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 14;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(413, 195);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(298, 196);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 23);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Tra Trong Kho";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(196, 196);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblUserFind
            // 
            this.lblUserFind.AutoSize = true;
            this.lblUserFind.Location = new System.Drawing.Point(507, 204);
            this.lblUserFind.Name = "lblUserFind";
            this.lblUserFind.Size = new System.Drawing.Size(0, 13);
            this.lblUserFind.TabIndex = 20;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(22, 231);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(563, 199);
            this.webBrowser2.TabIndex = 21;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(614, 95);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUser.TabIndex = 26;
            this.btnSaveUser.Text = "Save user";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // cboUserFind
            // 
            this.cboUserFind.FormattingEnabled = true;
            this.cboUserFind.Location = new System.Drawing.Point(601, 140);
            this.cboUserFind.Name = "cboUserFind";
            this.cboUserFind.Size = new System.Drawing.Size(100, 290);
            this.cboUserFind.TabIndex = 25;
            this.cboUserFind.SelectedIndexChanged += new System.EventHandler(this.cboUserFind_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(614, 66);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(601, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(601, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(720, 170);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(442, 260);
            this.webBrowser3.TabIndex = 27;
            this.webBrowser3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_DocumentCompleted);
            // 
            // webBrowser4
            // 
            this.webBrowser4.Location = new System.Drawing.Point(22, 231);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(563, 199);
            this.webBrowser4.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 447);
            this.Controls.Add(this.webBrowser4);
            this.Controls.Add(this.webBrowser3);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.cboUserFind);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.lblUserFind);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblUserFind;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.ListBox cboUserFind;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
    }
}

