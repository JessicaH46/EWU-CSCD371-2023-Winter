using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger;

[TestClass]
public class StorageTests
{
    private class Entity : IEntity
    {
        public Guid Id { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }

        public string Name => throw new NotImplementedException();
    }
    [TestMethod]
    public void AddTest()
    {
        var storage = new Storage();
        var entity = new Entity { Id = Guid.NewGuid() };

        storage.Add(entity);

        Assert.IsTrue(storage.Contains(entity));
    }

}
