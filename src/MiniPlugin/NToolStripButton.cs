//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;

namespace MiniPlugin
{
	public class NToolStripButton : ToolStripButton
	{
		ICommand command;
		
		public NToolStripButton(string text, ICommand command, string imageFile, ToolStripItemDisplayStyle style)
		{
			this.Text = text;
			this.command = command;
			this.DisplayStyle = style;
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
