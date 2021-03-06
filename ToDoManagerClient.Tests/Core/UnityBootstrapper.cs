using System;
using Microsoft.Practices.Unity;

namespace ToDoManagerClient.Tests.Core
{
	public static class UnityBootstrapper
	{
		private static readonly Lazy<UnityContainer> containerLazy = new Lazy<UnityContainer>(() =>
		{
			var container = new UnityContainer();
			return container;
		});

		public static UnityContainer Container
		{
			get { return containerLazy.Value; }
		}
	}
}
