namespace QuanLyXepLichThi
{
    partial class LoginForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButtonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Green;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.Red;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Controls.Add(this.simpleButtonLogin);
            this.panelControl1.Controls.Add(this.textEditPassword);
            this.panelControl1.Controls.Add(this.textEditUsername);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(133, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(430, 208);
            this.panelControl1.TabIndex = 2;
            // 
            // simpleButtonLogin
            // 
            this.simpleButtonLogin.Location = new System.Drawing.Point(178, 159);
            this.simpleButtonLogin.Name = "simpleButtonLogin";
            this.simpleButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonLogin.TabIndex = 5;
            this.simpleButtonLogin.Text = "Login";
            this.simpleButtonLogin.Click += new System.EventHandler(this.SimpleButtonLogin_Click);
            // 
            // textEditPassword
            // 
            this.textEditPassword.EditValue = "1";
            this.textEditPassword.Location = new System.Drawing.Point(77, 133);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.NullValuePrompt = "Password";
            this.textEditPassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditPassword.Properties.PasswordChar = '*';
            this.textEditPassword.Properties.ShowNullValuePromptWhenFocused = true;
            this.textEditPassword.Size = new System.Drawing.Size(275, 20);
            this.textEditPassword.TabIndex = 4;
            // 
            // textEditUsername
            // 
            this.textEditUsername.EditValue = "1";
            this.textEditUsername.Location = new System.Drawing.Point(77, 94);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Properties.NullValuePrompt = "Username";
            this.textEditUsername.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEditUsername.Properties.ShowNullValuePromptWhenFocused = true;
            this.textEditUsername.Size = new System.Drawing.Size(275, 20);
            this.textEditUsername.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(154, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 25);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Admin Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(675, 301);
            this.Controls.Add(this.panelControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLogin;
    }
}

