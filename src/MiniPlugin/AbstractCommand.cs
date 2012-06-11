//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace MiniPlugin
{
	public abstract class AbstractCommand : ICommand
	{
		public AbstractCommand()
		{
		}
		
		public abstract void Run();
	}
}
