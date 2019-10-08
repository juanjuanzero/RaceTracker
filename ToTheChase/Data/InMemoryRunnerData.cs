using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToTheChase.Models;

namespace ToTheChase.Data
{
    public class InMemoryRunnerData : IRunnerData
    {
        public readonly List<Runner> RunnerDb;

        public InMemoryRunnerData()
        {
            RunnerDb = new List<Runner>
            {
                new Runner
                {
                    RunnerID = 1,
                    RunnerNumber = 1,
                    FirstName ="Mark",
                    LastName ="Dumbledor",
                    PaceMinutes =7,
                    PaceSeconds =30,
                    Van =Van.Van1
                },
                new Runner
                {
                    RunnerID = 2,
                    RunnerNumber = 2,
                    FirstName ="Dirk",
                    LastName ="Soul",
                    PaceMinutes =7,
                    PaceSeconds =0,
                    Van =Van.Van1
                },
                new Runner
                {
                    RunnerID = 3,
                    RunnerNumber = 3,
                    FirstName ="Ben",
                    LastName ="Soul",
                    PaceMinutes =8,
                    PaceSeconds =30,
                    Van =Van.Van1
                },
                new Runner
                {
                    RunnerID = 4,
                    RunnerNumber = 4,
                    FirstName ="Juan",
                    LastName ="Solo",
                    PaceMinutes =8,
                    PaceSeconds =0,
                    Van =Van.Van1
                },
                new Runner
                {
                    RunnerID = 5,
                    RunnerNumber = 5,
                    FirstName ="Mort",
                    LastName ="Wesleyan",
                    PaceMinutes =7,
                    PaceSeconds =30,
                    Van =Van.Van1
                },
                new Runner
                {
                    RunnerID = 6,
                    RunnerNumber = 6,
                    FirstName ="Will",
                    LastName ="Steakman",
                    PaceMinutes =7,
                    PaceSeconds =30,
                    Van =Van.Van1
                },
                new Runner
                {
                    RunnerID = 7,
                    RunnerNumber = 7,
                    FirstName ="Daniel",
                    LastName ="Verde",
                    PaceMinutes =9,
                    PaceSeconds =30,
                    Van =Van.Van2
                },
                new Runner
                {
                    RunnerID = 8,
                    RunnerNumber = 8,
                    FirstName ="Stu",
                    LastName ="Samuels",
                    PaceMinutes =7,
                    PaceSeconds =0,
                    Van =Van.Van2
                },
                new Runner
                {
                    RunnerID = 9,
                    RunnerNumber = 9,
                    FirstName ="Juan",
                    LastName ="TrickPony",
                    PaceMinutes =7,
                    PaceSeconds =30,
                    Van =Van.Van2
                },
                new Runner
                {
                    RunnerID = 10,
                    RunnerNumber = 10,
                    FirstName ="Mac",
                    LastName ="Shaw",
                    PaceMinutes =7,
                    PaceSeconds =0,
                    Van =Van.Van2
                },
                new Runner
                {
                    RunnerID = 11,
                    RunnerNumber = 11,
                    FirstName ="Stan",
                    LastName ="Samuels",
                    PaceMinutes =8,
                    PaceSeconds =30,
                    Van =Van.Van2
                },
                new Runner
                {
                    RunnerID = 12,
                    RunnerNumber = 12,
                    FirstName ="Dan",
                    LastName ="Smith",
                    PaceMinutes =8,
                    PaceSeconds =30,
                    Van =Van.Van2
                }
            };
        }

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
        }

        public void Add(Runner runner)
        {
            var newRunner = runner;
            newRunner.RunnerID = RunnerDb.Max(r => r.RunnerID) + 1;
            newRunner.RunnerNumber = newRunner.RunnerID;
            RunnerDb.Add(newRunner);
        }

        public void Remove(int id)
        {
            var r = GetRunnerById(id);
            RunnerDb.Remove(r);
        }
    }
}