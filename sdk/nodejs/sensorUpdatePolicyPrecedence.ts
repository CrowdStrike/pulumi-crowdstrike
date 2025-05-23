// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * This resource allows you to set the precedence of Sensor Update Policies based on the order of IDs.
 *
 * ## API Scopes
 *
 * The following API scopes are required:
 *
 * - Sensor update policies | Read & Write
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as crowdstrike from "@crowdstrike/pulumi";
 *
 * const example = new crowdstrike.SensorUpdatePolicyPrecedence("example", {
 *     ids: [
 *         "a1j09y3yq0wnrpb5o6jlij9e4f40k6lq",
 *         "2asia54xti93bg0jbr5hfpqqbhxbyeoa",
 *         "xuzq8hs1uyc2s7zdar3fli0shiyl22vc",
 *     ],
 *     platformName: "linux",
 *     enforcement: "dynamic",
 * });
 * export const sensorUpdatePolicyPrecedence = example;
 * ```
 */
export class SensorUpdatePolicyPrecedence extends pulumi.CustomResource {
    /**
     * Get an existing SensorUpdatePolicyPrecedence resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SensorUpdatePolicyPrecedenceState, opts?: pulumi.CustomResourceOptions): SensorUpdatePolicyPrecedence {
        return new SensorUpdatePolicyPrecedence(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'crowdstrike:index/sensorUpdatePolicyPrecedence:SensorUpdatePolicyPrecedence';

    /**
     * Returns true if the given object is an instance of SensorUpdatePolicyPrecedence.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SensorUpdatePolicyPrecedence {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SensorUpdatePolicyPrecedence.__pulumiType;
    }

    /**
     * The enforcement type for this resource. `strict` requires all non-default sensor update policy ids for platform to be provided. `dynamic` will ensure the provided policies have precedence over others. When using dynamic, policy ids not included in `ids` will retain their current ordering after the managed ids.
     */
    public readonly enforcement!: pulumi.Output<string>;
    /**
     * The policy ids in order. The first ID specified will have the highest precedence and the last ID specified will have the lowest.
     */
    public readonly ids!: pulumi.Output<string[]>;
    public /*out*/ readonly lastUpdated!: pulumi.Output<string>;
    /**
     * That platform of the sensor update policies. (Windows, Mac, Linux)
     */
    public readonly platformName!: pulumi.Output<string>;

    /**
     * Create a SensorUpdatePolicyPrecedence resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SensorUpdatePolicyPrecedenceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SensorUpdatePolicyPrecedenceArgs | SensorUpdatePolicyPrecedenceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SensorUpdatePolicyPrecedenceState | undefined;
            resourceInputs["enforcement"] = state ? state.enforcement : undefined;
            resourceInputs["ids"] = state ? state.ids : undefined;
            resourceInputs["lastUpdated"] = state ? state.lastUpdated : undefined;
            resourceInputs["platformName"] = state ? state.platformName : undefined;
        } else {
            const args = argsOrState as SensorUpdatePolicyPrecedenceArgs | undefined;
            if ((!args || args.enforcement === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enforcement'");
            }
            if ((!args || args.ids === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ids'");
            }
            if ((!args || args.platformName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'platformName'");
            }
            resourceInputs["enforcement"] = args ? args.enforcement : undefined;
            resourceInputs["ids"] = args ? args.ids : undefined;
            resourceInputs["platformName"] = args ? args.platformName : undefined;
            resourceInputs["lastUpdated"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SensorUpdatePolicyPrecedence.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SensorUpdatePolicyPrecedence resources.
 */
export interface SensorUpdatePolicyPrecedenceState {
    /**
     * The enforcement type for this resource. `strict` requires all non-default sensor update policy ids for platform to be provided. `dynamic` will ensure the provided policies have precedence over others. When using dynamic, policy ids not included in `ids` will retain their current ordering after the managed ids.
     */
    enforcement?: pulumi.Input<string>;
    /**
     * The policy ids in order. The first ID specified will have the highest precedence and the last ID specified will have the lowest.
     */
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    lastUpdated?: pulumi.Input<string>;
    /**
     * That platform of the sensor update policies. (Windows, Mac, Linux)
     */
    platformName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SensorUpdatePolicyPrecedence resource.
 */
export interface SensorUpdatePolicyPrecedenceArgs {
    /**
     * The enforcement type for this resource. `strict` requires all non-default sensor update policy ids for platform to be provided. `dynamic` will ensure the provided policies have precedence over others. When using dynamic, policy ids not included in `ids` will retain their current ordering after the managed ids.
     */
    enforcement: pulumi.Input<string>;
    /**
     * The policy ids in order. The first ID specified will have the highest precedence and the last ID specified will have the lowest.
     */
    ids: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * That platform of the sensor update policies. (Windows, Mac, Linux)
     */
    platformName: pulumi.Input<string>;
}
