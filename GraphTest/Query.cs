using GraphTest.Types;

namespace GraphTest
{
    public class Query
    {
        public Query() { }

        public IEnumerable<User> GetAllUsers()
        {
            return _database.Uses;
        }
    }
}
