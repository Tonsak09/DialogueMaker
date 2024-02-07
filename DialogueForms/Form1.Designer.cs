namespace DialogueForms
{
    partial class Form1
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insert = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Dialogue = new System.Windows.Forms.ListBox();
            this.insertDropDown = new System.Windows.Forms.ComboBox();
            this.insertText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Display = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RawText = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DisplayText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Display.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insert);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.Dialogue);
            this.groupBox1.Controls.Add(this.insertDropDown);
            this.groupBox1.Controls.Add(this.insertText);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(153, 33);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 9;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(493, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Down";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Up";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Dialogue
            // 
            this.Dialogue.FormattingEnabled = true;
            this.Dialogue.ItemHeight = 16;
            this.Dialogue.Items.AddRange(new object[] {
            "BoxA",
            "BoxB",
            "BoxC"});
            this.Dialogue.Location = new System.Drawing.Point(574, 14);
            this.Dialogue.Name = "Dialogue";
            this.Dialogue.Size = new System.Drawing.Size(156, 148);
            this.Dialogue.TabIndex = 6;
            // 
            // insertDropDown
            // 
            this.insertDropDown.FormattingEnabled = true;
            this.insertDropDown.Items.AddRange(new object[] {
            "Shake",
            "Large",
            "Wiggle"});
            this.insertDropDown.Location = new System.Drawing.Point(16, 33);
            this.insertDropDown.Name = "insertDropDown";
            this.insertDropDown.Size = new System.Drawing.Size(121, 24);
            this.insertDropDown.TabIndex = 3;
            // 
            // insertText
            // 
            this.insertText.Location = new System.Drawing.Point(16, 63);
            this.insertText.Name = "insertText";
            this.insertText.Size = new System.Drawing.Size(276, 96);
            this.insertText.TabIndex = 2;
            this.insertText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Display);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 187);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text";
            // 
            // Display
            // 
            this.Display.Controls.Add(this.tabPage1);
            this.Display.Controls.Add(this.tabPage2);
            this.Display.Location = new System.Drawing.Point(7, 21);
            this.Display.Name = "Display";
            this.Display.SelectedIndex = 0;
            this.Display.Size = new System.Drawing.Size(723, 160);
            this.Display.TabIndex = 1;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RawText);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 131);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RawText";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RawText
            // 
            this.RawText.Location = new System.Drawing.Point(7, 7);
            this.RawText.Name = "RawText";
            this.RawText.Size = new System.Drawing.Size(702, 118);
            this.RawText.TabIndex = 0;
            this.RawText.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DisplayText);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(715, 131);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DisplayText";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DisplayText
            // 
            this.DisplayText.Location = new System.Drawing.Point(6, 6);
            this.DisplayText.Name = "DisplayText";
            this.DisplayText.Size = new System.Drawing.Size(702, 118);
            this.DisplayText.TabIndex = 1;
            this.DisplayText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Display.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox insertText;
        private System.Windows.Forms.ComboBox insertDropDown;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox Dialogue;
        private System.Windows.Forms.TabControl Display;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.RichTextBox RawText;
        private System.Windows.Forms.RichTextBox DisplayText;
    }
}

