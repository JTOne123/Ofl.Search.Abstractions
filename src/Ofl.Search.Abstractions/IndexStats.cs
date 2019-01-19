using System;

namespace Ofl.Search
{
    public abstract class IndexStats
    {
        #region Constructor

        protected IndexStats(long documents, long sizeInBytes)
        {
            // Validate parameters.
            if (documents < 0) throw new ArgumentOutOfRangeException(nameof(documents), documents,
                $"The {nameof(documents)} parameter must be a non-negative value.");
            if (sizeInBytes < 0) throw new ArgumentOutOfRangeException(nameof(sizeInBytes), sizeInBytes,
                $"The {nameof(sizeInBytes)} parameter must be a non-negative value.");

            // Assign values.
            Documents = documents;
            SizeInBytes = sizeInBytes;
        }

        #endregion

        #region Instance, read-only state

        public long Documents { get; }

        public long SizeInBytes { get; }

        #endregion
    }
}
