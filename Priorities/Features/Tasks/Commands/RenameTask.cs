﻿//
// Priorities/Features/Tasks/Commands/RenameTask.cs
//

namespace Priorities.Features.Tasks.Commands
{
    public class RenameTask : TaskCommand
    {
        protected int index;
        protected string name;
        protected string savedName;

        public RenameTask(Tasks tasks, int index, string name)
            : base(tasks)
        {
            this.index = index;
            this.name = name;
        }

        public override Result Do()
        {
            savedName = tasks[index].Name;
            tasks[index].Name = name;
            return new Ok();
        }

        public override Result Undo()
        {
            tasks[index].Name = savedName;
            return new Ok();
        }
    }
}
