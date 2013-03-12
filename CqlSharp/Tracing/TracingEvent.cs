// CqlSharp - CqlSharp
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

using System;
using System.Net;
using CqlSharp.Serialization;

namespace CqlSharp.Tracing
{
    [CqlTable("events", Keyspace = "system_traces")]
    public class TracingEvent
    {
        [CqlColumn("session_id")]
        public Guid SessionId { get; set; }

        [CqlColumn("event_id")]
        public Guid EventId { get; set; }

        [CqlColumn("activity")]
        public string Activity { get; set; }

        [CqlColumn("source")]
        public IPAddress Source { get; set; }

        [CqlColumn("source_elapsed")]
        public int SourceElapsed { get; set; }

        [CqlColumn("thread")]
        public string Thread { get; set; }
    }
}