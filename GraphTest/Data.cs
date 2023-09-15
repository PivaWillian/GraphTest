using GraphTest.Types;

namespace GraphTest
{
    public class Data
    {
        public ICollection<User> Users { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Data() 
        {
            Users = new List<User>() 
            {
                new User()
                {
                    UserName = "Test",
                    Email = "something@something.com",
                }
            };

            Posts = new List<Post>()
            {
                new Post()
                {
                    Content = "Achei engraçado."
                }
            };
        }
        //criar dados para uso nas requisições
/*Especificações:
User: Um usuário deve ter um id, username, email, listas de followers, posts e comments.
Post: Um post deve ter um id, content, e uma referência ao author que é um usuário. Além disso, ele deve conter uma lista de comments.
Comment: Um comentário deve ter um id, content, e uma referência ao author que é um usuário.
Você deve:
Criar tipos (type) para User, Post, e Comment.
Estabelecer as relações entre esses tipos.
Adicionar consultas para buscar um usuário por id, uma lista de posts, e uma lista de comentários de um post específico.*/
}
}
