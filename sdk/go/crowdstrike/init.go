// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package crowdstrike

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/crowdstrike/pulumi-crowdstrike/sdk/go/crowdstrike/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "crowdstrike:index/filevantagePolicy:FilevantagePolicy":
		r = &FilevantagePolicy{}
	case "crowdstrike:index/filevantageRuleGroup:FilevantageRuleGroup":
		r = &FilevantageRuleGroup{}
	case "crowdstrike:index/hostGroup:HostGroup":
		r = &HostGroup{}
	case "crowdstrike:index/preventionPolicyLinux:PreventionPolicyLinux":
		r = &PreventionPolicyLinux{}
	case "crowdstrike:index/preventionPolicyMac:PreventionPolicyMac":
		r = &PreventionPolicyMac{}
	case "crowdstrike:index/preventionPolicyWindows:PreventionPolicyWindows":
		r = &PreventionPolicyWindows{}
	case "crowdstrike:index/sensorUpdatePolicy:SensorUpdatePolicy":
		r = &SensorUpdatePolicy{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

type pkg struct {
	version semver.Version
}

func (p *pkg) Version() semver.Version {
	return p.version
}

func (p *pkg) ConstructProvider(ctx *pulumi.Context, name, typ, urn string) (pulumi.ProviderResource, error) {
	if typ != "pulumi:providers:crowdstrike" {
		return nil, fmt.Errorf("unknown provider type: %s", typ)
	}

	r := &Provider{}
	err := ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return r, err
}

func init() {
	version, err := internal.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"crowdstrike",
		"index/filevantagePolicy",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"crowdstrike",
		"index/filevantageRuleGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"crowdstrike",
		"index/hostGroup",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"crowdstrike",
		"index/preventionPolicyLinux",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"crowdstrike",
		"index/preventionPolicyMac",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"crowdstrike",
		"index/preventionPolicyWindows",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"crowdstrike",
		"index/sensorUpdatePolicy",
		&module{version},
	)
	pulumi.RegisterResourcePackage(
		"crowdstrike",
		&pkg{version},
	)
}
