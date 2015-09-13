using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContextFactory;
using System.Web;

namespace HttpUnitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void httpcontext_server_variables()
		{
			var tempContext = new MockHttpContext();
			tempContext.ServerVariables.Add("REMOTE_ADDR", "127.0.0.1");
			tempContext.ServerVariables.Add("HTTP_USER_AGENT", "user agent string here");
			tempContext.ServerVariables.Add("HTTP_X_FORWARDED_FOR", "12.13.14.15");

			HttpContextFactory.SetCurrentContext(tempContext.Context);

			//TODO: call http method
			//TODO: asserts
		}

		[TestMethod]
		public void httpcontext_header_variables()
		{
			var tempContext = new MockHttpContext();
			tempContext.HeaderVariables.Add("Authorization","BASIC abcdefghijklmnop==");

			HttpContextFactory.SetCurrentContext(tempContext.Context);

			//TODO: call http method
			//TODO: asserts
		}

		[TestMethod]
		public void httpcontext_cookies()
		{
			var tempContext = new MockHttpContext();
			tempContext.Cookies.Add(new HttpCookie("myCookie","abcd"));

			HttpContextFactory.SetCurrentContext(tempContext.Context);

			//TODO: call http method
			//TODO: asserts
		}
	}
}
