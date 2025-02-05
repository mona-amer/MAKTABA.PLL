

using EXCEL.BLL.SERVICE.Abstraction;
using EXCEL.DAL.DB;
using EXCEL.DAL.ENTITIES;
using Ganss.Excel;

public class COMPANYSERVICE : ICOMPANYSEVICE

{
    private readonly COMPANY _repository;

    public COMPANYSERVICE (ICOMPANYrepo repository)
    {
        _repository = new COMPANYrebo (new ApplicationDBcontext());
    }

    public async Task ImportDataFromExcel(string filePath)
    {
        var excelMapper = new ExcelMapper(filePath);
        var records = excelMapper.Fetch<COMPANY>().ToList();

        foreach (var record in records)
        {
            await _repository.AddAsync(record);
        }

        Console.WriteLine(" Data added successfully!");
    }

    public async Task<List<COMPANY>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task AddAsync(COMPANY data)
    {
        await _repository.AddAsync(data);
    }
}