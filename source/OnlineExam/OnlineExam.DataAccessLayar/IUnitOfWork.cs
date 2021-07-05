using System;

namespace OnlineExam.DataAccessLayar
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
