using System.Data;

namespace WebApi.Models
{
    public abstract class BaseController
    {
        protected IDbConnection connection;

        public BaseController(IDbConnection connection)
        {
            this.connection = connection;
        }
    }
}
