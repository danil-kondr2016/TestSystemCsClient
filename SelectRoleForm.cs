namespace TestSystemClient
{
    public enum UserRole {
        Nothing,
        Organizator,
        Participant,
    };

    public partial class SelectRoleForm : Form
    {
        public UserRole SelectedRole { get; set; }
    
        public SelectRoleForm()
        {
            InitializeComponent();
        }

        private void SelectRoleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIAmParticipant_Click(object sender, EventArgs e)
        {
            Program.ErrorUnimplemented();
            SelectedRole = UserRole.Nothing;
            DialogResult = DialogResult.OK;
        }

        private void btnIAmOrganizator_Click(object sender, EventArgs e)
        {
            SelectedRole = UserRole.Organizator;
            DialogResult = DialogResult.OK;
        }
    }
}
