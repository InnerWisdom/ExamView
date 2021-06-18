
namespace ExamView
{
    partial class FormReis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(561, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(616, 34);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(79, 27);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(616, 80);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(79, 27);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(616, 131);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(616, 179);
            this.change.Margin = new System.Windows.Forms.Padding(2);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(79, 27);
            this.change.TabIndex = 4;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // FormReis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 292);
            this.Controls.Add(this.change);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReis";
            this.Text = "FormReis";
            this.Load += new System.EventHandler(this.FormReis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button change;
    }
}