//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPlugin
{
	public class PluginToolBar
	{
		[XmlElement("Button")] public PluginToolBarButton[] Buttons { get; set; }
		
		public bool HasButtons {
			get { return Buttons != null && Buttons.Length > 0; }
		}
		
		public PluginToolBar()
		{
		}
		
		public ToolStrip Create()
		{
			ToolStrip bar = null;
			if (HasButtons) {
				bar = new ToolStrip();
				foreach (var button in Buttons) {
					bar.Items.Add(button.Create());
				}
			}
			return bar;
		}
	}
}
