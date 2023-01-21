using System;

namespace SimplePhoneBook.Domain.Entities
{
    public class BaseEntity<TStruct> where TStruct : struct
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public TStruct ID { get; set; }
        /// <summary>
        /// زمان ساخت
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// زمان اخرین تغییر
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
    }
}
