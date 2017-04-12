namespace Generics
{
    partial class Generics
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
            this.btnTestGenericsExample = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestGenericsExample
            // 
            this.btnTestGenericsExample.Location = new System.Drawing.Point(80, 57);
            this.btnTestGenericsExample.Name = "btnTestGenericsExample";
            this.btnTestGenericsExample.Size = new System.Drawing.Size(132, 23);
            this.btnTestGenericsExample.TabIndex = 0;
            this.btnTestGenericsExample.Text = "Learn Generics";
            this.btnTestGenericsExample.UseVisualStyleBackColor = true;
            this.btnTestGenericsExample.Click += new System.EventHandler(this.btnTestGenericsExample_Click);
            // 
            // Generics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.btnTestGenericsExample);
            this.Name = "Generics";
            this.Text = "Generics Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestGenericsExample;
    }
}

