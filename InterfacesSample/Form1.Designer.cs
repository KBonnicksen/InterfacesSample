namespace InterfacesSample
{
    partial class frmLogger
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnLogData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(107, 65);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            // 
            // btnLogData
            // 
            this.btnLogData.Location = new System.Drawing.Point(79, 151);
            this.btnLogData.Name = "btnLogData";
            this.btnLogData.Size = new System.Drawing.Size(174, 53);
            this.btnLogData.TabIndex = 1;
            this.btnLogData.Text = "Log Data";
            this.btnLogData.UseVisualStyleBackColor = true;
            this.btnLogData.Click += new System.EventHandler(this.BtnLogData_Click);
            // 
            // frmLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 234);
            this.Controls.Add(this.btnLogData);
            this.Controls.Add(this.txtInput);
            this.Name = "frmLogger";
            this.Text = "Log it!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnLogData;
    }
}

