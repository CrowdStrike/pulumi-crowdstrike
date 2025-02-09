// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * This resource allows management of a FileVantage rule group. A FileVantage rule group is a collection of file integrity rules that can be assigned to a FileVantge policy.
 *
 * ## API Scopes
 *
 * The following API scopes are required:
 *
 * - Falcon FileVantage | Read & Write
 *
 * ## Import
 *
 * filevantage rule group can be imported by specifying the policy id.
 *
 * ```sh
 * $ pulumi import crowdstrike:index/filevantageRuleGroup:FilevantageRuleGroup example 7fb858a949034a0cbca175f660f1e769
 * ```
 */
export class FilevantageRuleGroup extends pulumi.CustomResource {
    /**
     * Get an existing FilevantageRuleGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FilevantageRuleGroupState, opts?: pulumi.CustomResourceOptions): FilevantageRuleGroup {
        return new FilevantageRuleGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'crowdstrike:index/filevantageRuleGroup:FilevantageRuleGroup';

    /**
     * Returns true if the given object is an instance of FilevantageRuleGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FilevantageRuleGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FilevantageRuleGroup.__pulumiType;
    }

    /**
     * Description of the filevantage rule group.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    public /*out*/ readonly lastUpdated!: pulumi.Output<string>;
    /**
     * Name of the filevantage rule group.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Rules to be associated with the rule group. Precedence is determined by the order of the rules in the list.
     */
    public readonly rules!: pulumi.Output<outputs.FilevantageRuleGroupRule[] | undefined>;
    /**
     * The type of filevantage rule group.
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a FilevantageRuleGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: FilevantageRuleGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FilevantageRuleGroupArgs | FilevantageRuleGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FilevantageRuleGroupState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["lastUpdated"] = state ? state.lastUpdated : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["rules"] = state ? state.rules : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as FilevantageRuleGroupArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["rules"] = args ? args.rules : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["lastUpdated"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FilevantageRuleGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FilevantageRuleGroup resources.
 */
export interface FilevantageRuleGroupState {
    /**
     * Description of the filevantage rule group.
     */
    description?: pulumi.Input<string>;
    lastUpdated?: pulumi.Input<string>;
    /**
     * Name of the filevantage rule group.
     */
    name?: pulumi.Input<string>;
    /**
     * Rules to be associated with the rule group. Precedence is determined by the order of the rules in the list.
     */
    rules?: pulumi.Input<pulumi.Input<inputs.FilevantageRuleGroupRule>[]>;
    /**
     * The type of filevantage rule group.
     */
    type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FilevantageRuleGroup resource.
 */
export interface FilevantageRuleGroupArgs {
    /**
     * Description of the filevantage rule group.
     */
    description?: pulumi.Input<string>;
    /**
     * Name of the filevantage rule group.
     */
    name?: pulumi.Input<string>;
    /**
     * Rules to be associated with the rule group. Precedence is determined by the order of the rules in the list.
     */
    rules?: pulumi.Input<pulumi.Input<inputs.FilevantageRuleGroupRule>[]>;
    /**
     * The type of filevantage rule group.
     */
    type?: pulumi.Input<string>;
}
