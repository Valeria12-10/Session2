using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiWM.Entities;

namespace WebApiWM
    {
        public interface IAuthService 
        {
            string Authenticate(string username, string password);
            string AuthenticateWith2FA(string username, string token);
        }

        public class AuthService : IAuthService
        {
            private readonly List<Пользователи> _users = new List<Пользователи>
    {
        new Пользователи { IDПользователя = 1, ИмяПользователя = "admin", ХэшПароля = "hashed_password_1", Роль = "Администратор" },
        new Пользователи { IDПользователя = 2, ИмяПользователя = "storekeeper", ХэшПароля = "hashed_password_2", Роль = "Кладовщик" }
    };

            public string Authenticate(string username, string password)
            {
                var user = _users.SingleOrDefault(u => u.ИмяПользователя == username && u.ХэшПароля == password);
                if (user == null)
                    return null;

                // Генерация JWT-токена (упрощенно)
                return "generated_jwt_token";
            }

            public string AuthenticateWith2FA(string username, string token)
            {
                var user = _users.SingleOrDefault(u => u.ИмяПользователя == username);
                if (user == null || token != "valid_2fa_token")
                    return null;

                // Генерация JWT-токена (упрощенно)
                return "generated_jwt_token";
            }
        }
    }