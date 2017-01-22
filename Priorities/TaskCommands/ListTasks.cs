﻿//
// Priorities/TaskCommands/ListTasks.cs
//

using MSG.IO;
using System;
using Priorities.Types;

namespace Priorities.TaskCommands
{
    public class ListTasks : TaskCommand
    {
        Print print;

        public ListTasks(Print print, Tasks tasks)
            : base(tasks)
        {
            this.print = print;
        }

        public override void Do()
        {
            int priority = 0;
            foreach (Task task in tasks)
            {
                print.StringNL(String.Format("[{0}] {1}", priority++, task.Name));
            }
        }
    }
}