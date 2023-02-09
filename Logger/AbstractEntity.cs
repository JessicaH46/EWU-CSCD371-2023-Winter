using System;
namespace Logger
{
	public abstract record class AbstractEntity() : IEntity
	{
		public Guid? Id { get; init; }
        public abstract string Name { get; }
        Guid IEntity.Id { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    }
}

