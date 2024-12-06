// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace CrowdStrike.Crowdstrike
{
    /// <summary>
    /// This resource allows you to manage CrowdStrike Falcon prevention policies for Linux hosts. Prevention policies allow you to manage what activity will trigger detections and preventions on your hosts.
    /// 
    /// ## API Scopes
    /// 
    /// The following API scopes are required:
    /// 
    /// - Prevention policies | Read &amp; Write
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Crowdstrike = CrowdStrike.Crowdstrike;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Crowdstrike.PreventionPolicyLinux("example", new()
    ///     {
    ///         Enabled = true,
    ///         Description = "Made with Pulumi",
    ///         HostGroups = new[]
    ///         {
    ///             "d6e3c1e1b3d0467da0fowc96a5e6ecb5",
    ///         },
    ///         IoaRuleGroups = new[] {},
    ///         CloudAntiMalware = new Crowdstrike.Inputs.PreventionPolicyLinuxCloudAntiMalwareArgs
    ///         {
    ///             Detection = "MODERATE",
    ///             Prevention = "CAUTIOUS",
    ///         },
    ///         SensorAntiMalware = new Crowdstrike.Inputs.PreventionPolicyLinuxSensorAntiMalwareArgs
    ///         {
    ///             Detection = "MODERATE",
    ///             Prevention = "CAUTIOUS",
    ///         },
    ///         Quarantine = true,
    ///         CustomBlocking = true,
    ///         PreventSuspiciousProcesses = true,
    ///         ScriptBasedExecutionMonitoring = true,
    ///         UploadUnknownExecutables = true,
    ///         UploadUnknownDetectionRelatedExecutables = true,
    ///         DriftPrevention = true,
    ///         EmailProtocolVisibility = true,
    ///         FilesystemVisibility = true,
    ///         FtpVisibility = true,
    ///         HttpVisibility = true,
    ///         NetworkVisibility = true,
    ///         TlsVisibility = true,
    ///     });
    /// 
    ///     return new Dictionary&lt;string, object?&gt;
    ///     {
    ///         ["preventionPolicyLinux"] = example,
    ///     };
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// prevention policy can be imported by specifying the policy id.
    /// 
    /// ```sh
    /// $ pulumi import crowdstrike:index/preventionPolicyLinux:PreventionPolicyLinux example 7fb858a949034a0cbca175f660f1e769
    /// ```
    /// </summary>
    [CrowdstrikeResourceType("crowdstrike:index/preventionPolicyLinux:PreventionPolicyLinux")]
    public partial class PreventionPolicyLinux : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Use cloud-based machine learning informed by global analysis of executables to detect and prevent known malware for your online hosts.
        /// </summary>
        [Output("cloudAntiMalware")]
        public Output<Outputs.PreventionPolicyLinuxCloudAntiMalware> CloudAntiMalware { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Block processes matching hashes that you add to IOC Management with the action set to "Block" or "Block, hide detection".
        /// </summary>
        [Output("customBlocking")]
        public Output<bool> CustomBlocking { get; private set; } = null!;

        /// <summary>
        /// Description of the prevention policy.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Block new processes originating from files written in a container. This prevents a container from drifting from its immutable runtime state.
        /// </summary>
        [Output("driftPrevention")]
        public Output<bool> DriftPrevention { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor SMTP, IMAP, and POP3 traffic for malicious patterns and improved detections.
        /// </summary>
        [Output("emailProtocolVisibility")]
        public Output<bool> EmailProtocolVisibility { get; private set; } = null!;

        /// <summary>
        /// Enable the prevention policy.
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor filesystem activity for additional telemetry and improved detections.
        /// </summary>
        [Output("filesystemVisibility")]
        public Output<bool> FilesystemVisibility { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor unencrypted FTP traffic for malicious patterns and improved detections.
        /// </summary>
        [Output("ftpVisibility")]
        public Output<bool> FtpVisibility { get; private set; } = null!;

        /// <summary>
        /// Host Group ids to attach to the prevention policy.
        /// </summary>
        [Output("hostGroups")]
        public Output<ImmutableArray<string>> HostGroups { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor unencrypted HTTP traffic for malicious patterns and improved detections.
        /// </summary>
        [Output("httpVisibility")]
        public Output<bool> HttpVisibility { get; private set; } = null!;

        /// <summary>
        /// IOA Rule Group to attach to the prevention policy.
        /// </summary>
        [Output("ioaRuleGroups")]
        public Output<ImmutableArray<string>> IoaRuleGroups { get; private set; } = null!;

        [Output("lastUpdated")]
        public Output<string> LastUpdated { get; private set; } = null!;

        /// <summary>
        /// Name of the prevention policy.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor network activity for additional telemetry and improved detections.
        /// </summary>
        [Output("networkVisibility")]
        public Output<bool> NetworkVisibility { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Block processes that CrowdStrike analysts classify as suspicious. These are focused on dynamic IOAs, such as malware, exploits and other threats.
        /// </summary>
        [Output("preventSuspiciousProcesses")]
        public Output<bool> PreventSuspiciousProcesses { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Quarantine executable files after they’re prevented by NGAV. When this is enabled, we recommend setting anti-malware prevention levels to Moderate or higher and not using other antivirus solutions.
        /// </summary>
        [Output("quarantine")]
        public Output<bool> Quarantine { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Provides visibility into suspicious scripts, including shell and other scripting languages.
        /// </summary>
        [Output("scriptBasedExecutionMonitoring")]
        public Output<bool> ScriptBasedExecutionMonitoring { get; private set; } = null!;

        /// <summary>
        /// For offline and online hosts, use sensor-based machine learning to identify and analyze unknown executables as they run to detect and prevent malware.
        /// </summary>
        [Output("sensorAntiMalware")]
        public Output<Outputs.PreventionPolicyLinuxSensorAntiMalware> SensorAntiMalware { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor TLS traffic for malicious patterns and improved detections.
        /// </summary>
        [Output("tlsVisibility")]
        public Output<bool> TlsVisibility { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Upload all unknown detection-related executables for advanced analysis in the cloud.
        /// </summary>
        [Output("uploadUnknownDetectionRelatedExecutables")]
        public Output<bool> UploadUnknownDetectionRelatedExecutables { get; private set; } = null!;

        /// <summary>
        /// Whether to enable the setting. Upload all unknown executables for advanced analysis in the cloud.
        /// </summary>
        [Output("uploadUnknownExecutables")]
        public Output<bool> UploadUnknownExecutables { get; private set; } = null!;


        /// <summary>
        /// Create a PreventionPolicyLinux resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PreventionPolicyLinux(string name, PreventionPolicyLinuxArgs args, CustomResourceOptions? options = null)
            : base("crowdstrike:index/preventionPolicyLinux:PreventionPolicyLinux", name, args ?? new PreventionPolicyLinuxArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PreventionPolicyLinux(string name, Input<string> id, PreventionPolicyLinuxState? state = null, CustomResourceOptions? options = null)
            : base("crowdstrike:index/preventionPolicyLinux:PreventionPolicyLinux", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/crowdstrike/pulumi-crowdstrike",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PreventionPolicyLinux resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PreventionPolicyLinux Get(string name, Input<string> id, PreventionPolicyLinuxState? state = null, CustomResourceOptions? options = null)
        {
            return new PreventionPolicyLinux(name, id, state, options);
        }
    }

    public sealed class PreventionPolicyLinuxArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Use cloud-based machine learning informed by global analysis of executables to detect and prevent known malware for your online hosts.
        /// </summary>
        [Input("cloudAntiMalware")]
        public Input<Inputs.PreventionPolicyLinuxCloudAntiMalwareArgs>? CloudAntiMalware { get; set; }

        /// <summary>
        /// Whether to enable the setting. Block processes matching hashes that you add to IOC Management with the action set to "Block" or "Block, hide detection".
        /// </summary>
        [Input("customBlocking")]
        public Input<bool>? CustomBlocking { get; set; }

        /// <summary>
        /// Description of the prevention policy.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to enable the setting. Block new processes originating from files written in a container. This prevents a container from drifting from its immutable runtime state.
        /// </summary>
        [Input("driftPrevention")]
        public Input<bool>? DriftPrevention { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor SMTP, IMAP, and POP3 traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("emailProtocolVisibility")]
        public Input<bool>? EmailProtocolVisibility { get; set; }

        /// <summary>
        /// Enable the prevention policy.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor filesystem activity for additional telemetry and improved detections.
        /// </summary>
        [Input("filesystemVisibility")]
        public Input<bool>? FilesystemVisibility { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor unencrypted FTP traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("ftpVisibility")]
        public Input<bool>? FtpVisibility { get; set; }

        [Input("hostGroups", required: true)]
        private InputList<string>? _hostGroups;

        /// <summary>
        /// Host Group ids to attach to the prevention policy.
        /// </summary>
        public InputList<string> HostGroups
        {
            get => _hostGroups ?? (_hostGroups = new InputList<string>());
            set => _hostGroups = value;
        }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor unencrypted HTTP traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("httpVisibility")]
        public Input<bool>? HttpVisibility { get; set; }

        [Input("ioaRuleGroups", required: true)]
        private InputList<string>? _ioaRuleGroups;

        /// <summary>
        /// IOA Rule Group to attach to the prevention policy.
        /// </summary>
        public InputList<string> IoaRuleGroups
        {
            get => _ioaRuleGroups ?? (_ioaRuleGroups = new InputList<string>());
            set => _ioaRuleGroups = value;
        }

        /// <summary>
        /// Name of the prevention policy.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor network activity for additional telemetry and improved detections.
        /// </summary>
        [Input("networkVisibility")]
        public Input<bool>? NetworkVisibility { get; set; }

        /// <summary>
        /// Whether to enable the setting. Block processes that CrowdStrike analysts classify as suspicious. These are focused on dynamic IOAs, such as malware, exploits and other threats.
        /// </summary>
        [Input("preventSuspiciousProcesses")]
        public Input<bool>? PreventSuspiciousProcesses { get; set; }

        /// <summary>
        /// Whether to enable the setting. Quarantine executable files after they’re prevented by NGAV. When this is enabled, we recommend setting anti-malware prevention levels to Moderate or higher and not using other antivirus solutions.
        /// </summary>
        [Input("quarantine")]
        public Input<bool>? Quarantine { get; set; }

        /// <summary>
        /// Whether to enable the setting. Provides visibility into suspicious scripts, including shell and other scripting languages.
        /// </summary>
        [Input("scriptBasedExecutionMonitoring")]
        public Input<bool>? ScriptBasedExecutionMonitoring { get; set; }

        /// <summary>
        /// For offline and online hosts, use sensor-based machine learning to identify and analyze unknown executables as they run to detect and prevent malware.
        /// </summary>
        [Input("sensorAntiMalware")]
        public Input<Inputs.PreventionPolicyLinuxSensorAntiMalwareArgs>? SensorAntiMalware { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor TLS traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("tlsVisibility")]
        public Input<bool>? TlsVisibility { get; set; }

        /// <summary>
        /// Whether to enable the setting. Upload all unknown detection-related executables for advanced analysis in the cloud.
        /// </summary>
        [Input("uploadUnknownDetectionRelatedExecutables")]
        public Input<bool>? UploadUnknownDetectionRelatedExecutables { get; set; }

        /// <summary>
        /// Whether to enable the setting. Upload all unknown executables for advanced analysis in the cloud.
        /// </summary>
        [Input("uploadUnknownExecutables")]
        public Input<bool>? UploadUnknownExecutables { get; set; }

        public PreventionPolicyLinuxArgs()
        {
        }
        public static new PreventionPolicyLinuxArgs Empty => new PreventionPolicyLinuxArgs();
    }

    public sealed class PreventionPolicyLinuxState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Use cloud-based machine learning informed by global analysis of executables to detect and prevent known malware for your online hosts.
        /// </summary>
        [Input("cloudAntiMalware")]
        public Input<Inputs.PreventionPolicyLinuxCloudAntiMalwareGetArgs>? CloudAntiMalware { get; set; }

        /// <summary>
        /// Whether to enable the setting. Block processes matching hashes that you add to IOC Management with the action set to "Block" or "Block, hide detection".
        /// </summary>
        [Input("customBlocking")]
        public Input<bool>? CustomBlocking { get; set; }

        /// <summary>
        /// Description of the prevention policy.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether to enable the setting. Block new processes originating from files written in a container. This prevents a container from drifting from its immutable runtime state.
        /// </summary>
        [Input("driftPrevention")]
        public Input<bool>? DriftPrevention { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor SMTP, IMAP, and POP3 traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("emailProtocolVisibility")]
        public Input<bool>? EmailProtocolVisibility { get; set; }

        /// <summary>
        /// Enable the prevention policy.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor filesystem activity for additional telemetry and improved detections.
        /// </summary>
        [Input("filesystemVisibility")]
        public Input<bool>? FilesystemVisibility { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor unencrypted FTP traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("ftpVisibility")]
        public Input<bool>? FtpVisibility { get; set; }

        [Input("hostGroups")]
        private InputList<string>? _hostGroups;

        /// <summary>
        /// Host Group ids to attach to the prevention policy.
        /// </summary>
        public InputList<string> HostGroups
        {
            get => _hostGroups ?? (_hostGroups = new InputList<string>());
            set => _hostGroups = value;
        }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor unencrypted HTTP traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("httpVisibility")]
        public Input<bool>? HttpVisibility { get; set; }

        [Input("ioaRuleGroups")]
        private InputList<string>? _ioaRuleGroups;

        /// <summary>
        /// IOA Rule Group to attach to the prevention policy.
        /// </summary>
        public InputList<string> IoaRuleGroups
        {
            get => _ioaRuleGroups ?? (_ioaRuleGroups = new InputList<string>());
            set => _ioaRuleGroups = value;
        }

        [Input("lastUpdated")]
        public Input<string>? LastUpdated { get; set; }

        /// <summary>
        /// Name of the prevention policy.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor network activity for additional telemetry and improved detections.
        /// </summary>
        [Input("networkVisibility")]
        public Input<bool>? NetworkVisibility { get; set; }

        /// <summary>
        /// Whether to enable the setting. Block processes that CrowdStrike analysts classify as suspicious. These are focused on dynamic IOAs, such as malware, exploits and other threats.
        /// </summary>
        [Input("preventSuspiciousProcesses")]
        public Input<bool>? PreventSuspiciousProcesses { get; set; }

        /// <summary>
        /// Whether to enable the setting. Quarantine executable files after they’re prevented by NGAV. When this is enabled, we recommend setting anti-malware prevention levels to Moderate or higher and not using other antivirus solutions.
        /// </summary>
        [Input("quarantine")]
        public Input<bool>? Quarantine { get; set; }

        /// <summary>
        /// Whether to enable the setting. Provides visibility into suspicious scripts, including shell and other scripting languages.
        /// </summary>
        [Input("scriptBasedExecutionMonitoring")]
        public Input<bool>? ScriptBasedExecutionMonitoring { get; set; }

        /// <summary>
        /// For offline and online hosts, use sensor-based machine learning to identify and analyze unknown executables as they run to detect and prevent malware.
        /// </summary>
        [Input("sensorAntiMalware")]
        public Input<Inputs.PreventionPolicyLinuxSensorAntiMalwareGetArgs>? SensorAntiMalware { get; set; }

        /// <summary>
        /// Whether to enable the setting. Allows the sensor to monitor TLS traffic for malicious patterns and improved detections.
        /// </summary>
        [Input("tlsVisibility")]
        public Input<bool>? TlsVisibility { get; set; }

        /// <summary>
        /// Whether to enable the setting. Upload all unknown detection-related executables for advanced analysis in the cloud.
        /// </summary>
        [Input("uploadUnknownDetectionRelatedExecutables")]
        public Input<bool>? UploadUnknownDetectionRelatedExecutables { get; set; }

        /// <summary>
        /// Whether to enable the setting. Upload all unknown executables for advanced analysis in the cloud.
        /// </summary>
        [Input("uploadUnknownExecutables")]
        public Input<bool>? UploadUnknownExecutables { get; set; }

        public PreventionPolicyLinuxState()
        {
        }
        public static new PreventionPolicyLinuxState Empty => new PreventionPolicyLinuxState();
    }
}
