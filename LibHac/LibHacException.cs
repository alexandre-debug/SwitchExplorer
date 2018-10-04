﻿using System;
using System.Runtime.Serialization;

namespace LibHac
{
    /// <summary>
    /// This is the exception that is thrown when an error occurs 
    /// </summary>
    [Serializable]
    public class LibHacException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibHacException"/> class. 
        /// </summary>
        public LibHacException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibHacException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public LibHacException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///  Initializes a new instance of the <see cref="LibHacException"/> class with a specified error message
        ///  and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public LibHacException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibHacException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/>  that contains contextual information about the source or destination.</param>
        protected LibHacException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
