using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IApplicationRoleGroupRepository : IRepository<ApplicationGroupRole>
    {
    }

    public class ApplicationRoleGroupRepository : Repository<ApplicationGroupRole>, IApplicationRoleGroupRepository
    {
        public ApplicationRoleGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}