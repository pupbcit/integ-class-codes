using System.Collections.Generic;

namespace SISBL
{
    public class UserBusinessLogic
    {
        static List<UserCredentials> registeredUser = new List<UserCredentials>();


        static public bool Login(string studnum, string pw)
        {
            for (int i = 0; i < registeredUser.Count; i++)
            {
                if (registeredUser[i].studentnumber == studnum && registeredUser[i].password == pw)
                {
                    return true;
                }
            }

            return false;
        }

        static public void RegisterUser(UserCredentials newUser)
        {
            registeredUser.Add(newUser);
        }

    }
}
