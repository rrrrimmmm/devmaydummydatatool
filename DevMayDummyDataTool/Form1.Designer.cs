namespace DevMayDummyDataTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LastDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorList = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataNum = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "기간";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "처음 날짜";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "마지막 날짜";
            // 
            // FirstDateTimePicker
            // 
            this.FirstDateTimePicker.Location = new System.Drawing.Point(92, 29);
            this.FirstDateTimePicker.Name = "FirstDateTimePicker";
            this.FirstDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.FirstDateTimePicker.TabIndex = 3;
            this.FirstDateTimePicker.ValueChanged += new System.EventHandler(this.onFirstDateValueChanged);
            // 
            // LastDateTimePicker
            // 
            this.LastDateTimePicker.Location = new System.Drawing.Point(92, 56);
            this.LastDateTimePicker.Name = "LastDateTimePicker";
            this.LastDateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.LastDateTimePicker.TabIndex = 4;
            this.LastDateTimePicker.ValueChanged += new System.EventHandler(this.onLastDateValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "색 리스트";
            // 
            // ColorList
            // 
            this.ColorList.Location = new System.Drawing.Point(13, 113);
            this.ColorList.Multiline = true;
            this.ColorList.Name = "ColorList";
            this.ColorList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ColorList.Size = new System.Drawing.Size(279, 102);
            this.ColorList.TabIndex = 6;
            this.ColorList.Text = "FF0000,FFFF00,0000FF,FFFFFF,000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "원하는 데이터 수\r\n(마지막 날짜-처음날짜 보다 많을수 없다)";
            // 
            // DataNum
            // 
            this.DataNum.Location = new System.Drawing.Point(14, 249);
            this.DataNum.Name = "DataNum";
            this.DataNum.Size = new System.Drawing.Size(100, 21);
            this.DataNum.TabIndex = 8;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 290);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "저장";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // SaveProgressBar
            // 
            this.SaveProgressBar.Location = new System.Drawing.Point(12, 290);
            this.SaveProgressBar.Name = "SaveProgressBar";
            this.SaveProgressBar.Size = new System.Drawing.Size(280, 23);
            this.SaveProgressBar.TabIndex = 10;
            this.SaveProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 333);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveProgressBar);
            this.Controls.Add(this.DataNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ColorList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastDateTimePicker);
            this.Controls.Add(this.FirstDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Create Dummy Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FirstDateTimePicker;
        private System.Windows.Forms.DateTimePicker LastDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColorList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DataNum;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ProgressBar SaveProgressBar;
    }
}

