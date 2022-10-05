namespace ApiWeb.src.user.domain
{
    public interface IUserRepository
    {
        /// <summary>
        /// Crea un nuevo usaurio
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        IUser Create(IUser newUser);
        /// <summary>
        /// Busca un usuario por su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IUser Get(string id);
        /// <summary>
        /// Actualiza los datos de un usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IUser Update(string id);
        /// <summary>
        /// Elimina al usuario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IUser Delete(string id);
        /// <summary>
        /// Busca todos los usuarios
        /// </summary>
        /// <returns></returns>
        List<IUser> getAll();



    }
}
