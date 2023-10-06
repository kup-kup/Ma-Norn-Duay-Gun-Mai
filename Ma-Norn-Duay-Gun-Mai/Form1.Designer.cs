namespace Ma_Norn_Duay_Gun_Mai
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
            this.enter_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.enter_button.Location = new System.Drawing.Point(92, 507);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(199, 97);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "Enter Program";
            this.enter_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.exit_button.Location = new System.Drawing.Point(357, 507);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(199, 97);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 656);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.enter_button);
            this.Name = "Form1";
            this.Text = "Ma-Norn-Duay-Gun-Mai";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Button exit_button;
    }
}

