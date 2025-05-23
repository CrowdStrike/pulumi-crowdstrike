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
    public sealed class FilevantagePolicyScheduledExclusion
    {
        /// <summary>
        /// Description of the scheduled exclusion.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The end date of the scheduled exclusion. Format: YYYY-MM-DD
        /// </summary>
        public readonly string? EndDate;
        /// <summary>
        /// The end time of the scheduled exclusion in 24 hour format. Format: HH:MM
        /// </summary>
        public readonly string? EndTime;
        /// <summary>
        /// Identifier for the scheduled exclusion.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the scheduled exclusion.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A comma separated list of processes to exclude changes from. Example: **/run*me.sh excludes changes made by run*me.sh in any location
        /// </summary>
        public readonly string? Processes;
        /// <summary>
        /// Repeated scheduled exclusion
        /// </summary>
        public readonly Outputs.FilevantagePolicyScheduledExclusionRepeated? Repeated;
        /// <summary>
        /// The start date of the scheduled exclusion. Format: YYYY-MM-DD
        /// </summary>
        public readonly string StartDate;
        /// <summary>
        /// The start time of the scheduled exclusion in 24 hour format. Format: HH:MM
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// The timezone to use for the time fields. See https://en.wikipedia.org/wiki/List*of*tz*database*time_zones.
        /// </summary>
        public readonly string Timezone;
        /// <summary>
        /// A comma separated list of users to exclude changes from. Example: user1,user2,admin* excludes changes made by user1, user2, and any user starting with admin
        /// </summary>
        public readonly string? Users;

        [OutputConstructor]
        private FilevantagePolicyScheduledExclusion(
            string? description,

            string? endDate,

            string? endTime,

            string? id,

            string name,

            string? processes,

            Outputs.FilevantagePolicyScheduledExclusionRepeated? repeated,

            string startDate,

            string startTime,

            string timezone,

            string? users)
        {
            Description = description;
            EndDate = endDate;
            EndTime = endTime;
            Id = id;
            Name = name;
            Processes = processes;
            Repeated = repeated;
            StartDate = startDate;
            StartTime = startTime;
            Timezone = timezone;
            Users = users;
        }
    }
}
