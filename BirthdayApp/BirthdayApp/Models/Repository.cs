using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.Models
{
    public static class Repository
    {
        private static List<UserResponse> responses = new List<UserResponse>();

        static Repository()
        {
            AddResponse(new UserResponse() { Name = "Ahmet", Email = "asf@gmail.com", Phone = "0555", WillAttend = false});
            AddResponse(new UserResponse() { Name = "Mehmet", Email = "as@gmail.com", Phone = "0555", WillAttend = true});
            AddResponse(new UserResponse() { Name = "Ayşe", Email = "fff@gmail.com", Phone = "0555", WillAttend = false});
        }

        public static List<UserResponse> Responses
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(UserResponse response)
        {
            response.Id = (new Random()).Next(1, 9999);
            responses.Add(response);
        }

        public static void Update(UserResponse response)
        {
            var res = Responses.Find(i => i.Id == response.Id);

            if(res != null)
            {
                res.Name = response.Name;
                res.Phone = response.Phone;
                res.Email = response.Email;
                res.WillAttend = response.WillAttend;
            }
               
        }
        public static void Delete(int id)
        {
            var res = Responses.Find(i => i.Id == id);
            if(res != null)
            {
                Responses.Remove(res);
            }
        }
    }
}