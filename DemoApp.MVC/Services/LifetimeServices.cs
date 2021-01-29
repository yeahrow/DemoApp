using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.MVC.Services
{
    public interface ISingletonService
    {
        Guid ServiceId { get; set; }
    }

    public interface IScopedService
    {
        Guid ServiceId { get; set; }
    }

    public interface ITransientService
    {
        Guid ServiceId { get; set; }
    }

    public class SingletonService : ISingletonService
    {
        public Guid ServiceId { get; set; }

        public SingletonService()
        {
            ServiceId = Guid.NewGuid();
        }
    }

    public class ScopedService : IScopedService
    {
        public Guid ServiceId { get; set; }

        public ScopedService()
        {
            ServiceId = Guid.NewGuid();
        }
    }

    public class TransientService : ITransientService
    {
        public Guid ServiceId { get; set; }

        public TransientService()
        {
            ServiceId = Guid.NewGuid();
        }
    }
}
