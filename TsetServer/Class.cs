
using Moq;
using NUnit.Framework;
using Server;
using Server.Models;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
namespace TsetServer
{


    public static class DbSetExtensions
    {
        public static DbSet<T> ToDbSet<T>(this List<T> list) where T : class
        {
            IQueryable<T> queryableList = list.AsQueryable();

            DbSet<T> dbSet = new FakeDbSet<T>(queryableList);
            return dbSet;

        }
    }

    public class FakeDbSet<T> : DbSet<T>, IQueryable, IEnumerable<T>, IAsyncEnumerable<T> where T : class
    {
        private readonly IQueryable _queryable;

        public FakeDbSet(IQueryable queryable)
        {
            _queryable = queryable;
        }

        public IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }

}
