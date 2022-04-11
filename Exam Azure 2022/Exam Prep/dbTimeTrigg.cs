using System;

using System.Data.SqlClient;



public static void Run(TimerInfo myTimer, ILogger log)

{

    string constr = "Server=tcp:http-triggers-sql-server.database.windows.net,1433;Initial Catalog=http-triggers-sql;Persist Security Info=False;User ID=chonoadmin;Password=ENTER_PASSWORD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    string sqltext;



    log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

    //

    using (SqlConnection conn = new SqlConnection(constr))

    {

        conn.Open();



        // Insert a row

        sqltext = "INSERT INTO SubmittedItems (SubmittedName) VALUES ('TIMER')";



        using (SqlCommand cmd = new SqlCommand(sqltext, conn))

        {

            cmd.ExecuteNonQuery();

        }



    }

}