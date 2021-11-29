using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Data
{
    public interface IAdultService
    {
        public Task<IList<Adult>> GetAdultsAsync();
    }
}