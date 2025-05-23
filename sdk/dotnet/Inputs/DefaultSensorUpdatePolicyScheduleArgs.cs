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

    public sealed class DefaultSensorUpdatePolicyScheduleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable the scheduler for sensor update policy.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("timeBlocks")]
        private InputList<Inputs.DefaultSensorUpdatePolicyScheduleTimeBlockArgs>? _timeBlocks;

        /// <summary>
        /// The time block to prevent sensor updates. Only set when enabled is true.
        /// </summary>
        public InputList<Inputs.DefaultSensorUpdatePolicyScheduleTimeBlockArgs> TimeBlocks
        {
            get => _timeBlocks ?? (_timeBlocks = new InputList<Inputs.DefaultSensorUpdatePolicyScheduleTimeBlockArgs>());
            set => _timeBlocks = value;
        }

        /// <summary>
        /// The time zones that will be used for the time blocks. Only set when enabled is true.
        /// </summary>
        [Input("timezone")]
        public Input<string>? Timezone { get; set; }

        public DefaultSensorUpdatePolicyScheduleArgs()
        {
        }
        public static new DefaultSensorUpdatePolicyScheduleArgs Empty => new DefaultSensorUpdatePolicyScheduleArgs();
    }
}
