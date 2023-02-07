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
        Guid IEntity.Id { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    }

	public class Books : AbstractEntity
	{
		public Books(Guid? id, string title, string author, string ISBN )
		{
			//
		}
	}
}

