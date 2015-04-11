namespace BlogSystem.Services.Controllers
{
    using System.Web.Http;
    using Data;

    public class BaseApiController : ApiController
    {
        private IBlogSystemData data;

        protected BaseApiController(IBlogSystemData data)
        {
            this.data = data;
        }

        protected IBlogSystemData Data
        {
            get
            {
                return this.data;
            }
        }
    }
}