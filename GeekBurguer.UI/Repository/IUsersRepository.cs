using GeekBurguer.UI.Model;
using System.Collections.Generic;

namespace GeekBurguer.UI.Repository
{
    public interface IUsersRepository
    {
        User GetUserByFace(string faceUser);

        List<User> GetUsers();

        bool Add(User user);

        bool Update(User user);

        void Delete(User user);

        void Save();
    }
}
