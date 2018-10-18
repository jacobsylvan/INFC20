namespace GymShark
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
            this.panelRegister = new System.Windows.Forms.Panel();
            this.lblCheckAccount = new System.Windows.Forms.Label();
            this.lblLoginRegister = new System.Windows.Forms.Button();
            this.lblRegisterPhoneNumber = new System.Windows.Forms.Label();
            this.btnRegisterCompleted = new System.Windows.Forms.Button();
            this.txtInputPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtInputEmail = new System.Windows.Forms.TextBox();
            this.txtInputSsn = new System.Windows.Forms.TextBox();
            this.txtInputLastName = new System.Windows.Forms.TextBox();
            this.txtInputFirstName = new System.Windows.Forms.TextBox();
            this.txtInputPassword2 = new System.Windows.Forms.TextBox();
            this.txtInputUsername2 = new System.Windows.Forms.TextBox();
            this.lblRegisterEmail = new System.Windows.Forms.Label();
            this.lblRegisterSsnHelp = new System.Windows.Forms.Label();
            this.lblRegisterSsn = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRegisterFirstName = new System.Windows.Forms.Label();
            this.lblRegisterPassword = new System.Windows.Forms.Label();
            this.lblRegisterUsername = new System.Windows.Forms.Label();
            this.lblHem = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtInputUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtInputPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelLoggedIn = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.lblProfilPhone = new System.Windows.Forms.Label();
            this.lblProfilEmail = new System.Windows.Forms.Label();
            this.lblProfilSsn = new System.Windows.Forms.Label();
            this.lblProfilName = new System.Windows.Forms.Label();
            this.lblMinProfil = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.tabBooking = new System.Windows.Forms.TabControl();
            this.tabBookSession = new System.Windows.Forms.TabPage();
            this.listSessions = new System.Windows.Forms.DataGridView();
            this.btnBookSession = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabMySessions = new System.Windows.Forms.TabPage();
            this.listMySessions = new System.Windows.Forms.DataGridView();
            this.btnCancelSession = new System.Windows.Forms.Button();
            this.panelRegister.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelLoggedIn.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.tabBookSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSessions)).BeginInit();
            this.tabMySessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMySessions)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegister
            // 
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegister.Controls.Add(this.lblCheckAccount);
            this.panelRegister.Controls.Add(this.lblLoginRegister);
            this.panelRegister.Controls.Add(this.lblRegisterPhoneNumber);
            this.panelRegister.Controls.Add(this.btnRegisterCompleted);
            this.panelRegister.Controls.Add(this.txtInputPhoneNumber);
            this.panelRegister.Controls.Add(this.txtInputEmail);
            this.panelRegister.Controls.Add(this.txtInputSsn);
            this.panelRegister.Controls.Add(this.txtInputLastName);
            this.panelRegister.Controls.Add(this.txtInputFirstName);
            this.panelRegister.Controls.Add(this.txtInputPassword2);
            this.panelRegister.Controls.Add(this.txtInputUsername2);
            this.panelRegister.Controls.Add(this.lblRegisterEmail);
            this.panelRegister.Controls.Add(this.lblRegisterSsnHelp);
            this.panelRegister.Controls.Add(this.lblRegisterSsn);
            this.panelRegister.Controls.Add(this.lblLastName);
            this.panelRegister.Controls.Add(this.lblRegisterFirstName);
            this.panelRegister.Controls.Add(this.lblRegisterPassword);
            this.panelRegister.Controls.Add(this.lblRegisterUsername);
            this.panelRegister.Location = new System.Drawing.Point(18, 63);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(520, 440);
            this.panelRegister.TabIndex = 14;
            this.panelRegister.Visible = false;
            // 
            // lblCheckAccount
            // 
            this.lblCheckAccount.AutoSize = true;
            this.lblCheckAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAccount.Location = new System.Drawing.Point(296, 366);
            this.lblCheckAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckAccount.Name = "lblCheckAccount";
            this.lblCheckAccount.Size = new System.Drawing.Size(208, 20);
            this.lblCheckAccount.TabIndex = 17;
            this.lblCheckAccount.Text = "Har du redan ett konto?";
            // 
            // lblLoginRegister
            // 
            this.lblLoginRegister.Location = new System.Drawing.Point(346, 391);
            this.lblLoginRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblLoginRegister.Name = "lblLoginRegister";
            this.lblLoginRegister.Size = new System.Drawing.Size(128, 40);
            this.lblLoginRegister.TabIndex = 16;
            this.lblLoginRegister.Text = "Logga in";
            this.lblLoginRegister.UseVisualStyleBackColor = true;
            this.lblLoginRegister.Click += new System.EventHandler(this.lblLogin2_Click);
            // 
            // lblRegisterPhoneNumber
            // 
            this.lblRegisterPhoneNumber.AutoSize = true;
            this.lblRegisterPhoneNumber.Location = new System.Drawing.Point(8, 294);
            this.lblRegisterPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterPhoneNumber.Name = "lblRegisterPhoneNumber";
            this.lblRegisterPhoneNumber.Size = new System.Drawing.Size(50, 20);
            this.lblRegisterPhoneNumber.TabIndex = 15;
            this.lblRegisterPhoneNumber.Text = "Mobil:";
            // 
            // btnRegisterCompleted
            // 
            this.btnRegisterCompleted.Location = new System.Drawing.Point(124, 329);
            this.btnRegisterCompleted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegisterCompleted.Name = "btnRegisterCompleted";
            this.btnRegisterCompleted.Size = new System.Drawing.Size(150, 35);
            this.btnRegisterCompleted.TabIndex = 14;
            this.btnRegisterCompleted.Text = "Registrera";
            this.btnRegisterCompleted.UseVisualStyleBackColor = true;
            this.btnRegisterCompleted.Click += new System.EventHandler(this.btnRegisterCompleted_Click);
            // 
            // txtInputPhoneNumber
            // 
            this.txtInputPhoneNumber.Location = new System.Drawing.Point(124, 289);
            this.txtInputPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputPhoneNumber.Name = "txtInputPhoneNumber";
            this.txtInputPhoneNumber.Size = new System.Drawing.Size(148, 26);
            this.txtInputPhoneNumber.TabIndex = 13;
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.Location = new System.Drawing.Point(124, 249);
            this.txtInputEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.Size = new System.Drawing.Size(148, 26);
            this.txtInputEmail.TabIndex = 12;
            // 
            // txtInputSsn
            // 
            this.txtInputSsn.Location = new System.Drawing.Point(124, 209);
            this.txtInputSsn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputSsn.Name = "txtInputSsn";
            this.txtInputSsn.Size = new System.Drawing.Size(148, 26);
            this.txtInputSsn.TabIndex = 11;
            // 
            // txtInputLastName
            // 
            this.txtInputLastName.Location = new System.Drawing.Point(124, 169);
            this.txtInputLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputLastName.Name = "txtInputLastName";
            this.txtInputLastName.Size = new System.Drawing.Size(148, 26);
            this.txtInputLastName.TabIndex = 10;
            // 
            // txtInputFirstName
            // 
            this.txtInputFirstName.Location = new System.Drawing.Point(124, 129);
            this.txtInputFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputFirstName.Name = "txtInputFirstName";
            this.txtInputFirstName.Size = new System.Drawing.Size(148, 26);
            this.txtInputFirstName.TabIndex = 9;
            // 
            // txtInputPassword2
            // 
            this.txtInputPassword2.Location = new System.Drawing.Point(124, 89);
            this.txtInputPassword2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputPassword2.Name = "txtInputPassword2";
            this.txtInputPassword2.Size = new System.Drawing.Size(148, 26);
            this.txtInputPassword2.TabIndex = 8;
            this.txtInputPassword2.UseSystemPasswordChar = true;
            // 
            // txtInputUsername2
            // 
            this.txtInputUsername2.Location = new System.Drawing.Point(124, 49);
            this.txtInputUsername2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputUsername2.Name = "txtInputUsername2";
            this.txtInputUsername2.Size = new System.Drawing.Size(148, 26);
            this.txtInputUsername2.TabIndex = 7;
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Location = new System.Drawing.Point(8, 254);
            this.lblRegisterEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(52, 20);
            this.lblRegisterEmail.TabIndex = 6;
            this.lblRegisterEmail.Text = "Email:";
            // 
            // lblRegisterSsnHelp
            // 
            this.lblRegisterSsnHelp.AutoSize = true;
            this.lblRegisterSsnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterSsnHelp.Location = new System.Drawing.Point(296, 214);
            this.lblRegisterSsnHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterSsnHelp.Name = "lblRegisterSsnHelp";
            this.lblRegisterSsnHelp.Size = new System.Drawing.Size(100, 20);
            this.lblRegisterSsnHelp.TabIndex = 5;
            this.lblRegisterSsnHelp.Text = "(10 siffror)";
            // 
            // lblRegisterSsn
            // 
            this.lblRegisterSsn.AutoSize = true;
            this.lblRegisterSsn.Location = new System.Drawing.Point(8, 214);
            this.lblRegisterSsn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterSsn.Name = "lblRegisterSsn";
            this.lblRegisterSsn.Size = new System.Drawing.Size(121, 20);
            this.lblRegisterSsn.TabIndex = 4;
            this.lblRegisterSsn.Text = "Personnummer:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 174);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 20);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Efternamn:";
            // 
            // lblRegisterFirstName
            // 
            this.lblRegisterFirstName.AutoSize = true;
            this.lblRegisterFirstName.Location = new System.Drawing.Point(8, 134);
            this.lblRegisterFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterFirstName.Name = "lblRegisterFirstName";
            this.lblRegisterFirstName.Size = new System.Drawing.Size(77, 20);
            this.lblRegisterFirstName.TabIndex = 2;
            this.lblRegisterFirstName.Text = "Förnamn:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(8, 94);
            this.lblRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(80, 20);
            this.lblRegisterPassword.TabIndex = 1;
            this.lblRegisterPassword.Text = "Lösenord:";
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Location = new System.Drawing.Point(8, 54);
            this.lblRegisterUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(121, 20);
            this.lblRegisterUsername.TabIndex = 0;
            this.lblRegisterUsername.Text = "Användarnamn:";
            // 
            // lblHem
            // 
            this.lblHem.AutoSize = true;
            this.lblHem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHem.Location = new System.Drawing.Point(10, 14);
            this.lblHem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHem.Name = "lblHem";
            this.lblHem.Size = new System.Drawing.Size(165, 40);
            this.lblHem.TabIndex = 10;
            this.lblHem.Text = "Logga in:";
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.btnRegister);
            this.panelLogin.Controls.Add(this.txtInputUsername);
            this.panelLogin.Controls.Add(this.lblUsername);
            this.panelLogin.Controls.Add(this.txtInputPassword);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Location = new System.Drawing.Point(18, 63);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(328, 230);
            this.panelLogin.TabIndex = 12;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(24, 120);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(112, 35);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtInputUsername
            // 
            this.txtInputUsername.Location = new System.Drawing.Point(146, 40);
            this.txtInputUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Size = new System.Drawing.Size(148, 26);
            this.txtInputUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 43);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 20);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Användarnamn:";
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Location = new System.Drawing.Point(146, 80);
            this.txtInputPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.Size = new System.Drawing.Size(148, 26);
            this.txtInputPassword.TabIndex = 8;
            this.txtInputPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(146, 120);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 35);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Logga in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 83);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Lösenord:";
            // 
            // panelLoggedIn
            // 
            this.panelLoggedIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoggedIn.Controls.Add(this.btnLogout);
            this.panelLoggedIn.Controls.Add(this.btnDeleteAccount);
            this.panelLoggedIn.Controls.Add(this.lblDeleteAccount);
            this.panelLoggedIn.Controls.Add(this.lblProfilPhone);
            this.panelLoggedIn.Controls.Add(this.lblProfilEmail);
            this.panelLoggedIn.Controls.Add(this.lblProfilSsn);
            this.panelLoggedIn.Controls.Add(this.lblProfilName);
            this.panelLoggedIn.Controls.Add(this.lblMinProfil);
            this.panelLoggedIn.Location = new System.Drawing.Point(722, 14);
            this.panelLoggedIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLoggedIn.Name = "panelLoggedIn";
            this.panelLoggedIn.Size = new System.Drawing.Size(328, 556);
            this.panelLoggedIn.TabIndex = 16;
            this.panelLoggedIn.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(10, 211);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 32);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logga ut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(183, 512);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(112, 35);
            this.btnDeleteAccount.TabIndex = 17;
            this.btnDeleteAccount.Text = "Radera";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.Location = new System.Drawing.Point(4, 520);
            this.lblDeleteAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(163, 20);
            this.lblDeleteAccount.TabIndex = 16;
            this.lblDeleteAccount.Text = "Radera ditt konto?";
            // 
            // lblProfilPhone
            // 
            this.lblProfilPhone.AutoSize = true;
            this.lblProfilPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPhone.Location = new System.Drawing.Point(8, 177);
            this.lblProfilPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfilPhone.Name = "lblProfilPhone";
            this.lblProfilPhone.Size = new System.Drawing.Size(60, 20);
            this.lblProfilPhone.TabIndex = 15;
            this.lblProfilPhone.Text = "Mobil:";
            // 
            // lblProfilEmail
            // 
            this.lblProfilEmail.AutoSize = true;
            this.lblProfilEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilEmail.Location = new System.Drawing.Point(8, 138);
            this.lblProfilEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfilEmail.Name = "lblProfilEmail";
            this.lblProfilEmail.Size = new System.Drawing.Size(56, 20);
            this.lblProfilEmail.TabIndex = 14;
            this.lblProfilEmail.Text = "Email";
            // 
            // lblProfilSsn
            // 
            this.lblProfilSsn.AutoSize = true;
            this.lblProfilSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilSsn.Location = new System.Drawing.Point(8, 98);
            this.lblProfilSsn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfilSsn.Name = "lblProfilSsn";
            this.lblProfilSsn.Size = new System.Drawing.Size(135, 20);
            this.lblProfilSsn.TabIndex = 13;
            this.lblProfilSsn.Text = "Personnummer";
            // 
            // lblProfilName
            // 
            this.lblProfilName.AutoSize = true;
            this.lblProfilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilName.Location = new System.Drawing.Point(8, 62);
            this.lblProfilName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfilName.Name = "lblProfilName";
            this.lblProfilName.Size = new System.Drawing.Size(57, 20);
            this.lblProfilName.TabIndex = 12;
            this.lblProfilName.Text = "Namn";
            // 
            // lblMinProfil
            // 
            this.lblMinProfil.AutoSize = true;
            this.lblMinProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinProfil.Location = new System.Drawing.Point(4, -2);
            this.lblMinProfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinProfil.Name = "lblMinProfil";
            this.lblMinProfil.Size = new System.Drawing.Size(167, 40);
            this.lblMinProfil.TabIndex = 11;
            this.lblMinProfil.Text = "Min Profil";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(14, 591);
            this.lblFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 20);
            this.lblFeedback.TabIndex = 17;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.tabBookSession);
            this.tabBooking.Controls.Add(this.tabMySessions);
            this.tabBooking.Location = new System.Drawing.Point(18, 63);
            this.tabBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.SelectedIndex = 0;
            this.tabBooking.Size = new System.Drawing.Size(670, 508);
            this.tabBooking.TabIndex = 15;
            this.tabBooking.Visible = false;
            // 
            // tabBookSession
            // 
            this.tabBookSession.Controls.Add(this.listSessions);
            this.tabBookSession.Controls.Add(this.btnBookSession);
            this.tabBookSession.Controls.Add(this.dateTimePicker);
            this.tabBookSession.Location = new System.Drawing.Point(4, 29);
            this.tabBookSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBookSession.Name = "tabBookSession";
            this.tabBookSession.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBookSession.Size = new System.Drawing.Size(662, 475);
            this.tabBookSession.TabIndex = 0;
            this.tabBookSession.Text = "Boka pass";
            this.tabBookSession.UseVisualStyleBackColor = true;
            // 
            // listSessions
            // 
            this.listSessions.AllowUserToAddRows = false;
            this.listSessions.AllowUserToDeleteRows = false;
            this.listSessions.AllowUserToResizeColumns = false;
            this.listSessions.AllowUserToResizeRows = false;
            this.listSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.listSessions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.listSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSessions.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.listSessions.Location = new System.Drawing.Point(8, 46);
            this.listSessions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listSessions.MultiSelect = false;
            this.listSessions.Name = "listSessions";
            this.listSessions.ReadOnly = true;
            this.listSessions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listSessions.Size = new System.Drawing.Size(645, 371);
            this.listSessions.TabIndex = 3;
            this.listSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listSessions_CellContentClick);
            // 
            // btnBookSession
            // 
            this.btnBookSession.Location = new System.Drawing.Point(8, 428);
            this.btnBookSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookSession.Name = "btnBookSession";
            this.btnBookSession.Size = new System.Drawing.Size(645, 35);
            this.btnBookSession.TabIndex = 2;
            this.btnBookSession.Text = "Boka pass";
            this.btnBookSession.UseVisualStyleBackColor = true;
            this.btnBookSession.Click += new System.EventHandler(this.btnBookSession_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Location = new System.Drawing.Point(9, 9);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2018, 2, 15, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // tabMySessions
            // 
            this.tabMySessions.Controls.Add(this.listMySessions);
            this.tabMySessions.Controls.Add(this.btnCancelSession);
            this.tabMySessions.Location = new System.Drawing.Point(4, 29);
            this.tabMySessions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMySessions.Name = "tabMySessions";
            this.tabMySessions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMySessions.Size = new System.Drawing.Size(662, 475);
            this.tabMySessions.TabIndex = 1;
            this.tabMySessions.Text = "Mina pass";
            this.tabMySessions.UseVisualStyleBackColor = true;
            // 
            // listMySessions
            // 
            this.listMySessions.AllowUserToAddRows = false;
            this.listMySessions.AllowUserToDeleteRows = false;
            this.listMySessions.AllowUserToResizeColumns = false;
            this.listMySessions.AllowUserToResizeRows = false;
            this.listMySessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.listMySessions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.listMySessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listMySessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMySessions.Location = new System.Drawing.Point(4, 11);
            this.listMySessions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listMySessions.MultiSelect = false;
            this.listMySessions.Name = "listMySessions";
            this.listMySessions.ReadOnly = true;
            this.listMySessions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listMySessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMySessions.Size = new System.Drawing.Size(645, 408);
            this.listMySessions.TabIndex = 1;
            // 
            // btnCancelSession
            // 
            this.btnCancelSession.Location = new System.Drawing.Point(8, 428);
            this.btnCancelSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelSession.Name = "btnCancelSession";
            this.btnCancelSession.Size = new System.Drawing.Size(644, 35);
            this.btnCancelSession.TabIndex = 1;
            this.btnCancelSession.Text = "Avboka pass";
            this.btnCancelSession.UseVisualStyleBackColor = true;
            this.btnCancelSession.Click += new System.EventHandler(this.btnCancelSession_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 625);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblHem);
            this.Controls.Add(this.tabBooking);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLoggedIn);
            this.Name = "Form1";
            this.Text = "Gymshark App";
            this.Load += new System.EventHandler(this.Gymshark_App_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelLoggedIn.ResumeLayout(false);
            this.panelLoggedIn.PerformLayout();
            this.tabBooking.ResumeLayout(false);
            this.tabBookSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSessions)).EndInit();
            this.tabMySessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listMySessions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLoggedIn;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblDeleteAccount;
        private System.Windows.Forms.Label lblProfilPhone;
        private System.Windows.Forms.Label lblProfilEmail;
        private System.Windows.Forms.Label lblProfilSsn;
        private System.Windows.Forms.Label lblProfilName;
        private System.Windows.Forms.Label lblMinProfil;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label lblCheckAccount;
        private System.Windows.Forms.Button lblLoginRegister;
        private System.Windows.Forms.Label lblRegisterPhoneNumber;
        private System.Windows.Forms.Button btnRegisterCompleted;
        private System.Windows.Forms.TextBox txtInputPhoneNumber;
        private System.Windows.Forms.TextBox txtInputEmail;
        private System.Windows.Forms.TextBox txtInputSsn;
        private System.Windows.Forms.TextBox txtInputLastName;
        private System.Windows.Forms.TextBox txtInputFirstName;
        private System.Windows.Forms.TextBox txtInputPassword2;
        private System.Windows.Forms.TextBox txtInputUsername2;
        private System.Windows.Forms.Label lblRegisterEmail;
        private System.Windows.Forms.Label lblRegisterSsnHelp;
        private System.Windows.Forms.Label lblRegisterSsn;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblRegisterFirstName;
        private System.Windows.Forms.Label lblRegisterPassword;
        private System.Windows.Forms.Label lblRegisterUsername;
        private System.Windows.Forms.Label lblHem;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtInputUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtInputPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TabControl tabBooking;
        private System.Windows.Forms.TabPage tabBookSession;
        private System.Windows.Forms.TabPage tabMySessions;
        private System.Windows.Forms.Button btnBookSession;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnCancelSession;
        private System.Windows.Forms.DataGridView listSessions;
        private System.Windows.Forms.DataGridView listMySessions;
    }
}

