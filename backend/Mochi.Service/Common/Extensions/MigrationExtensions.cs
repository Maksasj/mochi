using Microsoft.EntityFrameworkCore;
using Mochi.Service.Data;

namespace Mochi.Service.Common.Extensions;

public static class MigrationExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using MochiDbContext dbContext = scope.ServiceProvider.GetRequiredService<MochiDbContext>();

        dbContext.Database.Migrate();
    }
}
