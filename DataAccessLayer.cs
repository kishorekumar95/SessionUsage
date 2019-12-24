using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Session.Controllers
{
    public class DataAccessLayer
    {
        private readonly MyComponent _myComponent;
        //private readonly HttpContextAccessor httpContextAccessor;
        public DataAccessLayer(IHttpContextAccessor httpContextAccessor)
        {
            _myComponent = new MyComponent(httpContextAccessor);
        }

        public DataSet PageLoad()
        {
            DataSet ret = new DataSet();

            _myComponent.SetSessionVariable();
            //IUnityContainer container = new UnityContainer();
            //container.RegisterType<IMyComponent, MyComponent>();
            //container.RegisterType<DAL>(new InjectionConstructor(container.Resolve<IMyComponent>()));
            //container.RegisterType<DAL>(new InjectionConstructor(new object[] { new MyComponent(), _contextAccessor }));


            //container.RegisterType<IMyComponent, MyComponent>();// Map ICar with BMW 

            //var drv = container.Resolve<DAL>(_contextAccessor); //(new InjectionConstructor(new MyComponent()));
            //drv.run();
            return ret;
        }
    }
}
