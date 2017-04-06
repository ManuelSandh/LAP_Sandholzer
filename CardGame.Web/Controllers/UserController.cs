﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CardGame.DAL.Logic;
using CardGame.DAL.Model;
using CardGame.Log;
using CardGame.Web.Models;

namespace CardGame.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<User> UserList = new List<User>();

            var dbUserlist = UserManager.GetAllUser();

            //var asd = new tblrole();
            

            foreach (var c in dbUserlist)
            {
                Register reguser = new Register();
                reguser.ID = c.idperson;
                reguser.Firstname = c.firstname;
                reguser.Lastname = c.lastname;
                reguser.Email = c.email;
                reguser.Role = c.userrole;
                reguser.Password = c.password;
                reguser.Salt = c.salt;


                UserList.Add(reguser);
            }

            return View(UserList);
        }

    }
}