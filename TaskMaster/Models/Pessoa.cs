using System;
using System.Collections.Generic;

namespace TaskMaster.Models
{
    public class Pessoa
    {
        public int Id { get; set; } // ID único

        // Tornando as propriedades Nome e Email anuláveis
        public string? Nome { get; set; } // Nome da pessoa
        public string? Email { get; set; } // E-mail da pessoa

        public DateTime DataNascimento { get; set; } // Data de nascimento da pessoa

        // Inicializando a coleção de Tarefas
        public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>(); // Tarefas associadas à pessoa
    }
}
