using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.API.Models.Domain
{
    public class Region
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        public long Population { get; set; }

        public IEnumerable<Walk> Walks { get; set; }

    }
}
