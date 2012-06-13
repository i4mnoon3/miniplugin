//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.IO;
using System.Windows.Forms;
using NUnit.Framework;

namespace MiniPlugin.Tests
{
	[TestFixture]
	public class PluginTests
	{
		Plugin plugin;
		Plugin nullPlugin;
		
		[SetUp]
		public void Setup()
		{
			plugin = Plugin.Deserialize(new StringReader(@"<Plugin Name='Simple Plugin' Author='Ian'>
	<MainMenu>
		<Menu Text='File'>
			<Menu Text='New'/>
			<Menu Text='-'/>
			<Menu Text='Exit' Command='MiniPlugin.Tests.ExitCommand'/>
		</Menu>
	</MainMenu>
	<ToolBar>
		<Button Text='Exit' Command='MiniPlugin.Tests.ExitCommand'/>
	</ToolBar>
	<StatusBar>
		<Label Text='Test...'/>
	</StatusBar>
</Plugin>"));
			
			nullPlugin = Plugin.Deserialize(new StringReader("<Plugin/>"));
		}
		
		[Test]
		public void TestValues()
		{
			Assert.AreEqual("Simple Plugin", plugin.Name);
			Assert.AreEqual("Ian", plugin.Author);
			var menu = plugin.CreateMenu();
			Assert.IsInstanceOf(typeof(MenuStrip), menu);
			var toolbar = plugin.CreateToolBar();
			Assert.IsInstanceOf(typeof(ToolStrip), toolbar);
			var statusBar = plugin.CreateStatusBar();
			Assert.IsInstanceOf(typeof(Control), statusBar);
			
			Assert.IsNull(nullPlugin.CreateMenu());
			Assert.IsNull(nullPlugin.CreateToolBar());
			Assert.IsNull(nullPlugin.CreateStatusBar());
		}
	}
	
	public class ExitCommand : AbstractCommand
	{
		public override void Run()
		{
		}
	}
}
