//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SamuraiApp.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class BattleSamuraiEntity
    {
        public int BattleSamuraiId { get; set; }
        public int SamuraiId { get; set; }
        public int BattleId { get; set; }
    
        public virtual BattleEntity Battle { get; set; }
        public virtual SamuraiEntity Samurai { get; set; }
    }
}