using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyzerProblem_Day22.POCO
{
    public class CensusDataDAO
    {
        public string state;
        public long population;
        public long density;
        public long area;
        public CensusDataDAO(string state, string population, string density, string area)
        {
            this.state = state;
            this.population = Convert.ToInt32(population);
            this.density = Convert.ToInt32(density);
            this.area = Convert.ToInt32(area);
        }
    }
}
