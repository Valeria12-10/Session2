//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiWM.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователи
    {
        

        public int IDПользователя { get; set; }
        public string ИмяПользователя { get; set; }
        public string Email { get; set; }
        public string ХэшПароля { get; set; }
        public string Роль { get; set; }
        public byte[] Фото { get; set; }
    }
}
