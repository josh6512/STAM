using JWT.Data;
using System.Security.Cryptography;
using System.Text;

namespace JWT.services
{
    public class repository
    {
        private readonly UserContext context;

        public repository(UserContext context)
        {
            this.context = context;
        }

        public void CreatePasswordHash(string password, out byte[]passwordHash,out byte[]passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash=hmac.ComputeHash(Encoding.UTF8.GetBytes(password));    
            }
        }
    }
}
