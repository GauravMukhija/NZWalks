using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZWalks.API.Models.Domain
{
    public class Walk
    {

        public int  Id { get; set; }

        public string Name { get; set; }

        public double Length { get; set; }

        public int RegionId { get; set; }

        public int WalkDifficultyId { get; set; }

        public Region Region { get; set; }

        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
