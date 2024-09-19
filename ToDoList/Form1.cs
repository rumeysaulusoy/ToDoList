using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace ToDoList {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            taskList.DrawItem += new DrawItemEventHandler(listBoxTasks_DrawItem);
        }
        
        private void listBoxTasks_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index < 0) return;
            
            Task task = (Task)taskList.Items[e.Index];
            e.DrawBackground();
            
            if (task.IsCompleted) {
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
            } 
            else {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }
            
            e.Graphics.DrawString(task.ToString(), e.Font, Brushes.Black, e.Bounds);
            e.DrawFocusRectangle();
        }

        List<Task> tasks = new List<Task>();
        private void add_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(textBox.Text)) {
                Task newTask = new Task(textBox.Text);
                tasks.Add(newTask);
                taskList.Items.Add(newTask);
                textBox.Clear();
            } 
            else {
                MessageBox.Show("Please enter a task name.");
            }
        }

        private void complete_Click(object sender, EventArgs e) {
            if (taskList.SelectedItem != null) {
                Task selectedTask = (Task)taskList.SelectedItem;
                selectedTask.IsCompleted = true;
                int selectedIndex = taskList.SelectedIndex;
                taskList.Items[selectedIndex] = selectedTask;
            }
            else {
                MessageBox.Show("Please choose a task to complete.");
            }
        }

        private void delete_Click(object sender, EventArgs e) {
            if (taskList.SelectedItem != null) {
                Task selectedTask = (Task)taskList.SelectedItem;
                tasks.Remove(selectedTask);
                taskList.Items.Remove(selectedTask);
            }
            else {
                MessageBox.Show("Please choose a task to delete.");
            }
        }
    }
}