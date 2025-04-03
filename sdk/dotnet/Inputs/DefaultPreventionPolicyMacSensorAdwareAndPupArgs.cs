// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace CrowdStrike.Crowdstrike.Inputs
{

    public sealed class DefaultPreventionPolicyMacSensorAdwareAndPupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Machine learning level for detection.
        /// </summary>
        [Input("detection", required: true)]
        public Input<string> Detection { get; set; } = null!;

        /// <summary>
        /// Machine learning level for prevention.
        /// </summary>
        [Input("prevention", required: true)]
        public Input<string> Prevention { get; set; } = null!;

        public DefaultPreventionPolicyMacSensorAdwareAndPupArgs()
        {
        }
        public static new DefaultPreventionPolicyMacSensorAdwareAndPupArgs Empty => new DefaultPreventionPolicyMacSensorAdwareAndPupArgs();
    }
}
