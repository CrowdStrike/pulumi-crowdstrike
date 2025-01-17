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

// This resource allows management of a FileVantage policy. A FileVantage policy is a collection of file integrity rules and rule groups that you can apply to host groups.
//
// ## API Scopes
//
// The following API scopes are required:
//
// - Falcon FileVantage | Read & Write
//
// ## Import
//
// filvantage policy can be imported by specifying the policy id.
//
// ```sh
// $ pulumi import crowdstrike:index/filevantagePolicy:FilevantagePolicy example 7fb858a949034a0cbca175f660f1e769
// ```
type FilevantagePolicy struct {
	pulumi.CustomResourceState

	// Description of the filevantage policy.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Enable the filevantage policy.
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Host Group ids to attach to the filevantage policy.
	HostGroups  pulumi.StringArrayOutput `pulumi:"hostGroups"`
	LastUpdated pulumi.StringOutput      `pulumi:"lastUpdated"`
	// Name of the filevantage policy.
	Name pulumi.StringOutput `pulumi:"name"`
	// Platform for the filevantage policy to manage. (Windows, Mac, Linux)
	PlatformName pulumi.StringOutput `pulumi:"platformName"`
	// Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
	RuleGroups pulumi.StringArrayOutput `pulumi:"ruleGroups"`
	// Scheduled exclusions for the filevantage policy.
	ScheduledExclusions FilevantagePolicyScheduledExclusionArrayOutput `pulumi:"scheduledExclusions"`
}

// NewFilevantagePolicy registers a new resource with the given unique name, arguments, and options.
func NewFilevantagePolicy(ctx *pulumi.Context,
	name string, args *FilevantagePolicyArgs, opts ...pulumi.ResourceOption) (*FilevantagePolicy, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PlatformName == nil {
		return nil, errors.New("invalid value for required argument 'PlatformName'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource FilevantagePolicy
	err := ctx.RegisterResource("crowdstrike:index/filevantagePolicy:FilevantagePolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFilevantagePolicy gets an existing FilevantagePolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFilevantagePolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FilevantagePolicyState, opts ...pulumi.ResourceOption) (*FilevantagePolicy, error) {
	var resource FilevantagePolicy
	err := ctx.ReadResource("crowdstrike:index/filevantagePolicy:FilevantagePolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FilevantagePolicy resources.
type filevantagePolicyState struct {
	// Description of the filevantage policy.
	Description *string `pulumi:"description"`
	// Enable the filevantage policy.
	Enabled *bool `pulumi:"enabled"`
	// Host Group ids to attach to the filevantage policy.
	HostGroups  []string `pulumi:"hostGroups"`
	LastUpdated *string  `pulumi:"lastUpdated"`
	// Name of the filevantage policy.
	Name *string `pulumi:"name"`
	// Platform for the filevantage policy to manage. (Windows, Mac, Linux)
	PlatformName *string `pulumi:"platformName"`
	// Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
	RuleGroups []string `pulumi:"ruleGroups"`
	// Scheduled exclusions for the filevantage policy.
	ScheduledExclusions []FilevantagePolicyScheduledExclusion `pulumi:"scheduledExclusions"`
}

type FilevantagePolicyState struct {
	// Description of the filevantage policy.
	Description pulumi.StringPtrInput
	// Enable the filevantage policy.
	Enabled pulumi.BoolPtrInput
	// Host Group ids to attach to the filevantage policy.
	HostGroups  pulumi.StringArrayInput
	LastUpdated pulumi.StringPtrInput
	// Name of the filevantage policy.
	Name pulumi.StringPtrInput
	// Platform for the filevantage policy to manage. (Windows, Mac, Linux)
	PlatformName pulumi.StringPtrInput
	// Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
	RuleGroups pulumi.StringArrayInput
	// Scheduled exclusions for the filevantage policy.
	ScheduledExclusions FilevantagePolicyScheduledExclusionArrayInput
}

func (FilevantagePolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*filevantagePolicyState)(nil)).Elem()
}

type filevantagePolicyArgs struct {
	// Description of the filevantage policy.
	Description *string `pulumi:"description"`
	// Enable the filevantage policy.
	Enabled *bool `pulumi:"enabled"`
	// Host Group ids to attach to the filevantage policy.
	HostGroups []string `pulumi:"hostGroups"`
	// Name of the filevantage policy.
	Name *string `pulumi:"name"`
	// Platform for the filevantage policy to manage. (Windows, Mac, Linux)
	PlatformName string `pulumi:"platformName"`
	// Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
	RuleGroups []string `pulumi:"ruleGroups"`
	// Scheduled exclusions for the filevantage policy.
	ScheduledExclusions []FilevantagePolicyScheduledExclusion `pulumi:"scheduledExclusions"`
}

// The set of arguments for constructing a FilevantagePolicy resource.
type FilevantagePolicyArgs struct {
	// Description of the filevantage policy.
	Description pulumi.StringPtrInput
	// Enable the filevantage policy.
	Enabled pulumi.BoolPtrInput
	// Host Group ids to attach to the filevantage policy.
	HostGroups pulumi.StringArrayInput
	// Name of the filevantage policy.
	Name pulumi.StringPtrInput
	// Platform for the filevantage policy to manage. (Windows, Mac, Linux)
	PlatformName pulumi.StringInput
	// Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
	RuleGroups pulumi.StringArrayInput
	// Scheduled exclusions for the filevantage policy.
	ScheduledExclusions FilevantagePolicyScheduledExclusionArrayInput
}

func (FilevantagePolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*filevantagePolicyArgs)(nil)).Elem()
}

type FilevantagePolicyInput interface {
	pulumi.Input

	ToFilevantagePolicyOutput() FilevantagePolicyOutput
	ToFilevantagePolicyOutputWithContext(ctx context.Context) FilevantagePolicyOutput
}

func (*FilevantagePolicy) ElementType() reflect.Type {
	return reflect.TypeOf((**FilevantagePolicy)(nil)).Elem()
}

func (i *FilevantagePolicy) ToFilevantagePolicyOutput() FilevantagePolicyOutput {
	return i.ToFilevantagePolicyOutputWithContext(context.Background())
}

func (i *FilevantagePolicy) ToFilevantagePolicyOutputWithContext(ctx context.Context) FilevantagePolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FilevantagePolicyOutput)
}

// FilevantagePolicyArrayInput is an input type that accepts FilevantagePolicyArray and FilevantagePolicyArrayOutput values.
// You can construct a concrete instance of `FilevantagePolicyArrayInput` via:
//
//	FilevantagePolicyArray{ FilevantagePolicyArgs{...} }
type FilevantagePolicyArrayInput interface {
	pulumi.Input

	ToFilevantagePolicyArrayOutput() FilevantagePolicyArrayOutput
	ToFilevantagePolicyArrayOutputWithContext(context.Context) FilevantagePolicyArrayOutput
}

type FilevantagePolicyArray []FilevantagePolicyInput

func (FilevantagePolicyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FilevantagePolicy)(nil)).Elem()
}

func (i FilevantagePolicyArray) ToFilevantagePolicyArrayOutput() FilevantagePolicyArrayOutput {
	return i.ToFilevantagePolicyArrayOutputWithContext(context.Background())
}

func (i FilevantagePolicyArray) ToFilevantagePolicyArrayOutputWithContext(ctx context.Context) FilevantagePolicyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FilevantagePolicyArrayOutput)
}

// FilevantagePolicyMapInput is an input type that accepts FilevantagePolicyMap and FilevantagePolicyMapOutput values.
// You can construct a concrete instance of `FilevantagePolicyMapInput` via:
//
//	FilevantagePolicyMap{ "key": FilevantagePolicyArgs{...} }
type FilevantagePolicyMapInput interface {
	pulumi.Input

	ToFilevantagePolicyMapOutput() FilevantagePolicyMapOutput
	ToFilevantagePolicyMapOutputWithContext(context.Context) FilevantagePolicyMapOutput
}

type FilevantagePolicyMap map[string]FilevantagePolicyInput

func (FilevantagePolicyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FilevantagePolicy)(nil)).Elem()
}

func (i FilevantagePolicyMap) ToFilevantagePolicyMapOutput() FilevantagePolicyMapOutput {
	return i.ToFilevantagePolicyMapOutputWithContext(context.Background())
}

func (i FilevantagePolicyMap) ToFilevantagePolicyMapOutputWithContext(ctx context.Context) FilevantagePolicyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FilevantagePolicyMapOutput)
}

type FilevantagePolicyOutput struct{ *pulumi.OutputState }

func (FilevantagePolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FilevantagePolicy)(nil)).Elem()
}

func (o FilevantagePolicyOutput) ToFilevantagePolicyOutput() FilevantagePolicyOutput {
	return o
}

func (o FilevantagePolicyOutput) ToFilevantagePolicyOutputWithContext(ctx context.Context) FilevantagePolicyOutput {
	return o
}

// Description of the filevantage policy.
func (o FilevantagePolicyOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *FilevantagePolicy) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Enable the filevantage policy.
func (o FilevantagePolicyOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *FilevantagePolicy) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Host Group ids to attach to the filevantage policy.
func (o FilevantagePolicyOutput) HostGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *FilevantagePolicy) pulumi.StringArrayOutput { return v.HostGroups }).(pulumi.StringArrayOutput)
}

func (o FilevantagePolicyOutput) LastUpdated() pulumi.StringOutput {
	return o.ApplyT(func(v *FilevantagePolicy) pulumi.StringOutput { return v.LastUpdated }).(pulumi.StringOutput)
}

// Name of the filevantage policy.
func (o FilevantagePolicyOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *FilevantagePolicy) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Platform for the filevantage policy to manage. (Windows, Mac, Linux)
func (o FilevantagePolicyOutput) PlatformName() pulumi.StringOutput {
	return o.ApplyT(func(v *FilevantagePolicy) pulumi.StringOutput { return v.PlatformName }).(pulumi.StringOutput)
}

// Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
func (o FilevantagePolicyOutput) RuleGroups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *FilevantagePolicy) pulumi.StringArrayOutput { return v.RuleGroups }).(pulumi.StringArrayOutput)
}

// Scheduled exclusions for the filevantage policy.
func (o FilevantagePolicyOutput) ScheduledExclusions() FilevantagePolicyScheduledExclusionArrayOutput {
	return o.ApplyT(func(v *FilevantagePolicy) FilevantagePolicyScheduledExclusionArrayOutput {
		return v.ScheduledExclusions
	}).(FilevantagePolicyScheduledExclusionArrayOutput)
}

type FilevantagePolicyArrayOutput struct{ *pulumi.OutputState }

func (FilevantagePolicyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FilevantagePolicy)(nil)).Elem()
}

func (o FilevantagePolicyArrayOutput) ToFilevantagePolicyArrayOutput() FilevantagePolicyArrayOutput {
	return o
}

func (o FilevantagePolicyArrayOutput) ToFilevantagePolicyArrayOutputWithContext(ctx context.Context) FilevantagePolicyArrayOutput {
	return o
}

func (o FilevantagePolicyArrayOutput) Index(i pulumi.IntInput) FilevantagePolicyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *FilevantagePolicy {
		return vs[0].([]*FilevantagePolicy)[vs[1].(int)]
	}).(FilevantagePolicyOutput)
}

type FilevantagePolicyMapOutput struct{ *pulumi.OutputState }

func (FilevantagePolicyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FilevantagePolicy)(nil)).Elem()
}

func (o FilevantagePolicyMapOutput) ToFilevantagePolicyMapOutput() FilevantagePolicyMapOutput {
	return o
}

func (o FilevantagePolicyMapOutput) ToFilevantagePolicyMapOutputWithContext(ctx context.Context) FilevantagePolicyMapOutput {
	return o
}

func (o FilevantagePolicyMapOutput) MapIndex(k pulumi.StringInput) FilevantagePolicyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *FilevantagePolicy {
		return vs[0].(map[string]*FilevantagePolicy)[vs[1].(string)]
	}).(FilevantagePolicyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FilevantagePolicyInput)(nil)).Elem(), &FilevantagePolicy{})
	pulumi.RegisterInputType(reflect.TypeOf((*FilevantagePolicyArrayInput)(nil)).Elem(), FilevantagePolicyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FilevantagePolicyMapInput)(nil)).Elem(), FilevantagePolicyMap{})
	pulumi.RegisterOutputType(FilevantagePolicyOutput{})
	pulumi.RegisterOutputType(FilevantagePolicyArrayOutput{})
	pulumi.RegisterOutputType(FilevantagePolicyMapOutput{})
}
