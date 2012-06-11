//	<file>
//		<license></license>
//		<owner name="Ian Escarro" email="ian.escarro@gmail.com"/>
//	</file>

using System;

namespace MiniPlugin
{
	public class PluginControl
	{
		public string Command { get; set; }
		
		public PluginControl()
		{
		}
		
		protected ICommand CreateCommand()
		{
			if (Command != null && !Command.Equals(string.Empty)) {
				Type t = Type.GetType(Command);
				if (t != null) {
					return Activator.CreateInstance(t) as ICommand;
				}
			}
			return null;
		}
	}
}
