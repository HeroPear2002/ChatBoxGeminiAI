using GenerativeAI.Methods;
using GenerativeAI.Models;
using GenerativeAI.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBox
{
	public partial class Form1 : Form
	{
		ChatSession chatSession;
		public string apiKey = "AIzaSyBhGuX_PpodibbuD7nGtxEFNYm32Kf4Pyk";
		public Form1()
		{
			InitializeComponent();
		}

		private async void btnSend_Click(object sender, EventArgs e)
		{
			var message = txtMessage.Texts.Trim();
			await SendMessageAsync(message);

		}

		private async Task SendMessageAsync(string message)
		{
			if (btnSend.Text != "Send message") return;

			if (message.Length > 0)
			{
				txtMessage.Texts = "";
				btnSend.Text = "Waiting...";

				txtBody.SelectionAlignment = HorizontalAlignment.Left;
				txtBody.SelectionColor = Color.Blue;
				txtBody.AppendText($"Me: {message}\n");

				txtBody.SelectionAlignment = HorizontalAlignment.Right;
				txtBody.SelectionColor = Color.Red;
				var result = await chatSession.SendMessageAsync(message);
				txtBody.AppendText($"Gemini AI: {result}\n");

				txtBody.SelectionAlignment = HorizontalAlignment.Left;
				txtBody.SelectionColor = txtBody.ForeColor;

				btnSend.Text = "Send message";
				txtBody.ScrollToCaret();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var model = new GenerativeModel(apiKey);
			chatSession = model.StartChat(new StartChatParams());

		}

		private async void txtMessage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				var message = txtMessage.Texts.Trim();
				await SendMessageAsync(message);
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://laptrinhvb.net");
		}
	}
}

