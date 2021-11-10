// -----------------------------------------------------------------------
// <copyright file="EqualityComparers.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using Ims.Case.Model;

namespace Ims.Case.Client
{
    /// <summary>
    /// Defines the <see cref="EqualityComparers" />.
    /// </summary>
    public static partial class EqualityComparers
    {
        /// <summary>
        /// Gets the CFItemType.
        /// </summary>
        public static IEqualityComparer<CFItemType> CFItemType { get; } = new CFItemTypeEqualityComparer();

        /// <summary>
        /// Gets the CFSubject.
        /// </summary>
        public static IEqualityComparer<CFSubject> CFSubject { get; } = new CFSubjectEqualityComparer();
    }
}
