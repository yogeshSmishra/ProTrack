using System;
using System.Collections.Generic;
using System.Text;

namespace ProTrack.Models
{
    public enum TrackStatus
    {
        Todo,
        InProgress,
        Completed
    }

    public class TaskItem
    {
        //static field to keep track of total tasks created
        private static int _totalTasks = 0;

        public readonly DateTime CreatedDate; // readonly field set only during construction

        //Properties
        public int Id { get; private set; } // private set means Id can only be set within this class
        public string Title { get; set; }
        public string? Description { get; set; }   // '?' means the description can be empty
        public TrackStatus Status { get; set; }

        //Write only property
        public string SecretNote
        {
            set
            {
                _secret = value;
            }
        }
        private string _secret = "";

        public TaskItem(int id, string title, string? description)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = TrackStatus.Todo;
            CreatedDate = DateTime.Now; // set creation date when task is created
            _totalTasks++; // increment total tasks count
        }

        //static method
        public static int GetTotalTasks()
        {
            return _totalTasks;
        }
    }
}
