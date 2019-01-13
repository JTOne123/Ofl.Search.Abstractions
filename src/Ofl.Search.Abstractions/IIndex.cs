﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Search
{
    public interface IIndex : IDisposable
    {
        string Name { get; }

        Task<bool> ExistsAsync(CancellationToken cancellationToken);

        Task CreateAsync(CancellationToken cancellationToken);

        Task DestroyAsync(CancellationToken cancellationToken);
    }
}
