using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileData;


namespace Assignment1.Data

{
    public class AdultService : IAdultService
    {
        IList<Adult> Adults { get; set; }
        public async Task<IList<Adult>> GetAdultsAsync()
        {

            List<Adult> adults;


            FileContext ctx = new FileContext();
            {
                adults = ctx.Adults.ToList();
                 ctx.SaveChanges();
            }
            return adults;
        }
    }
}