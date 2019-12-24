using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Session.Controllers
{
    public class BussinessLogicLayer
    {
        private readonly DataAccessLayer _dataAccessLayer;

        public BussinessLogicLayer(IHttpContextAccessor httpContextAccessor)
        {
            _dataAccessLayer = new DataAccessLayer(httpContextAccessor);
        }
        public DataSet PageLoad()
        {
            return _dataAccessLayer.PageLoad();
        }
    }
}
