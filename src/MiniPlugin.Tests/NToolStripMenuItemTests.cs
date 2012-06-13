//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;
using NUnit.Framework;

namespace MiniPlugin.Tests
{
	[TestFixture]
	public class NToolStripMenuItemTests
	{
		NToolStripMenuItem item;
		
		[SetUp]
		public void Setup()
		{
			item = new NToolStripMenuItem("Exit", new ExitCommand(), "", "");
		}
		
		[Test]
		public void TestClick()
		{
			item.PerformClick();
		}
	}
}
