﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ScrollIntoView.Skia.Tizen
{
	public sealed class Program
	{
		static void Main(string[] args)
		{
			var host = new TizenHost(() => new ScrollIntoView.App());
			host.Run();
		}
	}
}
