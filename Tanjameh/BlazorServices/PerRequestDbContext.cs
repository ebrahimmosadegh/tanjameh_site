using Microsoft.EntityFrameworkCore;
using Tanjameh.Infrastructure.Data;

namespace Tanjameh.BlazorServices;

public class PerRequestDbContext : ApplicationDbContext
{
    public PerRequestDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}
