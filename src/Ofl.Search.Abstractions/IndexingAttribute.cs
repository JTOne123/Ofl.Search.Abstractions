using System;

namespace Ofl.Search
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IndexingAttribute : Attribute
    {
        #region Constructor

        public IndexingAttribute(Indexing indexing)
        {
            // Validate parameters.
            if (indexing != Indexing.None && indexing != Indexing.Analyzed && indexing != Indexing.Searchable)
                throw new ArgumentOutOfRangeException(nameof(indexing), indexing,
                    $"The { nameof(indexing) } parameter had a value not contained in the { typeof(Indexing).FullName } enumeration.");

            // Assign values.
            Indexing = indexing;
        }

        #endregion

        #region Instance, read-only state.

        public Indexing Indexing { get; }

        #endregion
    }
}
