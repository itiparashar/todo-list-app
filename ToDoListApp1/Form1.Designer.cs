namespace ToDoListApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_newNote = new Button();
            listBox_Notes = new ListBox();
            SuspendLayout();
            // 
            // button_newNote
            // 
            button_newNote.Location = new Point(21, 17);
            button_newNote.Name = "button_newNote";
            button_newNote.Size = new Size(159, 65);
            button_newNote.TabIndex = 0;
            button_newNote.Text = "New Note";
            button_newNote.UseVisualStyleBackColor = true;
            button_newNote.Click += button_newNote_Click;
            // 
            // listBox_Notes
            // 
            listBox_Notes.FormattingEnabled = true;
            listBox_Notes.ItemHeight = 20;
            listBox_Notes.Location = new Point(21, 128);
            listBox_Notes.Name = "listBox_Notes";
            listBox_Notes.Size = new Size(501, 304);
            listBox_Notes.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox_Notes);
            Controls.Add(button_newNote);
            Name = "Form1";
            Text = "ToDo App";
            ResumeLayout(false);
        }

        #endregion

        private Button button_newNote;
        private ListBox listBox_Notes;
    }
}