using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Repositories;

public interface IRepository<T> where T : Entity
{
    DbSet<T> Table { get; }
}
