using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace LevoSampleSite.Api
{
    public class TimeStampController : ApiController
    {
        public JsonResult<string[]> Get()
        {
            string[] dateAndTime = new string[] {DateTime.Now.ToString(CultureInfo.CurrentCulture)};
            return Json(dateAndTime);
        }
    }
}
