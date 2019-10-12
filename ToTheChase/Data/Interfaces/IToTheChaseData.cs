using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToTheChase.Models;

namespace ToTheChase.Data
{
    public interface IToTheChaseData
    {
        IEnumerable<Runner> GetAllRunners();
        Runner GetRunnerById(int id);
        void UpdateRunner(Runner runner);
        void AddRunner(Runner runner);
        void RemoveRunner(int id);

        IEnumerable<Leg> Legs();
        Leg GetLegById(int id);
        void UpdateLeg(Leg leg);
        void AddLeg(Leg leg);
        void RemoveLeg(int id);
    }
}
