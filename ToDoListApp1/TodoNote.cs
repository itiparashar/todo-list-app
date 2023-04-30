using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

// Name of the note
// List which will hold all the todos
// Method that will save the note
// Method which will keep track if todo is checked or not

namespace ToDoListApp1
{
    internal class TodoNote
    {
        // Name of the note
        private string mNoteName = "";
        // List of items
        private List<TodoItem> mTodoItemsList = new List<TodoItem>();
        public TodoNote()
        {

        }

        public void setNoteName(string noteName)
        {
            mNoteName = noteName;
        }

        public string getNoteName()
        {
            return mNoteName;
        }

        public void addItemToNote(TodoItem item)
        {
            mTodoItemsList.Add(item);
        }

        public bool saveNote()
        {
            // call the function with name
            return writeXMLFile(mNoteName + ".xml");
        }

        private bool writeXMLFile(string fileName)
        {
            try
            {
                // Boilerplate code to write xml attributes
                var sts = new XmlWriterSettings()
                {
                    Indent = true,
                };

                using XmlWriter writer = XmlWriter.Create(Path.Combine("./notes", fileName), sts);

                // boilerplat
                writer.WriteStartDocument();
                // This will write root element
                writer.WriteStartElement("todolist");

                // This will iterate list and extract each todo item then
                // it will store bool status and text in xml
                foreach(TodoItem item in mTodoItemsList)
                {
                    writer.WriteStartElement("item");
                    writer.WriteAttributeString("isChecked", item.mIsChecked.ToString());
                    writer.WriteString(item.mItem);
                    writer.WriteEndElement();
                }

                writer.WriteEndDocument();
                writer.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
