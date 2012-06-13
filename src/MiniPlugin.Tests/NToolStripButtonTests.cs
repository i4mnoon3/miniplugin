//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using System.Windows.Forms;
using NUnit.Framework;

namespace MiniPlugin.Tests
{
	[TestFixture]
	public class NToolStripButtonTests
	{
		NToolStripButton b;
		
		[SetUp]
		public void Setup()
		{
			b = new NToolStripButton("Exit", new ExitCommand(), "", ToolStripItemDisplayStyle.None);
		}
		
		[Test]
		public void TestClick()
		{
			b.PerformClick();
		}
	}
}
