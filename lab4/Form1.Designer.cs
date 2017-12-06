namespace lab4
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
            this.openWordsBtn = new System.Windows.Forms.Button();
            this.wordList = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.findWordBtn = new System.Windows.Forms.Button();
            this.searchWordText = new System.Windows.Forms.TextBox();
            this.workTimeLabel = new System.Windows.Forms.Label();
            this.searchTimeLabel = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openWordsBtn
            // 
            this.openWordsBtn.Location = new System.Drawing.Point(12, 295);
            this.openWordsBtn.Name = "openWordsBtn";
            this.openWordsBtn.Size = new System.Drawing.Size(121, 40);
            this.openWordsBtn.TabIndex = 0;
            this.openWordsBtn.Text = "Открыть слова";
            this.openWordsBtn.UseVisualStyleBackColor = true;
            this.openWordsBtn.Click += new System.EventHandler(this.openWordsBtn_Click);
            // 
            // wordList
            // 
            this.wordList.FormattingEnabled = true;
            this.wordList.Location = new System.Drawing.Point(12, 12);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(292, 277);
            this.wordList.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // findWordBtn
            // 
            this.findWordBtn.Location = new System.Drawing.Point(12, 341);
            this.findWordBtn.Name = "findWordBtn";
            this.findWordBtn.Size = new System.Drawing.Size(121, 40);
            this.findWordBtn.TabIndex = 3;
            this.findWordBtn.Text = "Найти слово";
            this.findWordBtn.UseVisualStyleBackColor = true;
            this.findWordBtn.Click += new System.EventHandler(this.findWordBtn_Click);
            // 
            // searchWordText
            // 
            this.searchWordText.Location = new System.Drawing.Point(139, 341);
            this.searchWordText.Name = "searchWordText";
            this.searchWordText.Size = new System.Drawing.Size(165, 20);
            this.searchWordText.TabIndex = 4;
            // 
            // workTimeLabel
            // 
            this.workTimeLabel.AutoSize = true;
            this.workTimeLabel.Location = new System.Drawing.Point(139, 309);
            this.workTimeLabel.Name = "workTimeLabel";
            this.workTimeLabel.Size = new System.Drawing.Size(29, 13);
            this.workTimeLabel.TabIndex = 5;
            this.workTimeLabel.Text = "0 ms";
            // 
            // searchTimeLabel
            // 
            this.searchTimeLabel.AutoSize = true;
            this.searchTimeLabel.Location = new System.Drawing.Point(139, 368);
            this.searchTimeLabel.Name = "searchTimeLabel";
            this.searchTimeLabel.Size = new System.Drawing.Size(29, 13);
            this.searchTimeLabel.TabIndex = 6;
            this.searchTimeLabel.Text = "0 ms";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 387);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(292, 67);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(13, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дмитриев Василий РТ5-31";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.searchTimeLabel);
            this.Controls.Add(this.workTimeLabel);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.searchWordText);
            this.Controls.Add(this.findWordBtn);
            this.Controls.Add(this.openWordsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openWordsBtn;
        private System.Windows.Forms.ListBox wordList;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button findWordBtn;
        private System.Windows.Forms.TextBox searchWordText;
        private System.Windows.Forms.Label workTimeLabel;
        private System.Windows.Forms.Label searchTimeLabel;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
    }
}

