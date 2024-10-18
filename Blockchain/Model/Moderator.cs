//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blockchain.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moderator
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int GenderID { get; set; }
        public string Email { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
        public string Phone { get; set; }
        public int DirectionID { get; set; }
        public int ModeratorEventID { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public Nullable<int> RoleID { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ModeratorEvent ModeratorEvent { get; set; }
        public virtual Role Role { get; set; }
    }
}
