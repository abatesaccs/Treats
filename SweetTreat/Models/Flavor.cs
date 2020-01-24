using System.Collections.Generic;

namespace SweetTreat.Models
{
    public class Flavor
    {
        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }

        public int FlavorId {get; set;}
        public string FlavorName {get; set;}
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<TreatFlavor> Treats {get; set;}
    }
}