//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPlugin
{
	public class PluginMenu : PluginControl
	{
		[XmlAttribute("Text")] public string Text { get; set; }
		
		[XmlAttribute("Shortcut")] public string Shortcut { get; set; }
		
		[XmlAttribute("Image")] public string Image { get; set; }
		
		[XmlElement("Menu")] public PluginMenu[] Menus { get; set; }
		
		public bool HasMenus {
			get { return Menus != null && Menus.Length > 0; }
		}
		
		public PluginMenu()
		{
		}
		
		public ToolStripItem Create()
		{
			if (Text.Equals("-")) {
				return new NToolStripSeparator();
			} else {
				return new NToolStripMenuItem(Text, CreateCommand(), Image, Shortcut);
			}
		}
	}
}
