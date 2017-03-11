namespace Configurator
{
    partial class Configurator
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
            this.components = new System.ComponentModel.Container();
            this.start_on_boot_button = new System.Windows.Forms.Button();
            this.running_text = new System.Windows.Forms.Label();
            this.start_on_boot_text = new System.Windows.Forms.Label();
            this.running_button = new System.Windows.Forms.Button();
            this.layout_refresher = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start_on_boot_button
            // 
            this.start_on_boot_button.Location = new System.Drawing.Point(107, 51);
            this.start_on_boot_button.Name = "start_on_boot_button";
            this.start_on_boot_button.Size = new System.Drawing.Size(122, 31);
            this.start_on_boot_button.TabIndex = 0;
            this.start_on_boot_button.TabStop = false;
            this.start_on_boot_button.UseVisualStyleBackColor = true;
            this.start_on_boot_button.Click += new System.EventHandler(this.start_on_boot_button_Click);
            // 
            // running_text
            // 
            this.running_text.AutoSize = true;
            this.running_text.Location = new System.Drawing.Point(9, 18);
            this.running_text.Name = "running_text";
            this.running_text.Size = new System.Drawing.Size(53, 13);
            this.running_text.TabIndex = 1;
            this.running_text.Text = "Running: ";
            // 
            // start_on_boot_text
            // 
            this.start_on_boot_text.AutoSize = true;
            this.start_on_boot_text.Location = new System.Drawing.Point(9, 60);
            this.start_on_boot_text.Name = "start_on_boot_text";
            this.start_on_boot_text.Size = new System.Drawing.Size(74, 13);
            this.start_on_boot_text.TabIndex = 2;
            this.start_on_boot_text.Text = "Start on boot: ";
            // 
            // running_button
            // 
            this.running_button.Location = new System.Drawing.Point(107, 9);
            this.running_button.Name = "running_button";
            this.running_button.Size = new System.Drawing.Size(122, 31);
            this.running_button.TabIndex = 3;
            this.running_button.TabStop = false;
            this.running_button.UseVisualStyleBackColor = true;
            this.running_button.Click += new System.EventHandler(this.running_button_Click);
            // 
            // layout_refresher
            // 
            this.layout_refresher.Enabled = true;
            this.layout_refresher.Interval = 3000;
            this.layout_refresher.Tick += new System.EventHandler(this.layout_refresher_Tick);
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 93);
            this.Controls.Add(this.running_button);
            this.Controls.Add(this.start_on_boot_text);
            this.Controls.Add(this.running_text);
            this.Controls.Add(this.start_on_boot_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Configurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurator";
            this.Load += new System.EventHandler(this.Configurator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_on_boot_button;
        private System.Windows.Forms.Label running_text;
        private System.Windows.Forms.Label start_on_boot_text;
        private System.Windows.Forms.Button running_button;
        private System.Windows.Forms.Timer layout_refresher;
    }
}

