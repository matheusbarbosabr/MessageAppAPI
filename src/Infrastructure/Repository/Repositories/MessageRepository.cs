using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Data;
using Infrastructure.Repository.Generics;

namespace Infrastructure.Repository.Repositories;

public class MessageRepository : GenericRepository<Message>, IMessage
{
    public MessageRepository(DataContext context) : base(context)
    {
    }
}