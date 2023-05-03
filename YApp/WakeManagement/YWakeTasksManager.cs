using Microsoft.Win32.TaskScheduler;
using System.Xml.Linq;
using YY.Logging;

namespace YY.WakeManagement;

internal static class YWakeTasksManager {
    private static XElement GetTaskXElement(Microsoft.Win32.TaskScheduler.Task task) {
        XElement taskXElement = new("NodeTitle", task.Name);
        taskXElement.Add(XElement.Parse(task.Xml).Elements());
        taskXElement.Add(new XElement("Definition", XElement.Parse(task.Definition.XmlText).Elements()));
        return taskXElement;
    }

    internal static XDocument GetTasksXDocument() {
        try {
            XDocument tasksXDocument = new(new XElement("Tasks"));

            using TaskService taskService = new();
            TaskCollection tasks = taskService.RootFolder.GetTasks();
            foreach(Microsoft.Win32.TaskScheduler.Task task in tasks) {
                tasksXDocument.Root?.Add(GetTaskXElement(task));
            }
            YLog.Info($"Create TasksXDocument - Tasks count: {tasks.Count}");
            return tasksXDocument;
        } catch(Exception ex) {
            YLog.Error(ex);
            return new XDocument();
        }       
    }

    internal static bool SetTaskWakeToRun(string taskName, bool isWakeToRun) {
        try {
            using TaskService taskService = new();
            Microsoft.Win32.TaskScheduler.Task task = taskService.FindTask(taskName);
            if(task != null) {
                task.Definition.Settings.WakeToRun = isWakeToRun;
#pragma warning disable CS0618 // Type or member is obsolete
                _ = taskService.RootFolder.RegisterTaskDefinition(task.Path, task.Definition, TaskCreation.Update, taskService.ConnectedUser, null, TaskLogonType.S4U, null);
#pragma warning restore CS0618 // Type or member is obsolete
            }
            YLog.Info($"Set task - Name: {taskName}, WakeToRun: {isWakeToRun}");
            return true;
        } catch(Exception ex) {
            YLog.Error(ex);
            return false;
        }        
    }
}