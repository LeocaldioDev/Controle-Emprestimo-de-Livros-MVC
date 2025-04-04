﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.DATA.Models;

public partial class ControleEmprestimoLivroContext : DbContext
{
    public ControleEmprestimoLivroContext()
    {
    }

    public ControleEmprestimoLivroContext(DbContextOptions<ControleEmprestimoLivroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Livro> Livros { get; set; }

    public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; }

    public virtual DbSet<VwLivroClienteEmprestimo> VwLivroClienteEmprestimos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-D79UVC8;Initial Catalog=ControleEmprestimoLivro;User ID=sa;Password=536539;Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
        {
            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.LivroClienteEmprestimos).HasConstraintName("FK_livro_cliente_emprestimo_Cliente");

            entity.HasOne(d => d.IdlivroNavigation).WithMany(p => p.LivroClienteEmprestimos).HasConstraintName("FK_livro_cliente_emprestimo_Livro");
        });

        modelBuilder.Entity<VwLivroClienteEmprestimo>(entity =>
        {
            entity.ToView("VW_Livro_Cliente_Emprestimo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}