using System.Security.Cryptography;
using System.Text;

namespace Optimus.Domain.Entities.Users;

internal class Hash
{
    public static string Generate(string value)
    {
        var hash = SHA1.Create();
        var enconding = new ASCIIEncoding();
        var array = enconding.GetBytes(value);

        array = hash.ComputeHash(array);

        var result = new StringBuilder();

        foreach (var item in array)
        {
            result.Append(item.ToString("x2"));
        }

        return result.ToString();
    }
}
