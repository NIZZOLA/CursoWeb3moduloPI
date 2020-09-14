using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoNoticiasMVCEtec.Models;

namespace ProjetoNoticiasMVCEtec.Data
{
    public class ProjetoNoticiasMVCEtecContext : DbContext
    {
        public ProjetoNoticiasMVCEtecContext (DbContextOptions<ProjetoNoticiasMVCEtecContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoNoticiasMVCEtec.Models.NoticiaModel> NoticiaModel { get; set; }
    }
}
