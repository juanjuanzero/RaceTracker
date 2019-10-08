using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToTheChase.Models;

namespace ToTheChase.Data
{
    public class RunnerContext :DbContext, IRunnerData
    {
        public RunnerContext() :base("ToTheChase_SqlServer")
        {

        }
        public DbSet<Runner> RunnerDb { get; set; }

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

        public void Add(Runner runner)
        {
            RunnerDb.Add(runner);
            SaveChanges();
        }

        public void Remove(int id)
        {
            var r = GetRunnerById(id);
            RunnerDb.Remove(r);
            SaveChanges();
        }
    }
}