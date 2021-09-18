using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjRelacionamentoMVCAPINETCORE.Models;

namespace ProjRelacionamentoMVCAPINETCORE.Data
{
    public class ProjRelacionamentoMVCAPINETCOREContext : DbContext
    {
        public ProjRelacionamentoMVCAPINETCOREContext (DbContextOptions<ProjRelacionamentoMVCAPINETCOREContext> options)
            : base(options)
        {
        }

        public DbSet<ProjRelacionamentoMVCAPINETCORE.Models.Carro> Carro { get; set; }

        public DbSet<ProjRelacionamentoMVCAPINETCORE.Models.Locacao> Locacao { get; set; }
    }
}
