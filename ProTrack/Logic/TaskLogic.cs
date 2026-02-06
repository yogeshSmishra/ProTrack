using ProTrack.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProTrack.Logic
{
    public class TaskLogic
    {
        // A private list to store our tasks in memory while the app is running
        private readonly List<TaskItem> _tasks = new List<TaskItem>();
        //List is a dynamic array here from System.Collections.Generic
        //TaskItem yaha pe is dataType(Generic/Template) that u can only store TaskItem ke objects here
        //_tasks is reference type variable it stores the address of the list which is on heap memory
        private int _nextId = 1;

        // To add a new task
        public void AddTask(string title, string? description)
        {
            if(_tasks.Count >= Constants.MaxTaks)
            {
                Console.WriteLine("Cannot add more tasks. Maximum limit reached.");
                return;
            }
            var newTask = new TaskItem
             (
                //this is using contructor.
                _nextId,
                title,
                description
            );
            //write only property usage
            newTask.SecretNote = "This is a secret";
            _nextId++; // increment the nextId for the next task
            _tasks.Add(newTask);
        }


        // To get all tasks
        public List<TaskItem> GetAllTasks()
        {
            return _tasks;
        }

        public static int GetTaskCount()
        {
            return TaskItem.GetTotalTasks();
        }


        // To delete a task by its Id
        public bool DeleteTaskById(int id)
        {
            for(int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Id == id)
                {
                    _tasks.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}
