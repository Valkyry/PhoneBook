using System;

namespace SimplePhoneBook.Domain.Entities
{
    public class Contact : BaseEntity<Guid>
    {
        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// شماره همراه
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// شماره منزل
        /// </summary>
        public string TelephoneNumber { get; set; }
    }
}
