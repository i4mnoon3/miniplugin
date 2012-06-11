//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPlugin
{
	public class PluginToolBarButton : PluginControl
	{
		[XmlAttribute("Text")] public string Text { get; set; }
		
		[XmlAttribute("Image")] public string Image { get; set; }
		
		[XmlAttribute("Style")] public string Style { get; set; }
		
		public PluginToolBarButton()
		{
		}
		
		public ToolStripButton Create()
		{
			ToolStripItemDisplayStyle s = ToolStripItemDisplayStyle.ImageAndText;
			try {
				s = (ToolStripItemDisplayStyle)Enum.Parse(ToolStripItemDisplayStyle.ImageAndText.GetType(), Style);
			} catch {
			}
			return new NToolStripButton(Text, CreateCommand(), Image, s);
		}
	}
}
