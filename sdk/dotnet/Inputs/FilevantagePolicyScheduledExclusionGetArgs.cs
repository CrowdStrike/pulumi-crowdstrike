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

    public sealed class FilevantagePolicyScheduledExclusionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the scheduled exclusion.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The end date of the scheduled exclusion. Format: YYYY-MM-DD
        /// </summary>
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        /// <summary>
        /// The end time of the scheduled exclusion in 24 hour format. Format: HH:MM
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// Identifier for the scheduled exclusion.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the scheduled exclusion.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// A comma separated list of processes to exclude changes from. Example: **/run*me.sh excludes changes made by run*me.sh in any location
        /// </summary>
        [Input("processes")]
        public Input<string>? Processes { get; set; }

        /// <summary>
        /// Repeated scheduled exclusion
        /// </summary>
        [Input("repeated")]
        public Input<Inputs.FilevantagePolicyScheduledExclusionRepeatedGetArgs>? Repeated { get; set; }

        /// <summary>
        /// The start date of the scheduled exclusion. Format: YYYY-MM-DD
        /// </summary>
        [Input("startDate", required: true)]
        public Input<string> StartDate { get; set; } = null!;

        /// <summary>
        /// The start time of the scheduled exclusion in 24 hour format. Format: HH:MM
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        /// <summary>
        /// The timezone to use for the time fields. See https://en.wikipedia.org/wiki/List*of*tz*database*time_zones.
        /// </summary>
        [Input("timezone", required: true)]
        public Input<string> Timezone { get; set; } = null!;

        /// <summary>
        /// A comma separated list of users to exclude changes from. Example: user1,user2,admin* excludes changes made by user1, user2, and any user starting with admin
        /// </summary>
        [Input("users")]
        public Input<string>? Users { get; set; }

        public FilevantagePolicyScheduledExclusionGetArgs()
        {
        }
        public static new FilevantagePolicyScheduledExclusionGetArgs Empty => new FilevantagePolicyScheduledExclusionGetArgs();
    }
}
