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
    
    public partial class Taskplatform
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int PlatformId { get; set; }
    
        public virtual Platforms Platforms { get; set; }
        public virtual Task Task { get; set; }
    }
}
