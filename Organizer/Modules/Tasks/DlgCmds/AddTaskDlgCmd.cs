﻿//
// Organizer/Modules/Tasks/DlgCmds/AddTaskDlgCmd.cs
//

using MSG.Console;
using MSG.IO;
using MSG.Patterns;
using Organizer.Modules.Tasks.Cmds;

namespace Organizer.Modules.Tasks.DlgCmds
{
    /// <summary>
    /// Add Task Dialog Command
    /// </summary>
    public class AddTaskDlgCmd : DlgCmd
    {
        protected Tasks tasks;

        /// <summary>
        /// Initializes AddDialog.
        /// </summary>
        /// <param name="io"></param>
        /// <param name="addTask"></param>
        public AddTaskDlgCmd(Io io, UndoAndRedo undoAndRedo, Tasks tasks)
            : base(io, undoAndRedo)
        {
            this.tasks = tasks;
        }

        public string PriorityPrompt {
            get { return "\nEnter priority (blank to add to the end)\n# "; }
        }

        public string NamePrompt {
            get { return "\nEnter task name/description\n$ "; }
        }

        /// <summary>
        /// Creates an add task command to be executed.
        /// </summary>
        public override Cmd Create()
        {
            Editor nameEditor = new Editor();
            string name = nameEditor.StringPrompt(io, NamePrompt);
            if (string.IsNullOrEmpty(name)) {
                io.print.StringNL("Add cancelled");
                return null;
            }
            int? priority = null;
            if (tasks.Count > 0) {
                IntEditor priorityEditor = new IntEditor();
                priority = priorityEditor.IntPrompt(io, PriorityPrompt);
            }
            if (priority == null) {
                return new AddTask(tasks, name);
            }
            int index = priority.Value - 1;
            return new InsertTask(tasks, name, index);
        }
    }
}
