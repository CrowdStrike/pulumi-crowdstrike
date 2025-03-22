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

    public sealed class DefaultSensorUpdatePolicyScheduleTimeBlockGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("days", required: true)]
        private InputList<string>? _days;

        /// <summary>
        /// The days of the week the time block should be active.
        /// </summary>
        public InputList<string> Days
        {
            get => _days ?? (_days = new InputList<string>());
            set => _days = value;
        }

        /// <summary>
        /// The end time for the time block in 24HR format. Must be atleast 1 hour more than start_time.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        /// <summary>
        /// The start time for the time block in 24HR format. Must be atleast 1 hour before end_time.
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public DefaultSensorUpdatePolicyScheduleTimeBlockGetArgs()
        {
        }
        public static new DefaultSensorUpdatePolicyScheduleTimeBlockGetArgs Empty => new DefaultSensorUpdatePolicyScheduleTimeBlockGetArgs();
    }
}
