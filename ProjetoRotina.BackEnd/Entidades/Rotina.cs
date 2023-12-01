namespace ProjetoRotina.BackEnd.Entidades
{
    public class Rotina
    {
        public Rotina()
        {
            RotinaRealizada = new RotinaRealizada();
        }
        public int Id { get; set; }
        public string NomeDaRotina { get; set; }
        public string DiasDaSemana { get; set; }
        public int IdDoUsuario { get; set; }
        public RotinaRealizada RotinaRealizada { get; set; }
        public ICollection<RotinaRealizada> RotinasRealizadas { get; set; }
    }
}
