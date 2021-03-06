﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Relay
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An exception that occurs when a Listener gets disconnected from the Azure cloud service.
    /// </summary>
#if SERIALIZATION
    [Serializable]
#endif
    public class ConnectionLostException : RelayException
    {
        /// <summary>
        /// Creates a new instance of the <see cref="ConnectionLostException"/> class.
        /// </summary>
        public ConnectionLostException() { }

        /// <summary>
        /// Creates a new instance of the <see cref="ConnectionLostException"/> class.
        /// </summary>
        public ConnectionLostException(string message) : base(message) { }

        /// <summary>
        /// Creates a new instance of the <see cref="ConnectionLostException"/> class.
        /// </summary>
        public ConnectionLostException(string message, Exception inner) : base(message, inner) { }

#if SERIALIZATION
        /// <summary>
        /// Creates a new instance of the <see cref="ConnectionLostException"/> class.
        /// </summary>
        protected ConnectionLostException(SerializationInfo info, StreamingContext context) : base(info, context) { }
#endif
    }
}
