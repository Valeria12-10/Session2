﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Auth0.ManagementApi.Models;

namespace WebApiWM.Models
{

    public class User
    {
        public User(User юзер)
        {
            IDПользователя = юзер.IDПользователя;
            ИмяПользователя = юзер.ИмяПользователя;
            ХэшПароля = юзер.ХэшПароля;
            Email = юзер.Email;          
            Роль = юзер.Роль;

        }
        public int IDПользователя { get; set; }
        public string ИмяПользователя { get; set; }
        public string Email { get; set; }
        public string ХэшПароля { get; set; }
        public string Роль { get; set; }
    }
}