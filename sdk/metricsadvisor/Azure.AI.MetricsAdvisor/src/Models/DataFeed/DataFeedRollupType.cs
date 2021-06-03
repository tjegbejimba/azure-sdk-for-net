﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary>
    /// The strategy used by a <see cref="DataFeed"/> when rolling-up the ingested data before
    /// detecting anomalies.
    /// </summary>
    [CodeGenModel("NeedRollupEnum")]
    public readonly partial struct DataFeedRollupType
    {
        /// <summary>
        /// No roll-up will be applied for anomaly detection.
        /// </summary>
        public static DataFeedRollupType NoRollupNeeded { get; } = new DataFeedRollupType(NoRollupValue);

        /// <summary>
        /// Let the service do the roll-up. The method can be set with <see cref="DataFeedRollupSettings.DataFeedAutoRollupMethod"/>.
        /// </summary>
        public static DataFeedRollupType RollupNeeded { get; } = new DataFeedRollupType(NeedRollupValue);

        /// <summary>
        /// The data source already provides rolled-up values, and the service should use them.
        /// <see cref="DataFeedRollupSettings.AlreadyRolledUpIdentificationValue"/> must be set to help the
        /// service identify the rolled-up data.
        /// </summary>
        public static DataFeedRollupType AlreadyRolledUp { get; } = new DataFeedRollupType(AlreadyRollupValue);
    }
}
