using System;
using System.Collections.Generic;
using Gleason_UserInterface_Service.Helper;

namespace Gleason_UserInterface_Service.Repository
{
    public class GleasonRepository: IGleasonRepository
    {
        public GleasonRepository()
        {
            using (var context = new ApiContext())
            {
                var users = new List<Models.User>
                {
                new Models.User
                {
                    EmailId = "shubham@gmail.com",
                    Password = "12345"
                },
                new Models.User
                {
                   EmailId = "kumar@gmail.com",
                   Password = "67890"
                }
                };
                context.Users.AddRange(users);
                context.SaveChanges();
            }
        }

        public bool ValidateUser(Models.User user)
        {
            using (var context = new ApiContext())
            {
                //context.Users.fir
                var result = context.Users.Find(user.EmailId);
                if(result == null)
                {
                    return false;
                }
                return (result.EmailId == user.EmailId && result.Password == user.Password) ? true : false;
                
                
            }
        }
    }
}
