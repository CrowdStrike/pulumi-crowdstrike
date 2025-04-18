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

    public sealed class FilevantageRuleGroupRuleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Depth below the base path to monitor.
        /// </summary>
        [Input("depth")]
        public Input<string>? Depth { get; set; }

        /// <summary>
        /// Description of the filevantage rule.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Enable content capture for the rule. Requires watch*file*write*changes or watch*key*value*set_changes to be enabled.
        /// </summary>
        [Input("enableContentCapture")]
        public Input<bool>? EnableContentCapture { get; set; }

        /// <summary>
        /// Represents the files, directories, registry keys, or registry values that will be excluded from monitoring.
        /// </summary>
        [Input("exclude")]
        public Input<string>? Exclude { get; set; }

        /// <summary>
        /// Represents the changes performed by specific processes that will be excluded from monitoring.
        /// </summary>
        [Input("excludeProcesses")]
        public Input<string>? ExcludeProcesses { get; set; }

        /// <summary>
        /// Represents the changes performed by specific users that will be excluded from monitoring.
        /// </summary>
        [Input("excludeUsers")]
        public Input<string>? ExcludeUsers { get; set; }

        [Input("fileNames")]
        private InputList<string>? _fileNames;

        /// <summary>
        /// List of file names whose content will be monitored. Listed files must match the file include pattern and not match the file exclude pattern.
        /// </summary>
        public InputList<string> FileNames
        {
            get => _fileNames ?? (_fileNames = new InputList<string>());
            set => _fileNames = value;
        }

        /// <summary>
        /// Identifier for the filevantage rule.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Represents the files, directories, registry keys, or registry values that will be monitored. Defaults to all (*)
        /// </summary>
        [Input("include")]
        public Input<string>? Include { get; set; }

        /// <summary>
        /// Represents the changes performed by specific processes that will be monitored.
        /// </summary>
        [Input("includeProcesses")]
        public Input<string>? IncludeProcesses { get; set; }

        /// <summary>
        /// Represents the changes performed by specific users that will be monitored.
        /// </summary>
        [Input("includeUsers")]
        public Input<string>? IncludeUsers { get; set; }

        /// <summary>
        /// Representing the file system or registry path to monitor. All paths must end with the path separator, e.g. c:\windows\ for windows and /usr/bin/ for linux/mac.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// Precedence of the rule in the rule group.
        /// </summary>
        [Input("precedence")]
        public Input<int>? Precedence { get; set; }

        [Input("registryValues")]
        private InputList<string>? _registryValues;

        /// <summary>
        /// List of registry values whose content will be monitored. Listed registry values must match the registry include pattern and not match the registry exclude pattern.
        /// </summary>
        public InputList<string> RegistryValues
        {
            get => _registryValues ?? (_registryValues = new InputList<string>());
            set => _registryValues = value;
        }

        /// <summary>
        /// Severity to categorize change events produced by this rule.
        /// </summary>
        [Input("severity", required: true)]
        public Input<string> Severity { get; set; } = null!;

        /// <summary>
        /// Monitor directory attribute change events.
        /// </summary>
        [Input("watchDirectoryAttributeChanges")]
        public Input<bool>? WatchDirectoryAttributeChanges { get; set; }

        /// <summary>
        /// Monitor directory creation events.
        /// </summary>
        [Input("watchDirectoryCreateChanges")]
        public Input<bool>? WatchDirectoryCreateChanges { get; set; }

        /// <summary>
        /// Monitor directory deletion events.
        /// </summary>
        [Input("watchDirectoryDeleteChanges")]
        public Input<bool>? WatchDirectoryDeleteChanges { get; set; }

        /// <summary>
        /// Monitor directory permission change events.
        /// </summary>
        [Input("watchDirectoryPermissionChanges")]
        public Input<bool>? WatchDirectoryPermissionChanges { get; set; }

        /// <summary>
        /// Monitor directory rename events.
        /// </summary>
        [Input("watchDirectoryRenameChanges")]
        public Input<bool>? WatchDirectoryRenameChanges { get; set; }

        /// <summary>
        /// Monitor file attribute change events.
        /// </summary>
        [Input("watchFileAttributeChanges")]
        public Input<bool>? WatchFileAttributeChanges { get; set; }

        /// <summary>
        /// Monitor file creation events.
        /// </summary>
        [Input("watchFileCreateChanges")]
        public Input<bool>? WatchFileCreateChanges { get; set; }

        /// <summary>
        /// Monitor file deletion events.
        /// </summary>
        [Input("watchFileDeleteChanges")]
        public Input<bool>? WatchFileDeleteChanges { get; set; }

        /// <summary>
        /// Monitor file permission change events.
        /// </summary>
        [Input("watchFilePermissionChanges")]
        public Input<bool>? WatchFilePermissionChanges { get; set; }

        /// <summary>
        /// Monitor file rename events.
        /// </summary>
        [Input("watchFileRenameChanges")]
        public Input<bool>? WatchFileRenameChanges { get; set; }

        /// <summary>
        /// Monitor file write events.
        /// </summary>
        [Input("watchFileWriteChanges")]
        public Input<bool>? WatchFileWriteChanges { get; set; }

        /// <summary>
        /// Monitor registry key creation events.
        /// </summary>
        [Input("watchKeyCreateChanges")]
        public Input<bool>? WatchKeyCreateChanges { get; set; }

        /// <summary>
        /// Monitor registry key deletion events.
        /// </summary>
        [Input("watchKeyDeleteChanges")]
        public Input<bool>? WatchKeyDeleteChanges { get; set; }

        /// <summary>
        /// Monitor registry key permission change events.
        /// </summary>
        [Input("watchKeyPermissionsChanges")]
        public Input<bool>? WatchKeyPermissionsChanges { get; set; }

        /// <summary>
        /// Monitor registry key rename events.
        /// </summary>
        [Input("watchKeyRenameChanges")]
        public Input<bool>? WatchKeyRenameChanges { get; set; }

        /// <summary>
        /// Monitor registry value deletion events.
        /// </summary>
        [Input("watchKeyValueDeleteChanges")]
        public Input<bool>? WatchKeyValueDeleteChanges { get; set; }

        /// <summary>
        /// Monitor registry value set events.
        /// </summary>
        [Input("watchKeyValueSetChanges")]
        public Input<bool>? WatchKeyValueSetChanges { get; set; }

        public FilevantageRuleGroupRuleGetArgs()
        {
        }
        public static new FilevantageRuleGroupRuleGetArgs Empty => new FilevantageRuleGroupRuleGetArgs();
    }
}
