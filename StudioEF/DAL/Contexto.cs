﻿using System;
using System.Collections.Generic;
using System.Text;
using FEG.Models;
using Microsoft.EntityFrameworkCore;
using FEG.BLL;

namespace FEG.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Fotografos> Fotografos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Compras> Compras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source= ./Data/StudioEF.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios { UsuarioId = 1, Nombres = "Administrador", NombreUsuario = "Admin", Contrasena = UsuariosBLL.Encriptar("Admin"), Email = "guichardo21@gmail.com" });
        }

       
    }
}
