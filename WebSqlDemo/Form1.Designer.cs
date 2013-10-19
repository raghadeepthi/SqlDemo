namespace WebSqlDemo
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
            this.btnDBConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDBConnection
            // 
            this.btnDBConnection.Location = new System.Drawing.Point(46, 53);
            this.btnDBConnection.Name = "btnDBConnection";
            this.btnDBConnection.Size = new System.Drawing.Size(146, 28);
            this.btnDBConnection.TabIndex = 0;
            this.btnDBConnection.Text = "DbConnection";
            this.btnDBConnection.UseVisualStyleBackColor = true;
            this.btnDBConnection.Click += new System.EventHandler(this.btnDBConnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDBConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDBConnection;
    }
}

