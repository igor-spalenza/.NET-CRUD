using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Treinamento_CRM_Educacional.Models;

namespace Treinamento_CRM_Educacional.Data
{
    public class TreinamentoDataContext:DbContext
    {
        public TreinamentoDataContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Treinamento;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Pessoa> Pessoas{ get; set; }
        
    }
}