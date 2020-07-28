using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalR_Sample.Startup))]

namespace SignalR_Sample
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			Microsoft.AspNet.SignalR.StockTicker.Startup.ConfigureSignalR(app);
		}
	}
}
