using System;

namespace EntitlementsAPI.Models
{
    public class License
    {
        public int Id { get; set; }
        public Guid Fguid { get; set; }
        public int SubsId { get; set; }
    }
}
