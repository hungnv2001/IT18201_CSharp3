namespace CreateDatabase
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SqlConnection conn = new SqlConnection(@"Data Source=HUNG\SQLEXPRESS;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Matkhau1");

            string query = "Create Database ComputerShop";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully");

            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}