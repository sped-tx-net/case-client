// -----------------------------------------------------------------------
// <copyright file="EqualityComparers.CFSubjectEqualityComparer.cs" company="sped-tx.net">
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
        /// Defines the <see cref="CFSubjectEqualityComparer" />.
        /// </summary>
        private class CFSubjectEqualityComparer : IEqualityComparer<CFSubject>
        {
            /// <summary>
            /// The Equals.
            /// </summary>
            /// <param name="x">The x<see cref="CFSubject"/>.</param>
            /// <param name="y">The y<see cref="CFSubject"/>.</param>
            /// <returns>The <see cref="bool"/>.</returns>
            public bool Equals(CFSubject x, CFSubject y)
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
            /// <param name="obj">The obj<see cref="CFSubject"/>.</param>
            /// <returns>The <see cref="int"/>.</returns>
            public int GetHashCode([DisallowNull] CFSubject obj)
            {
                return obj.Identifier.GetHashCode();
            }
        }
    }
}
