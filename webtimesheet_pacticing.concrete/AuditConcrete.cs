using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webtimesheet_practice.Interface;
using webtimesheet_practicing.models;

namespace webtimesheet_pacticing.concrete
{
   public class AuditConcrete: IAudit
    {
       

        public void InsertAuditData(AuditTB audittb)
        {
            using (var _context = new DatabaseContext())
            {
                _context.AuditTB.Add(audittb);
                _context.SaveChanges();
            }
        }
    }
}
