// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package crowdstrike

import (
	"context"
	"reflect"

	"errors"
	"github.com/crowdstrike/pulumi-crowdstrike/sdk/go/crowdstrike/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// This resource allows management of an AWS account in Falcon.
//
// ## API Scopes
//
// The following API scopes are required:
//
// - Cloud security AWS registration | Read & Write
// - CSPM registration | Read & Write
type CloudAwsAccount struct {
	pulumi.CustomResourceState

	// The AWS Account ID
	AccountId pulumi.StringOutput `pulumi:"accountId"`
	// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
	AccountType    pulumi.StringOutput                 `pulumi:"accountType"`
	AssetInventory CloudAwsAccountAssetInventoryOutput `pulumi:"assetInventory"`
	// The name of the CloudTrail S3 bucket used for real-time visibility
	CloudtrailBucketName pulumi.StringOutput       `pulumi:"cloudtrailBucketName"`
	DeploymentMethod     pulumi.StringOutput       `pulumi:"deploymentMethod"`
	Dspm                 CloudAwsAccountDspmOutput `pulumi:"dspm"`
	// The ARN of the IAM role to be used by CrowdStrike Data Security Posture Management
	DspmRoleArn pulumi.StringOutput `pulumi:"dspmRoleArn"`
	// The name of the IAM role to be used by CrowdStrike Data Security Posture Management
	DspmRoleName pulumi.StringOutput `pulumi:"dspmRoleName"`
	// The ARN of the Amazon EventBridge used by CrowdStrike to forward messages
	EventbusArn pulumi.StringOutput `pulumi:"eventbusArn"`
	// The name of the Amazon EventBridge used by CrowdStrike to forward messages
	EventbusName pulumi.StringOutput `pulumi:"eventbusName"`
	// The external ID used to assume the AWS IAM role
	ExternalId pulumi.StringOutput `pulumi:"externalId"`
	// The ARN of the AWS IAM role used to access this AWS account
	IamRoleArn pulumi.StringOutput `pulumi:"iamRoleArn"`
	// The name of the AWS IAM role used to access this AWS account
	IamRoleName pulumi.StringOutput      `pulumi:"iamRoleName"`
	Idp         CloudAwsAccountIdpOutput `pulumi:"idp"`
	// The ARN of the intermediate role used to assume the AWS IAM role
	IntermediateRoleArn pulumi.StringOutput `pulumi:"intermediateRoleArn"`
	// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
	IsOrganizationManagementAccount pulumi.BoolOutput `pulumi:"isOrganizationManagementAccount"`
	// The AWS Organization ID
	OrganizationId     pulumi.StringOutput                     `pulumi:"organizationId"`
	RealtimeVisibility CloudAwsAccountRealtimeVisibilityOutput `pulumi:"realtimeVisibility"`
	SensorManagement   CloudAwsAccountSensorManagementOutput   `pulumi:"sensorManagement"`
	// The list of target Organizational Units
	TargetOuses pulumi.StringArrayOutput `pulumi:"targetOuses"`
}

// NewCloudAwsAccount registers a new resource with the given unique name, arguments, and options.
func NewCloudAwsAccount(ctx *pulumi.Context,
	name string, args *CloudAwsAccountArgs, opts ...pulumi.ResourceOption) (*CloudAwsAccount, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AccountId == nil {
		return nil, errors.New("invalid value for required argument 'AccountId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CloudAwsAccount
	err := ctx.RegisterResource("crowdstrike:index/cloudAwsAccount:CloudAwsAccount", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCloudAwsAccount gets an existing CloudAwsAccount resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCloudAwsAccount(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CloudAwsAccountState, opts ...pulumi.ResourceOption) (*CloudAwsAccount, error) {
	var resource CloudAwsAccount
	err := ctx.ReadResource("crowdstrike:index/cloudAwsAccount:CloudAwsAccount", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CloudAwsAccount resources.
type cloudAwsAccountState struct {
	// The AWS Account ID
	AccountId *string `pulumi:"accountId"`
	// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
	AccountType    *string                        `pulumi:"accountType"`
	AssetInventory *CloudAwsAccountAssetInventory `pulumi:"assetInventory"`
	// The name of the CloudTrail S3 bucket used for real-time visibility
	CloudtrailBucketName *string              `pulumi:"cloudtrailBucketName"`
	DeploymentMethod     *string              `pulumi:"deploymentMethod"`
	Dspm                 *CloudAwsAccountDspm `pulumi:"dspm"`
	// The ARN of the IAM role to be used by CrowdStrike Data Security Posture Management
	DspmRoleArn *string `pulumi:"dspmRoleArn"`
	// The name of the IAM role to be used by CrowdStrike Data Security Posture Management
	DspmRoleName *string `pulumi:"dspmRoleName"`
	// The ARN of the Amazon EventBridge used by CrowdStrike to forward messages
	EventbusArn *string `pulumi:"eventbusArn"`
	// The name of the Amazon EventBridge used by CrowdStrike to forward messages
	EventbusName *string `pulumi:"eventbusName"`
	// The external ID used to assume the AWS IAM role
	ExternalId *string `pulumi:"externalId"`
	// The ARN of the AWS IAM role used to access this AWS account
	IamRoleArn *string `pulumi:"iamRoleArn"`
	// The name of the AWS IAM role used to access this AWS account
	IamRoleName *string             `pulumi:"iamRoleName"`
	Idp         *CloudAwsAccountIdp `pulumi:"idp"`
	// The ARN of the intermediate role used to assume the AWS IAM role
	IntermediateRoleArn *string `pulumi:"intermediateRoleArn"`
	// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
	IsOrganizationManagementAccount *bool `pulumi:"isOrganizationManagementAccount"`
	// The AWS Organization ID
	OrganizationId     *string                            `pulumi:"organizationId"`
	RealtimeVisibility *CloudAwsAccountRealtimeVisibility `pulumi:"realtimeVisibility"`
	SensorManagement   *CloudAwsAccountSensorManagement   `pulumi:"sensorManagement"`
	// The list of target Organizational Units
	TargetOuses []string `pulumi:"targetOuses"`
}

type CloudAwsAccountState struct {
	// The AWS Account ID
	AccountId pulumi.StringPtrInput
	// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
	AccountType    pulumi.StringPtrInput
	AssetInventory CloudAwsAccountAssetInventoryPtrInput
	// The name of the CloudTrail S3 bucket used for real-time visibility
	CloudtrailBucketName pulumi.StringPtrInput
	DeploymentMethod     pulumi.StringPtrInput
	Dspm                 CloudAwsAccountDspmPtrInput
	// The ARN of the IAM role to be used by CrowdStrike Data Security Posture Management
	DspmRoleArn pulumi.StringPtrInput
	// The name of the IAM role to be used by CrowdStrike Data Security Posture Management
	DspmRoleName pulumi.StringPtrInput
	// The ARN of the Amazon EventBridge used by CrowdStrike to forward messages
	EventbusArn pulumi.StringPtrInput
	// The name of the Amazon EventBridge used by CrowdStrike to forward messages
	EventbusName pulumi.StringPtrInput
	// The external ID used to assume the AWS IAM role
	ExternalId pulumi.StringPtrInput
	// The ARN of the AWS IAM role used to access this AWS account
	IamRoleArn pulumi.StringPtrInput
	// The name of the AWS IAM role used to access this AWS account
	IamRoleName pulumi.StringPtrInput
	Idp         CloudAwsAccountIdpPtrInput
	// The ARN of the intermediate role used to assume the AWS IAM role
	IntermediateRoleArn pulumi.StringPtrInput
	// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
	IsOrganizationManagementAccount pulumi.BoolPtrInput
	// The AWS Organization ID
	OrganizationId     pulumi.StringPtrInput
	RealtimeVisibility CloudAwsAccountRealtimeVisibilityPtrInput
	SensorManagement   CloudAwsAccountSensorManagementPtrInput
	// The list of target Organizational Units
	TargetOuses pulumi.StringArrayInput
}

func (CloudAwsAccountState) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudAwsAccountState)(nil)).Elem()
}

type cloudAwsAccountArgs struct {
	// The AWS Account ID
	AccountId string `pulumi:"accountId"`
	// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
	AccountType      *string                        `pulumi:"accountType"`
	AssetInventory   *CloudAwsAccountAssetInventory `pulumi:"assetInventory"`
	DeploymentMethod *string                        `pulumi:"deploymentMethod"`
	Dspm             *CloudAwsAccountDspm           `pulumi:"dspm"`
	Idp              *CloudAwsAccountIdp            `pulumi:"idp"`
	// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
	IsOrganizationManagementAccount *bool `pulumi:"isOrganizationManagementAccount"`
	// The AWS Organization ID
	OrganizationId     *string                            `pulumi:"organizationId"`
	RealtimeVisibility *CloudAwsAccountRealtimeVisibility `pulumi:"realtimeVisibility"`
	SensorManagement   *CloudAwsAccountSensorManagement   `pulumi:"sensorManagement"`
	// The list of target Organizational Units
	TargetOuses []string `pulumi:"targetOuses"`
}

// The set of arguments for constructing a CloudAwsAccount resource.
type CloudAwsAccountArgs struct {
	// The AWS Account ID
	AccountId pulumi.StringInput
	// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
	AccountType      pulumi.StringPtrInput
	AssetInventory   CloudAwsAccountAssetInventoryPtrInput
	DeploymentMethod pulumi.StringPtrInput
	Dspm             CloudAwsAccountDspmPtrInput
	Idp              CloudAwsAccountIdpPtrInput
	// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
	IsOrganizationManagementAccount pulumi.BoolPtrInput
	// The AWS Organization ID
	OrganizationId     pulumi.StringPtrInput
	RealtimeVisibility CloudAwsAccountRealtimeVisibilityPtrInput
	SensorManagement   CloudAwsAccountSensorManagementPtrInput
	// The list of target Organizational Units
	TargetOuses pulumi.StringArrayInput
}

func (CloudAwsAccountArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudAwsAccountArgs)(nil)).Elem()
}

type CloudAwsAccountInput interface {
	pulumi.Input

	ToCloudAwsAccountOutput() CloudAwsAccountOutput
	ToCloudAwsAccountOutputWithContext(ctx context.Context) CloudAwsAccountOutput
}

func (*CloudAwsAccount) ElementType() reflect.Type {
	return reflect.TypeOf((**CloudAwsAccount)(nil)).Elem()
}

func (i *CloudAwsAccount) ToCloudAwsAccountOutput() CloudAwsAccountOutput {
	return i.ToCloudAwsAccountOutputWithContext(context.Background())
}

func (i *CloudAwsAccount) ToCloudAwsAccountOutputWithContext(ctx context.Context) CloudAwsAccountOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudAwsAccountOutput)
}

// CloudAwsAccountArrayInput is an input type that accepts CloudAwsAccountArray and CloudAwsAccountArrayOutput values.
// You can construct a concrete instance of `CloudAwsAccountArrayInput` via:
//
//	CloudAwsAccountArray{ CloudAwsAccountArgs{...} }
type CloudAwsAccountArrayInput interface {
	pulumi.Input

	ToCloudAwsAccountArrayOutput() CloudAwsAccountArrayOutput
	ToCloudAwsAccountArrayOutputWithContext(context.Context) CloudAwsAccountArrayOutput
}

type CloudAwsAccountArray []CloudAwsAccountInput

func (CloudAwsAccountArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CloudAwsAccount)(nil)).Elem()
}

func (i CloudAwsAccountArray) ToCloudAwsAccountArrayOutput() CloudAwsAccountArrayOutput {
	return i.ToCloudAwsAccountArrayOutputWithContext(context.Background())
}

func (i CloudAwsAccountArray) ToCloudAwsAccountArrayOutputWithContext(ctx context.Context) CloudAwsAccountArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudAwsAccountArrayOutput)
}

// CloudAwsAccountMapInput is an input type that accepts CloudAwsAccountMap and CloudAwsAccountMapOutput values.
// You can construct a concrete instance of `CloudAwsAccountMapInput` via:
//
//	CloudAwsAccountMap{ "key": CloudAwsAccountArgs{...} }
type CloudAwsAccountMapInput interface {
	pulumi.Input

	ToCloudAwsAccountMapOutput() CloudAwsAccountMapOutput
	ToCloudAwsAccountMapOutputWithContext(context.Context) CloudAwsAccountMapOutput
}

type CloudAwsAccountMap map[string]CloudAwsAccountInput

func (CloudAwsAccountMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CloudAwsAccount)(nil)).Elem()
}

func (i CloudAwsAccountMap) ToCloudAwsAccountMapOutput() CloudAwsAccountMapOutput {
	return i.ToCloudAwsAccountMapOutputWithContext(context.Background())
}

func (i CloudAwsAccountMap) ToCloudAwsAccountMapOutputWithContext(ctx context.Context) CloudAwsAccountMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudAwsAccountMapOutput)
}

type CloudAwsAccountOutput struct{ *pulumi.OutputState }

func (CloudAwsAccountOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CloudAwsAccount)(nil)).Elem()
}

func (o CloudAwsAccountOutput) ToCloudAwsAccountOutput() CloudAwsAccountOutput {
	return o
}

func (o CloudAwsAccountOutput) ToCloudAwsAccountOutputWithContext(ctx context.Context) CloudAwsAccountOutput {
	return o
}

// The AWS Account ID
func (o CloudAwsAccountOutput) AccountId() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.AccountId }).(pulumi.StringOutput)
}

// The AWS account type. Value is 'commercial' for Commercial cloud accounts. For GovCloud environments, value can be either 'commercial' or 'gov' depending on the account type
func (o CloudAwsAccountOutput) AccountType() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.AccountType }).(pulumi.StringOutput)
}

func (o CloudAwsAccountOutput) AssetInventory() CloudAwsAccountAssetInventoryOutput {
	return o.ApplyT(func(v *CloudAwsAccount) CloudAwsAccountAssetInventoryOutput { return v.AssetInventory }).(CloudAwsAccountAssetInventoryOutput)
}

// The name of the CloudTrail S3 bucket used for real-time visibility
func (o CloudAwsAccountOutput) CloudtrailBucketName() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.CloudtrailBucketName }).(pulumi.StringOutput)
}

func (o CloudAwsAccountOutput) DeploymentMethod() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.DeploymentMethod }).(pulumi.StringOutput)
}

func (o CloudAwsAccountOutput) Dspm() CloudAwsAccountDspmOutput {
	return o.ApplyT(func(v *CloudAwsAccount) CloudAwsAccountDspmOutput { return v.Dspm }).(CloudAwsAccountDspmOutput)
}

// The ARN of the IAM role to be used by CrowdStrike Data Security Posture Management
func (o CloudAwsAccountOutput) DspmRoleArn() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.DspmRoleArn }).(pulumi.StringOutput)
}

// The name of the IAM role to be used by CrowdStrike Data Security Posture Management
func (o CloudAwsAccountOutput) DspmRoleName() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.DspmRoleName }).(pulumi.StringOutput)
}

// The ARN of the Amazon EventBridge used by CrowdStrike to forward messages
func (o CloudAwsAccountOutput) EventbusArn() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.EventbusArn }).(pulumi.StringOutput)
}

// The name of the Amazon EventBridge used by CrowdStrike to forward messages
func (o CloudAwsAccountOutput) EventbusName() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.EventbusName }).(pulumi.StringOutput)
}

// The external ID used to assume the AWS IAM role
func (o CloudAwsAccountOutput) ExternalId() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.ExternalId }).(pulumi.StringOutput)
}

// The ARN of the AWS IAM role used to access this AWS account
func (o CloudAwsAccountOutput) IamRoleArn() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.IamRoleArn }).(pulumi.StringOutput)
}

// The name of the AWS IAM role used to access this AWS account
func (o CloudAwsAccountOutput) IamRoleName() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.IamRoleName }).(pulumi.StringOutput)
}

func (o CloudAwsAccountOutput) Idp() CloudAwsAccountIdpOutput {
	return o.ApplyT(func(v *CloudAwsAccount) CloudAwsAccountIdpOutput { return v.Idp }).(CloudAwsAccountIdpOutput)
}

// The ARN of the intermediate role used to assume the AWS IAM role
func (o CloudAwsAccountOutput) IntermediateRoleArn() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.IntermediateRoleArn }).(pulumi.StringOutput)
}

// Indicates whether this is the management account (formerly known as the root account) of an AWS Organization
func (o CloudAwsAccountOutput) IsOrganizationManagementAccount() pulumi.BoolOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.BoolOutput { return v.IsOrganizationManagementAccount }).(pulumi.BoolOutput)
}

// The AWS Organization ID
func (o CloudAwsAccountOutput) OrganizationId() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringOutput { return v.OrganizationId }).(pulumi.StringOutput)
}

func (o CloudAwsAccountOutput) RealtimeVisibility() CloudAwsAccountRealtimeVisibilityOutput {
	return o.ApplyT(func(v *CloudAwsAccount) CloudAwsAccountRealtimeVisibilityOutput { return v.RealtimeVisibility }).(CloudAwsAccountRealtimeVisibilityOutput)
}

func (o CloudAwsAccountOutput) SensorManagement() CloudAwsAccountSensorManagementOutput {
	return o.ApplyT(func(v *CloudAwsAccount) CloudAwsAccountSensorManagementOutput { return v.SensorManagement }).(CloudAwsAccountSensorManagementOutput)
}

// The list of target Organizational Units
func (o CloudAwsAccountOutput) TargetOuses() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *CloudAwsAccount) pulumi.StringArrayOutput { return v.TargetOuses }).(pulumi.StringArrayOutput)
}

type CloudAwsAccountArrayOutput struct{ *pulumi.OutputState }

func (CloudAwsAccountArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CloudAwsAccount)(nil)).Elem()
}

func (o CloudAwsAccountArrayOutput) ToCloudAwsAccountArrayOutput() CloudAwsAccountArrayOutput {
	return o
}

func (o CloudAwsAccountArrayOutput) ToCloudAwsAccountArrayOutputWithContext(ctx context.Context) CloudAwsAccountArrayOutput {
	return o
}

func (o CloudAwsAccountArrayOutput) Index(i pulumi.IntInput) CloudAwsAccountOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CloudAwsAccount {
		return vs[0].([]*CloudAwsAccount)[vs[1].(int)]
	}).(CloudAwsAccountOutput)
}

type CloudAwsAccountMapOutput struct{ *pulumi.OutputState }

func (CloudAwsAccountMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CloudAwsAccount)(nil)).Elem()
}

func (o CloudAwsAccountMapOutput) ToCloudAwsAccountMapOutput() CloudAwsAccountMapOutput {
	return o
}

func (o CloudAwsAccountMapOutput) ToCloudAwsAccountMapOutputWithContext(ctx context.Context) CloudAwsAccountMapOutput {
	return o
}

func (o CloudAwsAccountMapOutput) MapIndex(k pulumi.StringInput) CloudAwsAccountOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CloudAwsAccount {
		return vs[0].(map[string]*CloudAwsAccount)[vs[1].(string)]
	}).(CloudAwsAccountOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CloudAwsAccountInput)(nil)).Elem(), &CloudAwsAccount{})
	pulumi.RegisterInputType(reflect.TypeOf((*CloudAwsAccountArrayInput)(nil)).Elem(), CloudAwsAccountArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CloudAwsAccountMapInput)(nil)).Elem(), CloudAwsAccountMap{})
	pulumi.RegisterOutputType(CloudAwsAccountOutput{})
	pulumi.RegisterOutputType(CloudAwsAccountArrayOutput{})
	pulumi.RegisterOutputType(CloudAwsAccountMapOutput{})
}
