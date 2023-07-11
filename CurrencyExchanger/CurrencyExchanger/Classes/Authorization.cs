using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CurrencyExchanger.Classes;
using System.Threading.Tasks;

namespace CurrencyExchanger.Classes
{
    public class Authorization
    {
        private Operator statusOperator;

        private void AuthorizationFunction(string OperatorName, string OperatorPassword, string OperatorType)
        {
            statusOperator = Operator.GetInstance();

            bool operatorExist = false;

            string operatorInfoQuery = "SELECT * FROM Operators WHERE Operator_Name = @OperatorName AND Operator_Password = @OperatorPassword AND Operator_Type = @OperatorType";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CurrencyExchanger_db"].ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(operatorInfoQuery, connection);
                SqlParameter login = new SqlParameter
                {
                    ParameterName = "@OperatorName",
                    Value = OperatorName
                };
                SqlParameter password = new SqlParameter
                {
                    ParameterName = "@OperatorPassword",
                    Value = PasswordHasher.GetHesh(OperatorPassword)
                };
                SqlParameter type = new SqlParameter
                {
                    ParameterName = "@OperatorType",
                    Value = PasswordHasher.GetHesh(OperatorType)
                };

                command.Parameters.Add(login);
                command.Parameters.Add(password);
                command.Parameters.Add(type);

                var currentOperator = command.ExecuteReader();
                if (currentOperator.HasRows)
                {
                    operatorExist = true;
                    while (currentOperator.Read())
                    {
                        statusOperator.operatorId = currentOperator.GetInt32(0);
                        statusOperator.operatorName = currentOperator.GetString(1);
                        statusOperator.operatorPassword = currentOperator.GetString(2);
                        statusOperator.operatorType = currentOperator.GetString(3);
                    }
                }
                currentOperator.Close();

                connection.Close();
            }
        }
    }
}
