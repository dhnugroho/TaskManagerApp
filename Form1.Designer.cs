using System.Windows.Forms;

namespace TaskManagerApp
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
            this.taskDataGridView = new System.Windows.Forms.DataGridView();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.MarkAsCompletedButton = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.saveTasksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadTasksButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskDataGridView
            // 
            this.taskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGridView.Location = new System.Drawing.Point(-4, 186);
            this.taskDataGridView.Name = "taskDataGridView";
            this.taskDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.taskDataGridView.Size = new System.Drawing.Size(1071, 368);
            this.taskDataGridView.TabIndex = 0;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Location = new System.Drawing.Point(910, 134);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(125, 36);
            this.AddTaskButton.TabIndex = 1;
            this.AddTaskButton.Text = "Add";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // MarkAsCompletedButton
            // 
            this.MarkAsCompletedButton.BackColor = System.Drawing.Color.LimeGreen;
            this.MarkAsCompletedButton.Location = new System.Drawing.Point(517, 560);
            this.MarkAsCompletedButton.Name = "MarkAsCompletedButton";
            this.MarkAsCompletedButton.Size = new System.Drawing.Size(125, 36);
            this.MarkAsCompletedButton.TabIndex = 2;
            this.MarkAsCompletedButton.Text = "Complete";
            this.MarkAsCompletedButton.UseVisualStyleBackColor = false;
            this.MarkAsCompletedButton.Click += new System.EventHandler(this.MarkAsCompletedButton_Click);
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.BackColor = System.Drawing.Color.OrangeRed;
            this.DeleteTaskButton.Location = new System.Drawing.Point(648, 560);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(125, 36);
            this.DeleteTaskButton.TabIndex = 3;
            this.DeleteTaskButton.Text = "Delete";
            this.DeleteTaskButton.UseVisualStyleBackColor = false;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(451, 141);
            this.taskNameTextBox.Multiline = true;
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(317, 29);
            this.taskNameTextBox.TabIndex = 4;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.priorityComboBox.Location = new System.Drawing.Point(774, 141);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(121, 24);
            this.priorityComboBox.TabIndex = 5;
            // 
            // saveTasksButton
            // 
            this.saveTasksButton.BackColor = System.Drawing.Color.Silver;
            this.saveTasksButton.Location = new System.Drawing.Point(779, 560);
            this.saveTasksButton.Name = "saveTasksButton";
            this.saveTasksButton.Size = new System.Drawing.Size(125, 36);
            this.saveTasksButton.TabIndex = 6;
            this.saveTasksButton.Text = "Save File";
            this.saveTasksButton.UseVisualStyleBackColor = false;
            this.saveTasksButton.Click += new System.EventHandler(this.saveTasksButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task Manager App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TaskManagerApp.Properties.Resources.eta;
            this.pictureBox1.Location = new System.Drawing.Point(75, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // loadTasksButton
            // 
            this.loadTasksButton.BackColor = System.Drawing.Color.Silver;
            this.loadTasksButton.Location = new System.Drawing.Point(910, 560);
            this.loadTasksButton.Name = "loadTasksButton";
            this.loadTasksButton.Size = new System.Drawing.Size(125, 36);
            this.loadTasksButton.TabIndex = 9;
            this.loadTasksButton.Text = "Load File";
            this.loadTasksButton.UseVisualStyleBackColor = false;
            this.loadTasksButton.Click += new System.EventHandler(this.loadTasksButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Windows GUI (Windows Form .NET Framework 4.8)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Task Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(776, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Priority";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 604);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadTasksButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveTasksButton);
            this.Controls.Add(this.priorityComboBox);
            this.Controls.Add(this.taskNameTextBox);
            this.Controls.Add(this.DeleteTaskButton);
            this.Controls.Add(this.MarkAsCompletedButton);
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.taskDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView taskDataGridView;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button MarkAsCompletedButton;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Button saveTasksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadTasksButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

