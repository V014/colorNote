namespace colorNote
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.controlPanel = new System.Windows.Forms.Panel();
            this.lbl_mood = new System.Windows.Forms.Label();
            this.redBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.default_btn = new System.Windows.Forms.Button();
            this.orangeBtn = new System.Windows.Forms.Button();
            this.yellowBtn = new System.Windows.Forms.Button();
            this.datePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lbl_note = new System.Windows.Forms.Label();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.controlPanel.Controls.Add(this.lbl_mood);
            this.controlPanel.Controls.Add(this.redBtn);
            this.controlPanel.Controls.Add(this.greenBtn);
            this.controlPanel.Controls.Add(this.blueBtn);
            this.controlPanel.Controls.Add(this.default_btn);
            this.controlPanel.Controls.Add(this.orangeBtn);
            this.controlPanel.Controls.Add(this.yellowBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel.Location = new System.Drawing.Point(0, 124);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(333, 51);
            this.controlPanel.TabIndex = 2;
            // 
            // lbl_mood
            // 
            this.lbl_mood.AutoSize = true;
            this.lbl_mood.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mood.ForeColor = System.Drawing.Color.Gray;
            this.lbl_mood.Location = new System.Drawing.Point(238, 15);
            this.lbl_mood.Name = "lbl_mood";
            this.lbl_mood.Size = new System.Drawing.Size(50, 19);
            this.lbl_mood.TabIndex = 45;
            this.lbl_mood.Text = "Mood";
            // 
            // redBtn
            // 
            this.redBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.redBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redBtn.FlatAppearance.BorderSize = 0;
            this.redBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redBtn.Location = new System.Drawing.Point(12, 8);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(30, 30);
            this.redBtn.TabIndex = 38;
            this.redBtn.UseVisualStyleBackColor = false;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.greenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenBtn.FlatAppearance.BorderSize = 0;
            this.greenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenBtn.Location = new System.Drawing.Point(120, 8);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(30, 30);
            this.greenBtn.TabIndex = 42;
            this.greenBtn.UseVisualStyleBackColor = false;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.blueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blueBtn.FlatAppearance.BorderSize = 0;
            this.blueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueBtn.Location = new System.Drawing.Point(156, 8);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(30, 30);
            this.blueBtn.TabIndex = 40;
            this.blueBtn.UseVisualStyleBackColor = false;
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // default_btn
            // 
            this.default_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.default_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.default_btn.FlatAppearance.BorderSize = 0;
            this.default_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.default_btn.Location = new System.Drawing.Point(192, 8);
            this.default_btn.Name = "default_btn";
            this.default_btn.Size = new System.Drawing.Size(30, 30);
            this.default_btn.TabIndex = 39;
            this.default_btn.UseVisualStyleBackColor = false;
            this.default_btn.Click += new System.EventHandler(this.default_btn_Click);
            // 
            // orangeBtn
            // 
            this.orangeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(108)))), ((int)(((byte)(0)))));
            this.orangeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orangeBtn.FlatAppearance.BorderSize = 0;
            this.orangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orangeBtn.Location = new System.Drawing.Point(48, 8);
            this.orangeBtn.Name = "orangeBtn";
            this.orangeBtn.Size = new System.Drawing.Size(30, 30);
            this.orangeBtn.TabIndex = 41;
            this.orangeBtn.UseVisualStyleBackColor = false;
            this.orangeBtn.Click += new System.EventHandler(this.orangeBtn_Click);
            // 
            // yellowBtn
            // 
            this.yellowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.yellowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yellowBtn.FlatAppearance.BorderSize = 0;
            this.yellowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowBtn.Location = new System.Drawing.Point(84, 8);
            this.yellowBtn.Name = "yellowBtn";
            this.yellowBtn.Size = new System.Drawing.Size(30, 30);
            this.yellowBtn.TabIndex = 43;
            this.yellowBtn.UseVisualStyleBackColor = false;
            this.yellowBtn.Click += new System.EventHandler(this.yellowBtn_Click);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BorderRadius = 17;
            this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.datePicker.Color = System.Drawing.Color.Silver;
            this.datePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.datePicker.DisabledColor = System.Drawing.Color.Gray;
            this.datePicker.DisplayWeekNumbers = false;
            this.datePicker.DPHeight = 0;
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.FillDatePicker = false;
            this.datePicker.Font = new System.Drawing.Font("Roboto", 11F);
            this.datePicker.ForeColor = System.Drawing.Color.Silver;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Icon = ((System.Drawing.Image)(resources.GetObject("datePicker.Icon")));
            this.datePicker.IconColor = System.Drawing.Color.Gray;
            this.datePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.datePicker.LeftTextMargin = 5;
            this.datePicker.Location = new System.Drawing.Point(12, 76);
            this.datePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowCheckBox = true;
            this.datePicker.Size = new System.Drawing.Size(307, 32);
            this.datePicker.TabIndex = 31;
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.BackColor = System.Drawing.Color.Transparent;
            this.lbl_note.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbl_note.ForeColor = System.Drawing.Color.White;
            this.lbl_note.Location = new System.Drawing.Point(149, 34);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(165, 18);
            this.lbl_note.TabIndex = 32;
            this.lbl_note.Text = "this is how the day went..";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(333, 175);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.controlPanel);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "colorNote";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Button default_btn;
        private System.Windows.Forms.Button yellowBtn;
        private System.Windows.Forms.Button orangeBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Label lbl_mood;
        private Bunifu.UI.WinForms.BunifuDatePicker datePicker;
        private System.Windows.Forms.Label lbl_note;
    }
}

