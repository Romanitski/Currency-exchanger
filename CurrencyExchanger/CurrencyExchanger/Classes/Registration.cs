using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace CurrencyExchanger.Classes
{
    public class Registration
    {
        private bool OperatorExists(SqlConnection connection, string operatorName)
        {
            string checkOperatorQuery = "SELECT * FROM Operators WHERE Operator_Name = @OperatorName";
            SqlCommand command = new SqlCommand(checkOperatorQuery, connection);
            SqlParameter operatorNameParameter = new SqlParameter
            {
                ParameterName = "@OperatorName",
                Value = operatorName
            };
            command.Parameters.Add(operatorNameParameter);
            var currentOperator = command.ExecuteReader();
            if (currentOperator.HasRows)
            {
                currentOperator.Close();
                return true;
            }
            else
            {
                currentOperator.Close();
                return false;
            }
        }

        private void RegistrationFunction(string OperatorName, string OperatorPassword, string OperatorType)
        {
            string registrationProcedure = "RegistrationProcedure";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CurrencyExchanger_db"].ConnectionString))
            {
                connection.Open();

                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand(registrationProcedure, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@Operator_Name", SqlDbType.VarChar).Value = OperatorName;
                sqlCommand.Parameters.Add("@Operator_Password", SqlDbType.VarChar).Value = PasswordHasher.GetHesh(OperatorPassword);
                sqlCommand.Parameters.Add("@Operator_Type", SqlDbType.VarChar).Value = OperatorType;

                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);

                connection.Close();
            }
        }
    }
}
