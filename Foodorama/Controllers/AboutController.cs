using Microsoft.AspNetCore.Mvc;

namespace Foodorama.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "999 - 888 - 777";
        }

        public string Address()
        {
            return "USA";
        }
    }
}
