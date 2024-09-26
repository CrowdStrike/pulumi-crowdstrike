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
    /// This resource allows you to manage host groups in the CrowdStrike Falcon Platform.
    /// 
    /// ## API Scopes
    /// 
    /// The following API scopes are required:
    /// 
    /// - Host groups | Read &amp; Write
    /// - Firewall management | Read &amp; Write
    /// - Prevention policies | Read &amp; Write
    /// - Response policies | Read &amp; Write
    /// - Sensor update policies | Read &amp; Write
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
    ///     var @dynamic = new Crowdstrike.HostGroup("dynamic", new()
    ///     {
    ///         AssignmentRule = "tags:'SensorGroupingTags/molecule'+os_version:'Debian GNU 11'",
    ///         Description = "Made with Pulumi",
    ///         Type = "dynamic",
    ///     });
    /// 
    ///     var @static = new Crowdstrike.HostGroup("static", new()
    ///     {
    ///         Description = "Made with Pulumi",
    ///         Type = "static",
    ///         Hostnames = new[]
    ///         {
    ///             "host1",
    ///             "host2",
    ///         },
    ///     });
    /// 
    ///     var staticByID = new Crowdstrike.HostGroup("staticByID", new()
    ///     {
    ///         Description = "Made with Pulumi",
    ///         Type = "staticByID",
    ///         HostIds = new[]
    ///         {
    ///             "123123",
    ///             "124124",
    ///         },
    ///     });
    /// 
    ///     return new Dictionary&lt;string, object?&gt;
    ///     {
    ///         ["hostGroup"] = @dynamic,
    ///     };
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// host group can be imported by specifying the policy id.
    /// 
    /// ```sh
    /// $ pulumi import crowdstrike:index/hostGroup:HostGroup example 7fb858a949034a0cbca175f660f1e769
    /// ```
    /// </summary>
    [CrowdstrikeResourceType("crowdstrike:index/hostGroup:HostGroup")]
    public partial class HostGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The assignment rule for dynamic host groups.
        /// </summary>
        [Output("assignmentRule")]
        public Output<string?> AssignmentRule { get; private set; } = null!;

        /// <summary>
        /// Description of the host group.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// List of host ids to add to a staticByID host group.
        /// </summary>
        [Output("hostIds")]
        public Output<ImmutableArray<string>> HostIds { get; private set; } = null!;

        /// <summary>
        /// List of hostnames to add to a static host group.
        /// </summary>
        [Output("hostnames")]
        public Output<ImmutableArray<string>> Hostnames { get; private set; } = null!;

        [Output("lastUpdated")]
        public Output<string> LastUpdated { get; private set; } = null!;

        /// <summary>
        /// Name of the host group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The host group type, case sensitive. (dynamic, static, staticByID)
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a HostGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public HostGroup(string name, HostGroupArgs args, CustomResourceOptions? options = null)
            : base("crowdstrike:index/hostGroup:HostGroup", name, args ?? new HostGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private HostGroup(string name, Input<string> id, HostGroupState? state = null, CustomResourceOptions? options = null)
            : base("crowdstrike:index/hostGroup:HostGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing HostGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static HostGroup Get(string name, Input<string> id, HostGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new HostGroup(name, id, state, options);
        }
    }

    public sealed class HostGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The assignment rule for dynamic host groups.
        /// </summary>
        [Input("assignmentRule")]
        public Input<string>? AssignmentRule { get; set; }

        /// <summary>
        /// Description of the host group.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        [Input("hostIds")]
        private InputList<string>? _hostIds;

        /// <summary>
        /// List of host ids to add to a staticByID host group.
        /// </summary>
        public InputList<string> HostIds
        {
            get => _hostIds ?? (_hostIds = new InputList<string>());
            set => _hostIds = value;
        }

        [Input("hostnames")]
        private InputList<string>? _hostnames;

        /// <summary>
        /// List of hostnames to add to a static host group.
        /// </summary>
        public InputList<string> Hostnames
        {
            get => _hostnames ?? (_hostnames = new InputList<string>());
            set => _hostnames = value;
        }

        /// <summary>
        /// Name of the host group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The host group type, case sensitive. (dynamic, static, staticByID)
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public HostGroupArgs()
        {
        }
        public static new HostGroupArgs Empty => new HostGroupArgs();
    }

    public sealed class HostGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The assignment rule for dynamic host groups.
        /// </summary>
        [Input("assignmentRule")]
        public Input<string>? AssignmentRule { get; set; }

        /// <summary>
        /// Description of the host group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("hostIds")]
        private InputList<string>? _hostIds;

        /// <summary>
        /// List of host ids to add to a staticByID host group.
        /// </summary>
        public InputList<string> HostIds
        {
            get => _hostIds ?? (_hostIds = new InputList<string>());
            set => _hostIds = value;
        }

        [Input("hostnames")]
        private InputList<string>? _hostnames;

        /// <summary>
        /// List of hostnames to add to a static host group.
        /// </summary>
        public InputList<string> Hostnames
        {
            get => _hostnames ?? (_hostnames = new InputList<string>());
            set => _hostnames = value;
        }

        [Input("lastUpdated")]
        public Input<string>? LastUpdated { get; set; }

        /// <summary>
        /// Name of the host group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The host group type, case sensitive. (dynamic, static, staticByID)
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public HostGroupState()
        {
        }
        public static new HostGroupState Empty => new HostGroupState();
    }
}
