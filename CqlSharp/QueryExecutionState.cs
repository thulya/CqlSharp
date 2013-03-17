﻿// CqlSharp - CqlSharp
// Copyright (c) 2013 Joost Reuzel
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


namespace CqlSharp
{
    /// <summary>
    ///   Structure to capture state to use for executing the query
    /// </summary>
    internal struct QueryExecutionState
    {
        public bool UseBuffering;

        public bool TracingEnabled;

        public bool UseParallelConnections;

        public byte[][] Values;

        public byte[] PartitionKey;
    }
}