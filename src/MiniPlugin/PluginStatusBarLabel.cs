//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;

namespace MiniPlugin
{
	public class PluginStatusBarLabel : PluginControl
	{
		public string Text { get; set; }
		
		public PluginStatusBarLabel()
		{
		}
		
		public ToolStripLabel Create()
		{
			return new NToolStripLabel(Text);
		}
	}
}
