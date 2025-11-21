using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProjectC6.Menu_s
{
    /// <summary>
    /// Represents a single menu option.
    /// </summary>
    public class MenuItem
    {
        public string Description { get; }
        public Action Action { get; }

        public MenuItem(string description, Action action)
        {
            Description = description;
            Action = action;
        }
    }
}
