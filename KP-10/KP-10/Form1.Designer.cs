namespace KP_10
{
    partial class Form1
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
            textBoxPath = new TextBox();
            buttonCreate = new Button();
            buttonWrite = new Button();
            buttonRead = new Button();
            textBoxWriteText = new TextBox();
            textBoxReadText = new TextBox();
            textBoxNumLines = new TextBox();
            textBoxFindW = new TextBox();
            textBoxNumNeedLines = new TextBox();
            textBoxNumW = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonNumLines = new Button();
            buttonChangeW = new Button();
            buttonToUp = new Button();
            buttonNumOfContain = new Button();
            label5 = new Label();
            textBoxNewW = new TextBox();
            buttonToLow = new Button();
            SuspendLayout();
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(29, 41);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(279, 23);
            textBoxPath.TabIndex = 0;
            textBoxPath.Text = "C:\\Users\\shara\\source\\repos\\KP-10\\example.txt";
            textBoxPath.TextChanged += textBoxPath_TextChanged;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(340, 32);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(123, 42);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Создать файл";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonWrite
            // 
            buttonWrite.Location = new Point(340, 98);
            buttonWrite.Name = "buttonWrite";
            buttonWrite.Size = new Size(123, 42);
            buttonWrite.TabIndex = 2;
            buttonWrite.Text = "Записать в файл";
            buttonWrite.UseVisualStyleBackColor = true;
            buttonWrite.Click += buttonWrite_Click;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(580, 32);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(123, 42);
            buttonRead.TabIndex = 3;
            buttonRead.Text = "Прочитать файл";
            buttonRead.UseVisualStyleBackColor = true;
            buttonRead.Click += buttonRead_Click;
            // 
            // textBoxWriteText
            // 
            textBoxWriteText.Location = new Point(29, 109);
            textBoxWriteText.Multiline = true;
            textBoxWriteText.Name = "textBoxWriteText";
            textBoxWriteText.Size = new Size(279, 110);
            textBoxWriteText.TabIndex = 4;
            // 
            // textBoxReadText
            // 
            textBoxReadText.Location = new Point(497, 109);
            textBoxReadText.Multiline = true;
            textBoxReadText.Name = "textBoxReadText";
            textBoxReadText.Size = new Size(279, 110);
            textBoxReadText.TabIndex = 5;
            // 
            // textBoxNumLines
            // 
            textBoxNumLines.Location = new Point(291, 256);
            textBoxNumLines.Name = "textBoxNumLines";
            textBoxNumLines.Size = new Size(94, 23);
            textBoxNumLines.TabIndex = 6;
            // 
            // textBoxFindW
            // 
            textBoxFindW.Location = new Point(291, 285);
            textBoxFindW.Name = "textBoxFindW";
            textBoxFindW.Size = new Size(94, 23);
            textBoxFindW.TabIndex = 7;
            // 
            // textBoxNumNeedLines
            // 
            textBoxNumNeedLines.Location = new Point(291, 314);
            textBoxNumNeedLines.Name = "textBoxNumNeedLines";
            textBoxNumNeedLines.Size = new Size(94, 23);
            textBoxNumNeedLines.TabIndex = 8;
            // 
            // textBoxNumW
            // 
            textBoxNumW.Location = new Point(291, 343);
            textBoxNumW.Name = "textBoxNumW";
            textBoxNumW.Size = new Size(94, 23);
            textBoxNumW.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 259);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 10;
            label1.Text = "Количество строк в файле";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 288);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 11;
            label2.Text = "Искомая строка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 317);
            label3.Name = "label3";
            label3.Size = new Size(232, 15);
            label3.TabIndex = 12;
            label3.Text = "Количество строк с искомым символом";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 346);
            label4.Name = "label4";
            label4.Size = new Size(269, 15);
            label4.TabIndex = 13;
            label4.Text = "Число упоминаний искомого символа в тексте";
            // 
            // buttonNumLines
            // 
            buttonNumLines.Location = new Point(404, 250);
            buttonNumLines.Name = "buttonNumLines";
            buttonNumLines.Size = new Size(93, 33);
            buttonNumLines.TabIndex = 14;
            buttonNumLines.Text = "Счёт линий";
            buttonNumLines.UseVisualStyleBackColor = true;
            buttonNumLines.Click += buttonNumLines_Click;
            // 
            // buttonChangeW
            // 
            buttonChangeW.Location = new Point(513, 250);
            buttonChangeW.Name = "buttonChangeW";
            buttonChangeW.Size = new Size(93, 33);
            buttonChangeW.TabIndex = 15;
            buttonChangeW.Text = "Заменить";
            buttonChangeW.UseVisualStyleBackColor = true;
            buttonChangeW.Click += buttonChangeW_Click;
            // 
            // buttonToUp
            // 
            buttonToUp.Location = new Point(513, 288);
            buttonToUp.Name = "buttonToUp";
            buttonToUp.Size = new Size(93, 49);
            buttonToUp.TabIndex = 16;
            buttonToUp.Text = "Повысить регистр";
            buttonToUp.UseVisualStyleBackColor = true;
            buttonToUp.Click += buttonToUp_Click;
            // 
            // buttonNumOfContain
            // 
            buttonNumOfContain.Location = new Point(404, 288);
            buttonNumOfContain.Name = "buttonNumOfContain";
            buttonNumOfContain.Size = new Size(93, 49);
            buttonNumOfContain.TabIndex = 17;
            buttonNumOfContain.Text = "Частота появления";
            buttonNumOfContain.UseVisualStyleBackColor = true;
            buttonNumOfContain.Click += buttonNumOfContain_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 375);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 18;
            label5.Text = "Строка-замена";
            // 
            // textBoxNewW
            // 
            textBoxNewW.Location = new Point(291, 372);
            textBoxNewW.Name = "textBoxNewW";
            textBoxNewW.Size = new Size(94, 23);
            textBoxNewW.TabIndex = 19;
            // 
            // buttonToLow
            // 
            buttonToLow.Location = new Point(513, 343);
            buttonToLow.Name = "buttonToLow";
            buttonToLow.Size = new Size(93, 47);
            buttonToLow.TabIndex = 20;
            buttonToLow.Text = "Понизить регистр";
            buttonToLow.UseVisualStyleBackColor = true;
            buttonToLow.Click += buttonToLow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonToLow);
            Controls.Add(textBoxNewW);
            Controls.Add(label5);
            Controls.Add(buttonNumOfContain);
            Controls.Add(buttonToUp);
            Controls.Add(buttonChangeW);
            Controls.Add(buttonNumLines);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNumW);
            Controls.Add(textBoxNumNeedLines);
            Controls.Add(textBoxFindW);
            Controls.Add(textBoxNumLines);
            Controls.Add(textBoxReadText);
            Controls.Add(textBoxWriteText);
            Controls.Add(buttonRead);
            Controls.Add(buttonWrite);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxPath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPath;
        private Button buttonCreate;
        public Button buttonWrite;
        private Button buttonRead;
        private TextBox textBoxWriteText;
        private TextBox textBoxReadText;
        private TextBox textBoxNumLines;
        private TextBox textBoxFindW;
        private TextBox textBoxNumNeedLines;
        private TextBox textBoxNumW;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonNumLines;
        private Button buttonChangeW;
        private Button buttonToUp;
        private Button buttonNumOfContain;
        private Label label5;
        private TextBox textBoxNewW;
        private Button buttonToLow;
    }
}