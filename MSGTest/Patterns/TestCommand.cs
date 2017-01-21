﻿//
// MSGTest/Patterns/TestCommand.cs
//

using MSG.Patterns;

namespace MSGTest.Patterns
{
    class TestCommand : Command
    {
        public int doCount;
        public int redoCount;
        public int undoCount;
        public TestCommand()
        {
        }
        public override void Do()
        {
            doCount++;
        }
        public override void Redo()
        {
            redoCount++;
        }
        public override void Undo()
        {
            undoCount++;
        }
    }
}
