﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSG.Console
{
    /// <summary>
    ///   The responsibilities of this class are:
    ///   1. Organize menu items together to create a menu and generate its display.
    ///   2. Receive a user-entered shortcut and perform the action(s)
    ///      of the corresponding menu item.
    /// </summary>
    public class Menu
    {
        MenuItem[] menuItems;
        /// <summary>
        ///   Find and execute the menu item that matches the keystroke.
        /// </summary>
        /// <param name="keystroke"></param>
        /// <returns>
        ///   True if the keystroke matched one of the menu items.
        /// </returns>
        public bool ExecuteItemThatKeystrokeMatches(ConsoleKey keystroke)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                if (menuItem.ExecuteActionIfKeystrokeMatches(keystroke))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        ///   Initializes a new menu with the given array of menu items.  The items
        ///   are displayed in the order given in the array.
        /// </summary>
        /// <param name="menuItems"></param>
        public Menu(MenuItem[] menuItems)
        {
            this.menuItems = menuItems;
        }
        /// <summary>
        ///   Returns the number of items in the menu.
        /// </summary>
        public int ItemCount
        {
            get { return menuItems.Count();  }
        }
        /// <summary>
        ///   Returns a string of the entire menu.
        /// </summary>
        /// <returns>String representation of the menu</returns>
        public override string ToString()
        {
            string s = "";
            foreach (MenuItem menuItem in menuItems)
            {
                for (int i = 0; i < menuItem.LineCount; i++)
                {
                    s += menuItem.ToString(i) + "\n";
                }
            }
            return s;
        }
    }

}