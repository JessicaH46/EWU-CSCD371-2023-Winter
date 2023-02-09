using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Logger
{
    public readonly record struct NameRecords(string firstName, string lastName, string? middleName = null)
	{
		public string FirstName { get;} = firstName ?? throw new ArgumentNullException(nameof(firstName));
		public string LastName { get; } = lastName ?? throw new ArgumentNullException(nameof(lastName));
		public string? MiddleName { get; } = middleName;

		public override string ToString()
		{
			if(middleName == null)
			{
				return firstName + " " + lastName;

            }
			else
			{
                return firstName + " " + middleName + " " + lastName;
            }
		}

		/*
		 We want to compare these with value types instead of reference type, due to the possibility that
		 people may share the same name.
		 Another pro to using value type here is that they are initialized to a default value, so we
		 would not have to worry about dealing with FirstName equal to null.
		 We use structs here because they are value types and make the comparisons easier.

		 This is readonly so the type should be immutable, because the properties can't change after
		 they have been set
		*/
    }
}

