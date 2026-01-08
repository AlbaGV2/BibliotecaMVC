namespace BibliotecaMVC.Core.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }

        public List<Rol> Roles { get; set; }

        public string PasswordHash
        {
            get; set;

        }
    }
}
