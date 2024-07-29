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
    /// This resource allows management of a FileVantage rule group. A FileVantage rule group is a collection of file integrity rules that can be assigned to a FileVantge policy.
    /// 
    /// ## API Scopes
    /// 
    /// The following API scopes are required:
    /// 
    /// - Falcon FileVantage | Read &amp; Write
    /// 
    /// ## Import
    /// 
    /// filevantage rule group can be imported by specifying the policy id.
    /// 
    /// ```sh
    /// $ pulumi import crowdstrike:index/filevantageRuleGroup:FilevantageRuleGroup example 7fb858a949034a0cbca175f660f1e769
    /// ```
    /// </summary>
    [CrowdstrikeResourceType("crowdstrike:index/filevantageRuleGroup:FilevantageRuleGroup")]
    public partial class FilevantageRuleGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Description of the filevantage rule group.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("lastUpdated")]
        public Output<string> LastUpdated { get; private set; } = null!;

        /// <summary>
        /// Name of the filevantage rule group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Rules to be associated with the rule group. Precedence is determined by the order of the rules in the list.
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.FilevantageRuleGroupRule>> Rules { get; private set; } = null!;

        /// <summary>
        /// The type of filevantage rule group.
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a FilevantageRuleGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FilevantageRuleGroup(string name, FilevantageRuleGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("crowdstrike:index/filevantageRuleGroup:FilevantageRuleGroup", name, args ?? new FilevantageRuleGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FilevantageRuleGroup(string name, Input<string> id, FilevantageRuleGroupState? state = null, CustomResourceOptions? options = null)
            : base("crowdstrike:index/filevantageRuleGroup:FilevantageRuleGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing FilevantageRuleGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FilevantageRuleGroup Get(string name, Input<string> id, FilevantageRuleGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new FilevantageRuleGroup(name, id, state, options);
        }
    }

    public sealed class FilevantageRuleGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the filevantage rule group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Name of the filevantage rule group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rules")]
        private InputList<Inputs.FilevantageRuleGroupRuleArgs>? _rules;

        /// <summary>
        /// Rules to be associated with the rule group. Precedence is determined by the order of the rules in the list.
        /// </summary>
        public InputList<Inputs.FilevantageRuleGroupRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.FilevantageRuleGroupRuleArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// The type of filevantage rule group.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public FilevantageRuleGroupArgs()
        {
        }
        public static new FilevantageRuleGroupArgs Empty => new FilevantageRuleGroupArgs();
    }

    public sealed class FilevantageRuleGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the filevantage rule group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("lastUpdated")]
        public Input<string>? LastUpdated { get; set; }

        /// <summary>
        /// Name of the filevantage rule group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rules")]
        private InputList<Inputs.FilevantageRuleGroupRuleGetArgs>? _rules;

        /// <summary>
        /// Rules to be associated with the rule group. Precedence is determined by the order of the rules in the list.
        /// </summary>
        public InputList<Inputs.FilevantageRuleGroupRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.FilevantageRuleGroupRuleGetArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// The type of filevantage rule group.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public FilevantageRuleGroupState()
        {
        }
        public static new FilevantageRuleGroupState Empty => new FilevantageRuleGroupState();
    }
}