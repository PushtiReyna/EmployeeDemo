using Microsoft.EntityFrameworkCore;

namespace EmployeeDBFirstDemo.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
    }
    
}
