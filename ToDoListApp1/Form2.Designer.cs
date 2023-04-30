namespace ToDoListApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_NoteName = new TextBox();
            button_saveNote = new Button();
            button_newItem = new Button();
            textBox_NewItem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            checkedListBox_items = new CheckedListBox();
            SuspendLayout();
            // 
            // textBox_NoteName
            // 
            textBox_NoteName.Location = new Point(201, 29);
            textBox_NoteName.Name = "textBox_NoteName";
            textBox_NoteName.Size = new Size(345, 27);
            textBox_NoteName.TabIndex = 0;
            textBox_NoteName.Text = "Untitled 1";
            // 
            // button_saveNote
            // 
            button_saveNote.Location = new Point(20, 375);
            button_saveNote.Name = "button_saveNote";
            button_saveNote.Size = new Size(132, 63);
            button_saveNote.TabIndex = 1;
            button_saveNote.Text = "Save Note";
            button_saveNote.UseVisualStyleBackColor = true;
            button_saveNote.Click += button_saveNote_Click;
            // 
            // button_newItem
            // 
            button_newItem.Location = new Point(570, 75);
            button_newItem.Name = "button_newItem";
            button_newItem.Size = new Size(94, 29);
            button_newItem.TabIndex = 2;
            button_newItem.Text = "Add";
            button_newItem.UseVisualStyleBackColor = true;
            button_newItem.Click += button_newItem_Click;
            // 
            // textBox_NewItem
            // 
            textBox_NewItem.Location = new Point(201, 77);
            textBox_NewItem.Name = "textBox_NewItem";
            textBox_NewItem.Size = new Size(345, 27);
            textBox_NewItem.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter the name of Note";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 80);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Enter TODO";
            // 
            // checkedListBox_items
            // 
            checkedListBox_items.Font = new Font("Sans Serif Collection", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox_items.FormattingEnabled = true;
            checkedListBox_items.Location = new Point(29, 127);
            checkedListBox_items.Name = "checkedListBox_items";
            checkedListBox_items.Size = new Size(635, 246);
            checkedListBox_items.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox_items);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_NewItem);
            Controls.Add(button_newItem);
            Controls.Add(button_saveNote);
            Controls.Add(textBox_NoteName);
            Name = "Form2";
            Text = "My Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_NoteName;
        private Button button_saveNote;
        private Button button_newItem;
        private TextBox textBox_NewItem;
        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBox_items;
    }
}