using System;
using System.Collections.Generic;
using System.Text;

namespace ScpDatabaseProg
{
    class ScpDataBase
    {
        public List<ScpItem> _item;

        public ScpDataBase()
        {
            _item = new List<ScpItem>();
        }

        public void AddItem(ScpItem item)
        {
            _item.Add(item);
        }

        public ScpItem GetItems()
        {
            return _item[0];
        }
    }
}
