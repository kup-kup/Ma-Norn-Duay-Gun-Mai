namespace Ma_Norn_Duay_Gun_Mai
{
    partial class explain
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
            this.next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.next_button.Location = new System.Drawing.Point(499, 585);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(110, 54);
            this.next_button.TabIndex = 1;
            this.next_button.Text = "Next";
            this.next_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // explain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 661);
            this.Controls.Add(this.next_button);
            this.Name = "explain";
            this.Text = "Explanation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button next_button;
    }
}