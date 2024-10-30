using System;

namespace TaskMaster.Models
{
    public class Tarefa
    {
        public int Id { get; set; } // ID único

        // Tornando Título, Descricao e Status anuláveis
        public string? Titulo { get; set; } // Título da tarefa
        public string? Descricao { get; set; } // Descrição da tarefa
        public DateTime DataCriacao { get; set; } // Data de criação da tarefa
        public string? Status { get; set; } // Status da tarefa (pendente, em progresso, concluída)

        public int PessoaId { get; set; } // ID da pessoa responsável

        // Tornando Pessoa anulável para evitar erros ao inicializar uma tarefa sem pessoa atribuída
        public Pessoa? Pessoa { get; set; } // Navegação para a pessoa responsável
    }
}
