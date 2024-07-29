# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['FilevantagePolicyArgs', 'FilevantagePolicy']

@pulumi.input_type
class FilevantagePolicyArgs:
    def __init__(__self__, *,
                 platform_name: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 rule_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 scheduled_exclusions: Optional[pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]]] = None):
        """
        The set of arguments for constructing a FilevantagePolicy resource.
        :param pulumi.Input[str] platform_name: Platform for the filevantage policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input[str] description: Description of the filevantage policy.
        :param pulumi.Input[bool] enabled: Enable the filevantage policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the filevantage policy.
        :param pulumi.Input[str] name: Name of the filevantage policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] rule_groups: Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
        :param pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]] scheduled_exclusions: Scheduled exclusions for the filevantage policy.
        """
        pulumi.set(__self__, "platform_name", platform_name)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if host_groups is not None:
            pulumi.set(__self__, "host_groups", host_groups)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if rule_groups is not None:
            pulumi.set(__self__, "rule_groups", rule_groups)
        if scheduled_exclusions is not None:
            pulumi.set(__self__, "scheduled_exclusions", scheduled_exclusions)

    @property
    @pulumi.getter(name="platformName")
    def platform_name(self) -> pulumi.Input[str]:
        """
        Platform for the filevantage policy to manage. (Windows, Mac, Linux)
        """
        return pulumi.get(self, "platform_name")

    @platform_name.setter
    def platform_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "platform_name", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the filevantage policy.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Enable the filevantage policy.
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="hostGroups")
    def host_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Host Group ids to attach to the filevantage policy.
        """
        return pulumi.get(self, "host_groups")

    @host_groups.setter
    def host_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "host_groups", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the filevantage policy.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="ruleGroups")
    def rule_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
        """
        return pulumi.get(self, "rule_groups")

    @rule_groups.setter
    def rule_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "rule_groups", value)

    @property
    @pulumi.getter(name="scheduledExclusions")
    def scheduled_exclusions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]]]:
        """
        Scheduled exclusions for the filevantage policy.
        """
        return pulumi.get(self, "scheduled_exclusions")

    @scheduled_exclusions.setter
    def scheduled_exclusions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]]]):
        pulumi.set(self, "scheduled_exclusions", value)


@pulumi.input_type
class _FilevantagePolicyState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 last_updated: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 platform_name: Optional[pulumi.Input[str]] = None,
                 rule_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 scheduled_exclusions: Optional[pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]]] = None):
        """
        Input properties used for looking up and filtering FilevantagePolicy resources.
        :param pulumi.Input[str] description: Description of the filevantage policy.
        :param pulumi.Input[bool] enabled: Enable the filevantage policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the filevantage policy.
        :param pulumi.Input[str] name: Name of the filevantage policy.
        :param pulumi.Input[str] platform_name: Platform for the filevantage policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] rule_groups: Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
        :param pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]] scheduled_exclusions: Scheduled exclusions for the filevantage policy.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if host_groups is not None:
            pulumi.set(__self__, "host_groups", host_groups)
        if last_updated is not None:
            pulumi.set(__self__, "last_updated", last_updated)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if platform_name is not None:
            pulumi.set(__self__, "platform_name", platform_name)
        if rule_groups is not None:
            pulumi.set(__self__, "rule_groups", rule_groups)
        if scheduled_exclusions is not None:
            pulumi.set(__self__, "scheduled_exclusions", scheduled_exclusions)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the filevantage policy.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Enable the filevantage policy.
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="hostGroups")
    def host_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Host Group ids to attach to the filevantage policy.
        """
        return pulumi.get(self, "host_groups")

    @host_groups.setter
    def host_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "host_groups", value)

    @property
    @pulumi.getter(name="lastUpdated")
    def last_updated(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "last_updated")

    @last_updated.setter
    def last_updated(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "last_updated", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the filevantage policy.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="platformName")
    def platform_name(self) -> Optional[pulumi.Input[str]]:
        """
        Platform for the filevantage policy to manage. (Windows, Mac, Linux)
        """
        return pulumi.get(self, "platform_name")

    @platform_name.setter
    def platform_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "platform_name", value)

    @property
    @pulumi.getter(name="ruleGroups")
    def rule_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
        """
        return pulumi.get(self, "rule_groups")

    @rule_groups.setter
    def rule_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "rule_groups", value)

    @property
    @pulumi.getter(name="scheduledExclusions")
    def scheduled_exclusions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]]]:
        """
        Scheduled exclusions for the filevantage policy.
        """
        return pulumi.get(self, "scheduled_exclusions")

    @scheduled_exclusions.setter
    def scheduled_exclusions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FilevantagePolicyScheduledExclusionArgs']]]]):
        pulumi.set(self, "scheduled_exclusions", value)


class FilevantagePolicy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 platform_name: Optional[pulumi.Input[str]] = None,
                 rule_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 scheduled_exclusions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FilevantagePolicyScheduledExclusionArgs']]]]] = None,
                 __props__=None):
        """
        This resource allows management of a FileVantage policy. A FileVantage policy is a collection of file integrity rules and rule groups that you can apply to host groups.

        ## API Scopes

        The following API scopes are required:

        - Falcon FileVantage | Read & Write

        ## Import

        filvantage policy can be imported by specifying the policy id.

        ```sh
        $ pulumi import crowdstrike:index/filevantagePolicy:FilevantagePolicy example 7fb858a949034a0cbca175f660f1e769
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the filevantage policy.
        :param pulumi.Input[bool] enabled: Enable the filevantage policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the filevantage policy.
        :param pulumi.Input[str] name: Name of the filevantage policy.
        :param pulumi.Input[str] platform_name: Platform for the filevantage policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] rule_groups: Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FilevantagePolicyScheduledExclusionArgs']]]] scheduled_exclusions: Scheduled exclusions for the filevantage policy.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FilevantagePolicyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource allows management of a FileVantage policy. A FileVantage policy is a collection of file integrity rules and rule groups that you can apply to host groups.

        ## API Scopes

        The following API scopes are required:

        - Falcon FileVantage | Read & Write

        ## Import

        filvantage policy can be imported by specifying the policy id.

        ```sh
        $ pulumi import crowdstrike:index/filevantagePolicy:FilevantagePolicy example 7fb858a949034a0cbca175f660f1e769
        ```

        :param str resource_name: The name of the resource.
        :param FilevantagePolicyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FilevantagePolicyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 platform_name: Optional[pulumi.Input[str]] = None,
                 rule_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 scheduled_exclusions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FilevantagePolicyScheduledExclusionArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FilevantagePolicyArgs.__new__(FilevantagePolicyArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["host_groups"] = host_groups
            __props__.__dict__["name"] = name
            if platform_name is None and not opts.urn:
                raise TypeError("Missing required property 'platform_name'")
            __props__.__dict__["platform_name"] = platform_name
            __props__.__dict__["rule_groups"] = rule_groups
            __props__.__dict__["scheduled_exclusions"] = scheduled_exclusions
            __props__.__dict__["last_updated"] = None
        super(FilevantagePolicy, __self__).__init__(
            'crowdstrike:index/filevantagePolicy:FilevantagePolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            last_updated: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            platform_name: Optional[pulumi.Input[str]] = None,
            rule_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            scheduled_exclusions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FilevantagePolicyScheduledExclusionArgs']]]]] = None) -> 'FilevantagePolicy':
        """
        Get an existing FilevantagePolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the filevantage policy.
        :param pulumi.Input[bool] enabled: Enable the filevantage policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the filevantage policy.
        :param pulumi.Input[str] name: Name of the filevantage policy.
        :param pulumi.Input[str] platform_name: Platform for the filevantage policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input[Sequence[pulumi.Input[str]]] rule_groups: Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['FilevantagePolicyScheduledExclusionArgs']]]] scheduled_exclusions: Scheduled exclusions for the filevantage policy.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FilevantagePolicyState.__new__(_FilevantagePolicyState)

        __props__.__dict__["description"] = description
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["host_groups"] = host_groups
        __props__.__dict__["last_updated"] = last_updated
        __props__.__dict__["name"] = name
        __props__.__dict__["platform_name"] = platform_name
        __props__.__dict__["rule_groups"] = rule_groups
        __props__.__dict__["scheduled_exclusions"] = scheduled_exclusions
        return FilevantagePolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the filevantage policy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        Enable the filevantage policy.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="hostGroups")
    def host_groups(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Host Group ids to attach to the filevantage policy.
        """
        return pulumi.get(self, "host_groups")

    @property
    @pulumi.getter(name="lastUpdated")
    def last_updated(self) -> pulumi.Output[str]:
        return pulumi.get(self, "last_updated")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the filevantage policy.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="platformName")
    def platform_name(self) -> pulumi.Output[str]:
        """
        Platform for the filevantage policy to manage. (Windows, Mac, Linux)
        """
        return pulumi.get(self, "platform_name")

    @property
    @pulumi.getter(name="ruleGroups")
    def rule_groups(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Rule Group ids to attach to the filevantage policy. Precedence is based on the order of the list. Rule groups must be the same type as the policy.
        """
        return pulumi.get(self, "rule_groups")

    @property
    @pulumi.getter(name="scheduledExclusions")
    def scheduled_exclusions(self) -> pulumi.Output[Optional[Sequence['outputs.FilevantagePolicyScheduledExclusion']]]:
        """
        Scheduled exclusions for the filevantage policy.
        """
        return pulumi.get(self, "scheduled_exclusions")

