using XO.Entities.ModelExtensions;
using Microsoft.EntityFrameworkCore;

namespace XO.Entities.Models
{
    public partial class XOContext
    {
        public DbQuery<AdminGroupPermission_View00> AdminGroupPermission_View00 { get; set; }
    }
}
