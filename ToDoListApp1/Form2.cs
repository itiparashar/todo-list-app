using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListApp1
{
    public partial class Form2 : Form
    {
        private TodoNote todoNote;
        public Form2()
        {
            InitializeComponent();
            todoNote = new TodoNote();
        }

        private void button_saveNote_Click(object sender, EventArgs e)
        {
            // Here we will set the name of the note
            todoNote.setNoteName(textBox_NoteName.Text);

            // store in a file
            if (todoNote.saveNote() == true)
            {
                MessageBox.Show("Note saved successfully!");
            }
            else
            {
                MessageBox.Show("Some error occured!");
            }
        }

        // On click we will insert a checkbox and a textbox to listview_item
        private void button_newItem_Click(object sender, EventArgs e)
        {
            if (textBox_NewItem.Text == "")
            {
                MessageBox.Show("Please enter something!");
                return;
            }

            TodoItem t = new TodoItem(textBox_NewItem.Text, false);
            todoNote.addItemToNote(t);
            checkedListBox_items.Items.Add(textBox_NewItem.Text);

        }
    }
}
