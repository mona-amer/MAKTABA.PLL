using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL.BLL.SERVICE.Abstraction
{
    public interface ICOMPANYSEVICE
    {
        Task ImportDataFromExcel(string filePath); 

    }
}
