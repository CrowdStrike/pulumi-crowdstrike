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
    public sealed class GetSensorUpdatePolicyBuildsLinuxArm64N1Result
    {
        /// <summary>
        /// The build number for a specific sensor version.
        /// </summary>
        public readonly string Build;
        /// <summary>
        /// The target platform for a the build.
        /// </summary>
        public readonly string Platform;
        /// <summary>
        /// CrowdStrike Falcon Sensor version.
        /// </summary>
        public readonly string SensorVersion;
        /// <summary>
        /// The stage for the build.
        /// </summary>
        public readonly string Stage;

        [OutputConstructor]
        private GetSensorUpdatePolicyBuildsLinuxArm64N1Result(
            string build,

            string platform,

            string sensorVersion,

            string stage)
        {
            Build = build;
            Platform = platform;
            SensorVersion = sensorVersion;
            Stage = stage;
        }
    }
}
