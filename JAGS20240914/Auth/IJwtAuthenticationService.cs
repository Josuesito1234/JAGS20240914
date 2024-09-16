namespace JAGS20240914.Auth
{
    // Interfaz para un servicio de autentication JWT
    public interface IJwtAuthenticationService
    {
        // Metodo para autenticar al usuario y generar un token JWT
        string Authenticate(string userName);
    }
}
