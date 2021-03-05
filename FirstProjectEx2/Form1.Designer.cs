
namespace FirstProjectEx2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.introduction = new System.Windows.Forms.Button();
            this.introText = new System.Windows.Forms.Label();
            this.colorQuestion = new System.Windows.Forms.Label();
            this.ageQuestion = new System.Windows.Forms.Label();
            this.colorAnswer = new System.Windows.Forms.Label();
            this.ageAnswer = new System.Windows.Forms.Label();
            this.colorAnswerButton = new System.Windows.Forms.Button();
            this.ageAnswerButton = new System.Windows.Forms.Button();
            this.family = new System.Windows.Forms.PictureBox();
            this.pictureMessage = new System.Windows.Forms.Label();
            this.byeMessage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.family)).BeginInit();
            this.SuspendLayout();
            // 
            // introduction
            // 
            this.introduction.Location = new System.Drawing.Point(248, 66);
            this.introduction.Name = "introduction";
            this.introduction.Size = new System.Drawing.Size(113, 38);
            this.introduction.TabIndex = 0;
            this.introduction.Text = "Press Here!";
            this.introduction.UseVisualStyleBackColor = true;
            this.introduction.Click += new System.EventHandler(this.button1_Click);
            // 
            // introText
            // 
            this.introText.AutoSize = true;
            this.introText.Location = new System.Drawing.Point(160, 43);
            this.introText.Name = "introText";
            this.introText.Size = new System.Drawing.Size(291, 20);
            this.introText.TabIndex = 1;
            this.introText.Text = "PRESS THE BUTTON TO LEARN WHO I AM!";
            this.introText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorQuestion
            // 
            this.colorQuestion.AutoSize = true;
            this.colorQuestion.Location = new System.Drawing.Point(45, 122);
            this.colorQuestion.Name = "colorQuestion";
            this.colorQuestion.Size = new System.Drawing.Size(217, 20);
            this.colorQuestion.TabIndex = 2;
            this.colorQuestion.Text = "WHAT IS MY FAVORITE COLOR?";
            this.colorQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorQuestion.Click += new System.EventHandler(this.colorQuestion_Click);
            // 
            // ageQuestion
            // 
            this.ageQuestion.AutoSize = true;
            this.ageQuestion.Location = new System.Drawing.Point(400, 122);
            this.ageQuestion.Name = "ageQuestion";
            this.ageQuestion.Size = new System.Drawing.Size(120, 20);
            this.ageQuestion.TabIndex = 3;
            this.ageQuestion.Text = "HOW OLD AM I?";
            this.ageQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorAnswer
            // 
            this.colorAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.colorAnswer.Location = new System.Drawing.Point(63, 154);
            this.colorAnswer.Name = "colorAnswer";
            this.colorAnswer.Size = new System.Drawing.Size(176, 33);
            this.colorAnswer.TabIndex = 4;
            this.colorAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageAnswer
            // 
            this.ageAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.ageAnswer.Location = new System.Drawing.Point(368, 154);
            this.ageAnswer.Name = "ageAnswer";
            this.ageAnswer.Size = new System.Drawing.Size(176, 33);
            this.ageAnswer.TabIndex = 5;
            this.ageAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorAnswerButton
            // 
            this.colorAnswerButton.Location = new System.Drawing.Point(107, 190);
            this.colorAnswerButton.Name = "colorAnswerButton";
            this.colorAnswerButton.Size = new System.Drawing.Size(94, 29);
            this.colorAnswerButton.TabIndex = 6;
            this.colorAnswerButton.Text = "ANSWER";
            this.colorAnswerButton.UseVisualStyleBackColor = true;
            this.colorAnswerButton.Click += new System.EventHandler(this.colorAnswerButton_Click);
            // 
            // ageAnswerButton
            // 
            this.ageAnswerButton.Location = new System.Drawing.Point(411, 190);
            this.ageAnswerButton.Name = "ageAnswerButton";
            this.ageAnswerButton.Size = new System.Drawing.Size(94, 29);
            this.ageAnswerButton.TabIndex = 7;
            this.ageAnswerButton.Text = "ANSWER";
            this.ageAnswerButton.UseVisualStyleBackColor = true;
            this.ageAnswerButton.Click += new System.EventHandler(this.ageAnswerButton_Click);
            // 
            // family
            // 
            this.family.Image = ((System.Drawing.Image)(resources.GetObject("family.Image")));
            this.family.Location = new System.Drawing.Point(193, 225);
            this.family.Name = "family";
            this.family.Size = new System.Drawing.Size(223, 100);
            this.family.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.family.TabIndex = 8;
            this.family.TabStop = false;
            this.family.Click += new System.EventHandler(this.family_Click);
            // 
            // pictureMessage
            // 
            this.pictureMessage.AutoSize = true;
            this.pictureMessage.Location = new System.Drawing.Point(220, 328);
            this.pictureMessage.Name = "pictureMessage";
            this.pictureMessage.Size = new System.Drawing.Size(168, 20);
            this.pictureMessage.TabIndex = 9;
            this.pictureMessage.Text = "CLICK ON THE PICTURE!";
            // 
            // byeMessage
            // 
            this.byeMessage.Location = new System.Drawing.Point(461, 354);
            this.byeMessage.Name = "byeMessage";
            this.byeMessage.Size = new System.Drawing.Size(127, 29);
            this.byeMessage.TabIndex = 10;
            this.byeMessage.Text = "PRESS BUTTON!";
            this.byeMessage.UseVisualStyleBackColor = true;
            this.byeMessage.Click += new System.EventHandler(this.byeMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 395);
            this.Controls.Add(this.byeMessage);
            this.Controls.Add(this.pictureMessage);
            this.Controls.Add(this.family);
            this.Controls.Add(this.ageAnswerButton);
            this.Controls.Add(this.colorAnswerButton);
            this.Controls.Add(this.ageAnswer);
            this.Controls.Add(this.colorAnswer);
            this.Controls.Add(this.ageQuestion);
            this.Controls.Add(this.colorQuestion);
            this.Controls.Add(this.introText);
            this.Controls.Add(this.introduction);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.family)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button introduction;
        private System.Windows.Forms.Label introText;
        private System.Windows.Forms.Label colorQuestion;
        private System.Windows.Forms.Label ageQuestion;
        private System.Windows.Forms.Label colorAnswer;
        private System.Windows.Forms.Label ageAnswer;
        private System.Windows.Forms.Button colorAnswerButton;
        private System.Windows.Forms.Button ageAnswerButton;
        private System.Windows.Forms.PictureBox family;
        private System.Windows.Forms.Label pictureMessage;
        private System.Windows.Forms.Button byeMessage;
    }
}

