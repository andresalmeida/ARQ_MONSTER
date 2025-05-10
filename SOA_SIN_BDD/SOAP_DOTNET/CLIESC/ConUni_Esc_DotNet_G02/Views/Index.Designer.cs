//namespace ConUni_Esc_DotNet_G02.Views
//{
//    partial class Index
//    {
//        private System.ComponentModel.IContainer components = null;

//        // Variables para los controles
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.TextBox txtCelsius;
//        private System.Windows.Forms.Button btnConvertToFahrenheit;
//        private System.Windows.Forms.Label lblFahrenheitResult;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.TextBox txtFahrenheit;
//        private System.Windows.Forms.Button btnConvertToCelsius;
//        private System.Windows.Forms.Label lblCelsiusResult;
//        private System.Windows.Forms.Button btnLogout;

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
//            label1 = new Label();
//            txtCelsius = new TextBox();
//            btnConvertToFahrenheit = new Button();
//            lblFahrenheitResult = new Label();
//            label2 = new Label();
//            txtFahrenheit = new TextBox();
//            btnConvertToCelsius = new Button();
//            lblCelsiusResult = new Label();
//            btnLogout = new Button();
//            SuspendLayout();
//            // 
//            // label1
//            // 
//            label1.AutoSize = true;
//            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
//            label1.ForeColor = Color.Gold;
//            label1.Location = new Point(12, 15);
//            label1.Name = "label1";
//            label1.Size = new Size(216, 29);
//            label1.TabIndex = 0;
//            label1.Text = "👾 Ingresar Celsius:";
//            // 
//            // txtCelsius
//            // 
//            txtCelsius.Location = new Point(12, 47);
//            txtCelsius.Name = "txtCelsius";
//            txtCelsius.Size = new Size(576, 27);
//            txtCelsius.TabIndex = 1;
//            // 
//            // btnConvertToFahrenheit
//            // 
//            btnConvertToFahrenheit.BackColor = Color.LightSkyBlue;
//            btnConvertToFahrenheit.FlatStyle = FlatStyle.Flat;
//            btnConvertToFahrenheit.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            btnConvertToFahrenheit.ForeColor = Color.White;
//            btnConvertToFahrenheit.Location = new Point(12, 80);
//            btnConvertToFahrenheit.Name = "btnConvertToFahrenheit";
//            btnConvertToFahrenheit.Size = new Size(576, 35);
//            btnConvertToFahrenheit.TabIndex = 2;
//            btnConvertToFahrenheit.Text = "Convertir a °F";
//            btnConvertToFahrenheit.UseVisualStyleBackColor = false;
//            btnConvertToFahrenheit.Click += btnConvertToFahrenheit_Click;
//            // 
//            // lblFahrenheitResult
//            // 
//            lblFahrenheitResult.AutoSize = true;
//            lblFahrenheitResult.Location = new Point(12, 118);
//            lblFahrenheitResult.Name = "lblFahrenheitResult";
//            lblFahrenheitResult.Size = new Size(119, 20);
//            lblFahrenheitResult.TabIndex = 3;
//            lblFahrenheitResult.Text = "Resultado en °F: ";
//            // 
//            // label2
//            // 
//            label2.AutoSize = true;
//            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
//            label2.ForeColor = Color.Gold;
//            label2.Location = new Point(12, 215);
//            label2.Name = "label2";
//            label2.Size = new Size(256, 29);
//            label2.TabIndex = 4;
//            label2.Text = "👾 Ingresar Fahrenheit:";
//            // 
//            // txtFahrenheit
//            // 
//            txtFahrenheit.Location = new Point(12, 247);
//            txtFahrenheit.Name = "txtFahrenheit";
//            txtFahrenheit.Size = new Size(576, 27);
//            txtFahrenheit.TabIndex = 5;
//            // 
//            // btnConvertToCelsius
//            // 
//            btnConvertToCelsius.BackColor = Color.LightSkyBlue;
//            btnConvertToCelsius.FlatStyle = FlatStyle.Flat;
//            btnConvertToCelsius.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            btnConvertToCelsius.ForeColor = Color.White;
//            btnConvertToCelsius.Location = new Point(12, 280);
//            btnConvertToCelsius.Name = "btnConvertToCelsius";
//            btnConvertToCelsius.Size = new Size(576, 35);
//            btnConvertToCelsius.TabIndex = 6;
//            btnConvertToCelsius.Text = "Convertir a °C";
//            btnConvertToCelsius.UseVisualStyleBackColor = false;
//            btnConvertToCelsius.Click += btnConvertToCelsius_Click;
//            // 
//            // lblCelsiusResult
//            // 
//            lblCelsiusResult.AutoSize = true;
//            lblCelsiusResult.Location = new Point(12, 318);
//            lblCelsiusResult.Name = "lblCelsiusResult";
//            lblCelsiusResult.Size = new Size(121, 20);
//            lblCelsiusResult.TabIndex = 7;
//            lblCelsiusResult.Text = "Resultado en °C: ";
//            // 
//            // btnLogout
//            // 
//            btnLogout.BackColor = Color.OrangeRed;
//            btnLogout.FlatStyle = FlatStyle.Flat;
//            btnLogout.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
//            btnLogout.ForeColor = Color.White;
//            btnLogout.Location = new Point(182, 439);
//            btnLogout.Name = "btnLogout";
//            btnLogout.Size = new Size(232, 35);
//            btnLogout.TabIndex = 8;
//            btnLogout.Text = "Cerrar Sesión";
//            btnLogout.UseVisualStyleBackColor = false;
//            btnLogout.Click += btnLogout_Click;
//            // 
//            // Index
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(600, 650);
//            Controls.Add(btnLogout);
//            Controls.Add(lblCelsiusResult);
//            Controls.Add(btnConvertToCelsius);
//            Controls.Add(txtFahrenheit);
//            Controls.Add(label2);
//            Controls.Add(lblFahrenheitResult);
//            Controls.Add(btnConvertToFahrenheit);
//            Controls.Add(txtCelsius);
//            Controls.Add(label1);
//            Name = "Index";
//            Text = "Conversión de Temperatura";
//            ResumeLayout(false);
//            PerformLayout();
//        }
//    }
//}

namespace ConUni_Esc_DotNet_G02.Views
{
    partial class Index
    {
        private System.ComponentModel.IContainer components = null;

        // Variables para los controles
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCelsiusPrompt;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Button btnConvertToFahrenheit;
        private System.Windows.Forms.Label lblFahrenheitResult;
        private System.Windows.Forms.Label lblFahrenheitPrompt;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnConvertToCelsius;
        private System.Windows.Forms.Label lblCelsiusResult;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBoxBackground;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnShowBooModal;
        private System.Windows.Forms.Panel booModalPanel;
        private System.Windows.Forms.PictureBox booImage;
        private System.Windows.Forms.Label lblBooTitle;
        private System.Windows.Forms.Label lblBooExplanation;
        private System.Windows.Forms.Button btnCloseBoo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblCelsiusPrompt = new Label();
            txtCelsius = new TextBox();
            btnConvertToFahrenheit = new Button();
            lblFahrenheitResult = new Label();
            lblFahrenheitPrompt = new Label();
            txtFahrenheit = new TextBox();
            btnConvertToCelsius = new Button();
            lblCelsiusResult = new Label();
            btnLogout = new Button();
            pictureBoxBackground = new PictureBox();
            panelMain = new Panel();
            btnShowBooModal = new Button();
            booModalPanel = new Panel();
            booImage = new PictureBox();
            lblBooTitle = new Label();
            lblBooExplanation = new Label();
            btnCloseBoo = new Button();

            ((System.ComponentModel.ISupportInitialize)(pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(booImage)).BeginInit();
            panelMain.SuspendLayout();
            booModalPanel.SuspendLayout();
            SuspendLayout();

            // 
            // pictureBoxBackground
            // 
            pictureBoxBackground.Dock = DockStyle.Fill;
            pictureBoxBackground.Image = Image.FromFile("Resources\\sulli.jpg"); // Cambia a la ruta correcta de tu imagen
            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxBackground.Location = new Point(0, 0);
            pictureBoxBackground.Name = "pictureBoxBackground";
            pictureBoxBackground.Size = new Size(800, 700);
            pictureBoxBackground.TabIndex = 0;
            pictureBoxBackground.TabStop = false;

            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.FromArgb(0, 0, 0, 150);
            panelMain.Location = new Point(100, 50);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(600, 600);
            panelMain.TabIndex = 10;
            panelMain.Padding = new Padding(40);
            panelMain.BorderStyle = BorderStyle.None;
            // Agregamos controles al panel
            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblCelsiusPrompt);
            panelMain.Controls.Add(txtCelsius);
            panelMain.Controls.Add(btnConvertToFahrenheit);
            panelMain.Controls.Add(lblFahrenheitResult);
            panelMain.Controls.Add(lblFahrenheitPrompt);
            panelMain.Controls.Add(txtFahrenheit);
            panelMain.Controls.Add(btnConvertToCelsius);
            panelMain.Controls.Add(lblCelsiusResult);
            panelMain.Controls.Add(btnLogout);
            panelMain.Controls.Add(btnShowBooModal);

            // Crear un efecto de sombra y bordes redondeados para el panel
            panelMain.Paint += (sender, e) => {
                using (var brush = new SolidBrush(Color.FromArgb(160, 0, 0, 0)))
                {
                    // Rellenar el panel con un color semitransparente
                    e.Graphics.FillRectangle(brush, panelMain.ClientRectangle);
                }
                // Dibujar un borde sutil
                ControlPaint.DrawBorder(e.Graphics, panelMain.ClientRectangle,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(80, 255, 255, 255), 1, ButtonBorderStyle.Solid);
            };

            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(540, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎓 CONVERSIÓN UNIDADES MONSTER G02";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // Agregar sombra al texto del título
            //lblTitle.Paint += (sender, e) => {
            //    e.Graphics.DrawString(lblTitle.Text, lblTitle.Font,
            //        new SolidBrush(Color.FromArgb(100, 0, 0, 0)),
            //        new PointF(2, 2), StringFormat.GenericDefault);
            //};

            // 
            // lblCelsiusPrompt
            // 
            lblCelsiusPrompt.BackColor = Color.Transparent;
            lblCelsiusPrompt.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblCelsiusPrompt.ForeColor = Color.White;
            lblCelsiusPrompt.Location = new Point(40, 90);
            lblCelsiusPrompt.Name = "lblCelsiusPrompt";
            lblCelsiusPrompt.Size = new Size(520, 30);
            lblCelsiusPrompt.TabIndex = 1;
            lblCelsiusPrompt.Text = "👾 Ingresar Celsius:";

            // 
            // txtCelsius
            // 
            txtCelsius.Font = new Font("Segoe UI", 11F);
            txtCelsius.Location = new Point(40, 125);
            txtCelsius.Margin = new Padding(3, 5, 3, 10);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(520, 32);
            txtCelsius.TabIndex = 2;
            txtCelsius.BorderStyle = BorderStyle.FixedSingle;

            // 
            // btnConvertToFahrenheit
            // 
            btnConvertToFahrenheit.BackColor = Color.FromArgb(93, 156, 236);
            btnConvertToFahrenheit.FlatStyle = FlatStyle.Flat;
            btnConvertToFahrenheit.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnConvertToFahrenheit.ForeColor = Color.White;
            btnConvertToFahrenheit.Location = new Point(40, 167);
            btnConvertToFahrenheit.Margin = new Padding(3, 0, 3, 10);
            btnConvertToFahrenheit.Name = "btnConvertToFahrenheit";
            btnConvertToFahrenheit.Size = new Size(520, 40);
            btnConvertToFahrenheit.TabIndex = 3;
            btnConvertToFahrenheit.Text = "Convertir a °F";
            btnConvertToFahrenheit.UseVisualStyleBackColor = false;
            btnConvertToFahrenheit.FlatAppearance.BorderSize = 0;
            btnConvertToFahrenheit.Cursor = Cursors.Hand;
            btnConvertToFahrenheit.Click += btnConvertToFahrenheit_Click;
            // Eventos para efectos de hover
            btnConvertToFahrenheit.MouseEnter += (sender, e) => {
                btnConvertToFahrenheit.BackColor = Color.FromArgb(74, 137, 220);
            };
            btnConvertToFahrenheit.MouseLeave += (sender, e) => {
                btnConvertToFahrenheit.BackColor = Color.FromArgb(93, 156, 236);
            };

            // 
            // lblFahrenheitResult
            // 
            lblFahrenheitResult.BackColor = Color.Transparent;
            lblFahrenheitResult.Font = new Font("Comic Sans MS", 10F);
            lblFahrenheitResult.ForeColor = Color.White;
            lblFahrenheitResult.Location = new Point(40, 217);
            lblFahrenheitResult.Margin = new Padding(3, 0, 3, 20);
            lblFahrenheitResult.Name = "lblFahrenheitResult";
            lblFahrenheitResult.Size = new Size(520, 25);
            lblFahrenheitResult.TabIndex = 4;
            lblFahrenheitResult.Text = "Resultado en °F: ";

            // 
            // lblFahrenheitPrompt
            // 
            lblFahrenheitPrompt.BackColor = Color.Transparent;
            lblFahrenheitPrompt.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            lblFahrenheitPrompt.ForeColor = Color.White;
            lblFahrenheitPrompt.Location = new Point(40, 262);
            lblFahrenheitPrompt.Name = "lblFahrenheitPrompt";
            lblFahrenheitPrompt.Size = new Size(520, 30);
            lblFahrenheitPrompt.TabIndex = 5;
            lblFahrenheitPrompt.Text = "👾 Ingresar Fahrenheit:";

            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Font = new Font("Segoe UI", 11F);
            txtFahrenheit.Location = new Point(40, 297);
            txtFahrenheit.Margin = new Padding(3, 5, 3, 10);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(520, 32);
            txtFahrenheit.TabIndex = 6;
            txtFahrenheit.BorderStyle = BorderStyle.FixedSingle;

            // 
            // btnConvertToCelsius
            // 
            btnConvertToCelsius.BackColor = Color.FromArgb(93, 156, 236);
            btnConvertToCelsius.FlatStyle = FlatStyle.Flat;
            btnConvertToCelsius.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnConvertToCelsius.ForeColor = Color.White;
            btnConvertToCelsius.Location = new Point(40, 339);
            btnConvertToCelsius.Margin = new Padding(3, 0, 3, 10);
            btnConvertToCelsius.Name = "btnConvertToCelsius";
            btnConvertToCelsius.Size = new Size(520, 40);
            btnConvertToCelsius.TabIndex = 7;
            btnConvertToCelsius.Text = "Convertir a °C";
            btnConvertToCelsius.UseVisualStyleBackColor = false;
            btnConvertToCelsius.FlatAppearance.BorderSize = 0;
            btnConvertToCelsius.Cursor = Cursors.Hand;
            btnConvertToCelsius.Click += btnConvertToCelsius_Click;
            btnConvertToCelsius.MouseEnter += (sender, e) => {
                btnConvertToCelsius.BackColor = Color.FromArgb(74, 137, 220);
            };
            btnConvertToCelsius.MouseLeave += (sender, e) => {
                btnConvertToCelsius.BackColor = Color.FromArgb(93, 156, 236);
            };

            // 
            // lblCelsiusResult
            // 
            lblCelsiusResult.BackColor = Color.Transparent;
            lblCelsiusResult.Font = new Font("Comic Sans MS", 10F);
            lblCelsiusResult.ForeColor = Color.White;
            lblCelsiusResult.Location = new Point(40, 389);
            lblCelsiusResult.Margin = new Padding(3, 0, 3, 20);
            lblCelsiusResult.Name = "lblCelsiusResult";
            lblCelsiusResult.Size = new Size(520, 25);
            lblCelsiusResult.TabIndex = 8;
            lblCelsiusResult.Text = "Resultado en °C: ";

            // 
            // btnShowBooModal
            // 
            btnShowBooModal.BackColor = Color.FromArgb(241, 196, 15);
            btnShowBooModal.FlatStyle = FlatStyle.Flat;
            btnShowBooModal.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnShowBooModal.ForeColor = Color.White;
            btnShowBooModal.Location = new Point(40, 434);
            btnShowBooModal.Name = "btnShowBooModal";
            btnShowBooModal.Size = new Size(520, 40);
            btnShowBooModal.TabIndex = 9;
            btnShowBooModal.Text = "👧 ¿Necesitas ayuda de Boo?";
            btnShowBooModal.UseVisualStyleBackColor = false;
            btnShowBooModal.FlatAppearance.BorderSize = 0;
            btnShowBooModal.Cursor = Cursors.Hand;
            btnShowBooModal.Click += (sender, e) => {
                booModalPanel.Visible = true;
                booModalPanel.BringToFront();
            };
            btnShowBooModal.MouseEnter += (sender, e) => {
                btnShowBooModal.BackColor = Color.FromArgb(212, 172, 13);
            };
            btnShowBooModal.MouseLeave += (sender, e) => {
                btnShowBooModal.BackColor = Color.FromArgb(241, 196, 15);
            };

            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(150, 494);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(300, 40);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Cerrar Sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseEnter += (sender, e) => {
                btnLogout.BackColor = Color.FromArgb(203, 67, 53);
            };
            btnLogout.MouseLeave += (sender, e) => {
                btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            };

            // 
            // booModalPanel
            // 
            booModalPanel.BackColor = Color.FromArgb(44, 62, 80);
            booModalPanel.Location = new Point(150, 150);
            booModalPanel.Name = "booModalPanel";
            booModalPanel.Size = new Size(500, 400);
            booModalPanel.TabIndex = 11;
            booModalPanel.Visible = false;
            booModalPanel.Controls.Add(booImage);
            booModalPanel.Controls.Add(lblBooTitle);
            booModalPanel.Controls.Add(lblBooExplanation);
            booModalPanel.Controls.Add(btnCloseBoo);
            booModalPanel.BorderStyle = BorderStyle.None;
            booModalPanel.Paint += (sender, e) => {
                // Dibujar un borde sutil
                ControlPaint.DrawBorder(e.Graphics, booModalPanel.ClientRectangle,
                    Color.FromArgb(150, 255, 255, 255), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(150, 255, 255, 255), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(150, 255, 255, 255), 2, ButtonBorderStyle.Solid,
                    Color.FromArgb(150, 255, 255, 255), 2, ButtonBorderStyle.Solid);
            };

            // 
            // booImage
            // 
            booImage.Image = Image.FromFile("Resources\\buu.jpg"); // Cambia a la ruta correcta de tu imagen
            booImage.Location = new Point(30, 100);
            booImage.Name = "booImage";
            booImage.Size = new Size(150, 200);
            booImage.SizeMode = PictureBoxSizeMode.StretchImage;
            booImage.TabIndex = 0;
            booImage.TabStop = false;

            // 
            // lblBooTitle
            // 
            lblBooTitle.Font = new Font("Comic Sans MS", 14F, FontStyle.Bold);
            lblBooTitle.ForeColor = Color.FromArgb(241, 196, 15);
            lblBooTitle.Location = new Point(30, 20);
            lblBooTitle.Name = "lblBooTitle";
            lblBooTitle.Size = new Size(440, 40);
            lblBooTitle.TabIndex = 1;
            lblBooTitle.Text = "👧 Hola, soy Boo!";
            lblBooTitle.TextAlign = ContentAlignment.MiddleLeft;

            // 
            // lblBooExplanation
            // 
            lblBooExplanation.Font = new Font("Comic Sans MS", 10F);
            lblBooExplanation.ForeColor = Color.FromArgb(241, 196, 15);
            lblBooExplanation.Location = new Point(200, 100);
            lblBooExplanation.Name = "lblBooExplanation";
            lblBooExplanation.Size = new Size(270, 200);
            lblBooExplanation.TabIndex = 2;
            lblBooExplanation.Text = "¡Hoy te voy a ayudar a convertir entre Celsius y Fahrenheit. ¡Es super fácil!\r\n\r\nSi tienes grados Celsius, haz clic en \"Convertir a °F\", y si tienes grados Fahrenheit, haz lo mismo para convertirlo a °C.";

            // 
            // btnCloseBoo
            // 
            btnCloseBoo.BackColor = Color.FromArgb(44, 62, 80);
            btnCloseBoo.FlatStyle = FlatStyle.Flat;
            btnCloseBoo.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCloseBoo.ForeColor = Color.White;
            btnCloseBoo.Location = new Point(460, 10);
            btnCloseBoo.Name = "btnCloseBoo";
            btnCloseBoo.Size = new Size(30, 30);
            btnCloseBoo.TabIndex = 3;
            btnCloseBoo.Text = "X";
            btnCloseBoo.UseVisualStyleBackColor = false;
            btnCloseBoo.FlatAppearance.BorderSize = 0;
            btnCloseBoo.Cursor = Cursors.Hand;
            btnCloseBoo.Click += (sender, e) => {
                booModalPanel.Visible = false;
            };

            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(800, 700);
            Controls.Add(booModalPanel);
            Controls.Add(panelMain);
            Controls.Add(pictureBoxBackground);
            pictureBoxBackground.SendToBack();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de Temperatura - Monster G02";
            ((System.ComponentModel.ISupportInitialize)(pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(booImage)).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            booModalPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}