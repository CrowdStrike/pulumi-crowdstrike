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
    public sealed class FilevantageRuleGroupRule
    {
        /// <summary>
        /// Depth below the base path to monitor.
        /// </summary>
        public readonly string? Depth;
        /// <summary>
        /// Description of the filevantage rule.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Enable content capture for the rule. Requires watch*file*write*changes or watch*key*value*set_changes to be enabled.
        /// </summary>
        public readonly bool? EnableContentCapture;
        /// <summary>
        /// Represents the files, directories, registry keys, or registry values that will be excluded from monitoring.
        /// </summary>
        public readonly string? Exclude;
        /// <summary>
        /// Represents the changes performed by specific processes that will be excluded from monitoring.
        /// </summary>
        public readonly string? ExcludeProcesses;
        /// <summary>
        /// Represents the changes performed by specific users that will be excluded from monitoring.
        /// </summary>
        public readonly string? ExcludeUsers;
        /// <summary>
        /// List of file names whose content will be monitored. Listed files must match the file include pattern and not match the file exclude pattern.
        /// </summary>
        public readonly ImmutableArray<string> FileNames;
        /// <summary>
        /// Identifier for the filevantage rule.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Represents the files, directories, registry keys, or registry values that will be monitored. Defaults to all (*)
        /// </summary>
        public readonly string? Include;
        /// <summary>
        /// Represents the changes performed by specific processes that will be monitored.
        /// </summary>
        public readonly string? IncludeProcesses;
        /// <summary>
        /// Represents the changes performed by specific users that will be monitored.
        /// </summary>
        public readonly string? IncludeUsers;
        /// <summary>
        /// Representing the file system or registry path to monitor. All paths must end with the path separator, e.g. c:\windows\ for windows and /usr/bin/ for linux/mac.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// Precedence of the rule in the rule group.
        /// </summary>
        public readonly int? Precedence;
        /// <summary>
        /// List of registry values whose content will be monitored. Listed registry values must match the registry include pattern and not match the registry exclude pattern.
        /// </summary>
        public readonly ImmutableArray<string> RegistryValues;
        /// <summary>
        /// Severity to categorize change events produced by this rule.
        /// </summary>
        public readonly string Severity;
        /// <summary>
        /// Monitor directory attribute change events.
        /// </summary>
        public readonly bool? WatchDirectoryAttributeChanges;
        /// <summary>
        /// Monitor directory creation events.
        /// </summary>
        public readonly bool? WatchDirectoryCreateChanges;
        /// <summary>
        /// Monitor directory deletion events.
        /// </summary>
        public readonly bool? WatchDirectoryDeleteChanges;
        /// <summary>
        /// Monitor directory permission change events.
        /// </summary>
        public readonly bool? WatchDirectoryPermissionChanges;
        /// <summary>
        /// Monitor directory rename events.
        /// </summary>
        public readonly bool? WatchDirectoryRenameChanges;
        /// <summary>
        /// Monitor file attribute change events.
        /// </summary>
        public readonly bool? WatchFileAttributeChanges;
        /// <summary>
        /// Monitor file creation events.
        /// </summary>
        public readonly bool? WatchFileCreateChanges;
        /// <summary>
        /// Monitor file deletion events.
        /// </summary>
        public readonly bool? WatchFileDeleteChanges;
        /// <summary>
        /// Monitor file permission change events.
        /// </summary>
        public readonly bool? WatchFilePermissionChanges;
        /// <summary>
        /// Monitor file rename events.
        /// </summary>
        public readonly bool? WatchFileRenameChanges;
        /// <summary>
        /// Monitor file write events.
        /// </summary>
        public readonly bool? WatchFileWriteChanges;
        /// <summary>
        /// Monitor registry key creation events.
        /// </summary>
        public readonly bool? WatchKeyCreateChanges;
        /// <summary>
        /// Monitor registry key deletion events.
        /// </summary>
        public readonly bool? WatchKeyDeleteChanges;
        /// <summary>
        /// Monitor registry key permission change events.
        /// </summary>
        public readonly bool? WatchKeyPermissionsChanges;
        /// <summary>
        /// Monitor registry key rename events.
        /// </summary>
        public readonly bool? WatchKeyRenameChanges;
        /// <summary>
        /// Monitor registry value deletion events.
        /// </summary>
        public readonly bool? WatchKeyValueDeleteChanges;
        /// <summary>
        /// Monitor registry value set events.
        /// </summary>
        public readonly bool? WatchKeyValueSetChanges;

        [OutputConstructor]
        private FilevantageRuleGroupRule(
            string? depth,

            string description,

            bool? enableContentCapture,

            string? exclude,

            string? excludeProcesses,

            string? excludeUsers,

            ImmutableArray<string> fileNames,

            string? id,

            string? include,

            string? includeProcesses,

            string? includeUsers,

            string path,

            int? precedence,

            ImmutableArray<string> registryValues,

            string severity,

            bool? watchDirectoryAttributeChanges,

            bool? watchDirectoryCreateChanges,

            bool? watchDirectoryDeleteChanges,

            bool? watchDirectoryPermissionChanges,

            bool? watchDirectoryRenameChanges,

            bool? watchFileAttributeChanges,

            bool? watchFileCreateChanges,

            bool? watchFileDeleteChanges,

            bool? watchFilePermissionChanges,

            bool? watchFileRenameChanges,

            bool? watchFileWriteChanges,

            bool? watchKeyCreateChanges,

            bool? watchKeyDeleteChanges,

            bool? watchKeyPermissionsChanges,

            bool? watchKeyRenameChanges,

            bool? watchKeyValueDeleteChanges,

            bool? watchKeyValueSetChanges)
        {
            Depth = depth;
            Description = description;
            EnableContentCapture = enableContentCapture;
            Exclude = exclude;
            ExcludeProcesses = excludeProcesses;
            ExcludeUsers = excludeUsers;
            FileNames = fileNames;
            Id = id;
            Include = include;
            IncludeProcesses = includeProcesses;
            IncludeUsers = includeUsers;
            Path = path;
            Precedence = precedence;
            RegistryValues = registryValues;
            Severity = severity;
            WatchDirectoryAttributeChanges = watchDirectoryAttributeChanges;
            WatchDirectoryCreateChanges = watchDirectoryCreateChanges;
            WatchDirectoryDeleteChanges = watchDirectoryDeleteChanges;
            WatchDirectoryPermissionChanges = watchDirectoryPermissionChanges;
            WatchDirectoryRenameChanges = watchDirectoryRenameChanges;
            WatchFileAttributeChanges = watchFileAttributeChanges;
            WatchFileCreateChanges = watchFileCreateChanges;
            WatchFileDeleteChanges = watchFileDeleteChanges;
            WatchFilePermissionChanges = watchFilePermissionChanges;
            WatchFileRenameChanges = watchFileRenameChanges;
            WatchFileWriteChanges = watchFileWriteChanges;
            WatchKeyCreateChanges = watchKeyCreateChanges;
            WatchKeyDeleteChanges = watchKeyDeleteChanges;
            WatchKeyPermissionsChanges = watchKeyPermissionsChanges;
            WatchKeyRenameChanges = watchKeyRenameChanges;
            WatchKeyValueDeleteChanges = watchKeyValueDeleteChanges;
            WatchKeyValueSetChanges = watchKeyValueSetChanges;
        }
    }
}
