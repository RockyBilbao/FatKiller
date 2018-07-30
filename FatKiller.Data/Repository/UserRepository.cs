using FatKiller.Data.Interfaces;
using FatKiller.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FatKiller.Data.Repository
{
    public interface IUserRepository : IRepository<User>
    {

    }

    public class UserRepository : IUserRepository
    {
        private readonly ProjectEntities _projectEntities;

        public UserRepository(ProjectEntities projectEntities)
        {
            _projectEntities = projectEntities;
        }

        public void Add(User entity)
        {
            _projectEntities.User.Add(entity);
        }

        public int Count(Func<User, bool> predicate)
        {
            return _projectEntities.User.Count(); //TODO predicate
        }

        public void Delete(User entity)
        {
            _projectEntities.User.Remove(entity);
        }

        public IQueryable<User> GetAll()
        {
            return _projectEntities.User;
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            return _projectEntities.User.FirstOrDefault(x => x.UserId == id);
        }

        public IQueryable<User> GetWhere(Func<User, bool> predicate)
        {
            return _projectEntities.User.Where(predicate).AsQueryable(); //TODO AsQueryable??? sprawdzić
        }

        public void Update(User entity)
        {
            _projectEntities.User.Update(entity);
        }
    }
}
