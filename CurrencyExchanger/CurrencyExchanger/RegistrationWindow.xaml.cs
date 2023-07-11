using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using CurrencyExchanger.Classes;

namespace CurrencyExchanger
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private bool OperatorExists(SqlConnection connection, string userName)
        {
            string checkOperatorQuery = "SELECT * FROM Operators WHERE Operator_Name = @OperatorName";
            SqlCommand command = new SqlCommand(checkOperatorQuery, connection);
            SqlParameter operatorNameParameter = new SqlParameter
            {
                ParameterName = "@UserName",
                Value = userName
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

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            String name = operatorName.Text;
            String password = operatorPassword.Password;
            string operatorPosition = operatorType.Text;
            string registrationProcedure = "RegistrationProcedure";

            using(SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CurrencyExchanger_db"].ConnectionString))
            {
                connection.Open();


                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand(registrationProcedure, connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = name;
                sqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = PasswordHasher.GetHesh(password);

                try
                {
                    if(name.Trim().Equals("") || password.Trim().Equals("") || operatorType.Text.Equals(""))
                    {

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Такое имя уже существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
