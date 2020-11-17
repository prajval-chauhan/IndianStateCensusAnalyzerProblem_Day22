using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using IndianStatesCensusAnalyzerProblem_Day22.POCO;
using Newtonsoft.Json;

namespace IndianStatesCensusAnalyzerProblem_Day22
{
    public class CensusAnalyzer
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        public Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {
            dataMap = new CensusAnalyzerFactory().LoadCSVData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
