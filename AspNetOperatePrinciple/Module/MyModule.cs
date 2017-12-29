using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetOperatePrinciple.Module
{
    public class MyModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += BeginRequest;
        }

        private void BeginRequest(object sender, EventArgs e)
        {
            HttpApplication application = sender as HttpApplication;
            application.Context.Response.Write("BeginRequest");
        }
    }
}