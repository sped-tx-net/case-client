// -----------------------------------------------------------------------
// <copyright file="EqualityComparers.CFItemTypeEqualityComparer.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Ims.Case.Model;

namespace Ims.Case.Client
{
    /// <summary>
    /// Defines the <see cref="EqualityComparers" />.
    /// </summary>
    public static partial class EqualityComparers
    {
        /// <summary>
        /// Defines the <see cref="CFItemTypeEqualityComparer" />.
        /// </summary>
        private class CFItemTypeEqualityComparer : IEqualityComparer<CFItemType>
        {
            /// <summary>
            /// The Equals.
            /// </summary>
            /// <param name="x">The x<see cref="CFItemType"/>.</param>
            /// <param name="y">The y<see cref="CFItemType"/>.</param>
            /// <returns>The <see cref="bool"/>.</returns>
            public bool Equals(CFItemType x, CFItemType y)
            {
                if (y == null && x == null)
                    return true;
                else if (x == null || y == null)
                    return false;
                else if (x.Title == y.Title)
                    return true;
                else
                    return false;
            }

            /// <summary>
            /// The GetHashCode.
            /// </summary>
            /// <param name="obj">The obj<see cref="CFItemType"/>.</param>
            /// <returns>The <see cref="int"/>.</returns>
            public int GetHashCode([DisallowNull] CFItemType obj)
            {
                return obj.Identifier.GetHashCode();
            }
        }
    }
}
