namespace RegisterLogin
{
    public partial class Form1 : Form
    {
        private readonly LoginManager loginManager = new();
        private string loggedUsername = "";
        private static string filepath = "C:\\Users\\lab_services_student\\OneDrive - ADvTECH Ltd\\PROG\\Projects\\RegisterLogin\\RegisterLogin\\logins.txt";
        public Form1()
        {
            InitializeComponent();
            //loginManager.AddUser(new Login("test", "test"));
            loginManager.LoadFromTxt();
        }

        private void PnlWelcome()
        {
            pnlWelcome.Visible = true;
            pnlLogin.Visible = false;
            pnlRegister.Visible = false;
            pnlLoggedIn.Visible = false;
        }

        private void PnlLogin()
        {
            pnlWelcome.Visible = false;
            pnlLogin.Visible = true;
            pnlRegister.Visible = false;
            pnlLoggedIn.Visible = false;
        }

        private void PnlRegister()
        {
            pnlWelcome.Visible = false;
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
            pnlLoggedIn.Visible = false;
        }

        private void PnlLoggedIn()
        {
            pnlWelcome.Visible = false;
            pnlLogin.Visible = false;
            pnlRegister.Visible = false;
            pnlLoggedIn.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PnlLogin();
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            PnlRegister();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUser.Text;
            string password = txtLoginPassword.Text;
            bool valid = loginManager.CheckLogin(username, password);
            if (valid)
            {
                loggedUsername = username;
                lblWelcomeUser.Text = "Welcome " + loggedUsername;
                txtLoginUser.Text = "";
                txtLoginPassword.Text = "";
                //PnlLoggedIn();
                Form welcome = new Welcome(username, this);
                welcome.Show();
                Hide();
                //lblLoginStatus.Text = "Login successful";
                //lblLoginStatus.Visible = true;
            }
            else
            {
                lblLoginStatus.Text = "Login failed";
                lblLoginStatus.Visible = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUserRegister.Text;
            string password = txtRegisterPassword.Text;
            if (loginManager.AddUser(new Login(username, password)))
            {
                loginManager.AddUserToTxt(username, password);
                lblRegisterStatus.Text = "Registration successful";

                lblRegisterStatus.Visible = true;
                txtUserRegister.Text = "";
                txtRegisterPassword.Text = "";
                PnlLogin();
            }
            else
            {
                lblRegisterStatus.Text = "Username already exists";
                lblRegisterStatus.Visible = true;
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point pt = new(0, 0);
            pnlWelcome.Location = pt;
            pnlLogin.Location = pt;
            pnlRegister.Location = pt;
            pnlLoggedIn.Location = pt;
            this.Size = new Size(315, 231);
            PnlWelcome();
        }
    }
}
