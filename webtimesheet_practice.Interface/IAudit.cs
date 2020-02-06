using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webtimesheet_practicing.models;

namespace webtimesheet_practice.Interface
{
    public interface IAudit
    {
        void InsertAuditData(AuditTB audittb);
    }
}
