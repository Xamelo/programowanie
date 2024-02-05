namespace NotepadWinFormsApp
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            labelAbout = new Label();
            buttonClose = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // labelAbout
            // 
            labelAbout.AutoSize = true;
            labelAbout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAbout.Location = new Point(344, 26);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new Size(138, 25);
            labelAbout.TabIndex = 0;
            labelAbout.Text = "jebac sterydow";
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(325, 380);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(173, 58);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Zamknij";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(158, 64);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(508, 310);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(buttonClose);
            Controls.Add(labelAbout);
            Name = "AboutForm";
            Text = "O programie";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbout;
        private Button buttonClose;
        private PictureBox pictureBox;
    }
}