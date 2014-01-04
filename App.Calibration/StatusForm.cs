using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Calibration
{
	public partial class StatusForm : Form
	{
		public StatusForm()
		{
			InitializeComponent();
		}
		public StatusForm(List<string> messageList):this()
		{
			int index = messageList.Count;
			foreach (var message in messageList.AsEnumerable().Reverse())
			{
				StatusRichTextBox.AppendText(String.Format("[{0}] {1}" + Environment.NewLine, index--, message));
			}
		}
	}
}
