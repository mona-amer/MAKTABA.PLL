using EXCEL.DAL.DB;

class Program
{
    static void Main(string[] args)
    {
        try
        {

            Console.Write("Enter the Excel file path: ");
            string filePath = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(filePath))
            {
                Console.WriteLine(" Invalid path. Please try again.");
                return;
            }


            COMPANYSERVICE company_Data_Service = new ();      
            //  Import data from the user-provided file path

            company_Data_Service.ImportDataFromExcel(filePath);

            Console.WriteLine("Data imported successfully!");
            // show the data in the console

            Console.WriteLine("Data in the database:");
            var data = company_Data_Service.GetAllAsync().Result;  


        }



        catch (Exception ex)
        {
            Console.WriteLine($" An error occurred: {ex.Message}");
        }
    }
}