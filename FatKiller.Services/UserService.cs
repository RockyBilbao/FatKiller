using FatKiller.Data.Model;
using FatKiller.Data.Repository;
using System;
using System.Collections.Generic;

namespace FatKiller.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();

        User GetUser(Guid userId);
        void AddUser(User userToAdd);

        void UpdateUser(User userToUpdate);

        void DeleteUser(Guid userId);
    }

    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User userToAdd)
        {
            _userRepository.Add(userToAdd);
        }

        public void DeleteUser(Guid userId)
        {
            _userRepository.Delete(_userRepository.GetById(userId));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUser(Guid userId)
        {
            return _userRepository.GetById(userId);
        }

        public void UpdateUser(User userToUpdate)
        {
            _userRepository.Update(userToUpdate);
        }
    }
}
