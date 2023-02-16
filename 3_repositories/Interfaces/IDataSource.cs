using _3_repositories.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_repositories.Interfaces
{
    public interface IDataSource
    {
        DbSet<Person> PeopleDetails { get; set; }
        DbSet<Child> ChildrenDetails { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
