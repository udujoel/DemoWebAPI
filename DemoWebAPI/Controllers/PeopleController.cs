using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoWebAPI.Models;

namespace DemoWebAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person {FirstName = "Martin", LastName = "Freeman", id = 1});
            people.Add(new Person {FirstName = "Romerio", LastName = "Marinez", id = 2});
            people.Add(new Person {FirstName = "Donald", LastName = "Firima", id = 3});
            people.Add(new Person {FirstName = "F", LastName = "Ogbu", id = 4});

        }

        // GET: api/People
        public IEnumerable<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            var found = people.FirstOrDefault(x => x.id == id);
            

            return found;
        }

        // POST: api/People
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
