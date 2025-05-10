//namespace ConUni_Esc_DotNet_G02.Views
//{
//    partial class Login
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Button btnLogin;

//        // Requerido para la limpieza de los recursos
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.txtUsername = new System.Windows.Forms.TextBox();
//            this.txtPassword = new System.Windows.Forms.TextBox();
//            this.btnLogin = new System.Windows.Forms.Button();

//            // 
//            // txtUsername
//            // 
//            this.txtUsername.Location = new System.Drawing.Point(150, 100);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(200, 20);
//            this.txtUsername.TabIndex = 0;

//            // 
//            // txtPassword
//            // 
//            this.txtPassword.Location = new System.Drawing.Point(150, 140);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.Size = new System.Drawing.Size(200, 20);
//            this.txtPassword.TabIndex = 1;
//            this.txtPassword.PasswordChar = '*'; // Para ocultar la contraseña

//            // 
//            // btnLogin
//            // 
//            this.btnLogin.Location = new System.Drawing.Point(150, 180);
//            this.btnLogin.Name = "btnLogin";
//            this.btnLogin.Size = new System.Drawing.Size(100, 30);
//            this.btnLogin.TabIndex = 2;
//            this.btnLogin.Text = "Login";
//            this.btnLogin.UseVisualStyleBackColor = true;
//            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

//            // 
//            // Login
//            // 
//            this.ClientSize = new System.Drawing.Size(400, 300);
//            this.Controls.Add(this.txtUsername);
//            this.Controls.Add(this.txtPassword);
//            this.Controls.Add(this.btnLogin);
//            this.Name = "Login";
//            this.Text = "Login";
//        }
//    }
//}

//namespace ConUni_Esc_DotNet_G02.Views
//{
//    partial class Login
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblUsername;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label lblPassword;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Button btnLogin;
//        private System.Windows.Forms.Label lblError;
//        private System.Windows.Forms.PictureBox pictureBoxBackground;


//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }

//        private void InitializeComponent()
//        {
//            lblTitle = new Label();
//            lblUsername = new Label();
//            txtUsername = new TextBox();
//            lblPassword = new Label();
//            txtPassword = new TextBox();
//            btnLogin = new Button();
//            lblError = new Label();
//            pictureBoxBackground = new PictureBox();
//            pictureBoxBackground.Dock = DockStyle.Fill;
//            pictureBoxBackground.Image = Image.FromFile("Resources\\bg_sulley.gif");
//            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
//            SuspendLayout();
//            // 
//            // lblTitle
//            // 
//            lblTitle.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
//            lblTitle.ForeColor = Color.Gold;
//            lblTitle.Location = new Point(10, 20);
//            lblTitle.Name = "lblTitle";
//            lblTitle.Size = new Size(380, 50);
//            lblTitle.TabIndex = 0;
//            lblTitle.Text = "🔐 CONVERSIÓN UNIDADES MONSTER G02";
//            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
//            // 
//            // lblUsername
//            // 
//            lblUsername.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            lblUsername.ForeColor = Color.White;
//            lblUsername.Location = new Point(30, 90);
//            lblUsername.Name = "lblUsername";
//            lblUsername.Size = new Size(320, 23);
//            lblUsername.TabIndex = 1;
//            lblUsername.Text = "👾 Usuario:";
//            // 
//            // txtUsername
//            // 
//            txtUsername.Location = new Point(30, 115);
//            txtUsername.Name = "txtUsername";
//            txtUsername.Size = new Size(320, 27);
//            txtUsername.TabIndex = 2;
//            // 
//            // lblPassword
//            // 
//            lblPassword.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            lblPassword.ForeColor = Color.White;
//            lblPassword.Location = new Point(30, 155);
//            lblPassword.Name = "lblPassword";
//            lblPassword.Size = new Size(320, 23);
//            lblPassword.TabIndex = 3;
//            lblPassword.Text = "🔐 Contraseña:";
//            // 
//            // txtPassword
//            // 
//            txtPassword.Location = new Point(30, 180);
//            txtPassword.Name = "txtPassword";
//            txtPassword.PasswordChar = '●';
//            txtPassword.Size = new Size(320, 27);
//            txtPassword.TabIndex = 4;
//            // 
//            // btnLogin
//            // 
//            btnLogin.BackColor = Color.FromArgb(93, 156, 236);
//            btnLogin.FlatStyle = FlatStyle.Flat;
//            btnLogin.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            btnLogin.ForeColor = Color.White;
//            btnLogin.Location = new Point(30, 230);
//            btnLogin.Name = "btnLogin";
//            btnLogin.Size = new Size(320, 40);
//            btnLogin.TabIndex = 5;
//            btnLogin.Text = "Entrar al Mundo Monster 🚪";
//            btnLogin.UseVisualStyleBackColor = false;
//            btnLogin.Click += btnLogin_Click;
//            // 
//            // lblError
//            // 
//            lblError.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
//            lblError.ForeColor = Color.Red;
//            lblError.Location = new Point(30, 280);
//            lblError.Name = "lblError";
//            lblError.Size = new Size(320, 50);
//            lblError.TabIndex = 6;
//            lblError.TextAlign = ContentAlignment.MiddleCenter;
//            lblError.Visible = false;
//            // 
//            // Login
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.FromArgb(44, 62, 80);
//            Controls.Add(pictureBoxBackground);
//            pictureBoxBackground.SendToBack(); // lo manda al fondo
//            ClientSize = new Size(400, 350);
//            Controls.Add(lblTitle);
//            Controls.Add(lblUsername);
//            Controls.Add(txtUsername);
//            Controls.Add(lblPassword);
//            Controls.Add(txtPassword);
//            Controls.Add(btnLogin);
//            Controls.Add(lblError);
//            FormBorderStyle = FormBorderStyle.FixedDialog;
//            Name = "Login";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Login - Monsters Inc";
//            ResumeLayout(false);
//            PerformLayout();
//        }
//    }
//}


//namespace ConUni_Esc_DotNet_G02.Views
//{
//    partial class Login
//    {
//        private System.ComponentModel.IContainer components = null;
//        private System.Windows.Forms.Label lblTitle;
//        private System.Windows.Forms.Label lblUsername;
//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label lblPassword;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Button btnLogin;
//        private System.Windows.Forms.Label lblError;
//        private System.Windows.Forms.PictureBox pictureBoxBackground;


//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//                components.Dispose();
//            base.Dispose(disposing);
//        }
//        private void InitializeComponent()
//        {
//            lblTitle = new Label();
//            lblUsername = new Label();
//            txtUsername = new TextBox();
//            lblPassword = new Label();
//            txtPassword = new TextBox();
//            btnLogin = new Button();
//            lblError = new Label();
//            pictureBoxBackground = new PictureBox();
//            ((System.ComponentModel.ISupportInitialize)(pictureBoxBackground)).BeginInit();

//            SuspendLayout();

//            // 
//            // pictureBoxBackground
//            // 
//            pictureBoxBackground.Dock = DockStyle.Fill;
//            pictureBoxBackground.Image = Image.FromFile("Resources\\bg_sulley.gif");
//            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
//            pictureBoxBackground.Location = new Point(0, 0);
//            pictureBoxBackground.Name = "pictureBoxBackground";
//            pictureBoxBackground.Size = new Size(400, 350);
//            pictureBoxBackground.TabIndex = 0;
//            pictureBoxBackground.TabStop = false;

//            // 
//            // lblTitle
//            // 
//            lblTitle.BackColor = Color.Transparent;
//            lblTitle.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
//            lblTitle.ForeColor = Color.Gold;
//            lblTitle.Location = new Point(10, 20);
//            lblTitle.Name = "lblTitle";
//            lblTitle.Size = new Size(380, 50);
//            lblTitle.TabIndex = 0;
//            lblTitle.Text = "🔐 CONVERSIÓN UNIDADES MONSTER G02";
//            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

//            // 
//            // lblUsername
//            // 
//            lblUsername.BackColor = Color.Transparent;
//            lblUsername.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            lblUsername.ForeColor = Color.White;
//            lblUsername.Location = new Point(30, 90);
//            lblUsername.Name = "lblUsername";
//            lblUsername.Size = new Size(320, 23);
//            lblUsername.TabIndex = 1;
//            lblUsername.Text = "👾 Usuario:";

//            // 
//            // txtUsername
//            // 
//            txtUsername.Location = new Point(30, 115);
//            txtUsername.Name = "txtUsername";
//            txtUsername.Size = new Size(320, 27);
//            txtUsername.TabIndex = 2;

//            // 
//            // lblPassword
//            // 
//            lblPassword.BackColor = Color.Transparent;
//            lblPassword.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            lblPassword.ForeColor = Color.White;
//            lblPassword.Location = new Point(30, 155);
//            lblPassword.Name = "lblPassword";
//            lblPassword.Size = new Size(320, 23);
//            lblPassword.TabIndex = 3;
//            lblPassword.Text = "🔐 Contraseña:";

//            // 
//            // txtPassword
//            // 
//            txtPassword.Location = new Point(30, 180);
//            txtPassword.Name = "txtPassword";
//            txtPassword.PasswordChar = '●';
//            txtPassword.Size = new Size(320, 27);
//            txtPassword.TabIndex = 4;

//            // 
//            // btnLogin
//            // 
//            btnLogin.BackColor = Color.FromArgb(93, 156, 236);
//            btnLogin.FlatStyle = FlatStyle.Flat;
//            btnLogin.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            btnLogin.ForeColor = Color.White;
//            btnLogin.Location = new Point(30, 230);
//            btnLogin.Name = "btnLogin";
//            btnLogin.Size = new Size(320, 40);
//            btnLogin.TabIndex = 5;
//            btnLogin.Text = "Entrar al Mundo Monster 🚪";
//            btnLogin.UseVisualStyleBackColor = false;
//            btnLogin.Click += btnLogin_Click;

//            // 
//            // lblError
//            // 
//            lblError.BackColor = Color.Transparent;
//            lblError.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
//            lblError.ForeColor = Color.Red;
//            lblError.Location = new Point(30, 280);
//            lblError.Name = "lblError";
//            lblError.Size = new Size(320, 50);
//            lblError.TabIndex = 6;
//            lblError.TextAlign = ContentAlignment.MiddleCenter;
//            lblError.Visible = false;

//            // 
//            // Login
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.FromArgb(44, 62, 80);
//            ClientSize = new Size(400, 350);
//            Controls.Add(lblError);
//            Controls.Add(btnLogin);
//            Controls.Add(txtPassword);
//            Controls.Add(lblPassword);
//            Controls.Add(txtUsername);
//            Controls.Add(lblUsername);
//            Controls.Add(lblTitle);
//            Controls.Add(pictureBoxBackground);
//            pictureBoxBackground.SendToBack(); // Asegúrate de que esté al fondo después de agregar todos los controles
//            FormBorderStyle = FormBorderStyle.FixedDialog;
//            Name = "Login";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Login - Monsters Inc";
//            ((System.ComponentModel.ISupportInitialize)(pictureBoxBackground)).EndInit();
//            ResumeLayout(false);
//            PerformLayout();
//        }
//    }
//}

// HMMMMM

namespace ConUni_Esc_DotNet_G02.Views
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Panel panelLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private Panel GetPanelLogin()
        {
            return panelLogin;
        }

        private void InitializeComponent(Panel panelLogin)
        {
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            pictureBoxBackground = new PictureBox();
            panelLogin = new Panel();

            ((System.ComponentModel.ISupportInitialize)(pictureBoxBackground)).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();

            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Dock = DockStyle.Fill;
            pictureBoxBackground.Image = Image.FromFile("Resources\\bg_sulley.gif");
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackground.Location = new Point(0, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(450, 500);
            pictureBoxBackground.TabIndex = 0;
            pictureBoxBackground.TabStop = false;

            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            //panelLogin.BackColor = Color.FromArgb(0, 0, 0, 150);
            panelLogin.BackColor = Color.Transparent;
            panelLogin.Location = new Point(60, 80);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(500, 450);
            panelLogin.TabIndex = 7;
            panelLogin.Padding = new Padding(30);
            panelLogin.BorderStyle = BorderStyle.None;
            // Agregamos controles al panel
            panelLogin.Controls.Add(lblTitle);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(lblError);

            panelLogin.Paint += (sender, e) =>
            {
                using (var brush = new SolidBrush(Color.FromArgb(255, 0, 51, 102)))
                {
                    e.Graphics.FillRectangle(brush, panelLogin.ClientRectangle);
                }
                ControlPaint.DrawBorder(e.Graphics, panelLogin.ClientRectangle,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid);
            };

            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(10, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(480, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔐 CONVERSIÓN UNIDADES MONSTER G02";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // Agregar sombra al texto del título
            //lblTitle.Paint += (sender, e) =>
            //{
            //    e.Graphics.DrawString(lblTitle.Text, lblTitle.Font,
            //        new SolidBrush(Color.FromArgb(100, 0, 0, 0)),
            //        new PointF(2, 2), StringFormat.GenericDefault);
            //};

            // 
            // lblUsername
            // 
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(30, 90);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(450, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "👾 Usuario:";

            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(450, 27);
            txtUsername.TabIndex = 2;
            txtUsername.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;

            // 
            // lblPassword
            // 
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(30, 160);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(450, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "🔐 Contraseña:";

            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 189);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(450, 27);
            txtPassword.TabIndex = 4;
            txtPassword.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;

            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(93, 156, 236);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(100, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar al Mundo Monster 🚪";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Click += btnLogin_Click;

            // Eventos para efectos de hover
            btnLogin.MouseEnter += (sender, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(74, 137, 220); // Color más oscuro al pasar el mouse
            };
            btnLogin.MouseLeave += (sender, e) =>
            {
                btnLogin.BackColor = Color.FromArgb(93, 156, 236); // Color original
            };

            // 
            // lblError
            // 
            lblError.BackColor = Color.FromArgb(231, 76, 60);
            lblError.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold);
            lblError.ForeColor = Color.White;
            lblError.Location = new Point(30, 290);
            lblError.Name = "lblError";
            lblError.Size = new Size(290, 50);
            lblError.TabIndex = 6;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            lblError.Padding = new Padding(5);

            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(600, 600);
            Controls.Add(panelLogin);
            Controls.Add(pictureBoxBackground);
            pictureBoxBackground.SendToBack();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de Temperatura - Monster G02";
            ((System.ComponentModel.ISupportInitialize)(pictureBoxBackground)).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
