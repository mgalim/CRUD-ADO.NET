namespace CRUD_ADO.NET
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            lblStatusTxt = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            dtgvUser = new DataGridView();
            btnCreate = new Button();
            lblPass = new Label();
            lblUser = new Label();
            lblLastName = new Label();
            lblName = new Label();
            lblId = new Label();
            lblMail = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            txtMail = new TextBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvUser).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(33, 28);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(69, 28);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            // 
            // lblStatusTxt
            // 
            lblStatusTxt.AutoSize = true;
            lblStatusTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusTxt.Location = new Point(108, 28);
            lblStatusTxt.Name = "lblStatusTxt";
            lblStatusTxt.Size = new Size(0, 28);
            lblStatusTxt.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(814, 327);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 56);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(814, 207);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 56);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtgvUser
            // 
            dtgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUser.Location = new Point(12, 290);
            dtgvUser.Name = "dtgvUser";
            dtgvUser.RowHeadersWidth = 51;
            dtgvUser.Size = new Size(765, 290);
            dtgvUser.TabIndex = 4;
            dtgvUser.CellClick += dtgvUser_CellClick;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(814, 88);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(137, 56);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(413, 149);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(114, 28);
            lblPass.TabIndex = 6;
            lblPass.Text = "Contraseña:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(413, 84);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(83, 28);
            lblUser.TabIndex = 7;
            lblUser.Text = "Usuario:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(33, 218);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(90, 28);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Apellido:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(33, 149);
            lblName.Name = "lblName";
            lblName.Size = new Size(89, 28);
            lblName.TabIndex = 9;
            lblName.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(33, 84);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 28);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMail.Location = new Point(413, 218);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(63, 28);
            lblMail.TabIndex = 11;
            lblMail.Text = "Email:";
            // 
            // txtId
            // 
            txtId.Location = new Point(125, 85);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 12;
            // 
            // txtName
            // 
            txtName.Location = new Point(128, 153);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(129, 222);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 14;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(527, 88);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(250, 27);
            txtUser.TabIndex = 15;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(527, 153);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(250, 27);
            txtPass.TabIndex = 16;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(527, 218);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(250, 27);
            txtMail.TabIndex = 17;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(814, 443);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(137, 56);
            btnExit.TabIndex = 18;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 592);
            Controls.Add(btnExit);
            Controls.Add(txtMail);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lblMail);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(lblLastName);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(btnCreate);
            Controls.Add(dtgvUser);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(lblStatusTxt);
            Controls.Add(lblStatus);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD ADO.NET";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Label lblStatusTxt;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dtgvUser;
        private Button btnCreate;
        private Label lblPass;
        private Label lblUser;
        private Label lblLastName;
        private Label lblName;
        private Label lblId;
        private Label lblMail;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtMail;
        private Button btnExit;
    }
}
