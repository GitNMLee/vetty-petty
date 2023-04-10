namespace WindowsFormProject
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
            this.uxConnectDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxConnectDB
            // 
            this.uxConnectDB.Location = new System.Drawing.Point(633, 112);
            this.uxConnectDB.Name = "uxConnectDB";
            this.uxConnectDB.Size = new System.Drawing.Size(146, 23);
            this.uxConnectDB.TabIndex = 0;
            this.uxConnectDB.Text = "Connect to DB";
            this.uxConnectDB.UseVisualStyleBackColor = true;
            this.uxConnectDB.Click += new System.EventHandler(this.uxConnectDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxConnectDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxConnectDB;
    }
}

