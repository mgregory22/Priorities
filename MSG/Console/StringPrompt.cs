﻿using MSG.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSG.Console
{
    public class StringPrompt : Prompt
    {
        /// <summary>
        ///   Displays the prompt and reads a string.
        /// </summary>
        /// <returns>The string entered by the user</returns>
        public string DoPrompt()
        {
            string s;
            do
            {
                PrintPrompt();
                s = Read.String();
                Print.String(s, true);
            } while (StringIsInvalid(s));
            return s;
        }
        private bool StringIsInvalid(string s)
        {
            return false;
        }
        public StringPrompt(Print print, string promptMsg, Read read)
            : base(print, promptMsg, read)
        {

        }
    }
}