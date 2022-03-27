namespace ASLTranslator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.formalAndInformalGreetings = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.zoomTrack = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.translateBtn = new System.Windows.Forms.Button();
            this.addNewBoxBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.formalAndInformalFarewell = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.historyOfTranslation = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grammarBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrack)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of words for quick access:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formalAndInformalGreetings
            // 
            this.formalAndInformalGreetings.BackColor = System.Drawing.Color.White;
            this.formalAndInformalGreetings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formalAndInformalGreetings.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formalAndInformalGreetings.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.formalAndInformalGreetings.FormattingEnabled = true;
            this.formalAndInformalGreetings.ItemHeight = 19;
            this.formalAndInformalGreetings.Items.AddRange(new object[] {
            "Hey",
            "Hello",
            "Sup",
            "Pleased",
            "Good",
            "Afternoon",
            "Evening",
            "Morning",
            "Fine",
            "Thank you",
            "Meet"});
            this.formalAndInformalGreetings.Location = new System.Drawing.Point(24, 101);
            this.formalAndInformalGreetings.Name = "formalAndInformalGreetings";
            this.formalAndInformalGreetings.Size = new System.Drawing.Size(194, 209);
            this.formalAndInformalGreetings.TabIndex = 1;
            this.formalAndInformalGreetings.SelectedIndexChanged += new System.EventHandler(this.compatibleWordsBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type your text below to translate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transTextBox
            // 
            this.transTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transTextBox.Location = new System.Drawing.Point(5, 21);
            this.transTextBox.Multiline = true;
            this.transTextBox.Name = "transTextBox";
            this.transTextBox.Size = new System.Drawing.Size(452, 201);
            this.transTextBox.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.zoomTrack);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 352);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1316, 285);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1004, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(620, 9, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Zoom:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zoomTrack
            // 
            this.zoomTrack.AutoSize = false;
            this.zoomTrack.BackColor = System.Drawing.Color.Black;
            this.zoomTrack.LargeChange = 10;
            this.zoomTrack.Location = new System.Drawing.Point(1070, 5);
            this.zoomTrack.Margin = new System.Windows.Forms.Padding(0, 5, 0, 6);
            this.zoomTrack.Maximum = 100;
            this.zoomTrack.Name = "zoomTrack";
            this.zoomTrack.Size = new System.Drawing.Size(211, 30);
            this.zoomTrack.TabIndex = 43;
            this.zoomTrack.TickFrequency = 10;
            this.zoomTrack.Value = 50;
            this.zoomTrack.Scroll += new System.EventHandler(this.zoomTrack_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.translateBtn);
            this.panel1.Controls.Add(this.transTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 241);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(680, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(620, 201);
            this.flowLayoutPanel2.TabIndex = 37;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(43)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(485, 153);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(168, 38);
            this.clearBtn.TabIndex = 36;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // translateBtn
            // 
            this.translateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(43)))));
            this.translateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.translateBtn.FlatAppearance.BorderSize = 0;
            this.translateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.translateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.translateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translateBtn.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateBtn.ForeColor = System.Drawing.Color.White;
            this.translateBtn.Image = global::ASLTranslator.Properties.Resources.icons8_translator_28;
            this.translateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.translateBtn.Location = new System.Drawing.Point(485, 49);
            this.translateBtn.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(168, 38);
            this.translateBtn.TabIndex = 35;
            this.translateBtn.Text = "Translate";
            this.translateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.translateBtn.UseVisualStyleBackColor = false;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // addNewBoxBtn
            // 
            this.addNewBoxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(43)))));
            this.addNewBoxBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addNewBoxBtn.FlatAppearance.BorderSize = 0;
            this.addNewBoxBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.addNewBoxBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.addNewBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewBoxBtn.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBoxBtn.ForeColor = System.Drawing.Color.White;
            this.addNewBoxBtn.Image = global::ASLTranslator.Properties.Resources.icons8_add_28;
            this.addNewBoxBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewBoxBtn.Location = new System.Drawing.Point(297, 287);
            this.addNewBoxBtn.Margin = new System.Windows.Forms.Padding(92, 5, 2, 0);
            this.addNewBoxBtn.Name = "addNewBoxBtn";
            this.addNewBoxBtn.Size = new System.Drawing.Size(177, 41);
            this.addNewBoxBtn.TabIndex = 37;
            this.addNewBoxBtn.Text = "Add New Box";
            this.addNewBoxBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewBoxBtn.UseVisualStyleBackColor = false;
            this.addNewBoxBtn.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Greetings and Replies:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Farewell:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formalAndInformalFarewell
            // 
            this.formalAndInformalFarewell.BackColor = System.Drawing.Color.White;
            this.formalAndInformalFarewell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formalAndInformalFarewell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formalAndInformalFarewell.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.formalAndInformalFarewell.FormattingEnabled = true;
            this.formalAndInformalFarewell.ItemHeight = 19;
            this.formalAndInformalFarewell.Items.AddRange(new object[] {
            "Goodbye",
            "Bye"});
            this.formalAndInformalFarewell.Location = new System.Drawing.Point(297, 101);
            this.formalAndInformalFarewell.Name = "formalAndInformalFarewell";
            this.formalAndInformalFarewell.Size = new System.Drawing.Size(194, 152);
            this.formalAndInformalFarewell.TabIndex = 7;
            this.formalAndInformalFarewell.SelectedIndexChanged += new System.EventHandler(this.formalAndInformalFarewell_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(860, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(273, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "History of Translations:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyOfTranslation
            // 
            this.historyOfTranslation.BackColor = System.Drawing.Color.White;
            this.historyOfTranslation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyOfTranslation.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyOfTranslation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.historyOfTranslation.FormattingEnabled = true;
            this.historyOfTranslation.ItemHeight = 19;
            this.historyOfTranslation.Location = new System.Drawing.Point(865, 101);
            this.historyOfTranslation.Name = "historyOfTranslation";
            this.historyOfTranslation.Size = new System.Drawing.Size(451, 209);
            this.historyOfTranslation.TabIndex = 9;
            this.historyOfTranslation.SelectedIndexChanged += new System.EventHandler(this.historyOfTranslation_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(43)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(220, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(92, 0, 2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "Sort";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(43)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(493, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(92, 0, 2, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 30);
            this.button2.TabIndex = 39;
            this.button2.Text = "Sort";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Common Grammar:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grammarBox
            // 
            this.grammarBox.BackColor = System.Drawing.Color.White;
            this.grammarBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grammarBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammarBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.grammarBox.FormattingEnabled = true;
            this.grammarBox.ItemHeight = 19;
            this.grammarBox.Items.AddRange(new object[] {
            "Do",
            "Are",
            "You",
            "To",
            "How",
            "So",
            "Yes",
            "Who",
            "Sure"});
            this.grammarBox.Location = new System.Drawing.Point(567, 101);
            this.grammarBox.Name = "grammarBox";
            this.grammarBox.Size = new System.Drawing.Size(194, 209);
            this.grammarBox.TabIndex = 41;
            this.grammarBox.SelectedIndexChanged += new System.EventHandler(this.grammarBox_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(43)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(763, 101);
            this.button3.Margin = new System.Windows.Forms.Padding(92, 0, 2, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 30);
            this.button3.TabIndex = 42;
            this.button3.Text = "Sort";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1337, 653);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addNewBoxBtn);
            this.Controls.Add(this.grammarBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.historyOfTranslation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.formalAndInformalFarewell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.formalAndInformalGreetings);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASL Translator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox formalAndInformalGreetings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox transTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.Button addNewBoxBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox formalAndInformalFarewell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox historyOfTranslation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox grammarBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar zoomTrack;
    }
}

