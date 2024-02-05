namespace WinFormsAppFirst
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
            components = new System.ComponentModel.Container();
            buttonHello = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            labelSchoolSubject = new Label();
            checkBoxSchoolSubjectMathematics = new CheckBox();
            checkBoxSchoolSubjectEnglish = new CheckBox();
            radioButtonPizzaQuestionYes = new RadioButton();
            radioButtonPizzaQuestionNo = new RadioButton();
            labelPizzaQuestion = new Label();
            comboBoxFavouriteMeal = new ComboBox();
            labelFavouriteMeal = new Label();
            labelCurrentTimeDesciption = new Label();
            labelCurrentTime = new Label();
            buttonRefreshTime = new Button();
            timerRefreshTime = new System.Windows.Forms.Timer(components);
            labelMouseClick = new Label();
            numericUpDownFirstNumber = new NumericUpDown();
            numericUpDownSecondNumber = new NumericUpDown();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMul = new Button();
            buttonDiv = new Button();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNumber).BeginInit();
            SuspendLayout();
            // 
            // buttonHello
            // 
            buttonHello.Location = new Point(120, 280);
            buttonHello.Name = "buttonHello";
            buttonHello.Size = new Size(232, 88);
            buttonHello.TabIndex = 1;
            buttonHello.Text = "Hello";
            buttonHello.UseVisualStyleBackColor = true;
            buttonHello.Click += buttonHello_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(431, 23);
            textBoxName.TabIndex = 0;
            textBoxName.Text = "Jan";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.FromArgb(128, 64, 0);
            labelName.Location = new Point(12, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(160, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Enter your name";
            // 
            // labelSchoolSubject
            // 
            labelSchoolSubject.AutoSize = true;
            labelSchoolSubject.Location = new Point(12, 63);
            labelSchoolSubject.Name = "labelSchoolSubject";
            labelSchoolSubject.Size = new Size(173, 15);
            labelSchoolSubject.TabIndex = 3;
            labelSchoolSubject.Text = "What's your fav school subject?";
            // 
            // checkBoxSchoolSubjectMathematics
            // 
            checkBoxSchoolSubjectMathematics.AutoSize = true;
            checkBoxSchoolSubjectMathematics.Location = new Point(15, 95);
            checkBoxSchoolSubjectMathematics.Name = "checkBoxSchoolSubjectMathematics";
            checkBoxSchoolSubjectMathematics.Size = new Size(54, 19);
            checkBoxSchoolSubjectMathematics.TabIndex = 2;
            checkBoxSchoolSubjectMathematics.Text = "math";
            checkBoxSchoolSubjectMathematics.UseVisualStyleBackColor = true;
            // 
            // checkBoxSchoolSubjectEnglish
            // 
            checkBoxSchoolSubjectEnglish.AutoSize = true;
            checkBoxSchoolSubjectEnglish.Location = new Point(15, 120);
            checkBoxSchoolSubjectEnglish.Name = "checkBoxSchoolSubjectEnglish";
            checkBoxSchoolSubjectEnglish.Size = new Size(64, 19);
            checkBoxSchoolSubjectEnglish.TabIndex = 3;
            checkBoxSchoolSubjectEnglish.Text = "english";
            checkBoxSchoolSubjectEnglish.UseVisualStyleBackColor = true;
            // 
            // radioButtonPizzaQuestionYes
            // 
            radioButtonPizzaQuestionYes.AutoSize = true;
            radioButtonPizzaQuestionYes.Location = new Point(401, 94);
            radioButtonPizzaQuestionYes.Name = "radioButtonPizzaQuestionYes";
            radioButtonPizzaQuestionYes.Size = new Size(42, 19);
            radioButtonPizzaQuestionYes.TabIndex = 4;
            radioButtonPizzaQuestionYes.Text = "Yes";
            radioButtonPizzaQuestionYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonPizzaQuestionNo
            // 
            radioButtonPizzaQuestionNo.AutoSize = true;
            radioButtonPizzaQuestionNo.Checked = true;
            radioButtonPizzaQuestionNo.Location = new Point(402, 120);
            radioButtonPizzaQuestionNo.Name = "radioButtonPizzaQuestionNo";
            radioButtonPizzaQuestionNo.Size = new Size(41, 19);
            radioButtonPizzaQuestionNo.TabIndex = 5;
            radioButtonPizzaQuestionNo.TabStop = true;
            radioButtonPizzaQuestionNo.Text = "No";
            radioButtonPizzaQuestionNo.UseVisualStyleBackColor = true;
            // 
            // labelPizzaQuestion
            // 
            labelPizzaQuestion.AutoSize = true;
            labelPizzaQuestion.Location = new Point(324, 63);
            labelPizzaQuestion.Name = "labelPizzaQuestion";
            labelPizzaQuestion.Size = new Size(119, 15);
            labelPizzaQuestion.TabIndex = 8;
            labelPizzaQuestion.Text = "Pizza with pineapple?";
            // 
            // comboBoxFavouriteMeal
            // 
            comboBoxFavouriteMeal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFavouriteMeal.FormattingEnabled = true;
            comboBoxFavouriteMeal.Items.AddRange(new object[] { "kebab", "pizza", "ramen", "chicken  with rise", "potatos" });
            comboBoxFavouriteMeal.Location = new Point(15, 199);
            comboBoxFavouriteMeal.Name = "comboBoxFavouriteMeal";
            comboBoxFavouriteMeal.Size = new Size(428, 23);
            comboBoxFavouriteMeal.TabIndex = 9;
            // 
            // labelFavouriteMeal
            // 
            labelFavouriteMeal.AutoSize = true;
            labelFavouriteMeal.Location = new Point(16, 181);
            labelFavouriteMeal.Name = "labelFavouriteMeal";
            labelFavouriteMeal.Size = new Size(54, 15);
            labelFavouriteMeal.TabIndex = 10;
            labelFavouriteMeal.Text = "Fav meal";
            // 
            // labelCurrentTimeDesciption
            // 
            labelCurrentTimeDesciption.AutoSize = true;
            labelCurrentTimeDesciption.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentTimeDesciption.Location = new Point(579, 37);
            labelCurrentTimeDesciption.Name = "labelCurrentTimeDesciption";
            labelCurrentTimeDesciption.Size = new Size(176, 37);
            labelCurrentTimeDesciption.TabIndex = 11;
            labelCurrentTimeDesciption.Text = "Current Time:";
            // 
            // labelCurrentTime
            // 
            labelCurrentTime.AutoSize = true;
            labelCurrentTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentTime.Location = new Point(579, 89);
            labelCurrentTime.Name = "labelCurrentTime";
            labelCurrentTime.Size = new Size(68, 30);
            labelCurrentTime.TabIndex = 12;
            labelCurrentTime.Text = "label1";
            // 
            // buttonRefreshTime
            // 
            buttonRefreshTime.Location = new Point(579, 181);
            buttonRefreshTime.Name = "buttonRefreshTime";
            buttonRefreshTime.Size = new Size(124, 36);
            buttonRefreshTime.TabIndex = 13;
            buttonRefreshTime.Text = "Refresh Time";
            buttonRefreshTime.UseVisualStyleBackColor = true;
            buttonRefreshTime.Click += buttonRefreshTime_Click;
            // 
            // timerRefreshTime
            // 
            timerRefreshTime.Enabled = true;
            timerRefreshTime.Interval = 1000;
            timerRefreshTime.Tick += timerRefreshTime_Tick;
            // 
            // labelMouseClick
            // 
            labelMouseClick.AutoSize = true;
            labelMouseClick.BackColor = SystemColors.Control;
            labelMouseClick.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelMouseClick.ForeColor = Color.FromArgb(192, 0, 0);
            labelMouseClick.Location = new Point(546, 251);
            labelMouseClick.Name = "labelMouseClick";
            labelMouseClick.Size = new Size(157, 32);
            labelMouseClick.TabIndex = 14;
            labelMouseClick.Text = "Not click yet";
            labelMouseClick.MouseClick += labelMouseClick_MouseClick;
            // 
            // numericUpDownFirstNumber
            // 
            numericUpDownFirstNumber.Location = new Point(435, 346);
            numericUpDownFirstNumber.Name = "numericUpDownFirstNumber";
            numericUpDownFirstNumber.Size = new Size(120, 23);
            numericUpDownFirstNumber.TabIndex = 15;
            // 
            // numericUpDownSecondNumber
            // 
            numericUpDownSecondNumber.Location = new Point(626, 346);
            numericUpDownSecondNumber.Name = "numericUpDownSecondNumber";
            numericUpDownSecondNumber.Size = new Size(120, 23);
            numericUpDownSecondNumber.TabIndex = 16;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(402, 388);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(86, 34);
            buttonAdd.TabIndex = 17;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += operation_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(494, 388);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(86, 34);
            buttonSub.TabIndex = 18;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += operation_Click;
            // 
            // buttonMul
            // 
            buttonMul.Location = new Point(586, 388);
            buttonMul.Name = "buttonMul";
            buttonMul.Size = new Size(86, 34);
            buttonMul.TabIndex = 19;
            buttonMul.Text = "*";
            buttonMul.UseVisualStyleBackColor = true;
            buttonMul.Click += operation_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(678, 388);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(86, 34);
            buttonDiv.TabIndex = 20;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += operation_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelResult.Location = new Point(494, 443);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(81, 30);
            labelResult.TabIndex = 21;
            labelResult.Text = "Wynik: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(838, 495);
            Controls.Add(labelResult);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMul);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownSecondNumber);
            Controls.Add(numericUpDownFirstNumber);
            Controls.Add(labelMouseClick);
            Controls.Add(buttonRefreshTime);
            Controls.Add(labelCurrentTime);
            Controls.Add(labelCurrentTimeDesciption);
            Controls.Add(labelFavouriteMeal);
            Controls.Add(comboBoxFavouriteMeal);
            Controls.Add(labelPizzaQuestion);
            Controls.Add(radioButtonPizzaQuestionNo);
            Controls.Add(radioButtonPizzaQuestionYes);
            Controls.Add(checkBoxSchoolSubjectEnglish);
            Controls.Add(checkBoxSchoolSubjectMathematics);
            Controls.Add(labelSchoolSubject);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonHello);
            Name = "MainForm";
            Text = "huj wie co";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHello;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelSchoolSubject;
        private CheckBox checkBoxSchoolSubjectMathematics;
        private CheckBox checkBoxSchoolSubjectEnglish;
        private RadioButton radioButtonPizzaQuestionYes;
        private RadioButton radioButtonPizzaQuestionNo;
        private Label labelPizzaQuestion;
        private ComboBox comboBoxFavouriteMeal;
        private Label labelFavouriteMeal;
        private Label labelCurrentTimeDesciption;
        private Label labelCurrentTime;
        private Button buttonRefreshTime;
        private System.Windows.Forms.Timer timerRefreshTime;
        private Label labelMouseClick;
        private NumericUpDown numericUpDownFirstNumber;
        private NumericUpDown numericUpDownSecondNumber;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMul;
        private Button buttonDiv;
        private Label labelResult;
    }
}