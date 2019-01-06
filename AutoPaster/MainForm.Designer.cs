namespace AutoPaster
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
            this.btnType = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnType
            // 
            this.btnType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnType.Location = new System.Drawing.Point(100, 187);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 23);
            this.btnType.TabIndex = 0;
            this.btnType.Text = "Paste";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(12, 29);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(260, 115);
            this.tbInput.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnType);
            this.Name = "MainForm";
            this.Text = "AutoPaster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.TextBox tbInput;
    }
}

