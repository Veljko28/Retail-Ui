using Retail_Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retail_Ui.Helpers
{
	public interface IApiHelper
	{
		Task<AuthenticatedUser> Authenticate(string username, string password);
	}
}
