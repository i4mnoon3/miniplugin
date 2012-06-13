//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPlugin
{
	public class PluginStatusBarLabel : PluginControl
	{
		[XmlAttribute("Text")] public string Text { get; set; }
		
		public PluginStatusBarLabel()
		{
		}
		
		public ToolStripLabel Create()
		{
			return new NToolStripLabel(Text);
		}
	}
}
