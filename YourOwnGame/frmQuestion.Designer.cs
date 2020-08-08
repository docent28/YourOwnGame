namespace YourOwnGame
{
    partial class frmQuestion
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
            this.lvQuestions = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNameQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPriceQuestion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContentQuestion = new System.Windows.Forms.TextBox();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.cbCategoryQuestion = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvQuestions
            // 
            this.lvQuestions.HideSelection = false;
            this.lvQuestions.Location = new System.Drawing.Point(13, 87);
            this.lvQuestions.Name = "lvQuestions";
            this.lvQuestions.Size = new System.Drawing.Size(527, 700);
            this.lvQuestions.TabIndex = 0;
            this.lvQuestions.UseCompatibleStateImageBehavior = false;
            this.lvQuestions.View = System.Windows.Forms.View.List;
            this.lvQuestions.SelectedIndexChanged += new System.EventHandler(this.lvQuestions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список вопросов";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvQuestions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 799);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNameQuestion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtPriceQuestion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbCategoryQuestion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtContentQuestion);
            this.panel2.Location = new System.Drawing.Point(601, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 687);
            this.panel2.TabIndex = 3;
            // 
            // txtNameQuestion
            // 
            this.txtNameQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameQuestion.Location = new System.Drawing.Point(17, 75);
            this.txtNameQuestion.Name = "txtNameQuestion";
            this.txtNameQuestion.Size = new System.Drawing.Size(524, 41);
            this.txtNameQuestion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Имя вопроса";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(153, 612);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(228, 54);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPriceQuestion
            // 
            this.txtPriceQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPriceQuestion.Location = new System.Drawing.Point(17, 552);
            this.txtPriceQuestion.Name = "txtPriceQuestion";
            this.txtPriceQuestion.Size = new System.Drawing.Size(524, 41);
            this.txtPriceQuestion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость вопроса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Категория вопроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Содержание вопроса";
            // 
            // txtContentQuestion
            // 
            this.txtContentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtContentQuestion.Location = new System.Drawing.Point(17, 188);
            this.txtContentQuestion.Multiline = true;
            this.txtContentQuestion.Name = "txtContentQuestion";
            this.txtContentQuestion.Size = new System.Drawing.Size(524, 187);
            this.txtContentQuestion.TabIndex = 0;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSerialize.Location = new System.Drawing.Point(634, 727);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(209, 47);
            this.btnSerialize.TabIndex = 7;
            this.btnSerialize.Text = "Сохранить";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeserialize.Location = new System.Drawing.Point(903, 727);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(209, 47);
            this.btnDeserialize.TabIndex = 8;
            this.btnDeserialize.Text = "Прочитать";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // cbCategoryQuestion
            // 
            this.cbCategoryQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategoryQuestion.FormattingEnabled = true;
            this.cbCategoryQuestion.Location = new System.Drawing.Point(17, 443);
            this.cbCategoryQuestion.Name = "cbCategoryQuestion";
            this.cbCategoryQuestion.Size = new System.Drawing.Size(524, 44);
            this.cbCategoryQuestion.TabIndex = 4;
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 799);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContentQuestion;
        private System.Windows.Forms.TextBox txtNameQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPriceQuestion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.ComboBox cbCategoryQuestion;
    }
}