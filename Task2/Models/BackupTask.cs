﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class BackupTask : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Text for BackupTask");
        }
    }
}
