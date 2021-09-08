using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        public List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Josh", LastName = "Miller", Id = 3 });
            people.Add(new Person { FirstName = "Jeff", LastName = "Miller", Id = 2 });
            people.Add(new Person { FirstName = "Joe", LastName = "Miller", Id = 1 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person value)
        {
            people.Add(value);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
