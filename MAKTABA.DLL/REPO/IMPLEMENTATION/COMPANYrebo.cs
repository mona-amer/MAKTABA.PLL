using EXCEL.DAL.DB;
using EXCEL.DAL.ENTITIES;
using Microsoft.EntityFrameworkCore;

public class COMPANYrebo : COMPANY

{
    private readonly ApplicationDBcontext _context;

    public COMPANYrebo(ApplicationDBcontext context)
    {
        _context = context;
    }

    public COMPANYrebo()
    {
    }

    public async Task<List<COMPANY>> GetAllAsync()
    {
        return await _context.ExcelData.ToListAsync();
    }

    public async Task AddAsync(COMPANY data)
    {
        await _context.ExcelData.AddAsync(data);
        await _context.SaveChangesAsync();
    }
}
