namespace winForms
{
    partial class loginForm
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
            LabelLogin = new Label();
            UserName = new TextBox();
            groupBoxLogin = new GroupBox();
            ButtonClear = new Button();
            ShowPassword = new CheckBox();
            ButtonLogin = new Button();
            Password = new TextBox();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // LabelLogin
            // 
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Tw Cen MT Condensed Extra Bold", 20F, FontStyle.Bold);
            LabelLogin.ForeColor = Color.Navy;
            LabelLogin.Location = new Point(226, 44);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(186, 48);
            LabelLogin.TabIndex = 0;
            LabelLogin.Text = "Connexion";
            // 
            // UserName
            // 
            UserName.BackColor = SystemColors.InactiveCaption;
            UserName.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserName.Location = new Point(112, 119);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Nom d'utilisateur";
            UserName.Size = new Size(436, 46);
            UserName.TabIndex = 1;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxLogin.Controls.Add(ButtonClear);
            groupBoxLogin.Controls.Add(ShowPassword);
            groupBoxLogin.Controls.Add(ButtonLogin);
            groupBoxLogin.Controls.Add(Password);
            groupBoxLogin.Controls.Add(UserName);
            groupBoxLogin.Controls.Add(LabelLogin);
            groupBoxLogin.Location = new Point(50, 23);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(655, 427);
            groupBoxLogin.TabIndex = 2;
            groupBoxLogin.TabStop = false;
            // 
            // ButtonClear
            // 
            ButtonClear.BackColor = Color.IndianRed;
            ButtonClear.Cursor = Cursors.Hand;
            ButtonClear.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonClear.ForeColor = Color.Navy;
            ButtonClear.Location = new Point(112, 354);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(436, 46);
            ButtonClear.TabIndex = 5;
            ButtonClear.Text = "Effacer";
            ButtonClear.UseVisualStyleBackColor = false;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Location = new Point(112, 240);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(230, 29);
            ShowPassword.TabIndex = 4;
            ShowPassword.Text = "Afficher le mot de passe";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.LightGreen;
            ButtonLogin.Cursor = Cursors.Hand;
            ButtonLogin.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonLogin.ForeColor = Color.Navy;
            ButtonLogin.Location = new Point(112, 288);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(436, 51);
            ButtonLogin.TabIndex = 3;
            ButtonLogin.Text = "Connexion";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // Password
            // 
            Password.BackColor = SystemColors.InactiveCaption;
            Password.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(112, 188);
            Password.MaxLength = 5;
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Mot de passe";
            Password.Size = new Size(436, 46);
            Password.TabIndex = 2;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 495);
            Controls.Add(groupBoxLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "loginForm";
            Text = "Connexion";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelLogin;
        private TextBox UserName;
        private GroupBox groupBoxLogin;
        private TextBox Password;
        private Button ButtonLogin;
        private CheckBox ShowPassword;
        private Button ButtonClear;
    }
}