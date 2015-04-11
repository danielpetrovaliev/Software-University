namespace MusicSystem.Services.Controllers
{
    using System.Web.Http;
    using Data;

    public class BaseApiController : ApiController
    {
        private IMusicSystemData data;

        protected BaseApiController(IMusicSystemData data)
        {
            this.data = data;
        }

        protected IMusicSystemData Data
        {
            get
            {
                return this.data;
            }
        } 
    }
}