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
        private readonly List<Leg> LegsDb;
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
                    LegID = 15,
                    LegNumber = 3,
                    LengthInMiles = 3.5
                },
                new Leg
                {
                    LegID = 16,
                    LegNumber = 4,
                    LengthInMiles = 5.2
                },
                new Leg
                {
                    LegID = 17,
                    LegNumber = 5,
                    LengthInMiles = 4.5
                },
                new Leg
                {
                    LegID = 18,
                    LegNumber = 6,
                    LengthInMiles = 6.2
                },
                new Leg
                {
                    LegID = 19,
                    LegNumber = 7,
                    LengthInMiles = 4.9
                },
                new Leg
                {
                    LegID = 20,
                    LegNumber = 8,
                    LengthInMiles = 4.8
                },
                new Leg
                {
                    LegID = 21,
                    LegNumber = 9,
                    LengthInMiles = 9
                },
                new Leg
                {
                    LegID = 22,
                    LegNumber = 10,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 23,
                    LegNumber = 11,
                    LengthInMiles = 6.3
                },
                new Leg
                {
                    LegID = 24,
                    LegNumber = 12,
                    LengthInMiles = 5.8
                },
                new Leg
                {
                    LegID = 25,
                    LegNumber = 1,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 26,
                    LegNumber = 2,
                    LengthInMiles = 7.3
                },
                new Leg
                {
                    LegID = 27,
                    LegNumber = 3,
                    LengthInMiles = 3.5
                },
                new Leg
                {
                    LegID = 28,
                    LegNumber = 4,
                    LengthInMiles = 5.2
                },
                new Leg
                {
                    LegID = 29,
                    LegNumber = 5,
                    LengthInMiles = 4.5
                },
                new Leg
                {
                    LegID = 30,
                    LegNumber = 6,
                    LengthInMiles = 6.2
                },
                new Leg
                {
                    LegID = 31,
                    LegNumber = 7,
                    LengthInMiles = 4.9
                },
                new Leg
                {
                    LegID = 32,
                    LegNumber = 8,
                    LengthInMiles = 4.8
                },
                new Leg
                {
                    LegID = 33,
                    LegNumber = 9,
                    LengthInMiles = 9
                },
                new Leg
                {
                    LegID = 34,
                    LegNumber = 10,
                    LengthInMiles = 7.4
                },
                new Leg
                {
                    LegID = 35,
                    LegNumber = 11,
                    LengthInMiles = 6.3
                },
                new Leg
                {
                    LegID = 36,
                    LegNumber = 12,
                    LengthInMiles = 5.8
                }
            };
        }

        public void Add(Leg leg)
        {
            leg.LegID = LegsDb.Max(l => l.LegID) + 1;
            LegsDb.Add(leg);
        }

        public Leg GetLegById(int id)
        {
            var leg = LegsDb.FirstOrDefault(l => l.LegID == id);
            return leg;
        }

        public IEnumerable<Leg> Legs()
        {
            return LegsDb.OrderBy(l => l.LegNumber);
        }

        public void Remove(int id)
        {
            var leg = GetLegById(id);
            LegsDb.Remove(leg);
        }

        public void UpdateLeg(Leg leg)
        {
            Remove(leg.LegID);
            LegsDb.Add(leg);
        }
    }
}