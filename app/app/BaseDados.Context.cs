﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BaseDadosContainer : DbContext
    {
        public BaseDadosContainer()
            : base("name=BaseDadosContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> CategoriaSet { get; set; }
        public virtual DbSet<Estado> EstadoSet { get; set; }
        public virtual DbSet<MetodoPagamento> MetodoPagamentoSet { get; set; }
        public virtual DbSet<Pessoa> PessoaSet { get; set; }
        public virtual DbSet<Morada> MoradaSet { get; set; }
        public virtual DbSet<Restaurante> RestauranteSet { get; set; }
        public virtual DbSet<ItemMenu> ItemMenuSet { get; set; }
        public virtual DbSet<Pagamento> PagamentoSet { get; set; }
        public virtual DbSet<Pedido> PedidoSet { get; set; }
    }
}
