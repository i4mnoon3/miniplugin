//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MiniPlugin
{
	public class PluginMainMenu
	{
		[XmlElement("Menu")] public PluginMenu[] Menus { get; set; }
		
		public bool HasMenus {
			get { return Menus != null && Menus.Length> 0; }
		}
		
		public PluginMainMenu()
		{
		}
		
		public MenuStrip Create()
		{
			var mainMenu = new MenuStrip();
			foreach (var menu in Menus) {
				var item = menu.Create();
				if (menu.HasMenus) {
					AddItem(item, menu.Menus);
				}
				mainMenu.Items.Add(item);
			}
			return mainMenu;
		}
		
		void AddItem(ToolStripItem item, PluginMenu[] menus)
		{
			foreach (var menu in menus) {
				ToolStripItem subItem = menu.Create();
				if (menu.HasMenus) {
					AddItem(subItem, menu.Menus);
				}
				if (subItem is NToolStripMenuItem) {
					(item as ToolStripMenuItem).DropDownItems.Add(subItem);
				}
				(item as ToolStripMenuItem).DropDownItems.Add(subItem);
			}
		}
	}
}
