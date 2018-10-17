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
            this.tabMySessions = new System.Windows.Forms.TabPage();
            this.listMySessions = new System.Windows.Forms.DataGridView();
            this.btnCancelSession = new System.Windows.Forms.Button();
            this.tabBookSession = new System.Windows.Forms.TabPage();
            this.listSessions = new System.Windows.Forms.DataGridView();
            this.btnBookSession = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panelNews = new System.Windows.Forms.Panel();
            this.lblNewsContent = new System.Windows.Forms.TextBox();
            this.lblNews = new System.Windows.Forms.Label();
            this.lblNewsDate = new System.Windows.Forms.Label();
            this.lblNewsName = new System.Windows.Forms.Label();
            this.panelRegister.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelLoggedIn.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.tabMySessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listMySessions)).BeginInit();
            this.tabBookSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSessions)).BeginInit();
            this.panelNews.SuspendLayout();
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
            this.panelRegister.Location = new System.Drawing.Point(12, 41);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(347, 287);
            this.panelRegister.TabIndex = 14;
            this.panelRegister.Visible = false;
            // 
            // lblCheckAccount
            // 
            this.lblCheckAccount.AutoSize = true;
            this.lblCheckAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckAccount.Location = new System.Drawing.Point(197, 238);
            this.lblCheckAccount.Name = "lblCheckAccount";
            this.lblCheckAccount.Size = new System.Drawing.Size(143, 13);
            this.lblCheckAccount.TabIndex = 17;
            this.lblCheckAccount.Text = "Har du redan ett konto?";
            // 
            // lblLoginRegister
            // 
            this.lblLoginRegister.Location = new System.Drawing.Point(231, 254);
            this.lblLoginRegister.Name = "lblLoginRegister";
            this.lblLoginRegister.Size = new System.Drawing.Size(85, 26);
            this.lblLoginRegister.TabIndex = 16;
            this.lblLoginRegister.Text = "Logga in";
            this.lblLoginRegister.UseVisualStyleBackColor = true;
            this.lblLoginRegister.Click += new System.EventHandler(this.lblLogin2_Click);
            // 
            // lblRegisterPhoneNumber
            // 
            this.lblRegisterPhoneNumber.AutoSize = true;
            this.lblRegisterPhoneNumber.Location = new System.Drawing.Point(5, 191);
            this.lblRegisterPhoneNumber.Name = "lblRegisterPhoneNumber";
            this.lblRegisterPhoneNumber.Size = new System.Drawing.Size(35, 13);
            this.lblRegisterPhoneNumber.TabIndex = 15;
            this.lblRegisterPhoneNumber.Text = "Mobil:";
            // 
            // btnRegisterCompleted
            // 
            this.btnRegisterCompleted.Location = new System.Drawing.Point(83, 214);
            this.btnRegisterCompleted.Name = "btnRegisterCompleted";
            this.btnRegisterCompleted.Size = new System.Drawing.Size(100, 23);
            this.btnRegisterCompleted.TabIndex = 14;
            this.btnRegisterCompleted.Text = "Registrera";
            this.btnRegisterCompleted.UseVisualStyleBackColor = true;
            this.btnRegisterCompleted.Click += new System.EventHandler(this.btnRegisterCompleted_Click);
            // 
            // txtInputPhoneNumber
            // 
            this.txtInputPhoneNumber.Location = new System.Drawing.Point(83, 188);
            this.txtInputPhoneNumber.Name = "txtInputPhoneNumber";
            this.txtInputPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtInputPhoneNumber.TabIndex = 13;
            // 
            // txtInputEmail
            // 
            this.txtInputEmail.Location = new System.Drawing.Point(83, 162);
            this.txtInputEmail.Name = "txtInputEmail";
            this.txtInputEmail.Size = new System.Drawing.Size(100, 20);
            this.txtInputEmail.TabIndex = 12;
            // 
            // txtInputSsn
            // 
            this.txtInputSsn.Location = new System.Drawing.Point(83, 136);
            this.txtInputSsn.Name = "txtInputSsn";
            this.txtInputSsn.Size = new System.Drawing.Size(100, 20);
            this.txtInputSsn.TabIndex = 11;
            // 
            // txtInputLastName
            // 
            this.txtInputLastName.Location = new System.Drawing.Point(83, 110);
            this.txtInputLastName.Name = "txtInputLastName";
            this.txtInputLastName.Size = new System.Drawing.Size(100, 20);
            this.txtInputLastName.TabIndex = 10;
            // 
            // txtInputFirstName
            // 
            this.txtInputFirstName.Location = new System.Drawing.Point(83, 84);
            this.txtInputFirstName.Name = "txtInputFirstName";
            this.txtInputFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtInputFirstName.TabIndex = 9;
            // 
            // txtInputPassword2
            // 
            this.txtInputPassword2.Location = new System.Drawing.Point(83, 58);
            this.txtInputPassword2.Name = "txtInputPassword2";
            this.txtInputPassword2.Size = new System.Drawing.Size(100, 20);
            this.txtInputPassword2.TabIndex = 8;
            this.txtInputPassword2.UseSystemPasswordChar = true;
            // 
            // txtInputUsername2
            // 
            this.txtInputUsername2.Location = new System.Drawing.Point(83, 32);
            this.txtInputUsername2.Name = "txtInputUsername2";
            this.txtInputUsername2.Size = new System.Drawing.Size(100, 20);
            this.txtInputUsername2.TabIndex = 7;
            // 
            // lblRegisterEmail
            // 
            this.lblRegisterEmail.AutoSize = true;
            this.lblRegisterEmail.Location = new System.Drawing.Point(5, 165);
            this.lblRegisterEmail.Name = "lblRegisterEmail";
            this.lblRegisterEmail.Size = new System.Drawing.Size(35, 13);
            this.lblRegisterEmail.TabIndex = 6;
            this.lblRegisterEmail.Text = "Email:";
            // 
            // lblRegisterSsnHelp
            // 
            this.lblRegisterSsnHelp.AutoSize = true;
            this.lblRegisterSsnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterSsnHelp.Location = new System.Drawing.Point(197, 139);
            this.lblRegisterSsnHelp.Name = "lblRegisterSsnHelp";
            this.lblRegisterSsnHelp.Size = new System.Drawing.Size(65, 13);
            this.lblRegisterSsnHelp.TabIndex = 5;
            this.lblRegisterSsnHelp.Text = "(10 siffror)";
            // 
            // lblRegisterSsn
            // 
            this.lblRegisterSsn.AutoSize = true;
            this.lblRegisterSsn.Location = new System.Drawing.Point(5, 139);
            this.lblRegisterSsn.Name = "lblRegisterSsn";
            this.lblRegisterSsn.Size = new System.Drawing.Size(80, 13);
            this.lblRegisterSsn.TabIndex = 4;
            this.lblRegisterSsn.Text = "Personnummer:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(5, 113);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Efternamn:";
            // 
            // lblRegisterFirstName
            // 
            this.lblRegisterFirstName.AutoSize = true;
            this.lblRegisterFirstName.Location = new System.Drawing.Point(5, 87);
            this.lblRegisterFirstName.Name = "lblRegisterFirstName";
            this.lblRegisterFirstName.Size = new System.Drawing.Size(51, 13);
            this.lblRegisterFirstName.TabIndex = 2;
            this.lblRegisterFirstName.Text = "Förnamn:";
            // 
            // lblRegisterPassword
            // 
            this.lblRegisterPassword.AutoSize = true;
            this.lblRegisterPassword.Location = new System.Drawing.Point(5, 61);
            this.lblRegisterPassword.Name = "lblRegisterPassword";
            this.lblRegisterPassword.Size = new System.Drawing.Size(54, 13);
            this.lblRegisterPassword.TabIndex = 1;
            this.lblRegisterPassword.Text = "Lösenord:";
            // 
            // lblRegisterUsername
            // 
            this.lblRegisterUsername.AutoSize = true;
            this.lblRegisterUsername.Location = new System.Drawing.Point(5, 35);
            this.lblRegisterUsername.Name = "lblRegisterUsername";
            this.lblRegisterUsername.Size = new System.Drawing.Size(82, 13);
            this.lblRegisterUsername.TabIndex = 0;
            this.lblRegisterUsername.Text = "Användarnamn:";
            // 
            // lblHem
            // 
            this.lblHem.AutoSize = true;
            this.lblHem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHem.Location = new System.Drawing.Point(7, 9);
            this.lblHem.Name = "lblHem";
            this.lblHem.Size = new System.Drawing.Size(112, 29);
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
            this.panelLogin.Location = new System.Drawing.Point(12, 41);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(219, 150);
            this.panelLogin.TabIndex = 12;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 78);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Registrera";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtInputUsername
            // 
            this.txtInputUsername.Location = new System.Drawing.Point(97, 26);
            this.txtInputUsername.Name = "txtInputUsername";
            this.txtInputUsername.Size = new System.Drawing.Size(100, 20);
            this.txtInputUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(82, 13);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Användarnamn:";
            // 
            // txtInputPassword
            // 
            this.txtInputPassword.Location = new System.Drawing.Point(97, 52);
            this.txtInputPassword.Name = "txtInputPassword";
            this.txtInputPassword.Size = new System.Drawing.Size(100, 20);
            this.txtInputPassword.TabIndex = 8;
            this.txtInputPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(97, 78);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Logga in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 13);
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
            this.panelLoggedIn.Location = new System.Drawing.Point(481, 9);
            this.panelLoggedIn.Name = "panelLoggedIn";
            this.panelLoggedIn.Size = new System.Drawing.Size(219, 362);
            this.panelLoggedIn.TabIndex = 16;
            this.panelLoggedIn.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(7, 137);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 21);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "Logga ut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(122, 333);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAccount.TabIndex = 17;
            this.btnDeleteAccount.Text = "Radera";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.Location = new System.Drawing.Point(3, 338);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(113, 13);
            this.lblDeleteAccount.TabIndex = 16;
            this.lblDeleteAccount.Text = "Radera ditt konto?";
            // 
            // lblProfilPhone
            // 
            this.lblProfilPhone.AutoSize = true;
            this.lblProfilPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilPhone.Location = new System.Drawing.Point(5, 115);
            this.lblProfilPhone.Name = "lblProfilPhone";
            this.lblProfilPhone.Size = new System.Drawing.Size(41, 13);
            this.lblProfilPhone.TabIndex = 15;
            this.lblProfilPhone.Text = "Mobil:";
            // 
            // lblProfilEmail
            // 
            this.lblProfilEmail.AutoSize = true;
            this.lblProfilEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilEmail.Location = new System.Drawing.Point(5, 90);
            this.lblProfilEmail.Name = "lblProfilEmail";
            this.lblProfilEmail.Size = new System.Drawing.Size(37, 13);
            this.lblProfilEmail.TabIndex = 14;
            this.lblProfilEmail.Text = "Email";
            // 
            // lblProfilSsn
            // 
            this.lblProfilSsn.AutoSize = true;
            this.lblProfilSsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilSsn.Location = new System.Drawing.Point(5, 64);
            this.lblProfilSsn.Name = "lblProfilSsn";
            this.lblProfilSsn.Size = new System.Drawing.Size(89, 13);
            this.lblProfilSsn.TabIndex = 13;
            this.lblProfilSsn.Text = "Personnummer";
            // 
            // lblProfilName
            // 
            this.lblProfilName.AutoSize = true;
            this.lblProfilName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilName.Location = new System.Drawing.Point(5, 40);
            this.lblProfilName.Name = "lblProfilName";
            this.lblProfilName.Size = new System.Drawing.Size(39, 13);
            this.lblProfilName.TabIndex = 12;
            this.lblProfilName.Text = "Namn";
            // 
            // lblMinProfil
            // 
            this.lblMinProfil.AutoSize = true;
            this.lblMinProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinProfil.Location = new System.Drawing.Point(3, -1);
            this.lblMinProfil.Name = "lblMinProfil";
            this.lblMinProfil.Size = new System.Drawing.Size(114, 29);
            this.lblMinProfil.TabIndex = 11;
            this.lblMinProfil.Text = "Min Profil";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(9, 384);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 17;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.tabBookSession);
            this.tabBooking.Controls.Add(this.tabMySessions);
            this.tabBooking.Location = new System.Drawing.Point(12, 41);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.SelectedIndex = 0;
            this.tabBooking.Size = new System.Drawing.Size(447, 330);
            this.tabBooking.TabIndex = 15;
            this.tabBooking.Visible = false;
            // 
            // tabMySessions
            // 
            this.tabMySessions.Controls.Add(this.listMySessions);
            this.tabMySessions.Controls.Add(this.btnCancelSession);
            this.tabMySessions.Location = new System.Drawing.Point(4, 22);
            this.tabMySessions.Name = "tabMySessions";
            this.tabMySessions.Padding = new System.Windows.Forms.Padding(3);
            this.tabMySessions.Size = new System.Drawing.Size(439, 304);
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
            this.listMySessions.Location = new System.Drawing.Point(3, 7);
            this.listMySessions.MultiSelect = false;
            this.listMySessions.Name = "listMySessions";
            this.listMySessions.ReadOnly = true;
            this.listMySessions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listMySessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listMySessions.Size = new System.Drawing.Size(430, 265);
            this.listMySessions.TabIndex = 1;
            // 
            // btnCancelSession
            // 
            this.btnCancelSession.Location = new System.Drawing.Point(5, 278);
            this.btnCancelSession.Name = "btnCancelSession";
            this.btnCancelSession.Size = new System.Drawing.Size(429, 23);
            this.btnCancelSession.TabIndex = 1;
            this.btnCancelSession.Text = "Avboka pass";
            this.btnCancelSession.UseVisualStyleBackColor = true;
            this.btnCancelSession.Click += new System.EventHandler(this.btnCancelSession_Click);
            // 
            // tabBookSession
            // 
            this.tabBookSession.Controls.Add(this.listSessions);
            this.tabBookSession.Controls.Add(this.btnBookSession);
            this.tabBookSession.Controls.Add(this.dateTimePicker);
            this.tabBookSession.Location = new System.Drawing.Point(4, 22);
            this.tabBookSession.Name = "tabBookSession";
            this.tabBookSession.Padding = new System.Windows.Forms.Padding(3);
            this.tabBookSession.Size = new System.Drawing.Size(439, 304);
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
            this.listSessions.Location = new System.Drawing.Point(5, 30);
            this.listSessions.MultiSelect = false;
            this.listSessions.Name = "listSessions";
            this.listSessions.ReadOnly = true;
            this.listSessions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listSessions.Size = new System.Drawing.Size(430, 241);
            this.listSessions.TabIndex = 3;
            this.listSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listSessions_CellContentClick);
            // 
            // btnBookSession
            // 
            this.btnBookSession.Location = new System.Drawing.Point(5, 278);
            this.btnBookSession.Name = "btnBookSession";
            this.btnBookSession.Size = new System.Drawing.Size(430, 23);
            this.btnBookSession.TabIndex = 2;
            this.btnBookSession.Text = "Boka pass";
            this.btnBookSession.UseVisualStyleBackColor = true;
            this.btnBookSession.Click += new System.EventHandler(this.btnBookSession_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Location = new System.Drawing.Point(6, 6);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2018, 2, 15, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // panelNews
            // 
            this.panelNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNews.Controls.Add(this.lblNewsContent);
            this.panelNews.Controls.Add(this.lblNews);
            this.panelNews.Controls.Add(this.lblNewsDate);
            this.panelNews.Controls.Add(this.lblNewsName);
            this.panelNews.Location = new System.Drawing.Point(287, 9);
            this.panelNews.Name = "panelNews";
            this.panelNews.Size = new System.Drawing.Size(419, 362);
            this.panelNews.TabIndex = 18;
            // 
            // lblNewsContent
            // 
            this.lblNewsContent.BackColor = System.Drawing.SystemColors.Control;
            this.lblNewsContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNewsContent.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsContent.Location = new System.Drawing.Point(7, 79);
            this.lblNewsContent.Margin = new System.Windows.Forms.Padding(2);
            this.lblNewsContent.Multiline = true;
            this.lblNewsContent.Name = "lblNewsContent";
            this.lblNewsContent.ReadOnly = true;
            this.lblNewsContent.Size = new System.Drawing.Size(403, 249);
            this.lblNewsContent.TabIndex = 15;
            // 
            // lblNews
            // 
            this.lblNews.AutoSize = true;
            this.lblNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNews.Location = new System.Drawing.Point(3, -1);
            this.lblNews.Name = "lblNews";
            this.lblNews.Size = new System.Drawing.Size(149, 29);
            this.lblNews.TabIndex = 11;
            this.lblNews.Text = "Senaste nytt:";
            // 
            // lblNewsDate
            // 
            this.lblNewsDate.AutoSize = true;
            this.lblNewsDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsDate.Location = new System.Drawing.Point(3, 344);
            this.lblNewsDate.Name = "lblNewsDate";
            this.lblNewsDate.Size = new System.Drawing.Size(43, 13);
            this.lblNewsDate.TabIndex = 14;
            this.lblNewsDate.Text = "Datum";
            // 
            // lblNewsName
            // 
            this.lblNewsName.AutoSize = true;
            this.lblNewsName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsName.Location = new System.Drawing.Point(3, 40);
            this.lblNewsName.Name = "lblNewsName";
            this.lblNewsName.Size = new System.Drawing.Size(66, 23);
            this.lblNewsName.TabIndex = 12;
            this.lblNewsName.Text = "Namn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 406);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.panelLoggedIn);
            this.Controls.Add(this.lblHem);
            this.Controls.Add(this.panelNews);
            this.Controls.Add(this.tabBooking);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelRegister);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.tabMySessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listMySessions)).EndInit();
            this.tabBookSession.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSessions)).EndInit();
            this.panelNews.ResumeLayout(false);
            this.panelNews.PerformLayout();
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
        private System.Windows.Forms.Panel panelNews;
        private System.Windows.Forms.Label lblNewsDate;
        private System.Windows.Forms.Label lblNewsName;
        private System.Windows.Forms.Label lblNews;
        private System.Windows.Forms.TextBox lblNewsContent;
    }
}

