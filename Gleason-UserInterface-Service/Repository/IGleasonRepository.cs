using System;
namespace Gleason_UserInterface_Service.Repository
{
    public interface IGleasonRepository
    {
        public Boolean ValidateUser(Models.User user);
    }
}
