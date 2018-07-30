using AutoMapper;
using FatKiller.Data.Model;
using FatKiller.Services;
using FatKiller.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FatKiller.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> GetAll()
        {
            var users = _userService.GetAllUsers();
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(users);
        }

        [HttpGet("{id}")]
        public UserViewModel GetUser(Guid userId)
        {
            var user = _userService.GetUser(userId);
            return _mapper.Map<User, UserViewModel>(user);
        }
    }
}
