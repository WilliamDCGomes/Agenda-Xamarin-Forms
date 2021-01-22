﻿using AppTarefas.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTarefas.Banco
{
    public class BancoContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        public BancoContext()
        {
            Database.Migrate();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={Constantes.CaminhoDoBanco}");
        }
    }
}
