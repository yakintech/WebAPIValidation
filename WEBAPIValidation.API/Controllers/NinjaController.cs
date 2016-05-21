using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using WEBAPIValidation.API.Models.Attributes;
using WEBAPIValidation.API.Models.DTO;

namespace WEBAPIValidation.API.Controllers
{
    public class NinjaController : ApiController
    {
        [ValidateModelAttribute]
        public void PostNinja(NinjaDTO model)
        {
            //
        }
    }
}
