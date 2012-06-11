//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;

namespace MiniPlugin
{
	public class NToolStripMenuItem : ToolStripMenuItem
	{
		ICommand command;
		
		public NToolStripMenuItem()
		{
		}
		
		public NToolStripMenuItem(string text, ICommand command, string image, string shortcut)
		{
			this.Text = text;
			this.command = command;
		}
		
		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			if (command != null) {
				command.Run();
			}
		}
	}
}
