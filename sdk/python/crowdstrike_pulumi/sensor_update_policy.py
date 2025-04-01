# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import sys
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
if sys.version_info >= (3, 11):
    from typing import NotRequired, TypedDict, TypeAlias
else:
    from typing_extensions import NotRequired, TypedDict, TypeAlias
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['SensorUpdatePolicyArgs', 'SensorUpdatePolicy']

@pulumi.input_type
class SensorUpdatePolicyArgs:
    def __init__(__self__, *,
                 build: pulumi.Input[str],
                 platform_name: pulumi.Input[str],
                 schedule: pulumi.Input['SensorUpdatePolicyScheduleArgs'],
                 build_arm64: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 uninstall_protection: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a SensorUpdatePolicy resource.
        :param pulumi.Input[str] build: Sensor build to use for the sensor update policy.
        :param pulumi.Input[str] platform_name: Platform for the sensor update policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input['SensorUpdatePolicyScheduleArgs'] schedule: Prohibit sensor updates during a set of time blocks.
        :param pulumi.Input[str] build_arm64: Sensor arm64 build to use for the sensor update policy (Linux only). Required if platform_name is Linux.
        :param pulumi.Input[str] description: Description of the sensor update policy.
        :param pulumi.Input[bool] enabled: Enable the sensor update policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the sensor update policy.
        :param pulumi.Input[str] name: Name of the sensor update policy.
        :param pulumi.Input[bool] uninstall_protection: Enable uninstall protection. Windows and Mac only.
        """
        pulumi.set(__self__, "build", build)
        pulumi.set(__self__, "platform_name", platform_name)
        pulumi.set(__self__, "schedule", schedule)
        if build_arm64 is not None:
            pulumi.set(__self__, "build_arm64", build_arm64)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if host_groups is not None:
            pulumi.set(__self__, "host_groups", host_groups)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if uninstall_protection is not None:
            pulumi.set(__self__, "uninstall_protection", uninstall_protection)

    @property
    @pulumi.getter
    def build(self) -> pulumi.Input[str]:
        """
        Sensor build to use for the sensor update policy.
        """
        return pulumi.get(self, "build")

    @build.setter
    def build(self, value: pulumi.Input[str]):
        pulumi.set(self, "build", value)

    @property
    @pulumi.getter(name="platformName")
    def platform_name(self) -> pulumi.Input[str]:
        """
        Platform for the sensor update policy to manage. (Windows, Mac, Linux)
        """
        return pulumi.get(self, "platform_name")

    @platform_name.setter
    def platform_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "platform_name", value)

    @property
    @pulumi.getter
    def schedule(self) -> pulumi.Input['SensorUpdatePolicyScheduleArgs']:
        """
        Prohibit sensor updates during a set of time blocks.
        """
        return pulumi.get(self, "schedule")

    @schedule.setter
    def schedule(self, value: pulumi.Input['SensorUpdatePolicyScheduleArgs']):
        pulumi.set(self, "schedule", value)

    @property
    @pulumi.getter(name="buildArm64")
    def build_arm64(self) -> Optional[pulumi.Input[str]]:
        """
        Sensor arm64 build to use for the sensor update policy (Linux only). Required if platform_name is Linux.
        """
        return pulumi.get(self, "build_arm64")

    @build_arm64.setter
    def build_arm64(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "build_arm64", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the sensor update policy.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Enable the sensor update policy.
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="hostGroups")
    def host_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Host Group ids to attach to the sensor update policy.
        """
        return pulumi.get(self, "host_groups")

    @host_groups.setter
    def host_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "host_groups", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Name of the sensor update policy.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="uninstallProtection")
    def uninstall_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Enable uninstall protection. Windows and Mac only.
        """
        return pulumi.get(self, "uninstall_protection")

    @uninstall_protection.setter
    def uninstall_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "uninstall_protection", value)


@pulumi.input_type
class _SensorUpdatePolicyState:
    def __init__(__self__, *,
                 build: Optional[pulumi.Input[str]] = None,
                 build_arm64: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 last_updated: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 platform_name: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input['SensorUpdatePolicyScheduleArgs']] = None,
                 uninstall_protection: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering SensorUpdatePolicy resources.
        :param pulumi.Input[str] build: Sensor build to use for the sensor update policy.
        :param pulumi.Input[str] build_arm64: Sensor arm64 build to use for the sensor update policy (Linux only). Required if platform_name is Linux.
        :param pulumi.Input[str] description: Description of the sensor update policy.
        :param pulumi.Input[bool] enabled: Enable the sensor update policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the sensor update policy.
        :param pulumi.Input[str] name: Name of the sensor update policy.
        :param pulumi.Input[str] platform_name: Platform for the sensor update policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input['SensorUpdatePolicyScheduleArgs'] schedule: Prohibit sensor updates during a set of time blocks.
        :param pulumi.Input[bool] uninstall_protection: Enable uninstall protection. Windows and Mac only.
        """
        if build is not None:
            pulumi.set(__self__, "build", build)
        if build_arm64 is not None:
            pulumi.set(__self__, "build_arm64", build_arm64)
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
        if schedule is not None:
            pulumi.set(__self__, "schedule", schedule)
        if uninstall_protection is not None:
            pulumi.set(__self__, "uninstall_protection", uninstall_protection)

    @property
    @pulumi.getter
    def build(self) -> Optional[pulumi.Input[str]]:
        """
        Sensor build to use for the sensor update policy.
        """
        return pulumi.get(self, "build")

    @build.setter
    def build(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "build", value)

    @property
    @pulumi.getter(name="buildArm64")
    def build_arm64(self) -> Optional[pulumi.Input[str]]:
        """
        Sensor arm64 build to use for the sensor update policy (Linux only). Required if platform_name is Linux.
        """
        return pulumi.get(self, "build_arm64")

    @build_arm64.setter
    def build_arm64(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "build_arm64", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of the sensor update policy.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Enable the sensor update policy.
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="hostGroups")
    def host_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        Host Group ids to attach to the sensor update policy.
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
        Name of the sensor update policy.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="platformName")
    def platform_name(self) -> Optional[pulumi.Input[str]]:
        """
        Platform for the sensor update policy to manage. (Windows, Mac, Linux)
        """
        return pulumi.get(self, "platform_name")

    @platform_name.setter
    def platform_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "platform_name", value)

    @property
    @pulumi.getter
    def schedule(self) -> Optional[pulumi.Input['SensorUpdatePolicyScheduleArgs']]:
        """
        Prohibit sensor updates during a set of time blocks.
        """
        return pulumi.get(self, "schedule")

    @schedule.setter
    def schedule(self, value: Optional[pulumi.Input['SensorUpdatePolicyScheduleArgs']]):
        pulumi.set(self, "schedule", value)

    @property
    @pulumi.getter(name="uninstallProtection")
    def uninstall_protection(self) -> Optional[pulumi.Input[bool]]:
        """
        Enable uninstall protection. Windows and Mac only.
        """
        return pulumi.get(self, "uninstall_protection")

    @uninstall_protection.setter
    def uninstall_protection(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "uninstall_protection", value)


class SensorUpdatePolicy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 build: Optional[pulumi.Input[str]] = None,
                 build_arm64: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 platform_name: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[Union['SensorUpdatePolicyScheduleArgs', 'SensorUpdatePolicyScheduleArgsDict']]] = None,
                 uninstall_protection: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        This resource allows management of sensor update policies in the CrowdStrike Falcon platform. Sensor update policies allow you to control the update process across a set of hosts.

        ## API Scopes

        The following API scopes are required:

        - Sensor update policies | Read & Write

        ## Import

        sensor update policies can be imported by specifying the policy id.

        ```sh
        $ pulumi import crowdstrike:index/sensorUpdatePolicy:SensorUpdatePolicy example 7fb858a949034a0cbca175f660f1e769
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] build: Sensor build to use for the sensor update policy.
        :param pulumi.Input[str] build_arm64: Sensor arm64 build to use for the sensor update policy (Linux only). Required if platform_name is Linux.
        :param pulumi.Input[str] description: Description of the sensor update policy.
        :param pulumi.Input[bool] enabled: Enable the sensor update policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the sensor update policy.
        :param pulumi.Input[str] name: Name of the sensor update policy.
        :param pulumi.Input[str] platform_name: Platform for the sensor update policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input[Union['SensorUpdatePolicyScheduleArgs', 'SensorUpdatePolicyScheduleArgsDict']] schedule: Prohibit sensor updates during a set of time blocks.
        :param pulumi.Input[bool] uninstall_protection: Enable uninstall protection. Windows and Mac only.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SensorUpdatePolicyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource allows management of sensor update policies in the CrowdStrike Falcon platform. Sensor update policies allow you to control the update process across a set of hosts.

        ## API Scopes

        The following API scopes are required:

        - Sensor update policies | Read & Write

        ## Import

        sensor update policies can be imported by specifying the policy id.

        ```sh
        $ pulumi import crowdstrike:index/sensorUpdatePolicy:SensorUpdatePolicy example 7fb858a949034a0cbca175f660f1e769
        ```

        :param str resource_name: The name of the resource.
        :param SensorUpdatePolicyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SensorUpdatePolicyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 build: Optional[pulumi.Input[str]] = None,
                 build_arm64: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 platform_name: Optional[pulumi.Input[str]] = None,
                 schedule: Optional[pulumi.Input[Union['SensorUpdatePolicyScheduleArgs', 'SensorUpdatePolicyScheduleArgsDict']]] = None,
                 uninstall_protection: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SensorUpdatePolicyArgs.__new__(SensorUpdatePolicyArgs)

            if build is None and not opts.urn:
                raise TypeError("Missing required property 'build'")
            __props__.__dict__["build"] = build
            __props__.__dict__["build_arm64"] = build_arm64
            __props__.__dict__["description"] = description
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["host_groups"] = host_groups
            __props__.__dict__["name"] = name
            if platform_name is None and not opts.urn:
                raise TypeError("Missing required property 'platform_name'")
            __props__.__dict__["platform_name"] = platform_name
            if schedule is None and not opts.urn:
                raise TypeError("Missing required property 'schedule'")
            __props__.__dict__["schedule"] = schedule
            __props__.__dict__["uninstall_protection"] = uninstall_protection
            __props__.__dict__["last_updated"] = None
        super(SensorUpdatePolicy, __self__).__init__(
            'crowdstrike:index/sensorUpdatePolicy:SensorUpdatePolicy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            build: Optional[pulumi.Input[str]] = None,
            build_arm64: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            host_groups: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            last_updated: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            platform_name: Optional[pulumi.Input[str]] = None,
            schedule: Optional[pulumi.Input[Union['SensorUpdatePolicyScheduleArgs', 'SensorUpdatePolicyScheduleArgsDict']]] = None,
            uninstall_protection: Optional[pulumi.Input[bool]] = None) -> 'SensorUpdatePolicy':
        """
        Get an existing SensorUpdatePolicy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] build: Sensor build to use for the sensor update policy.
        :param pulumi.Input[str] build_arm64: Sensor arm64 build to use for the sensor update policy (Linux only). Required if platform_name is Linux.
        :param pulumi.Input[str] description: Description of the sensor update policy.
        :param pulumi.Input[bool] enabled: Enable the sensor update policy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] host_groups: Host Group ids to attach to the sensor update policy.
        :param pulumi.Input[str] name: Name of the sensor update policy.
        :param pulumi.Input[str] platform_name: Platform for the sensor update policy to manage. (Windows, Mac, Linux)
        :param pulumi.Input[Union['SensorUpdatePolicyScheduleArgs', 'SensorUpdatePolicyScheduleArgsDict']] schedule: Prohibit sensor updates during a set of time blocks.
        :param pulumi.Input[bool] uninstall_protection: Enable uninstall protection. Windows and Mac only.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SensorUpdatePolicyState.__new__(_SensorUpdatePolicyState)

        __props__.__dict__["build"] = build
        __props__.__dict__["build_arm64"] = build_arm64
        __props__.__dict__["description"] = description
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["host_groups"] = host_groups
        __props__.__dict__["last_updated"] = last_updated
        __props__.__dict__["name"] = name
        __props__.__dict__["platform_name"] = platform_name
        __props__.__dict__["schedule"] = schedule
        __props__.__dict__["uninstall_protection"] = uninstall_protection
        return SensorUpdatePolicy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def build(self) -> pulumi.Output[str]:
        """
        Sensor build to use for the sensor update policy.
        """
        return pulumi.get(self, "build")

    @property
    @pulumi.getter(name="buildArm64")
    def build_arm64(self) -> pulumi.Output[Optional[str]]:
        """
        Sensor arm64 build to use for the sensor update policy (Linux only). Required if platform_name is Linux.
        """
        return pulumi.get(self, "build_arm64")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of the sensor update policy.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[bool]:
        """
        Enable the sensor update policy.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="hostGroups")
    def host_groups(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        Host Group ids to attach to the sensor update policy.
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
        Name of the sensor update policy.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="platformName")
    def platform_name(self) -> pulumi.Output[str]:
        """
        Platform for the sensor update policy to manage. (Windows, Mac, Linux)
        """
        return pulumi.get(self, "platform_name")

    @property
    @pulumi.getter
    def schedule(self) -> pulumi.Output['outputs.SensorUpdatePolicySchedule']:
        """
        Prohibit sensor updates during a set of time blocks.
        """
        return pulumi.get(self, "schedule")

    @property
    @pulumi.getter(name="uninstallProtection")
    def uninstall_protection(self) -> pulumi.Output[bool]:
        """
        Enable uninstall protection. Windows and Mac only.
        """
        return pulumi.get(self, "uninstall_protection")

