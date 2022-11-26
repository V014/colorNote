namespace colorNote
{
    partial class Days
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_color = new System.Windows.Forms.Panel();
            this.button_day = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.Color.Transparent;
            this.panel_color.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_color.Location = new System.Drawing.Point(0, 40);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(50, 10);
            this.panel_color.TabIndex = 2;
            // 
            // button_day
            // 
            this.button_day.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_day.FlatAppearance.BorderSize = 0;
            this.button_day.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_day.Font = new System.Drawing.Font("Roboto", 12F);
            this.button_day.ForeColor = System.Drawing.Color.White;
            this.button_day.Location = new System.Drawing.Point(0, 0);
            this.button_day.Name = "button_day";
            this.button_day.Size = new System.Drawing.Size(50, 40);
            this.button_day.TabIndex = 4;
            this.button_day.Text = "00";
            this.button_day.UseVisualStyleBackColor = true;
            // 
            // Days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button_day);
            this.Controls.Add(this.panel_color);
            this.Name = "Days";
            this.Size = new System.Drawing.Size(50, 50);
            this.Load += new System.EventHandler(this.Days_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button button_day;
        public System.Windows.Forms.Panel panel_color;
    }
}
