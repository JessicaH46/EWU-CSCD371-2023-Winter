using System;
namespace Logger
{
	public abstract class AbstractEntity : IEntity
	{
		public Guid? Id { get; init; }

		protected AbstractEntity(Guid? id)
		{
			Id = id;
		}

		string IEntity.Name { get; set; }
	}
}

