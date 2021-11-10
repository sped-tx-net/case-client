// -----------------------------------------------------------------------
// <copyright file="ApiException.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Ims.Case.Client
{
    /// <summary>
    /// API Exception.
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        public ApiException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        public ApiException(int errorCode, string message, dynamic errorContent = null) : base(message)
        {
            ErrorCode = errorCode;
            ErrorContent = errorContent;
        }

        /// <summary>
        /// Gets or sets the error code (HTTP status code)...
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Gets the ErrorContent
        /// Gets or sets the error content (body json object)...
        /// </summary>
        public dynamic ErrorContent { get; private set; }
    }
}
