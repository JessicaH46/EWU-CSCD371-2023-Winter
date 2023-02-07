using System;
using System.Collections.Generic;

namespace Logger
{
	public readonly struct NameRecords
	{
		public string FirstName { get; }
		public string LastName { get; }
		public string MiddleName { get; }

		/*
		 We want to compare these with value types instead of reference type, due to the possibility that
		 people may share the same name.
		 Another pro to using value type here is that they are initialized to a default value, so we
		 would not have to worry about dealing with FirstName equal to null.
		 We use structs here because they are value types and make the comparisons easier.

		 This is readonly so the type should be immutable, because the properties can't change after
		 they have been set
		*/
		public NameRecords(string FirstNameX, string LastNameX, string? MiddleNameX = null)
        {
            FirstName = FirstNameX ?? throw new ArgumentNullException(nameof(FirstNameX));
            LastName = LastNameX ?? throw new ArgumentNullException(nameof(LastName));
			MiddleName = MiddleNameX ?? throw new ArgumentNullException(nameof(MiddleNameX));

        }
    }
}

