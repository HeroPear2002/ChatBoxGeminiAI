namespace ChatBox
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
			this.btnSend = new CustomUI.CXHUI.CXHButton();
			this.txtBody = new System.Windows.Forms.RichTextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnSend.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.btnSend.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnSend.BorderRadius = 40;
			this.btnSend.BorderSize = 0;
			this.btnSend.FlatAppearance.BorderSize = 0;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSend.ForeColor = System.Drawing.Color.White;
			this.btnSend.Location = new System.Drawing.Point(456, 319);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(118, 44);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send message";
			this.btnSend.TextColor = System.Drawing.Color.MediumSlateBlue;
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtBody
			// 
			this.txtBody.Location = new System.Drawing.Point(33, 12);
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(541, 301);
			this.txtBody.TabIndex = 2;
			this.txtBody.Text = "";
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(33, 332);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(417, 20);
			this.txtMessage.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 387);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.txtBody);
			this.Controls.Add(this.btnSend);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomUI.CXHUI.CXHButton btnSend;
		private System.Windows.Forms.RichTextBox txtBody;
		private System.Windows.Forms.TextBox txtMessage;
	}
}

