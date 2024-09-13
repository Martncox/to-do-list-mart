using System;

namespace to_do_list_mart
{
    partial class TODOLIST
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Discription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.EditB = new System.Windows.Forms.Button();
            this.ToDoListVeiw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListVeiw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "MartToDo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 79);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(776, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(12, 126);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(776, 20);
            this.Description.TabIndex = 2;
            // 
            // Discription
            // 
            this.Discription.Location = new System.Drawing.Point(13, 106);
            this.Discription.Name = "Discription";
            this.Discription.Size = new System.Drawing.Size(775, 17);
            this.Discription.TabIndex = 3;
            this.Discription.Text = "Description";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(775, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveB
            // 
            this.SaveB.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveB.Location = new System.Drawing.Point(640, 152);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(147, 43);
            this.SaveB.TabIndex = 6;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(436, 152);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(147, 43);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "-";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // EditB
            // 
            this.EditB.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditB.Location = new System.Drawing.Point(226, 152);
            this.EditB.Name = "EditB";
            this.EditB.Size = new System.Drawing.Size(147, 43);
            this.EditB.TabIndex = 8;
            this.EditB.Text = "Edit";
            this.EditB.UseVisualStyleBackColor = true;
            this.EditB.Click += new System.EventHandler(this.EditB_Click);
            // 
            // ToDoListVeiw
            // 
            this.ToDoListVeiw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ToDoListVeiw.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToDoListVeiw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ToDoListVeiw.Location = new System.Drawing.Point(12, 201);
            this.ToDoListVeiw.Name = "ToDoListVeiw";
            this.ToDoListVeiw.Size = new System.Drawing.Size(776, 237);
            this.ToDoListVeiw.TabIndex = 9;
            // 
            // TODOLIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToDoListVeiw);
            this.Controls.Add(this.EditB);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Discription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TODOLIST";
            this.Text = "To DO list";
            this.Load += new System.EventHandler(this.TODOLIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ToDoListVeiw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label Discription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button EditB;
        private System.Windows.Forms.DataGridView ToDoListVeiw;
        private EventHandler label1_Click;
    }
}

