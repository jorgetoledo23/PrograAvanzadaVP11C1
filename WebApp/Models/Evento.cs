namespace WebApp.Models
{
    public class Evento
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Estado { get; set; }


        //FK

        public int LugarId { get; set; }
        public Lugar? Lugar { get; set; }



        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }


    }
}
