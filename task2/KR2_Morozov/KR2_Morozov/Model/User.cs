//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KR2_Morozov.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.TaskUser = new HashSet<TaskUser>();
        }
    
        public int Id { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }
        public double Rate { get; set; }
        public int DeportamentId { get; set; }
        public string Duty { get; set; }
        public string Stackdescript { get; set; }
        public Nullable<int> RoleId { get; set; }
    
        public virtual Deportament Deportament { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskUser> TaskUser { get; set; }
    }
}
