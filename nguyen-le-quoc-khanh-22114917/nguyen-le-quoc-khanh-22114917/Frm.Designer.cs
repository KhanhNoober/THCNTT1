namespace nguyen_le_quoc_khanh_22114917
{
    partial class Frm
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
            this.components = new System.ComponentModel.Container();
            this.pnl_background = new System.Windows.Forms.Panel();
            this.lbl_timer_countdown = new System.Windows.Forms.Label();
            this.pnl_green_light = new System.Windows.Forms.Panel();
            this.pnl_yellow_light = new System.Windows.Forms.Panel();
            this.pnl_red_light = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_background
            // 
            this.pnl_background.BackColor = System.Drawing.SystemColors.MenuText;
            this.pnl_background.Controls.Add(this.lbl_timer_countdown);
            this.pnl_background.Controls.Add(this.pnl_green_light);
            this.pnl_background.Controls.Add(this.pnl_yellow_light);
            this.pnl_background.Controls.Add(this.pnl_red_light);
            this.pnl_background.Location = new System.Drawing.Point(12, 12);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(132, 426);
            this.pnl_background.TabIndex = 0;
            // 
            // lbl_timer_countdown
            // 
            this.lbl_timer_countdown.AutoSize = true;
            this.lbl_timer_countdown.Font = new System.Drawing.Font("Segoe UI", 31.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_timer_countdown.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_timer_countdown.Location = new System.Drawing.Point(24, 28);
            this.lbl_timer_countdown.Name = "lbl_timer_countdown";
            this.lbl_timer_countdown.Size = new System.Drawing.Size(86, 70);
            this.lbl_timer_countdown.TabIndex = 2;
            this.lbl_timer_countdown.Text = "00";
            this.lbl_timer_countdown.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_green_light
            // 
            this.pnl_green_light.BackColor = System.Drawing.Color.Lime;
            this.pnl_green_light.Location = new System.Drawing.Point(24, 327);
            this.pnl_green_light.Name = "pnl_green_light";
            this.pnl_green_light.Size = new System.Drawing.Size(87, 81);
            this.pnl_green_light.TabIndex = 1;
            // 
            // pnl_yellow_light
            // 
            this.pnl_yellow_light.BackColor = System.Drawing.Color.Yellow;
            this.pnl_yellow_light.Location = new System.Drawing.Point(24, 225);
            this.pnl_yellow_light.Name = "pnl_yellow_light";
            this.pnl_yellow_light.Size = new System.Drawing.Size(87, 81);
            this.pnl_yellow_light.TabIndex = 1;
            // 
            // pnl_red_light
            // 
            this.pnl_red_light.BackColor = System.Drawing.Color.Red;
            this.pnl_red_light.Location = new System.Drawing.Point(24, 122);
            this.pnl_red_light.Name = "pnl_red_light";
            this.pnl_red_light.Size = new System.Drawing.Size(87, 81);
            this.pnl_red_light.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.pnl_background);
            this.Name = "Frm";
            this.Text = "Form1";
            this.pnl_background.ResumeLayout(false);
            this.pnl_background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_background;
        private Panel pnl_green_light;
        private Panel pnl_yellow_light;
        private Panel pnl_red_light;
        private Label lbl_timer_countdown;
        private System.Windows.Forms.Timer timer1;
    }
}