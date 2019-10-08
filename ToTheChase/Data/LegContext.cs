using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToTheChase.Data.Interfaces;
using ToTheChase.Models;

namespace ToTheChase.Data
{
    public class LegContext : DbContext, ILegData
    {
        public DbSet<Leg> LegsDb { get; set; }
        public LegContext(): base("ToTheChase_SqlServer")
        {

        }

        public void Add(Leg leg)
        {
            LegsDb.Add(leg);
            SaveChanges();
        }

        public Leg GetLegById(int id)
        {
            var leg = LegsDb.FirstOrDefault(l => l.LegID == id);
            return leg;
        }

        public IEnumerable<Leg> Legs()
        {
            return LegsDb;
        }

        public void Remove(int id)
        {
            var leg = LegsDb.FirstOrDefault(l => l.LegID == id);
            LegsDb.Remove(leg);
            SaveChanges();
        }

        public void UpdateLeg(Leg leg)
        {
            var updateleg = LegsDb.FirstOrDefault(l => l.LegID == leg.LegID);
            if(updateleg != null)
            {
                var legEntry = Entry(updateleg);
                legEntry.State = EntityState.Modified;
                updateleg.EndExchange = leg.EndExchange;
                updateleg.LegDescrition = leg.LegDescrition;
                updateleg.LegName = leg.LegName;
                updateleg.LegNumber = leg.LegNumber;
                updateleg.LengthInMiles = leg.LengthInMiles;
                updateleg.StartExchange = leg.StartExchange;
                SaveChanges();
            }
            
        }
    }
}