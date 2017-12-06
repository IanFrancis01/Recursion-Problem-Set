namespace Recursion_Problem_Set
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
            this.btnQ2 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.txtQuestion1 = new System.Windows.Forms.TextBox();
            this.txtQuestion3 = new System.Windows.Forms.TextBox();
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQ2
            // 
            this.btnQ2.Location = new System.Drawing.Point(94, 43);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(75, 23);
            this.btnQ2.TabIndex = 0;
            this.btnQ2.Text = "Question 2";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.btnQuestion1a_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(9, 318);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(79, 25);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(13, 43);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(75, 23);
            this.btnQ1.TabIndex = 2;
            this.btnQ1.Text = "Question 1";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.btnQ1a_Click);
            // 
            // btnQ3
            // 
            this.btnQ3.Location = new System.Drawing.Point(227, 43);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(75, 23);
            this.btnQ3.TabIndex = 3;
            this.btnQ3.Text = "Question 3";
            this.btnQ3.UseVisualStyleBackColor = true;
            // 
            // txtQuestion1
            // 
            this.txtQuestion1.Location = new System.Drawing.Point(40, 72);
            this.txtQuestion1.Name = "txtQuestion1";
            this.txtQuestion1.Size = new System.Drawing.Size(100, 20);
            this.txtQuestion1.TabIndex = 4;
            // 
            // txtQuestion3
            // 
            this.txtQuestion3.Location = new System.Drawing.Point(227, 72);
            this.txtQuestion3.Name = "txtQuestion3";
            this.txtQuestion3.Size = new System.Drawing.Size(75, 20);
            this.txtQuestion3.TabIndex = 6;
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.Location = new System.Drawing.Point(23, 95);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(132, 20);
            this.lblQuestion1.TabIndex = 7;
            this.lblQuestion1.Text = "Question 1 or 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 495);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.txtQuestion3);
            this.Controls.Add(this.txtQuestion1);
            this.Controls.Add(this.btnQ3);
            this.Controls.Add(this.btnQ1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnQ2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.TextBox txtQuestion1;
        private System.Windows.Forms.TextBox txtQuestion3;
        private System.Windows.Forms.Label lblQuestion1;
    }
}

