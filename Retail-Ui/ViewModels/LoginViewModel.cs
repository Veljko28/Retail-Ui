using Caliburn.Micro;
using Retail_Ui.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Ui.ViewModels
{
	public class LoginViewModel
	{
		private IApiHelper _apiHelper;

		public LoginViewModel(IApiHelper apiHelper)
		{
			_apiHelper = apiHelper;
		}


		private string _userName;

		public string UserName
		{
			get { return _userName; }
			set { 
				_userName = value;
			}
		}

		private string _password;

		public string Password
		{
			get { return _password; }
			set {
				_password = value;
			}
		}


	}
}
