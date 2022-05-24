// <copyright file="Person.cs" company="Farooq Mahmud">
// Copyright (c) Farooq Mahmud. All rights reserved.
// </copyright>

namespace DataAccess.EFCore.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Human beings involved with AdventureWorks: employees, customer contacts, and vendor contacts.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
            this.Customers = new HashSet<Customer>();
            this.EmailAddresses = new HashSet<EmailAddress>();
            this.PersonCreditCards = new HashSet<PersonCreditCard>();
            this.PersonPhones = new HashSet<PersonPhone>();
        }

        /// <summary>
        /// Gets or sets primary key for Person records.
        /// </summary>
        public int BusinessEntityId { get; set; }

        /// <summary>
        /// Gets or sets primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact.
        /// </summary>
        public string PersonType { get; set; } = null!;

        /// <summary>
        /// Gets or sets a value indicating whether 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        /// </summary>
        public bool NameStyle { get; set; }

        /// <summary>
        /// Gets or sets a courtesy title. For example, Mr. or Ms.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets first name of the person.
        /// </summary>
        public string FirstName { get; set; } = null!;

        /// <summary>
        /// Gets or sets middle name or middle initial of the person.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets last name of the person.
        /// </summary>
        public string LastName { get; set; } = null!;

        /// <summary>
        /// Gets or sets surname suffix. For example, Sr. or Jr.
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        /// </summary>
        public int EmailPromotion { get; set; }

        /// <summary>
        /// Gets or sets additional contact information about the person stored in xml format.
        /// </summary>
        public string AdditionalContactInfo { get; set; }

        /// <summary>
        /// Gets or sets personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        /// </summary>
        public string Demographics { get; set; }

        /// <summary>
        /// Gets or sets rOWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Gets or sets date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual BusinessEntity BusinessEntity { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Employee Employee { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual Password Password { get; set; } = null!;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<Customer> Customers { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
