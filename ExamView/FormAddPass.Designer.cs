
namespace ExamView
{
    partial class FormAddPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGraz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumPlace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер рейса";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(287, 175);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 26);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(195, 175);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 27);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Гражданство";
            // 
            // textBoxGraz
            // 
            this.textBoxGraz.Location = new System.Drawing.Point(180, 69);
            this.textBoxGraz.Name = "textBoxGraz";
            this.textBoxGraz.Size = new System.Drawing.Size(294, 20);
            this.textBoxGraz.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер места";
            // 
            // textBoxNumPlace
            // 
            this.textBoxNumPlace.Location = new System.Drawing.Point(180, 103);
            this.textBoxNumPlace.Name = "textBoxNumPlace";
            this.textBoxNumPlace.Size = new System.Drawing.Size(294, 20);
            this.textBoxNumPlace.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата покупки";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(180, 135);
            this.date.Margin = new System.Windows.Forms.Padding(2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(294, 20);
            this.date.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(180, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // FormAddPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 216);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGraz);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddPass";
            this.Text = "FormAddPass";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.FormAddPass_Load);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGraz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumPlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}