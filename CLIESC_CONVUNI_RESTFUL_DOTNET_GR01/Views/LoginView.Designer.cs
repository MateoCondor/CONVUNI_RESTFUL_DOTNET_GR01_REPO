namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views
{
    partial class LoginView
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
            label1 = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SubmitButton = new Button();
            ErrorTextBox = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            label2 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(102, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesión";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.BorderStyle = BorderStyle.None;
            UsernameTextBox.Location = new Point(6, 18);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(182, 16);
            UsernameTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Location = new Point(6, 18);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(182, 16);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(90, 168, 230);
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(55, 172);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(194, 27);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Ingresar";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ErrorTextBox
            // 
            ErrorTextBox.ForeColor = Color.Red;
            ErrorTextBox.Location = new Point(24, 218);
            ErrorTextBox.Name = "ErrorTextBox";
            ErrorTextBox.Size = new Size(250, 35);
            ErrorTextBox.TabIndex = 6;
            ErrorTextBox.Text = "Mensaje de error";
            ErrorTextBox.TextAlign = ContentAlignment.TopCenter;
            ErrorTextBox.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(UsernameTextBox);
            groupBox2.Location = new Point(55, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(194, 40);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuario";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(PasswordTextBox);
            groupBox3.Location = new Point(55, 112);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(194, 40);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(SubmitButton);
            panel1.Controls.Add(ErrorTextBox);
            panel1.Location = new Point(114, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 262);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(28, 63, 97);
            label2.Location = new Point(132, 31);
            label2.Name = "label2";
            label2.Size = new Size(265, 25);
            label2.TabIndex = 9;
            label2.Text = "CONVERSIÓN DE UNIDADES";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 247, 255);
            ClientSize = new Size(514, 409);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "LoginView";
            Text = "Conversión de Unidades";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button SubmitButton;
        private Label ErrorTextBox;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Panel panel1;
        private Label label2;
    }
}
