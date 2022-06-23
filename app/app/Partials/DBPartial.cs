namespace app
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class BaseDadosContainer : DbContext
    {
        public virtual DbSet<Trabalhador> TrabalhadorSet { get; set; }
    }
}
