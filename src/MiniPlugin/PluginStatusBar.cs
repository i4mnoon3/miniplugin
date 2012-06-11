//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPlugin
{
	public class PluginStatusBar
	{
		[XmlElement("Label")] public PluginStatusBarLabel[] Labels { get; set; }
		
		public bool HasLabels {
			get { return Labels != null && Labels.Length > 0; }
		}
		
		public PluginStatusBar()
		{
		}
		
		public StatusStrip Create()
		{
			StatusStrip bar = null;
			if (HasLabels) {
				bar = new NStatusStrip();
				foreach (PluginStatusBarLabel label in Labels) {
					bar.Items.Add(label.Create());
				}
			}
			return bar;
		}
	}
}
