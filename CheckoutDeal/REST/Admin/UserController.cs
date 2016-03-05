using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CheckoutDealDAL.Entities;
namespace CheckoutDeal.REST.Admin
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        public List<User> Get()
        {
            return CheckoutDealDAL.Models.DAOUser.Get();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public int Post([FromBody]User value)
        {
            CheckoutDealDAL.Models.DAOUser.AddUpdate(value);
            return value.UserId;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
             
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}