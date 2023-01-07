using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payement_Application_From_Scrash.Models
{
    public class PayementDetailContext: DbContext
    {
        public PayementDetailContext(DbContextOptions<PayementDetailContext> options):base(options)
        {

        }
        public DbSet<PaymentDetail> PayementDetails { get; set; }
    }
}
