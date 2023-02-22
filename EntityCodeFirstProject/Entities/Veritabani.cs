using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityCodeFirstProject.Entities
{
    public static class Veritabani
    {

        public static List<User> _user;

        //public static List<User> User
        //{
        //    get { return _user; }
        //}

        public static void KullaniciEkle(User user)
        {
            _user.Add(user);
        }
       
    }
}