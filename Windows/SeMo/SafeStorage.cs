using System;

namespace SeMo
{
    public class SafeStorage
    {
        /// <summary>
        /// Unique key to ensure secrecy of the safe storage of password
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// Safe storage of the used password, encrypted with rsa private key or a symmetric key maybe?
        /// </summary>
        public string Safe { get; set; }
    }
}