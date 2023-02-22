using EntityCodeFirstProject.Context;
using EntityCodeFirstProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityCodeFirstProject.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult FormIndex()
        {
            return View();
        }
        [HttpGet]
        public ActionResult KayitEkle()
        {
            return View();
        }




        [HttpPost]
        public ActionResult KayitEkle(User user)
        {
            var baglanti = new Baglanti();

            baglanti.Users.Add(user);
            baglanti.SaveChanges();

            return View();
        }

        //[HttpPost]
        //public ActionResult KayitEkle(string FirstName, string Surname,string UserName,string Pasword,int Phone)
        //{


        //    var baglanti = new baglanti();
        //    user user = new user();
        //    user.firstname = firstname;
        //    user.surname = surname;
        //    user.username = username;
        //    user.pasword = pasword;
        //    user.phone = phone;

        //    baglanti.users.add(user);
        //    baglanti.savechanges();

        //    return view();
        //}

    }
}