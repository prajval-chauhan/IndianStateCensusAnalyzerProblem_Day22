using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyzerProblem_Day22
{
    public class CensusAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, INCORRECT_HEADER, NO_SUCH_COUNTRY
        }
        public ExceptionType eType;
        public CensusAnalyzerException(string message, ExceptionType exceptionType): base(message)
        {
            this.eType = exceptionType;
        }
    }
}
