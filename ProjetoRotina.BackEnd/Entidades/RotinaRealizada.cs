namespace ProjetoRotina.BackEnd.Entidades
{
    public class RotinaRealizada
    {
        public int Id { get; set; }
        public bool Realizado { get; set; }
        public string? DataDaRealizacao { get; set; }
        public int IdDaRotina { get; set; }
    }
}
