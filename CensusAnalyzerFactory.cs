using IndianStatesCensusAnalyzerProblem_Day22.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyzerProblem_Day22
{
    public class CensusAnalyzerFactory
    {
        public Dictionary<string, CensusDTO> LoadCSVData(CensusAnalyzer.Country country, string csvFIlePath, string dataHeaders)
        {
            switch(country)
            {
                case (CensusAnalyzer.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFIlePath, dataHeaders);
                //case (CensusAnalyzer.Country.US):
                //    return new USCensusAdapter().LoadCensusData(csvFIlePath, dataHeaders);
                default:
                    throw new CensusAnalyzerException("No such Country", CensusAnalyzerException.ExceptionType.NO_SUCH_COUNTRY);  
            }
        }
    }
}
