using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoralesFiFthCRUD.Repository;
namespace MoralesFiFthCRUD.Controllers
{
    public class BaseController : Controller
    {
        public database1Entities _db;
        public BaseRepository<User> _userRepo;
        public BaseRepository<UserRole> _userRole;
        public BaseController()
        {
            _db = new database1Entities();
            _userRepo = new BaseRepository<User>();
            _userRole = new BaseRepository<UserRole>();
        }
    }
}