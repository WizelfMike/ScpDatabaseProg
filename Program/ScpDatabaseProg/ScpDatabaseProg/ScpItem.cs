using System;
using System.Collections.Generic;
using System.Text;

namespace ScpDatabaseProg
{
    class ScpItem
    {
        public string name { get; private set; }

        public ScpItem(string Name)
        {
            name = Name;
        }
    }
}
