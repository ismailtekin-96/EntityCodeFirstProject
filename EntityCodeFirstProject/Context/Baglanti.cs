using EntityCodeFirstProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace EntityCodeFirstProject.Context
{
    public class Baglanti :DbContext     // Tüm ilişkilerin tanımlanacağı yer
    {
        public DbSet<User> Users { get; set; }

       
       
        
    }
}