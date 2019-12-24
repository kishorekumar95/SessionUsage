using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session.Controllers
{
    public class MyComponent //: IMyComponent
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public MyComponent(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public void SetSessionVariable()
        {
            _contextAccessor.HttpContext.Session.SetString("Test", "Ben Rules!");
        }

        public string GetSessionVariable()
        {
            return _contextAccessor.HttpContext.Session.GetString("Test");
        }
    }
}
