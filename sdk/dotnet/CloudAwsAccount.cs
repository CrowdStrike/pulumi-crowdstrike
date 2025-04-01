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
    /// This resource allows management of an AWS account in Falcon.
    /// 
    /// ## API Scopes
    /// 
    /// The following API scopes are required:
    /// 
    /// - Cloud security AWS registration | Read &amp; Write
    /// - CSPM registration | Read &amp; Write
    /// 
    /// ## Import
    /// 
    /// A previously registered cloud aws account can be imported by account id.
    /// 
    /// ```sh
    /// $ pulumi import crowdstrike:index/cloudAwsAccount:CloudAwsAccount account 12345678910
    /// ```
    /// </summary>
    [CrowdstrikeResourceType("crowdstrike:index/cloudAwsAccount:CloudAwsAccount")]
    public partial class CloudAwsAccount : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The AWS Account ID
        /// </summary>
        [Output("accountId")]
        public Output<string> AccountId { get; private set; } = null!;

        /// <summary>
        /// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
        /// </summary>
        [Output("accountType")]
        public Output<string> AccountType { get; private set; } = null!;

        [Output("assetInventory")]
        public Output<Outputs.CloudAwsAccountAssetInventory> AssetInventory { get; private set; } = null!;

        /// <summary>
        /// The name of the CloudTrail S3 bucket used for real-time visibility
        /// </summary>
        [Output("cloudtrailBucketName")]
        public Output<string> CloudtrailBucketName { get; private set; } = null!;

        [Output("deploymentMethod")]
        public Output<string> DeploymentMethod { get; private set; } = null!;

        [Output("dspm")]
        public Output<Outputs.CloudAwsAccountDspm> Dspm { get; private set; } = null!;

        /// <summary>
        /// The ARN of the IAM role to be used by CrowdStrike Data Security Posture Management
        /// </summary>
        [Output("dspmRoleArn")]
        public Output<string> DspmRoleArn { get; private set; } = null!;

        /// <summary>
        /// The name of the IAM role to be used by CrowdStrike Data Security Posture Management
        /// </summary>
        [Output("dspmRoleName")]
        public Output<string> DspmRoleName { get; private set; } = null!;

        /// <summary>
        /// The ARN of the Amazon EventBridge used by CrowdStrike to forward messages
        /// </summary>
        [Output("eventbusArn")]
        public Output<string> EventbusArn { get; private set; } = null!;

        /// <summary>
        /// The name of the Amazon EventBridge used by CrowdStrike to forward messages
        /// </summary>
        [Output("eventbusName")]
        public Output<string> EventbusName { get; private set; } = null!;

        /// <summary>
        /// The external ID used to assume the AWS IAM role
        /// </summary>
        [Output("externalId")]
        public Output<string> ExternalId { get; private set; } = null!;

        /// <summary>
        /// The ARN of the AWS IAM role used to access this AWS account
        /// </summary>
        [Output("iamRoleArn")]
        public Output<string> IamRoleArn { get; private set; } = null!;

        /// <summary>
        /// The name of the AWS IAM role used to access this AWS account
        /// </summary>
        [Output("iamRoleName")]
        public Output<string> IamRoleName { get; private set; } = null!;

        [Output("idp")]
        public Output<Outputs.CloudAwsAccountIdp> Idp { get; private set; } = null!;

        /// <summary>
        /// The ARN of the intermediate role used to assume the AWS IAM role
        /// </summary>
        [Output("intermediateRoleArn")]
        public Output<string> IntermediateRoleArn { get; private set; } = null!;

        /// <summary>
        /// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
        /// </summary>
        [Output("isOrganizationManagementAccount")]
        public Output<bool> IsOrganizationManagementAccount { get; private set; } = null!;

        /// <summary>
        /// The AWS Organization ID (starts with `o-`). When specified, accounts within the organization will be registered. If `target_ous` is empty, all accounts in the organization will be registered. The `account_id` must be the organization's management account ID.
        /// </summary>
        [Output("organizationId")]
        public Output<string> OrganizationId { get; private set; } = null!;

        [Output("realtimeVisibility")]
        public Output<Outputs.CloudAwsAccountRealtimeVisibility> RealtimeVisibility { get; private set; } = null!;

        [Output("sensorManagement")]
        public Output<Outputs.CloudAwsAccountSensorManagement> SensorManagement { get; private set; } = null!;

        /// <summary>
        /// The list of target Organizational Units
        /// </summary>
        [Output("targetOuses")]
        public Output<ImmutableArray<string>> TargetOuses { get; private set; } = null!;


        /// <summary>
        /// Create a CloudAwsAccount resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CloudAwsAccount(string name, CloudAwsAccountArgs args, CustomResourceOptions? options = null)
            : base("crowdstrike:index/cloudAwsAccount:CloudAwsAccount", name, args ?? new CloudAwsAccountArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CloudAwsAccount(string name, Input<string> id, CloudAwsAccountState? state = null, CustomResourceOptions? options = null)
            : base("crowdstrike:index/cloudAwsAccount:CloudAwsAccount", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CloudAwsAccount resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CloudAwsAccount Get(string name, Input<string> id, CloudAwsAccountState? state = null, CustomResourceOptions? options = null)
        {
            return new CloudAwsAccount(name, id, state, options);
        }
    }

    public sealed class CloudAwsAccountArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The AWS Account ID
        /// </summary>
        [Input("accountId", required: true)]
        public Input<string> AccountId { get; set; } = null!;

        /// <summary>
        /// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
        /// </summary>
        [Input("accountType")]
        public Input<string>? AccountType { get; set; }

        [Input("assetInventory")]
        public Input<Inputs.CloudAwsAccountAssetInventoryArgs>? AssetInventory { get; set; }

        [Input("deploymentMethod")]
        public Input<string>? DeploymentMethod { get; set; }

        [Input("dspm")]
        public Input<Inputs.CloudAwsAccountDspmArgs>? Dspm { get; set; }

        [Input("idp")]
        public Input<Inputs.CloudAwsAccountIdpArgs>? Idp { get; set; }

        /// <summary>
        /// The AWS Organization ID (starts with `o-`). When specified, accounts within the organization will be registered. If `target_ous` is empty, all accounts in the organization will be registered. The `account_id` must be the organization's management account ID.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        [Input("realtimeVisibility")]
        public Input<Inputs.CloudAwsAccountRealtimeVisibilityArgs>? RealtimeVisibility { get; set; }

        [Input("sensorManagement")]
        public Input<Inputs.CloudAwsAccountSensorManagementArgs>? SensorManagement { get; set; }

        [Input("targetOuses")]
        private InputList<string>? _targetOuses;

        /// <summary>
        /// The list of target Organizational Units
        /// </summary>
        public InputList<string> TargetOuses
        {
            get => _targetOuses ?? (_targetOuses = new InputList<string>());
            set => _targetOuses = value;
        }

        public CloudAwsAccountArgs()
        {
        }
        public static new CloudAwsAccountArgs Empty => new CloudAwsAccountArgs();
    }

    public sealed class CloudAwsAccountState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The AWS Account ID
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
        /// </summary>
        [Input("accountType")]
        public Input<string>? AccountType { get; set; }

        [Input("assetInventory")]
        public Input<Inputs.CloudAwsAccountAssetInventoryGetArgs>? AssetInventory { get; set; }

        /// <summary>
        /// The name of the CloudTrail S3 bucket used for real-time visibility
        /// </summary>
        [Input("cloudtrailBucketName")]
        public Input<string>? CloudtrailBucketName { get; set; }

        [Input("deploymentMethod")]
        public Input<string>? DeploymentMethod { get; set; }

        [Input("dspm")]
        public Input<Inputs.CloudAwsAccountDspmGetArgs>? Dspm { get; set; }

        /// <summary>
        /// The ARN of the IAM role to be used by CrowdStrike Data Security Posture Management
        /// </summary>
        [Input("dspmRoleArn")]
        public Input<string>? DspmRoleArn { get; set; }

        /// <summary>
        /// The name of the IAM role to be used by CrowdStrike Data Security Posture Management
        /// </summary>
        [Input("dspmRoleName")]
        public Input<string>? DspmRoleName { get; set; }

        /// <summary>
        /// The ARN of the Amazon EventBridge used by CrowdStrike to forward messages
        /// </summary>
        [Input("eventbusArn")]
        public Input<string>? EventbusArn { get; set; }

        /// <summary>
        /// The name of the Amazon EventBridge used by CrowdStrike to forward messages
        /// </summary>
        [Input("eventbusName")]
        public Input<string>? EventbusName { get; set; }

        /// <summary>
        /// The external ID used to assume the AWS IAM role
        /// </summary>
        [Input("externalId")]
        public Input<string>? ExternalId { get; set; }

        /// <summary>
        /// The ARN of the AWS IAM role used to access this AWS account
        /// </summary>
        [Input("iamRoleArn")]
        public Input<string>? IamRoleArn { get; set; }

        /// <summary>
        /// The name of the AWS IAM role used to access this AWS account
        /// </summary>
        [Input("iamRoleName")]
        public Input<string>? IamRoleName { get; set; }

        [Input("idp")]
        public Input<Inputs.CloudAwsAccountIdpGetArgs>? Idp { get; set; }

        /// <summary>
        /// The ARN of the intermediate role used to assume the AWS IAM role
        /// </summary>
        [Input("intermediateRoleArn")]
        public Input<string>? IntermediateRoleArn { get; set; }

        /// <summary>
        /// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
        /// </summary>
        [Input("isOrganizationManagementAccount")]
        public Input<bool>? IsOrganizationManagementAccount { get; set; }

        /// <summary>
        /// The AWS Organization ID (starts with `o-`). When specified, accounts within the organization will be registered. If `target_ous` is empty, all accounts in the organization will be registered. The `account_id` must be the organization's management account ID.
        /// </summary>
        [Input("organizationId")]
        public Input<string>? OrganizationId { get; set; }

        [Input("realtimeVisibility")]
        public Input<Inputs.CloudAwsAccountRealtimeVisibilityGetArgs>? RealtimeVisibility { get; set; }

        [Input("sensorManagement")]
        public Input<Inputs.CloudAwsAccountSensorManagementGetArgs>? SensorManagement { get; set; }

        [Input("targetOuses")]
        private InputList<string>? _targetOuses;

        /// <summary>
        /// The list of target Organizational Units
        /// </summary>
        public InputList<string> TargetOuses
        {
            get => _targetOuses ?? (_targetOuses = new InputList<string>());
            set => _targetOuses = value;
        }

        public CloudAwsAccountState()
        {
        }
        public static new CloudAwsAccountState Empty => new CloudAwsAccountState();
    }
}
