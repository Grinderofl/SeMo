using System;

namespace SeMo
{
    public class SafeStorage
    {
        /// <summary>
        /// Guid to ensure secrecy of the safe storage of password
        /// </summary>
        public Guid Guid { get; set; }

        /// <summary>
        /// Safe storage of the used password, encrypted with rsa private key or a symmetric key maybe?
        /// </summary>
        public string Safe { get; set; }
    }
}