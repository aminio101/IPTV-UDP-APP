//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MRK_Udp_Server_HTV
{
    using System;
    using System.Collections.Generic;
    
    public partial class TV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Floor { get; set; }
        public Nullable<int> RoomNumber { get; set; }
        public string IP { get; set; }
        public string SubnetMask { get; set; }
        public string Getway { get; set; }
        public string DNS { get; set; }
        public bool registered { get; set; }
        public string MAC { get; set; }
        public bool status { get; set; }
    }
}
