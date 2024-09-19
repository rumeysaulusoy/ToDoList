namespace ToDoList
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.taskList = new System.Windows.Forms.ListBox();
            this.complete = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(25, 60);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(247, 22);
            this.textBox.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(304, 55);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 32);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // taskList
            // 
            this.taskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.taskList.FormattingEnabled = true;
            this.taskList.ItemHeight = 16;
            this.taskList.Location = new System.Drawing.Point(25, 115);
            this.taskList.Name = "taskList";
            this.taskList.Size = new System.Drawing.Size(329, 354);
            this.taskList.TabIndex = 2;
            // 
            // complete
            // 
            this.complete.Location = new System.Drawing.Point(92, 492);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(81, 30);
            this.complete.TabIndex = 3;
            this.complete.Text = "Complete";
            this.complete.UseVisualStyleBackColor = true;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(206, 492);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 30);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 602);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.Button delete;

        private System.Windows.Forms.ListBox taskList;

        private System.Windows.Forms.Button add;

        private System.Windows.Forms.TextBox textBox;

        #endregion
    }
}