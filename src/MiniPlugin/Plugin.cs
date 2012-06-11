//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPlugin
{
	public class Plugin : BaseSerializable<Plugin>
	{
		public PluginStatusBar StatusBar { get; set; }
		
		public PluginToolBar ToolBar { get; set; }
		
		public PluginMainMenu MainMenu { get; set; }
		
		[XmlAttribute("Author")] public string Author { get; set; }
		
		[XmlAttribute("Name")] public string Name { get; set; }
		
		public Plugin()
		{
		}
		
		public MenuStrip CreateMenu()
		{
			if (MainMenu != null) {
				return MainMenu.Create();
			}
			return null;
		}
		
		public Control CreateToolBar()
		{
			if (ToolBar != null) {
				return ToolBar.Create();
			}
			return null;
		}
		
		public Control CreateStatusBar()
		{
			if (StatusBar != null) {
				return StatusBar.Create();
			}
			return null;
		}
	}
}
