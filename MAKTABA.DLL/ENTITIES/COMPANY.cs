using EXCEL.DAL.ENTITIES;
using LinqToExcel.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEL.DAL.ENTITIES
{
   public class COMPANY
    {
        [ExcelColumn("year")]
        public decimal year { get; set; }


        [ExcelColumn("months")]
        public string months { get; set; }


        [ExcelColumn("target")]
        public double target { get; set; }

        public async Task AddAsync(COMPANY record)
        {
            throw new NotImplementedException();
        }

        public async Task<List<COMPANY>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}






   
 