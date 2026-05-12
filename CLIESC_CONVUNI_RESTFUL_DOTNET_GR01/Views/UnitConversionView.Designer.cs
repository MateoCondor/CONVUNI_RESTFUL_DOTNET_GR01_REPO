namespace CLIESC_CONVUNI_RESTFUL_DOTNET_GR01.Views
{
    partial class UnitConversionView
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
            label1 = new Label();
            UnitConversionTypeSelect = new ComboBox();
            ConversionUnitSourceSelect = new ComboBox();
            ConversionUnitDestinationSelect = new ComboBox();
            ConversionUnitValueTextBox = new TextBox();
            SubmitButton = new Button();
            ConversionUnitResultTextBox = new TextBox();
            ErrorTextBox = new Label();
            LogoutButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(28, 63, 97);
            label1.Location = new Point(75, 22);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 0;
            label1.Text = "Conversión de Unidades";
            // 
            // UnitConversionTypeSelect
            // 
            UnitConversionTypeSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            UnitConversionTypeSelect.FormattingEnabled = true;
            UnitConversionTypeSelect.Location = new Point(24, 83);
            UnitConversionTypeSelect.Name = "UnitConversionTypeSelect";
            UnitConversionTypeSelect.Size = new Size(140, 23);
            UnitConversionTypeSelect.TabIndex = 2;
            UnitConversionTypeSelect.SelectedValueChanged += ConversionTypeSelect_SelectedValueChanged;
            // 
            // ConversionUnitSourceSelect
            // 
            ConversionUnitSourceSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ConversionUnitSourceSelect.FlatStyle = FlatStyle.System;
            ConversionUnitSourceSelect.FormattingEnabled = true;
            ConversionUnitSourceSelect.Location = new Point(24, 146);
            ConversionUnitSourceSelect.Name = "ConversionUnitSourceSelect";
            ConversionUnitSourceSelect.Size = new Size(140, 23);
            ConversionUnitSourceSelect.TabIndex = 3;
            // 
            // ConversionUnitDestinationSelect
            // 
            ConversionUnitDestinationSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ConversionUnitDestinationSelect.FormattingEnabled = true;
            ConversionUnitDestinationSelect.Location = new Point(210, 146);
            ConversionUnitDestinationSelect.Name = "ConversionUnitDestinationSelect";
            ConversionUnitDestinationSelect.Size = new Size(140, 23);
            ConversionUnitDestinationSelect.TabIndex = 4;
            // 
            // ConversionUnitValueTextBox
            // 
            ConversionUnitValueTextBox.Location = new Point(24, 215);
            ConversionUnitValueTextBox.Name = "ConversionUnitValueTextBox";
            ConversionUnitValueTextBox.Size = new Size(140, 23);
            ConversionUnitValueTextBox.TabIndex = 8;
            ConversionUnitValueTextBox.KeyPress += ConversionValueTextBox_KeyPress;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.FromArgb(90, 168, 230);
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.ForeColor = Color.White;
            SubmitButton.Location = new Point(45, 267);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(99, 31);
            SubmitButton.TabIndex = 9;
            SubmitButton.Text = "Convertir";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ConversionUnitResultTextBox
            // 
            ConversionUnitResultTextBox.BackColor = Color.White;
            ConversionUnitResultTextBox.Location = new Point(210, 215);
            ConversionUnitResultTextBox.Name = "ConversionUnitResultTextBox";
            ConversionUnitResultTextBox.ReadOnly = true;
            ConversionUnitResultTextBox.Size = new Size(140, 23);
            ConversionUnitResultTextBox.TabIndex = 10;
            // 
            // ErrorTextBox
            // 
            ErrorTextBox.ForeColor = Color.Red;
            ErrorTextBox.Location = new Point(24, 319);
            ErrorTextBox.Name = "ErrorTextBox";
            ErrorTextBox.Size = new Size(326, 36);
            ErrorTextBox.TabIndex = 12;
            ErrorTextBox.Text = "Mensaje de error";
            ErrorTextBox.TextAlign = ContentAlignment.TopCenter;
            ErrorTextBox.Visible = false;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(90, 168, 230);
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(222, 269);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(107, 29);
            LogoutButton.TabIndex = 13;
            LogoutButton.Text = "Cerrar sesión";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ConversionUnitResultTextBox);
            panel1.Controls.Add(ConversionUnitValueTextBox);
            panel1.Controls.Add(ConversionUnitSourceSelect);
            panel1.Controls.Add(ConversionUnitDestinationSelect);
            panel1.Controls.Add(UnitConversionTypeSelect);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(ErrorTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SubmitButton);
            panel1.Location = new Point(25, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 361);
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 65);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 14;
            label2.Text = "Tipo de conversión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 128);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 15;
            label3.Text = "Origen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 128);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 16;
            label4.Text = "Destino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 197);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 17;
            label5.Text = "Valor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 197);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 18;
            label6.Text = "Resultado";
            // 
            // UnitConversionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 247, 255);
            ClientSize = new Size(421, 433);
            Controls.Add(panel1);
            Name = "UnitConversionView";
            Text = "Conversión de Unidades";
            FormClosed += UnitConversionView_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox UnitConversionTypeSelect;
        private ComboBox ConversionUnitSourceSelect;
        private ComboBox ConversionUnitDestinationSelect;
        private TextBox ConversionUnitValueTextBox;
        private Button SubmitButton;
        private TextBox ConversionUnitResultTextBox;
        private Label ErrorTextBox;
        private Button LogoutButton;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}