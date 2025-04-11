using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TaskManagerApp
{
    public partial class Form1 : Form
    {
        private List<TaskModel> tasks;
        private BackgroundWorker statusUpdateWorker;
        private readonly string filePath;

        public Form1()
        {
            InitializeComponent();
            filePath = GetTaskFilePath();
            tasks = new List<TaskModel>();
            InitializeBackgroundWorker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasksFromFile();
        }

        #region Task Management

        private bool IsValidTask(string taskName, string priority)
        {
            if (string.IsNullOrWhiteSpace(taskName))
            {
                ShowError("Task name cannot be empty!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(priority))
            {
                ShowError("Please select a priority for the task!");
                return false;
            }

            return true;
        }

        private void AddTask(string taskName, string priority)
        {
            var task = new TaskModel
            {
                TaskId = tasks.Count + 1,
                TaskName = taskName,
                Priority = priority,
                Status = "Pending"
            };

            tasks.Add(task);
            UpdateTaskListView();
        }

        private void DeleteSelectedTask()
        {
            if (taskDataGridView.SelectedRows.Count == 0) return;

            var selectedTask = taskDataGridView.SelectedRows[0].DataBoundItem as TaskModel;
            if (selectedTask != null)
            {
                tasks.Remove(selectedTask);
                UpdateTaskListView();
            }
        }

        private void MarkTaskAsCompleted()
        {
            if (taskDataGridView.SelectedRows.Count == 0) return;

            var selectedTask = taskDataGridView.SelectedRows[0].DataBoundItem as TaskModel;
            if (selectedTask != null)
            {
                selectedTask.Status = "Completed";
                UpdateTaskListView();
            }
        }

        private void UpdateTaskListView()
        {
            taskDataGridView.DataSource = null;
            taskDataGridView.DataSource = tasks;

            // OPTIONAL: Force UI to redraw (helps during dynamic updates)
            taskDataGridView.Refresh();
        }

        #endregion

        #region Background Worker

        private void InitializeBackgroundWorker()
        {
            statusUpdateWorker = new BackgroundWorker();
            statusUpdateWorker.DoWork += UpdateTaskStatuses;
            statusUpdateWorker.RunWorkerAsync();
        }

        private void UpdateTaskStatuses(object sender, DoWorkEventArgs e)
        {
            var rand = new Random();

            while (true)
            {
                foreach (var task in tasks.Where(t => t.Status == "Pending" && rand.Next(0, 5) == 0))
                {
                    task.Status = "In Progress";
                }

                InvokeIfRequired(() => taskDataGridView.Refresh());
                Thread.Sleep(1000);
            }
        }

        #endregion

        #region File Operations

        private string GetTaskFilePath()
        {
            var projectRoot = Directory.GetParent(Application.StartupPath)?.Parent?.Parent?.FullName;
            return Path.Combine(projectRoot ?? string.Empty, "TaskManagerApp", "tasks_file", "tasks.json");
        }

        private void SaveTasksToFile()
        {
            try
            {
                var json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                File.WriteAllText(filePath, json);
                ShowInfo("Tasks saved successfully!");
            }
            catch (Exception ex)
            {
                ShowError($"Error saving tasks: {ex.Message}");
            }
        }

        private void LoadTasksFromFile()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    ShowInfo("No task file found.");
                    return;
                }

                string json = File.ReadAllText(filePath);
                var loadedTasks = JsonConvert.DeserializeObject<List<TaskModel>>(json);

                // Validate each task
                List<string> errors = new List<string>();
                foreach (var task in loadedTasks)
                {
                    if (string.IsNullOrWhiteSpace(task.TaskName))
                    {
                        errors.Add($"Task ID {task.TaskId} has an empty TaskName.");
                    }

                    if (string.IsNullOrWhiteSpace(task.Priority) ||
                        !(task.Priority == "Low" || task.Priority == "Medium" || task.Priority == "High"))
                    {
                        errors.Add($"Task ID {task.TaskId} has an invalid Priority: '{task.Priority}'");
                    }

                    if (string.IsNullOrWhiteSpace(task.Status) ||
                        !(task.Status == "Pending" || task.Status == "Completed" || task.Status == "In Progress"))
                    {
                        errors.Add($"Task ID {task.TaskId} has an invalid Status: '{task.Status}'");
                    }
                }

                if (errors.Count > 0)
                {
                    string errorMessage = "Validation failed while loading tasks:\n\n" + string.Join("\n", errors);
                    MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop loading if there's invalid data
                }

                tasks = JsonConvert.DeserializeObject<List<TaskModel>>(json) ?? new List<TaskModel>();
                UpdateTaskListView();
            }
            catch (JsonReaderException jrex)
            {
                MessageBox.Show("Invalid JSON format: " + jrex.Message, "JSON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tasks = new List<TaskModel>(); // Reset the list to prevent null reference errors
            }
            catch (Exception ex)
            {
                ShowError($"Error loading tasks: {ex.Message}");
            }
        }

        #endregion

        #region Event Handlers

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            var taskName = taskNameTextBox.Text;
            var priority = priorityComboBox.SelectedItem?.ToString();

            if (!IsValidTask(taskName, priority)) return;

            AddTask(taskName, priority);
            taskNameTextBox.Clear();
            priorityComboBox.SelectedIndex = -1;
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteSelectedTask();
            }
            catch (Exception ex)
            {
                ShowError($"Error deleting task: {ex.Message}");
            }
        }

        private void MarkAsCompletedButton_Click(object sender, EventArgs e)
        {
            try
            {
                MarkTaskAsCompleted();
            }
            catch (Exception ex)
            {
                ShowError($"Error marking task as completed: {ex.Message}");
            }
        }

        private void saveTasksButton_Click(object sender, EventArgs e)
        {
            SaveTasksToFile();
        }

        private void loadTasksButton_Click(object sender, EventArgs e)
        {
            LoadTasksFromFile();
        }

        #endregion

        #region Utilities

        private void ShowError(string message) =>
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void ShowInfo(string message) =>
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void InvokeIfRequired(MethodInvoker action)
        {
            if (InvokeRequired)
                Invoke(action);
            else
                action();
        }
        #endregion
    }
}
