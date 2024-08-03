using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Models;

namespace Task2.Service
{
    public class TaskManager
    {
        private List<string> ITasks1=new List<string> { };

        public bool AddTask(string taskName)
        { 
            if (taskName != null)
            {
                ITasks1.Add(taskName);
                return true;
            }
            else
            { 
                return false; 
            }
        }
        public List<string> PrintTasks()
        {
            return ITasks1;
        }


    }
}
