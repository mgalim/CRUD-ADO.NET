using CRUD_ADO.NET.DataBase;
using CRUD_ADO.NET.Models;

namespace CRUD_ADO.NET
{
    public partial class frmPrincipal : Form
    {
        GestorDB gestorDB = new GestorDB();
        public int idUser;
        public int rowSelected;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (gestorDB.DeleteUser(idUser))
                {

                    lblStatusTxt.Text = "Usuario eliminado";
                    lblStatusTxt.ForeColor = Color.Green;
                    dtgvUser.DataSource = null;
                    LoadUsers();
                    ResetForm();
                }
                else
                {
                    lblStatusTxt.Text = "Usuario no encontrado";
                    lblStatusTxt.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblStatusTxt.Text = ex.Message;
                lblStatusTxt.ForeColor = Color.Red;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (gestorDB.isUser(idUser))
                {
                    Usuario usuario = new()
                    {
                        Nombre = txtName.Text.Trim(),
                        Apellido = txtLastName.Text.Trim(),
                        NombreUsuario = txtUser.Text.Trim(),
                        Password = txtPass.Text.Trim(),
                        Email = txtMail.Text.Trim(),
                    };
                    gestorDB.UpdateUser(idUser, usuario);
                    lblStatusTxt.Text = "Usuario actualizado";
                    lblStatusTxt.ForeColor = Color.Green;
                    dtgvUser.DataSource = null;
                    LoadUsers();
                    ResetForm();
                    idUser = 0;
                }
                else
                {
                    lblStatusTxt.Text = "Usuario no encontrado";
                    lblStatusTxt.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblStatusTxt.Text = ex.Message;
                lblStatusTxt.ForeColor = Color.Red;
            }
        }
        private void LoadUsers()
        {
            try
            {
                dtgvUser.AutoGenerateColumns = true;
                dtgvUser.DataSource = gestorDB.GetUsuarios();

            }
            catch (Exception ex)
            {
                lblStatusTxt.Text = ex.Message;
                lblStatusTxt.ForeColor = Color.Red;
            }
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            LoadUsers();
            txtId.Enabled = false;
        }

        private void ResetForm()
        {
            foreach (Control ctr in Controls)
            {
                if (ctr is TextBox)
                    ctr.ResetText();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            List<string> textBoxValues = new() { txtName.Text, txtLastName.Text, txtUser.Text, txtPass.Text, txtMail.Text };
            bool allFieldsValid = textBoxValues.All(value => !string.IsNullOrEmpty(value));

            try
            {

                if (!allFieldsValid)
                {
                    lblStatusTxt.Text = "Falta completar algun campo";
                    lblStatusTxt.ForeColor = Color.Red;
                }
                else if (gestorDB.isUser(idUser))
                {
                    lblStatusTxt.Text = "Usuario ya existe";
                    lblStatusTxt.ForeColor = Color.Red;
                }
                else
                {
                    Usuario usuario = new Usuario
                    {
                        Nombre = txtName.Text.Trim(),
                        Apellido = txtLastName.Text.Trim(),
                        NombreUsuario = txtUser.Text.Trim(),
                        Password = txtPass.Text.Trim(),
                        Email = txtMail.Text.Trim(),
                    };

                    int userId = gestorDB.CreateUser(usuario);
                    lblStatusTxt.Text = $"Usuario registrado con el Id: {userId}";
                    lblStatusTxt.ForeColor = Color.Green;
                    dtgvUser.DataSource = null;
                    LoadUsers();
                    ResetForm();
                    idUser = 0;
                }
            }
            catch (Exception ex)
            {
                lblStatusTxt.Text = ex.Message;
                lblStatusTxt.ForeColor = Color.Red;
            }
        }

        private void dtgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowSelected = (int)e.RowIndex;
                idUser = Convert.ToInt32(dtgvUser[0, rowSelected].Value);
                lblStatusTxt.Text = $"Se seleccionó al usuario con id: {idUser}";
                lblStatusTxt.ForeColor = Color.Green;
                if (idUser > 0)
                {
                    Usuario usuario = gestorDB.GetUserById(idUser);
                    txtId.Text = idUser.ToString();
                    txtName.Text = usuario.Nombre;
                    txtLastName.Text = usuario.Apellido;
                    txtUser.Text = usuario.NombreUsuario;
                    txtPass.Text = usuario.Password;
                    txtMail.Text = usuario.Email;

                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

