using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToTheChase.Data.Interfaces;
using ToTheChase.Models;

namespace ToTheChase.Data
{
    public class InMemoryLegData : ILegData
    {
        private readonly IEnumerable<Leg> LegsDb;
        public InMemoryLegData()
        {
            LegsDb = new List<Leg>
            {
                new Leg
                {
                    LegID = 1,
                    LegNumber = 1,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 2,
                    LegNumber = 2,
                    LengthInMiles = 7.3
                },
                new Leg
                {
                    LegID = 3,
                    LegNumber = 3,
                    LengthInMiles = 3.5
                },
                new Leg
                {
                    LegID = 4,
                    LegNumber = 4,
                    LengthInMiles = 5.2
                },
                new Leg
                {
                    LegID = 5,
                    LegNumber = 5,
                    LengthInMiles = 4.5
                },
                new Leg
                {
                    LegID = 6,
                    LegNumber = 6,
                    LengthInMiles = 6.2
                },
                new Leg
                {
                    LegID = 7,
                    LegNumber = 7,
                    LengthInMiles = 4.9
                },
                new Leg
                {
                    LegID = 8,
                    LegNumber = 8,
                    LengthInMiles = 4.8
                },
                new Leg
                {
                    LegID = 9,
                    LegNumber = 9,
                    LengthInMiles = 9
                },
                new Leg
                {
                    LegID = 10,
                    LegNumber = 10,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 11,
                    LegNumber = 11,
                    LengthInMiles = 6.3
                },
                new Leg
                {
                    LegID = 12,
                    LegNumber = 12,
                    LengthInMiles = 5.8
                },
                new Leg
                {
                    LegID = 13,
                    LegNumber = 13,
                    LengthInMiles = 4.5
                },
                new Leg
                {
                    LegID = 14,
                    LegNumber = 14,
                    LengthInMiles = 6.5
                },
                new Leg
                {
                    LegID = 3,
                    LegNumber = 3,
                    LengthInMiles = 3.5
                },
                new Leg
                {
                    LegID = 4,
                    LegNumber = 4,
                    LengthInMiles = 5.2
                },
                new Leg
                {
                    LegID = 5,
                    LegNumber = 5,
                    LengthInMiles = 4.5
                },
                new Leg
                {
                    LegID = 6,
                    LegNumber = 6,
                    LengthInMiles = 6.2
                },
                new Leg
                {
                    LegID = 7,
                    LegNumber = 7,
                    LengthInMiles = 4.9
                },
                new Leg
                {
                    LegID = 8,
                    LegNumber = 8,
                    LengthInMiles = 4.8
                },
                new Leg
                {
                    LegID = 9,
                    LegNumber = 9,
                    LengthInMiles = 9
                },
                new Leg
                {
                    LegID = 10,
                    LegNumber = 10,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 11,
                    LegNumber = 11,
                    LengthInMiles = 6.3
                },
                new Leg
                {
                    LegID = 12,
                    LegNumber = 12,
                    LengthInMiles = 5.8
                },
                new Leg
                {
                    LegID = 1,
                    LegNumber = 1,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 2,
                    LegNumber = 2,
                    LengthInMiles = 7.3
                },
                new Leg
                {
                    LegID = 3,
                    LegNumber = 3,
                    LengthInMiles = 3.5
                },
                new Leg
                {
                    LegID = 4,
                    LegNumber = 4,
                    LengthInMiles = 5.2
                },
                new Leg
                {
                    LegID = 5,
                    LegNumber = 5,
                    LengthInMiles = 4.5
                },
                new Leg
                {
                    LegID = 6,
                    LegNumber = 6,
                    LengthInMiles = 6.2
                },
                new Leg
                {
                    LegID = 7,
                    LegNumber = 7,
                    LengthInMiles = 4.9
                },
                new Leg
                {
                    LegID = 8,
                    LegNumber = 8,
                    LengthInMiles = 4.8
                },
                new Leg
                {
                    LegID = 9,
                    LegNumber = 9,
                    LengthInMiles = 9
                },
                new Leg
                {
                    LegID = 10,
                    LegNumber = 10,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 11,
                    LegNumber = 11,
                    LengthInMiles = 6.3
                },
                new Leg
                {
                    LegID = 12,
                    LegNumber = 12,
                    LengthInMiles = 5.8
                }
            };
        }

        public IEnumerable<Leg> Legs()
        {
            return LegsDb;
        }
    }
}