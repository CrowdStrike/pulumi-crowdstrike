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
    public sealed class GetCloudAwsAccountAccountResult
    {
        /// <summary>
        /// The AWS Account ID
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
        /// </summary>
        public readonly string AccountType;
        /// <summary>
        /// Whether asset inventory is enabled
        /// </summary>
        public readonly bool AssetInventoryEnabled;
        /// <summary>
        /// The name of the CloudTrail S3 bucket used for real-time visibility
        /// </summary>
        public readonly string CloudtrailBucketName;
        /// <summary>
        /// The AWS region of the CloudTrail bucket
        /// </summary>
        public readonly string CloudtrailRegion;
        /// <summary>
        /// Whether Data Security Posture Management is enabled
        /// </summary>
        public readonly bool DspmEnabled;
        /// <summary>
        /// The ARN of the IAM role to be used by CrowdStrike DSPM
        /// </summary>
        public readonly string DspmRoleArn;
        /// <summary>
        /// The name of the IAM role to be used by CrowdStrike DSPM
        /// </summary>
        public readonly string DspmRoleName;
        /// <summary>
        /// The ARN of the Amazon EventBridge used by CrowdStrike to forward messages
        /// </summary>
        public readonly string EventbusArn;
        /// <summary>
        /// The name of the Amazon EventBridge used by CrowdStrike to forward messages
        /// </summary>
        public readonly string EventbusName;
        /// <summary>
        /// The external ID used to assume the AWS IAM role
        /// </summary>
        public readonly string ExternalId;
        /// <summary>
        /// The ARN of the AWS IAM role used to access this AWS account
        /// </summary>
        public readonly string IamRoleArn;
        /// <summary>
        /// The name of the AWS IAM role used to access this AWS account
        /// </summary>
        public readonly string IamRoleName;
        /// <summary>
        /// Whether Identity Protection is enabled
        /// </summary>
        public readonly bool IdpEnabled;
        /// <summary>
        /// The ARN of the intermediate role used to assume the AWS IAM role
        /// </summary>
        public readonly string IntermediateRoleArn;
        /// <summary>
        /// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
        /// </summary>
        public readonly bool IsOrganizationManagementAccount;
        /// <summary>
        /// The AWS Organization ID
        /// </summary>
        public readonly string OrganizationId;
        /// <summary>
        /// Whether real-time visibility is enabled
        /// </summary>
        public readonly bool RealtimeVisibilityEnabled;
        /// <summary>
        /// Whether 1-click sensor deployment is enabled
        /// </summary>
        public readonly bool SensorManagementEnabled;
        /// <summary>
        /// The list of AWS Organizational Units (OUs) targeted for this account
        /// </summary>
        public readonly ImmutableArray<string> TargetOuses;

        [OutputConstructor]
        private GetCloudAwsAccountAccountResult(
            string accountId,

            string accountType,

            bool assetInventoryEnabled,

            string cloudtrailBucketName,

            string cloudtrailRegion,

            bool dspmEnabled,

            string dspmRoleArn,

            string dspmRoleName,

            string eventbusArn,

            string eventbusName,

            string externalId,

            string iamRoleArn,

            string iamRoleName,

            bool idpEnabled,

            string intermediateRoleArn,

            bool isOrganizationManagementAccount,

            string organizationId,

            bool realtimeVisibilityEnabled,

            bool sensorManagementEnabled,

            ImmutableArray<string> targetOuses)
        {
            AccountId = accountId;
            AccountType = accountType;
            AssetInventoryEnabled = assetInventoryEnabled;
            CloudtrailBucketName = cloudtrailBucketName;
            CloudtrailRegion = cloudtrailRegion;
            DspmEnabled = dspmEnabled;
            DspmRoleArn = dspmRoleArn;
            DspmRoleName = dspmRoleName;
            EventbusArn = eventbusArn;
            EventbusName = eventbusName;
            ExternalId = externalId;
            IamRoleArn = iamRoleArn;
            IamRoleName = iamRoleName;
            IdpEnabled = idpEnabled;
            IntermediateRoleArn = intermediateRoleArn;
            IsOrganizationManagementAccount = isOrganizationManagementAccount;
            OrganizationId = organizationId;
            RealtimeVisibilityEnabled = realtimeVisibilityEnabled;
            SensorManagementEnabled = sensorManagementEnabled;
            TargetOuses = targetOuses;
        }
    }
}
