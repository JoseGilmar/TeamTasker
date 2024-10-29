using System;
using System.Collections.Generic;

namespace TaskMaster.Models
{
    public class Pessoa
    {
        public int Id { get; set; } // ID único
        public string Nome { get; set; } // Nome da pessoa
        public string Email { get; set; } // E-mail da pessoa
        public DateTime DataNascimento { get; set; } // Data de nascimento da pessoa

        public ICollection<Tarefa> Tarefas { get; set; } // Tarefas associadas à pessoa
    }
}
