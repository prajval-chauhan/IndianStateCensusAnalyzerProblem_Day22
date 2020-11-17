using IndianStatesCensusAnalyzerProblem_Day22.POCO;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace IndianStatesCensusAnalyzerProblem_Day22
{
    class Program
    {
        public static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        public static string indianStateCodeHeaders = "SrNo,State Name,TIN,StateCode";
        public static string indianStateCensusFilePath = @"C:\Users\prajv\source\repos\IndianStatesCensusAnalyzerProblem_Day22\files\IndiaStateCensusData.csv";
        public static string indianStateCodeFilePath = @"C:\Users\prajv\source\repos\IndianStatesCensusAnalyzerProblem_Day22\files\IndiaStateCode.csv";
        public static Dictionary<string, CensusDTO> totalRecord = new Dictionary<string, CensusDTO>();
        public static Dictionary<string, CensusDTO> stateRecord = new Dictionary<string, CensusDTO>();

        static void Main(string[] args)
        {
            Console.WriteLine("------STATE ANALYZER PROGRAM-------");
            CensusAnalyzer censusAnalyzer = new CensusAnalyzer();
            totalRecord = censusAnalyzer.LoadCensusData(CensusAnalyzer.Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            stateRecord = censusAnalyzer.LoadCensusData(CensusAnalyzer.Country.INDIA, indianStateCodeFilePath, indianStateCodeHeaders);
            Console.WriteLine("Total Records present in the Indian State Census file are: " + totalRecord.Count);
            Console.WriteLine("Total Records present in the Indian State Code file are: " + stateRecord.Count);
        }
    }
}
