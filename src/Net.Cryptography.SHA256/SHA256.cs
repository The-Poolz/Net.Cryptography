using System.Text;

namespace Net.Cryptography.SHA256
{
    /// <summary>
    /// Provides a method for computing SHA256 hash of a string.
    /// </summary>
    public static class SHA256
    {
        /// <summary>
        /// Computes the SHA256 hash of the specified string.
        /// </summary>
        /// <param name="str">The input string to compute the hash for.</param>
        /// <remarks>
        /// This method computes the SHA256 hash for the given string using <see cref="System.Security.Cryptography.SHA256"/>.
        /// The hash is computed on the UTF-8 representation of the input string.
        /// </remarks>
        /// <returns>A hexadecimal string representing the SHA256 hash of the input string.</returns>
        public static string ToSha256(this string str)
        {
            using var sha256Hash = System.Security.Cryptography.SHA256.Create();
            var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str));

            var builder = new StringBuilder();
            foreach (var t in bytes)
            {
                builder.Append(t.ToString("x2"));
            }
            return builder.ToString();
        }
    }
}