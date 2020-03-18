using MySql.Data.MySqlClient;


namespace Autorization
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3308;username=root;password=root;database=Test_1");

        public void openCoonection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
