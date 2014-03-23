﻿// CqlSharp - CqlSharp
// Copyright (c) 2014 Joost Reuzel
//   
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
// http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace CqlSharp
{
    /// <summary>
    ///   Represents the error result of a query.
    /// </summary>
    public class CqlError : ICqlQueryResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CqlError"/> class.
        /// </summary>
        /// <param name="exception">The exception.</param>
        internal CqlError(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CqlError"/> class.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="tracingId">The tracing unique identifier.</param>
        internal CqlError(Exception exception, Guid? tracingId)
        {
            Exception = exception;
            TracingId = tracingId;
        }

        /// <summary>
        ///   Gets the exception that has resulted in this CqlError state
        /// </summary>
        public Exception Exception { get; private set; }

        #region ICqlQueryResult Members

        /// <summary>
        ///   Gets the type of the result.
        /// </summary>
        /// <value> The type of the result. </value>
        public CqlResultType ResultType
        {
            get { return CqlResultType.Error; }
        }

        /// <summary>
        ///   Gets the tracing id, if present
        /// </summary>
        /// <value> The tracing id, if present </value>
        public Guid? TracingId { get; private set; }

        #endregion
    }
}