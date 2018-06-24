using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SchoolApi.DataAccess.Models;

namespace SchoolApi.DataAccess
{
    public class ResultDataAccess :  BaseDataAccess
    {
        public ResultDataAccess(string connectionString) : base(connectionString)
        {

        }

        public OverallResults GetOverallResults()
        {
            List<DbParameter> parameterList = new List<DbParameter>();
            OverallResults overallResult = new OverallResults();

            using (DbDataReader dataReader = base.GetDataReader("Test_GetAll", parameterList, CommandType.StoredProcedure))
            {
                if (dataReader != null && dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        overallResult.Appeared = (int)dataReader["Appeared"];
                        overallResult.TotalStudentsPassed = (int)dataReader["TotalStudentsPassed"];
                        overallResult.PassPercent = (decimal)dataReader["Pass%"];

                        overallResult.SUB1Failed = (int)dataReader["SUB1Failed"];
                        overallResult.SUB2Failed = (int)dataReader["SUB2Failed"];
                        overallResult.SUB2Failed = (int)dataReader["SUB2Failed"];
                        overallResult.SUB3Failed = (int)dataReader["SUB3Failed"];
                        overallResult.SUB4Failed = (int)dataReader["SUB4Failed"];
                        overallResult.SUB5Failed = (int)dataReader["SUB5Failed"];
                        overallResult.SUB6Failed = (int)dataReader["SUB6Failed"];
                    }
                }
            }
            return overallResult;
        }
    }
}
