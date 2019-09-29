using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToTheChase.Models;

namespace ToTheChase.Data
{
    public interface IRunnerData
    {
        IEnumerable<Runner> GetAllRunners();
        Runner GetRunnerById(int id);
        void UpdateRunner(Runner runner);
    }
}
