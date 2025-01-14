// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Provider specific input for InMage unplanned failover. </summary>
    public partial class InMageUnplannedFailoverInput : UnplannedFailoverProviderSpecificInput
    {
        /// <summary> Initializes a new instance of InMageUnplannedFailoverInput. </summary>
        public InMageUnplannedFailoverInput()
        {
            InstanceType = "InMage";
        }

        /// <summary> The recovery point type. Values from LatestTime, LatestTag or Custom. In the case of custom, the recovery point provided by RecoveryPointId will be used. In the other two cases, recovery point id will be ignored. </summary>
        public RecoveryPointType? RecoveryPointType { get; set; }
        /// <summary> The recovery point id to be passed to failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public string RecoveryPointId { get; set; }
    }
}
