﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.MixedReality.ObjectAnchors.Tests
{
    public class MixedRealityRecordMatcher : RecordMatcher
    {
        private const string ClientCorrelationVectorHeaderName = "X-MRC-CV";
        private const string ContentLengthHeaderName = "Content-Length";

        public MixedRealityRecordMatcher()
            : base(compareBodies: ShouldValidateBodies())
        {
            IgnoredHeaders.Add(ClientCorrelationVectorHeaderName);
            VolatileHeaders.Add(ClientCorrelationVectorHeaderName);
            VolatileResponseHeaders.Add(ClientCorrelationVectorHeaderName);
            if (!ShouldValidateBodies())
            {
                IgnoredHeaders.Add(ContentLengthHeaderName);
                VolatileHeaders.Add(ContentLengthHeaderName);
                VolatileResponseHeaders.Add(ContentLengthHeaderName);
            }
        }

        public static bool ShouldValidateBodies()
        {
#if NETCOREAPP2_1
            return true;
#else
            return false;
#endif
        }
    }
}
