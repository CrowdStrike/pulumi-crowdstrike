// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * This resource allows you to manage the default prevention policy for Linux hosts. Prevention policies allow you to manage what activity will trigger detections and preventions on your hosts.
 *
 * ## API Scopes
 *
 * The following API scopes are required:
 *
 * - Prevention policies | Read & Write
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as crowdstrike from "@crowdstrike/pulumi";
 *
 * const _default = new crowdstrike.DefaultPreventionPolicyLinux("default", {
 *     description: "managed by terraform",
 *     ioaRuleGroups: [],
 *     cloudAntiMalware: {
 *         detection: "MODERATE",
 *         prevention: "CAUTIOUS",
 *     },
 *     sensorAntiMalware: {
 *         detection: "MODERATE",
 *         prevention: "CAUTIOUS",
 *     },
 *     quarantine: true,
 *     customBlocking: true,
 *     preventSuspiciousProcesses: true,
 *     scriptBasedExecutionMonitoring: true,
 *     uploadUnknownExecutables: true,
 *     uploadUnknownDetectionRelatedExecutables: true,
 *     driftPrevention: true,
 *     emailProtocolVisibility: true,
 *     filesystemVisibility: true,
 *     ftpVisibility: true,
 *     httpVisibility: true,
 *     networkVisibility: true,
 *     tlsVisibility: true,
 *     sensorTamperingProtection: true,
 *     onWriteScriptFileVisibility: true,
 *     memoryVisibility: true,
 *     extendedCommandLineVisibility: true,
 * });
 * export const defaultPreventionPolicyLinux = _default;
 * ```
 *
 * ## Import
 *
 * The mac default prevention policy can be imported by specifying the id.
 *
 * ```sh
 * $ pulumi import crowdstrike:index/defaultPreventionPolicyLinux:DefaultPreventionPolicyLinux default 7fb858a949034a0cbca175f660f1e769
 * ```
 */
export class DefaultPreventionPolicyLinux extends pulumi.CustomResource {
    /**
     * Get an existing DefaultPreventionPolicyLinux resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DefaultPreventionPolicyLinuxState, opts?: pulumi.CustomResourceOptions): DefaultPreventionPolicyLinux {
        return new DefaultPreventionPolicyLinux(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'crowdstrike:index/defaultPreventionPolicyLinux:DefaultPreventionPolicyLinux';

    /**
     * Returns true if the given object is an instance of DefaultPreventionPolicyLinux.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DefaultPreventionPolicyLinux {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DefaultPreventionPolicyLinux.__pulumiType;
    }

    /**
     * Use cloud-based machine learning informed by global analysis of executables to detect and prevent known malware for your online hosts.
     */
    public readonly cloudAntiMalware!: pulumi.Output<outputs.DefaultPreventionPolicyLinuxCloudAntiMalware>;
    /**
     * Whether to enable the setting. Block processes matching hashes that you add to IOC Management with the action set to "Block" or "Block, hide detection".
     */
    public readonly customBlocking!: pulumi.Output<boolean>;
    /**
     * Description of the prevention policy.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Whether to enable the setting. Block new processes originating from files written in a container. This prevents a container from drifting from its immutable runtime state.
     */
    public readonly driftPrevention!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor SMTP, IMAP, and POP3 traffic for malicious patterns and improved detections.
     */
    public readonly emailProtocolVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor full CLI commands that include pipes and redirects. This is applicable only for User mode.
     */
    public readonly extendedCommandLineVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor filesystem activity for additional telemetry and improved detections.
     */
    public readonly filesystemVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor unencrypted FTP traffic for malicious patterns and improved detections.
     */
    public readonly ftpVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor unencrypted HTTP traffic for malicious patterns and improved detections.
     */
    public readonly httpVisibility!: pulumi.Output<boolean>;
    /**
     * IOA Rule Group to attach to the prevention policy.
     */
    public readonly ioaRuleGroups!: pulumi.Output<string[]>;
    public /*out*/ readonly lastUpdated!: pulumi.Output<string>;
    /**
     * Whether to enable the setting. When enabled, the sensor will inspect memory-related operations: mmap, mprotect, ptrace and reading/writing remote process memory and produce events.
     */
    public readonly memoryVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor network activity for additional telemetry and improved detections.
     */
    public readonly networkVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Provides improved visibility into various script files being written to disk in addition to clouding a portion of their content.
     */
    public readonly onWriteScriptFileVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Block processes that CrowdStrike analysts classify as suspicious. These are focused on dynamic IOAs, such as malware, exploits and other threats.
     */
    public readonly preventSuspiciousProcesses!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Quarantine executable files after they’re prevented by NGAV. When this is enabled, we recommend setting anti-malware prevention levels to Moderate or higher and not using other antivirus solutions.
     */
    public readonly quarantine!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Provides visibility into suspicious scripts, including shell and other scripting languages.
     */
    public readonly scriptBasedExecutionMonitoring!: pulumi.Output<boolean>;
    /**
     * For offline and online hosts, use sensor-based machine learning to identify and analyze unknown executables as they run to detect and prevent malware.
     */
    public readonly sensorAntiMalware!: pulumi.Output<outputs.DefaultPreventionPolicyLinuxSensorAntiMalware>;
    /**
     * Whether to enable the setting. Block attempts to tamper with the sensor by protecting critical components and resources. If disabled, the sensor still creates detections for tampering attempts but will not prevent the activity from occurring. Disabling is not recommended.
     */
    public readonly sensorTamperingProtection!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor TLS traffic for malicious patterns and improved detections.
     */
    public readonly tlsVisibility!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Upload all unknown detection-related executables for advanced analysis in the cloud.
     */
    public readonly uploadUnknownDetectionRelatedExecutables!: pulumi.Output<boolean>;
    /**
     * Whether to enable the setting. Upload all unknown executables for advanced analysis in the cloud.
     */
    public readonly uploadUnknownExecutables!: pulumi.Output<boolean>;

    /**
     * Create a DefaultPreventionPolicyLinux resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DefaultPreventionPolicyLinuxArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DefaultPreventionPolicyLinuxArgs | DefaultPreventionPolicyLinuxState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DefaultPreventionPolicyLinuxState | undefined;
            resourceInputs["cloudAntiMalware"] = state ? state.cloudAntiMalware : undefined;
            resourceInputs["customBlocking"] = state ? state.customBlocking : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["driftPrevention"] = state ? state.driftPrevention : undefined;
            resourceInputs["emailProtocolVisibility"] = state ? state.emailProtocolVisibility : undefined;
            resourceInputs["extendedCommandLineVisibility"] = state ? state.extendedCommandLineVisibility : undefined;
            resourceInputs["filesystemVisibility"] = state ? state.filesystemVisibility : undefined;
            resourceInputs["ftpVisibility"] = state ? state.ftpVisibility : undefined;
            resourceInputs["httpVisibility"] = state ? state.httpVisibility : undefined;
            resourceInputs["ioaRuleGroups"] = state ? state.ioaRuleGroups : undefined;
            resourceInputs["lastUpdated"] = state ? state.lastUpdated : undefined;
            resourceInputs["memoryVisibility"] = state ? state.memoryVisibility : undefined;
            resourceInputs["networkVisibility"] = state ? state.networkVisibility : undefined;
            resourceInputs["onWriteScriptFileVisibility"] = state ? state.onWriteScriptFileVisibility : undefined;
            resourceInputs["preventSuspiciousProcesses"] = state ? state.preventSuspiciousProcesses : undefined;
            resourceInputs["quarantine"] = state ? state.quarantine : undefined;
            resourceInputs["scriptBasedExecutionMonitoring"] = state ? state.scriptBasedExecutionMonitoring : undefined;
            resourceInputs["sensorAntiMalware"] = state ? state.sensorAntiMalware : undefined;
            resourceInputs["sensorTamperingProtection"] = state ? state.sensorTamperingProtection : undefined;
            resourceInputs["tlsVisibility"] = state ? state.tlsVisibility : undefined;
            resourceInputs["uploadUnknownDetectionRelatedExecutables"] = state ? state.uploadUnknownDetectionRelatedExecutables : undefined;
            resourceInputs["uploadUnknownExecutables"] = state ? state.uploadUnknownExecutables : undefined;
        } else {
            const args = argsOrState as DefaultPreventionPolicyLinuxArgs | undefined;
            if ((!args || args.ioaRuleGroups === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ioaRuleGroups'");
            }
            resourceInputs["cloudAntiMalware"] = args ? args.cloudAntiMalware : undefined;
            resourceInputs["customBlocking"] = args ? args.customBlocking : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["driftPrevention"] = args ? args.driftPrevention : undefined;
            resourceInputs["emailProtocolVisibility"] = args ? args.emailProtocolVisibility : undefined;
            resourceInputs["extendedCommandLineVisibility"] = args ? args.extendedCommandLineVisibility : undefined;
            resourceInputs["filesystemVisibility"] = args ? args.filesystemVisibility : undefined;
            resourceInputs["ftpVisibility"] = args ? args.ftpVisibility : undefined;
            resourceInputs["httpVisibility"] = args ? args.httpVisibility : undefined;
            resourceInputs["ioaRuleGroups"] = args ? args.ioaRuleGroups : undefined;
            resourceInputs["memoryVisibility"] = args ? args.memoryVisibility : undefined;
            resourceInputs["networkVisibility"] = args ? args.networkVisibility : undefined;
            resourceInputs["onWriteScriptFileVisibility"] = args ? args.onWriteScriptFileVisibility : undefined;
            resourceInputs["preventSuspiciousProcesses"] = args ? args.preventSuspiciousProcesses : undefined;
            resourceInputs["quarantine"] = args ? args.quarantine : undefined;
            resourceInputs["scriptBasedExecutionMonitoring"] = args ? args.scriptBasedExecutionMonitoring : undefined;
            resourceInputs["sensorAntiMalware"] = args ? args.sensorAntiMalware : undefined;
            resourceInputs["sensorTamperingProtection"] = args ? args.sensorTamperingProtection : undefined;
            resourceInputs["tlsVisibility"] = args ? args.tlsVisibility : undefined;
            resourceInputs["uploadUnknownDetectionRelatedExecutables"] = args ? args.uploadUnknownDetectionRelatedExecutables : undefined;
            resourceInputs["uploadUnknownExecutables"] = args ? args.uploadUnknownExecutables : undefined;
            resourceInputs["lastUpdated"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DefaultPreventionPolicyLinux.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DefaultPreventionPolicyLinux resources.
 */
export interface DefaultPreventionPolicyLinuxState {
    /**
     * Use cloud-based machine learning informed by global analysis of executables to detect and prevent known malware for your online hosts.
     */
    cloudAntiMalware?: pulumi.Input<inputs.DefaultPreventionPolicyLinuxCloudAntiMalware>;
    /**
     * Whether to enable the setting. Block processes matching hashes that you add to IOC Management with the action set to "Block" or "Block, hide detection".
     */
    customBlocking?: pulumi.Input<boolean>;
    /**
     * Description of the prevention policy.
     */
    description?: pulumi.Input<string>;
    /**
     * Whether to enable the setting. Block new processes originating from files written in a container. This prevents a container from drifting from its immutable runtime state.
     */
    driftPrevention?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor SMTP, IMAP, and POP3 traffic for malicious patterns and improved detections.
     */
    emailProtocolVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor full CLI commands that include pipes and redirects. This is applicable only for User mode.
     */
    extendedCommandLineVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor filesystem activity for additional telemetry and improved detections.
     */
    filesystemVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor unencrypted FTP traffic for malicious patterns and improved detections.
     */
    ftpVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor unencrypted HTTP traffic for malicious patterns and improved detections.
     */
    httpVisibility?: pulumi.Input<boolean>;
    /**
     * IOA Rule Group to attach to the prevention policy.
     */
    ioaRuleGroups?: pulumi.Input<pulumi.Input<string>[]>;
    lastUpdated?: pulumi.Input<string>;
    /**
     * Whether to enable the setting. When enabled, the sensor will inspect memory-related operations: mmap, mprotect, ptrace and reading/writing remote process memory and produce events.
     */
    memoryVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor network activity for additional telemetry and improved detections.
     */
    networkVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Provides improved visibility into various script files being written to disk in addition to clouding a portion of their content.
     */
    onWriteScriptFileVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Block processes that CrowdStrike analysts classify as suspicious. These are focused on dynamic IOAs, such as malware, exploits and other threats.
     */
    preventSuspiciousProcesses?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Quarantine executable files after they’re prevented by NGAV. When this is enabled, we recommend setting anti-malware prevention levels to Moderate or higher and not using other antivirus solutions.
     */
    quarantine?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Provides visibility into suspicious scripts, including shell and other scripting languages.
     */
    scriptBasedExecutionMonitoring?: pulumi.Input<boolean>;
    /**
     * For offline and online hosts, use sensor-based machine learning to identify and analyze unknown executables as they run to detect and prevent malware.
     */
    sensorAntiMalware?: pulumi.Input<inputs.DefaultPreventionPolicyLinuxSensorAntiMalware>;
    /**
     * Whether to enable the setting. Block attempts to tamper with the sensor by protecting critical components and resources. If disabled, the sensor still creates detections for tampering attempts but will not prevent the activity from occurring. Disabling is not recommended.
     */
    sensorTamperingProtection?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor TLS traffic for malicious patterns and improved detections.
     */
    tlsVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Upload all unknown detection-related executables for advanced analysis in the cloud.
     */
    uploadUnknownDetectionRelatedExecutables?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Upload all unknown executables for advanced analysis in the cloud.
     */
    uploadUnknownExecutables?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a DefaultPreventionPolicyLinux resource.
 */
export interface DefaultPreventionPolicyLinuxArgs {
    /**
     * Use cloud-based machine learning informed by global analysis of executables to detect and prevent known malware for your online hosts.
     */
    cloudAntiMalware?: pulumi.Input<inputs.DefaultPreventionPolicyLinuxCloudAntiMalware>;
    /**
     * Whether to enable the setting. Block processes matching hashes that you add to IOC Management with the action set to "Block" or "Block, hide detection".
     */
    customBlocking?: pulumi.Input<boolean>;
    /**
     * Description of the prevention policy.
     */
    description?: pulumi.Input<string>;
    /**
     * Whether to enable the setting. Block new processes originating from files written in a container. This prevents a container from drifting from its immutable runtime state.
     */
    driftPrevention?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor SMTP, IMAP, and POP3 traffic for malicious patterns and improved detections.
     */
    emailProtocolVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor full CLI commands that include pipes and redirects. This is applicable only for User mode.
     */
    extendedCommandLineVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor filesystem activity for additional telemetry and improved detections.
     */
    filesystemVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor unencrypted FTP traffic for malicious patterns and improved detections.
     */
    ftpVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor unencrypted HTTP traffic for malicious patterns and improved detections.
     */
    httpVisibility?: pulumi.Input<boolean>;
    /**
     * IOA Rule Group to attach to the prevention policy.
     */
    ioaRuleGroups: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Whether to enable the setting. When enabled, the sensor will inspect memory-related operations: mmap, mprotect, ptrace and reading/writing remote process memory and produce events.
     */
    memoryVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor network activity for additional telemetry and improved detections.
     */
    networkVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Provides improved visibility into various script files being written to disk in addition to clouding a portion of their content.
     */
    onWriteScriptFileVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Block processes that CrowdStrike analysts classify as suspicious. These are focused on dynamic IOAs, such as malware, exploits and other threats.
     */
    preventSuspiciousProcesses?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Quarantine executable files after they’re prevented by NGAV. When this is enabled, we recommend setting anti-malware prevention levels to Moderate or higher and not using other antivirus solutions.
     */
    quarantine?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Provides visibility into suspicious scripts, including shell and other scripting languages.
     */
    scriptBasedExecutionMonitoring?: pulumi.Input<boolean>;
    /**
     * For offline and online hosts, use sensor-based machine learning to identify and analyze unknown executables as they run to detect and prevent malware.
     */
    sensorAntiMalware?: pulumi.Input<inputs.DefaultPreventionPolicyLinuxSensorAntiMalware>;
    /**
     * Whether to enable the setting. Block attempts to tamper with the sensor by protecting critical components and resources. If disabled, the sensor still creates detections for tampering attempts but will not prevent the activity from occurring. Disabling is not recommended.
     */
    sensorTamperingProtection?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Allows the sensor to monitor TLS traffic for malicious patterns and improved detections.
     */
    tlsVisibility?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Upload all unknown detection-related executables for advanced analysis in the cloud.
     */
    uploadUnknownDetectionRelatedExecutables?: pulumi.Input<boolean>;
    /**
     * Whether to enable the setting. Upload all unknown executables for advanced analysis in the cloud.
     */
    uploadUnknownExecutables?: pulumi.Input<boolean>;
}
