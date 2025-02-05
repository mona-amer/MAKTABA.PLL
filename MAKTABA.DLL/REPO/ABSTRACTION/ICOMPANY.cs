using EXCEL.DAL.ENTITIES;

public interface ICOMPANYrepo
    {
        Task<List<COMPANY>> GetAllAsync();
        Task AddAsync( COMPANY data);
    } 