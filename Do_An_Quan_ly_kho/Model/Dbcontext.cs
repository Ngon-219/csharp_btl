using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Quan_ly_kho.Model
{
    internal class Dbcontext 
    {
        private databasemainDataContext db = new databasemainDataContext("Data Source=localhost\\SQLEXPRESS;Initial Catalog=csharp_winfrom;Integrated Security=True;TrustServerCertificate=True");
        
    }
}
