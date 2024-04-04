using EbenezerConnect.Data;
using EbenezerConnect.Data.Entidades;

namespace EbenezerConnect.Services
{
    public class UserService
    {

        public void CreateUser(string username,String type)
        {
            var context = new Connection();
            var user = new Eb_User
            {
                UserName = username,
                UserType = type
            };
            try
            {
                context.Eb_User.Add(user);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao adicionar o novo usuário: {ex.Message}");
            }
        }

        public List<Eb_User> GetUsers()
        {
            var context = new Connection();
            return context.Eb_User.ToList();
        }

        public Eb_User GetUserById(int id)
        {
            var context = new Connection();
            return context.Eb_User.Find(id);
        }

        public bool UpdateUser(int id, string username, string type)
        {
            var context = new Connection();
            var user = context.Eb_User.Find(id);
            if (user == null)
            {
                return false; // Retorna falso se o usuário não for encontrado
            }

            user.UserName = username;
            user.UserType = type;
            context.SaveChanges();
            return true; // Retorna verdadeiro se o usuário for atualizado com sucesso
        }


        public bool DeleteUser(int id)
        {
            var context = new Connection();
            var user = context.Eb_User.Find(id);
            if (user == null)
            {
                return false; // Retorna falso se o usuário não for encontrado
            }

            context.Eb_User.Remove(user);
            context.SaveChanges();
            return true; // Retorna verdadeiro se o usuário for excluído com sucesso
        }
    }
}
