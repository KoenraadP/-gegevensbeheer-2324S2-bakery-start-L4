using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakery.Dal
{
    public class BakeryDbContext : DbContext
    {
        public BakeryDbContext() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=BakeryDb;Integrated Security=True")
        {

        }

        // welke tabellen wil je in de database?

        

        // Stap 1: Migraties inschakelen --> dit moet je slechts één keer doen
        // EntityFramework6\Enable-Migrations

        // Stap 2: Voeg een migratie toe --> elke keer je iets verandert aan je Entities classes
        // één parameter: naam voor migration (wat wordt er gewijzigd of wat moet er gebeuren?)
        // EntityFramework6\Add-Migration CreateDatabase

        // Stap 3: Update de database --> altijd nadat je eerst Add-Migration (stap 2) gedaan hebt
        // EntityFramework6\Update-Database
        
    }
}
