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

    [TestMethod]
    public void RemoveTest()
    {
        var storage = new Storage();
        var entity = new Entity { Id = Guid.NewGuid() };

        storage.Remove(entity);

        Assert.IsFalse(storage.Contains(entity));

    }

    [TestMethod]
    public void GetTest()
    {
        var storage = new Storage();
        var entity = new Entity { Id = Guid.NewGuid() };

        storage.Add(entity);

        var res = storage.Get(entity.Id);

        Assert.AreEqual(entity, res);

    }

    [TestMethod]
    public void GetTestWhenItIsNull()
    {
        var storage = new Storage();
        var entity = new Entity { Id = Guid.NewGuid() };

        storage.Add(entity);

        var res = storage.Get(Guid.NewGuid());

        Assert.IsNull(res);

    }

}
