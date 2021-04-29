using Caliburn.Micro;
using Retail_Ui.Helpers;
using Retail_Ui.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Retail_Ui
{
	class Bootstrapper : BootstrapperBase
	{

		private SimpleContainer _container = new SimpleContainer();

		public Bootstrapper()
		{
			Initialize();
		}

		protected override void Configure()
		{
			_container.Instance(_container);


			_container.Singleton<IWindowManager, WindowManager>()
				.Singleton<IEventAggregator, EventAggregator>()
				.Singleton<IApiHelper, ApiHelper>();

			GetType().Assembly.GetTypes().Where(type => type.IsClass && type.Name.EndsWith("ViewModel")).ToList()
				.ForEach(viewmodel =>
				{
					_container.RegisterPerRequest(viewmodel, viewmodel.ToString(), viewmodel);
				});
		}

		protected override void OnStartup(object sender, StartupEventArgs e)
		{
			DisplayRootViewFor<LoginViewModel>();
		}

		protected override IEnumerable<object> GetAllInstances(Type service)
		{
			return _container.GetAllInstances(service);
		}

		protected override object GetInstance(Type service, string key)
		{
			return _container.GetInstance(service, key);
		}

	}
}
