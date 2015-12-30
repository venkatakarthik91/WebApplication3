using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class TestController : ApiController
    {
        List<string> listOfGirlFriends = Models.SampleData.listOfGirlFriends;
        public class ChangeGF
        {
            string oldGF;

            public string OldGF
            {
                get
                {
                    return oldGF;
                }

                set
                {
                    oldGF = value;
                }
            }

            public string NewGF
            {
                get
                {
                    return newGF;
                }

                set
                {
                    newGF = value;
                }
            }

            string newGF;
        }
        // GET: api/Test
        [Authorize(Roles = "read, write, full control")]
        public IEnumerable<string> Get()
        {
            return listOfGirlFriends;
        }

        // GET: api/Test/5
        [Authorize(Roles = "read,write,full control")]
        public string Get(int id)
        {
            return listOfGirlFriends[id];
        }

        // POST: api/Test
        [Authorize(Roles = "full control")]
        public void Post([FromBody]string value)
        {
            listOfGirlFriends.Add(value);
        }

        // PUT: api/Test/5
        [Authorize(Roles = "read,write,full control")]
        public void Put([FromBody]ChangeGF obj)
        {
            for (int i = 0; i < listOfGirlFriends.Count; i++)
            {
                if (listOfGirlFriends[i].Equals(obj.OldGF, StringComparison.OrdinalIgnoreCase))
                {
                    listOfGirlFriends[i] = obj.NewGF;
                    break;
                }
            }
        }

        // DELETE: api/Test/5
        public void Delete([FromBody]string name)
        {
            listOfGirlFriends.Remove(name);
        }
    }
}
