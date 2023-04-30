using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp1
{
    // This class will store individual todo item
    class TodoItem
    {
        public string mItem { get; set; }
        public bool mIsChecked { get; set; }
        public TodoItem(string item, bool isChecked)
        {
            mItem = item;
            mIsChecked = isChecked;
        }


    }
}
