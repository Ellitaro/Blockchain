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
    
    public partial class Activity
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public System.DateTime Date { get; set; }
        public string Title { get; set; }
        public int Day { get; set; }
        public System.TimeSpan Time { get; set; }
        public int ModeratorID { get; set; }
        public int Jury1ID { get; set; }
        public Nullable<int> Jury2ID { get; set; }
        public Nullable<int> Jury3ID { get; set; }
        public int Jury4ID { get; set; }
        public Nullable<int> Jury5ID { get; set; }
        public int ParticipantID { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Jury Jury { get; set; }
        public virtual Jury Jury1 { get; set; }
        public virtual Jury Jury2 { get; set; }
        public virtual Jury Jury3 { get; set; }
        public virtual Jury Jury4 { get; set; }
    }
}
