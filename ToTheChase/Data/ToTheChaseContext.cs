using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToTheChase.Models;

namespace ToTheChase.Data
{
    public class ToTheChaseContext :DbContext, IToTheChaseData
    {
        public ToTheChaseContext() :base("ToTheChase_SqlServer")
        {

        }
        public DbSet<Runner> RunnerDb { get; set; }
        public DbSet<Leg> LegsDb { get; set; }

        #region Runner Methods
        public Runner GetRunnerById(int id)
        {
            var runner = RunnerDb.FirstOrDefault(r => r.RunnerID == id);
            return runner;
        }

        public IEnumerable<Runner> GetAllRunners()
        {
            return RunnerDb.OrderBy(r => r.RunnerNumber);
        }

        public void UpdateRunner(Runner NewRunner)
        {
            var oldRunner = RunnerDb.FirstOrDefault(r => r.RunnerID == NewRunner.RunnerID);
            RunnerDb.Remove(oldRunner);
            RunnerDb.Add(NewRunner);
            SaveChanges();
        }

        public void AddRunner(Runner runner)
        {
            RunnerDb.Add(runner);
            SaveChanges();
        }

        public void RemoveRunner(int id)
        {
            var r = GetRunnerById(id);
            RunnerDb.Remove(r);
            SaveChanges();
        }
        #endregion

        #region Leg Methods


        public void AddLeg(Leg leg)
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

        public void RemoveLeg(int id)
        {
            var leg = LegsDb.FirstOrDefault(l => l.LegID == id);
            LegsDb.Remove(leg);
            SaveChanges();
        }

        public void UpdateLeg(Leg leg)
        {
            var updateleg = LegsDb.FirstOrDefault(l => l.LegID == leg.LegID);
            if (updateleg != null)
            {
                var legEntry = Entry(updateleg);
                legEntry.State = EntityState.Modified;
                updateleg.EndExchange = leg.EndExchange;
                updateleg.LegNumber = leg.LegNumber;
                updateleg.LengthInMiles = leg.LengthInMiles;
                updateleg.StartExchange = leg.StartExchange;
                updateleg.AssignedRunnerId = leg.AssignedRunnerId;
                updateleg.LegDifficulty = leg.LegDifficulty;
                SaveChanges();
            }

        }
        #endregion
    }
}