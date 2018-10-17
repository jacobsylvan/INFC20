using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GymShark
{
    public partial class Form1 : Form
    {
        Controller cr = new Controller();


        public Form1()
        {
            InitializeComponent();
            tabBooking.SelectedIndexChanged += new EventHandler(tabBooking_SelectedIndexChanged);
        }

        private void GetMySessions()
        {

            listMySessions.Rows.Clear();
            listMySessions.Refresh();
            lblFeedback.Text = "";

            listMySessions.ColumnCount = 7;
            listMySessions.Columns[0].Name = "Datum";
            listMySessions.Columns[1].Name = "Tid";
            listMySessions.Columns[2].Name = "Pass";
            listMySessions.Columns[3].Name = "Plats";
            listMySessions.Columns[4].Name = "Instruktör";
            listMySessions.Columns[5].Name = "Längd (min)";
            listMySessions.Columns[6].Name = "SessionId";
            listMySessions.Columns["SessionId"].Visible = false;

            var result = Controller.GetSessionsForUser(cr.CurrentUser.CustomerId.Id.ToString());


            if (result.Count > 0)
            {
                foreach (Session s in result)
                {
                    string[] row = new string[] { s.Date.ToString("yyyy-MM-dd"), s.StartTime, s.SessionType.Name.ToString(), s.Place.Name.ToString(), s.Instructor.Name.ToString(), s.Duration.ToString(), s.SessionId.ToString() };
                    listMySessions.Rows.Add(row);
                }

            }
            else lblFeedback.Text = "Du har inga inbokade pass.";
        }


        private void tabBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabBooking.SelectedTab == tabBooking.TabPages[1])
            {
                GetMySessions();
            }
            else if (tabBooking.SelectedTab == tabBooking.TabPages[0])
            {
                lblFeedback.Text = "";
            }
        }

        private void Gymshark_App_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string username = txtInputUsername.Text.ToLower();
                string password = txtInputPassword.Text;
                cr.CurrentUser = Dal.GetAccount(username, password);
                Boolean isCorrect = Controller.CheckLogin(username, password);

                dateTimePicker.Value = DateTime.Today;


                if (isCorrect)
                {

                    lblFeedback.Text = "Inloggningen lyckades.";
                    panelLogin.Visible = false;


                    Customer c = Controller.FindCustomerWithUsername(username);
                    lblProfilName.Text = c.FirstName + " " + c.LastName;
                    lblProfilSsn.Text = c.SSN;
                    lblProfilEmail.Text = c.Email;
                    lblProfilPhone.Text = c.PhoneNumber;

                    panelLoggedIn.Visible = true;
                    lblHem.Text = "Välkommen " + c.FirstName + "!";
                    txtInputUsername.Text = "";
                    txtInputPassword.Text = "";

                    tabBooking.Visible = true;
                    panelNews.Visible = false;
                    lblHem.Text = "Bokningssystem:";
                }
                else
                {

                    lblFeedback.Text = "Se till att du har använt rätt kombination av användarnamn och lösenord.";
                }
            }
            catch (Exception ex)
            {
                lblFeedback.Text = ex.Message;
            }
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false; // hide login panel
            panelRegister.Visible = true; // show register panel
            panelNews.Visible = false; // hide news panel

            lblHem.Text = "Registrera:";

        }

        private void btnRegisterCompleted_Click(object sender, EventArgs e)
        {

            try
            {
                bool DigitsInFirstName = txtInputFirstName.Text.Any(c => char.IsDigit(c));
                bool DigitsInLastName = txtInputLastName.Text.Any(c => char.IsDigit(c));
                bool LettersInSsn = txtInputSsn.Text.Any(c => char.IsLetter(c));
                bool LettersInPhone = txtInputPhoneNumber.Text.Any(c => char.IsLetter(c));
                bool AtInEmail = txtInputEmail.Text.Contains("@");

                if (txtInputUsername2.Text == "" || txtInputPassword2.Text == "" || txtInputFirstName.Text == null || txtInputLastName.Text == null || txtInputSsn.Text == null || txtInputEmail.Text == null || txtInputPhoneNumber == null)
                {
                    lblFeedback.Text = "Se till att alla fält är ifyllda innan du registrerar dig.";
                }

                else if (DigitsInFirstName)
                {
                    lblFeedback.Text = "Se till att förnamn endast innehåller bokstäver.";
                }

                else if (DigitsInLastName)
                {
                    lblFeedback.Text = "Se till att efternamn endast innehåller bokstäver.";
                }

                else if (txtInputSsn.TextLength != 10)
                {
                    lblFeedback.Text = "Se till att du har skrivit in personnummer med 10 siffror.";
                }

                else if (LettersInSsn)
                {
                    lblFeedback.Text = "Se till att personummer endast innehåller siffror.";
                }

                else if (AtInEmail == false)
                {
                    lblFeedback.Text = "Se till att din email är giltig.";
                }

                else if (LettersInPhone)
                {
                    lblFeedback.Text = "Se till att mobilnummer endast innehåller siffror.";
                }

                else
                {

                    string username = txtInputUsername2.Text;
                    string password = txtInputPassword2.Text;
                    string firstName = txtInputFirstName.Text;
                    string lastName = txtInputLastName.Text;
                    string ssn = txtInputSsn.Text;
                    string email = txtInputEmail.Text;
                    string phoneNumber = txtInputPhoneNumber.Text;

                    lblFeedback.Text = Controller.AddCustomer(firstName, lastName, ssn, email, phoneNumber);
                    Customer c = Controller.FindCustomer(ssn);
                    Controller.AddAccount(username, password, c.Id);

                    txtInputUsername2.Text = "";
                    txtInputPassword2.Text = "";
                    txtInputFirstName.Text = "";
                    txtInputLastName.Text = "";
                    txtInputSsn.Text = "";
                    txtInputEmail.Text = "";
                    txtInputPhoneNumber.Text = "";

                }
            }
            catch (Exception ex)
            {

                lblFeedback.Text = ex.Message;
            }
        }

        private void lblLogin2_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = false;
            panelLogin.Visible = true;
            panelNews.Visible = true;

            lblHem.Text = "Logga in:";

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Är du säker på att du vill ta bort ditt konto?", "Ta bort konto?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    lblFeedback.Text = Controller.RemoveCustomer(lblProfilSsn.Text);
                    panelLogin.Visible = true;
                    panelLoggedIn.Visible = false;
                    tabBooking.Visible = false;
                    panelNews.Visible = true;

                    lblHem.Text = "Logga in:";
                    lblProfilName.Text = "";
                    lblProfilSsn.Text = "";
                    lblProfilEmail.Text = "";
                    lblProfilPhone.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    //nothing is going to happen
                }
            }
            catch (Exception ex)
            {

                lblFeedback.Text = ex.Message;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelLoggedIn.Visible = false;
            tabBooking.Visible = false;
            panelNews.Visible = true;

            lblFeedback.Text = "Du har nu loggats ut.";
            lblHem.Text = "Logga in:";
            lblProfilName.Text = "";
            lblProfilSsn.Text = "";
            lblProfilEmail.Text = "";
            lblProfilPhone.Text = "";

            cr.CurrentUser = null;

        }

        private void btnBookSession_Click(object sender, EventArgs e)
        {
            try
            {
                if (listSessions.SelectedRows.Count == 1)
                {
                    string selectedSession = listSessions.CurrentRow.Cells[6].Value.ToString();
                    string currentUserId = cr.CurrentUser.CustomerId.Id.ToString();
                    Boolean isBookedOnSession = Controller.IsBookedOnSession(selectedSession, currentUserId);

                    if (isBookedOnSession)
                    {
                        lblFeedback.Text = "Du är redan bokad på valt pass.";
                    }

                    else
                    {
                        Controller.BookSession(selectedSession, currentUserId);
                        lblFeedback.Text = "Ditt pass är nu inbokat.";
                    }
                }
            }
            catch (Exception ex)
            {

                lblFeedback.Text = ex.Message;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                listSessions.Rows.Clear();
                listSessions.Refresh();
                lblFeedback.Text = "";

                DateTime temp = dateTimePicker.Value.Date;
                String selectedDate = temp.ToString("yyyy-MM-dd");

                listSessions.ColumnCount = 7;
                listSessions.Columns[0].Name = "Datum";
                listSessions.Columns[1].Name = "Tid";
                listSessions.Columns[2].Name = "Pass";
                listSessions.Columns[3].Name = "Plats";
                listSessions.Columns[4].Name = "Instruktör";
                listSessions.Columns[5].Name = "Längd (min)";
                listSessions.Columns[6].Name = "SessionId";
                listSessions.Columns["SessionId"].Visible = false;

                var result = Controller.GetSessionsForDate(selectedDate);


                if (result.Count > 0)
                {
                    foreach (Session s in result)
                    {
                        string[] row = new string[] { s.Date.ToString("yyyy-MM-dd"), s.StartTime, s.SessionType.Name.ToString(), s.Place.Name.ToString(), s.Instructor.Name.ToString(), s.Duration.ToString(), s.SessionId.ToString() };
                        listSessions.Rows.Add(row);
                    }
                }
                else lblFeedback.Text = "Inga pass på vald dag";
            }
            catch (Exception ex)
            {

                lblFeedback.Text = ex.Message;
            }
        }

        private void listSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.listSessions.Rows[e.RowIndex];
                    string session = row.Cells["SessionId"].Value.ToString();

                }

            }
        }

        private void btnCancelSession_Click(object sender, EventArgs e)
        {

            try
            {
                if (listMySessions.SelectedRows.Count == 1)
                {
                    string selectedSession = listMySessions.CurrentRow.Cells[6].Value.ToString();
                    string currentUserId = cr.CurrentUser.CustomerId.Id.ToString();

                    DialogResult result = MessageBox.Show("Är du säker på att du vill avboka ditt pass?", "Avboka pass?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        Controller.CancelSession(selectedSession, currentUserId);
                        GetMySessions();
                        lblFeedback.Text = "Ditt pass är nu avbokat.";
                    }

                    else if (result == DialogResult.No)
                    {
                        //nothing is going to happen
                    }
                }
            }
            catch (Exception ex)
            {
                lblFeedback.Text = ex.Message;
            }
        }
    }
}