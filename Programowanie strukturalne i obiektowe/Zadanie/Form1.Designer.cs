namespace Zadanie
{
    partial class MainForm
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
            labelRegisterText = new Label();
            labelMail = new Label();
            textBoxMail = new TextBox();
            labelPassword = new Label();
            labelRepeatPass = new Label();
            textBoxPassword = new TextBox();
            textBoxRepeatPass = new TextBox();
            buttonSubmit = new Button();
            labelCommunication = new Label();
            SuspendLayout();
            // 
            // labelRegisterText
            // 
            labelRegisterText.BackColor = Color.Teal;
            labelRegisterText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelRegisterText.ForeColor = Color.White;
            labelRegisterText.Location = new Point(0, 0);
            labelRegisterText.Name = "labelRegisterText";
            labelRegisterText.Size = new Size(448, 32);
            labelRegisterText.TabIndex = 0;
            labelRegisterText.Text = "Rejestruj konto";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(0, 44);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(77, 15);
            labelMail.TabIndex = 1;
            labelMail.Text = "Podaj e-mail:";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(0, 62);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(448, 23);
            textBoxMail.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(0, 98);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(71, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Podaj hasło:";
            // 
            // labelRepeatPass
            // 
            labelRepeatPass.AutoSize = true;
            labelRepeatPass.Location = new Point(0, 166);
            labelRepeatPass.Name = "labelRepeatPass";
            labelRepeatPass.Size = new Size(81, 15);
            labelRepeatPass.TabIndex = 4;
            labelRepeatPass.Text = "Powtórz hasło";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(0, 116);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(448, 23);
            textBoxPassword.TabIndex = 5;
            // 
            // textBoxRepeatPass
            // 
            textBoxRepeatPass.Location = new Point(0, 184);
            textBoxRepeatPass.Name = "textBoxRepeatPass";
            textBoxRepeatPass.PasswordChar = '*';
            textBoxRepeatPass.Size = new Size(448, 23);
            textBoxRepeatPass.TabIndex = 6;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(172, 271);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(83, 23);
            buttonSubmit.TabIndex = 7;
            buttonSubmit.Text = "ZATWIERDŹ";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // labelCommunication
            // 
            labelCommunication.AutoSize = true;
            labelCommunication.Location = new Point(158, 329);
            labelCommunication.Name = "labelCommunication";
            labelCommunication.Size = new Size(97, 15);
            labelCommunication.TabIndex = 8;
            labelCommunication.Text = "XYZ 11111111111";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 450);
            Controls.Add(labelCommunication);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxRepeatPass);
            Controls.Add(textBoxPassword);
            Controls.Add(labelRepeatPass);
            Controls.Add(labelPassword);
            Controls.Add(textBoxMail);
            Controls.Add(labelMail);
            Controls.Add(labelRegisterText);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegisterText;
        private Label labelMail;
        private TextBox textBoxMail;
        private Label labelPassword;
        private Label labelRepeatPass;
        private TextBox textBoxPassword;
        private TextBox textBoxRepeatPass;
        private Button buttonSubmit;
        private Label labelCommunication;
    }
}