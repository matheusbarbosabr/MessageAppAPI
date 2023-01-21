using Domain.Interfaces.Generics;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository.Generics;

public class GenericRepository<T> : IGeneric<T> where T : class
{
    private readonly DataContext _context;
    public GenericRepository(DataContext context)
    {
        _context = context;
    }
    
    public async Task Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<T> GetEntityById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<List<T>> List()
    {
        return await _context.Set<T>().ToListAsync();
    }
}