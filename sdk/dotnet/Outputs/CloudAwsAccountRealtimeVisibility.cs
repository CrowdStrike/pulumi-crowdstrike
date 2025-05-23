// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace CrowdStrike.Crowdstrike.Outputs
{

    [OutputType]
    public sealed class CloudAwsAccountRealtimeVisibility
    {
        /// <summary>
        /// The AWS region of the CloudTrail bucket
        /// </summary>
        public readonly string CloudtrailRegion;
        /// <summary>
        /// Enable real-time visibility and detection
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Set to true if a CloudTrail already exists
        /// </summary>
        public readonly bool? UseExistingCloudtrail;

        [OutputConstructor]
        private CloudAwsAccountRealtimeVisibility(
            string cloudtrailRegion,

            bool enabled,

            bool? useExistingCloudtrail)
        {
            CloudtrailRegion = cloudtrailRegion;
            Enabled = enabled;
            UseExistingCloudtrail = useExistingCloudtrail;
        }
    }
}
