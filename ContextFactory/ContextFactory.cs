using System;
using System.Web;

namespace ContextFactory
{
	// this object obtained from:
	//http://stackoverflow.com/questions/9624242/setting-httpcontext-current-session-in-a-unit-test

	public class HttpContextFactory
	{
		private static HttpContextBase m_context;
		public static HttpContextBase Current
		{
			get
			{
				if (m_context != null)
				{
					return m_context;
				}

				if (HttpContext.Current == null)
				{
					throw new InvalidOperationException("HttpContext not available");
				}

				return new HttpContextWrapper(HttpContext.Current);
			}
		}

		public static void SetCurrentContext(HttpContextBase context)
		{
			m_context = context;
		}
	}
}
