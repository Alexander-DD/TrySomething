﻿namespace TrySomething
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Clear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 62);
			this.textBox1.MaxLength = 2147483647;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(1174, 609);
			this.textBox1.TabIndex = 0;
			// 
			// Clear
			// 
			this.Clear.Location = new System.Drawing.Point(12, 12);
			this.Clear.Name = "Clear";
			this.Clear.Size = new System.Drawing.Size(108, 44);
			this.Clear.TabIndex = 1;
			this.Clear.Text = "Убрать лишнее";
			this.Clear.UseVisualStyleBackColor = true;
			this.Clear.Click += new System.EventHandler(this.Clear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1198, 683);
			this.Controls.Add(this.Clear);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Чистка лога";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Clear;
	}
}