# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import builtins
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

__all__ = ['ProviderArgs', 'Provider']

@pulumi.input_type
class ProviderArgs:
    def __init__(__self__, *,
                 client_id: Optional[pulumi.Input[builtins.str]] = None,
                 client_secret: Optional[pulumi.Input[builtins.str]] = None,
                 cloud: Optional[pulumi.Input[builtins.str]] = None,
                 member_cid: Optional[pulumi.Input[builtins.str]] = None):
        """
        The set of arguments for constructing a Provider resource.
        :param pulumi.Input[builtins.str] client_id: Falcon Client Id for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_ID environment variable when left
               blank.
        :param pulumi.Input[builtins.str] client_secret: Falcon Client Secret used for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_SECRET environment variable
               when left blank.
        :param pulumi.Input[builtins.str] cloud: Falcon Cloud to authenticate to. Valid values are autodiscover, us-1, us-2, eu-1, us-gov-1. Will use FALCON_CLOUD
               environment variable when left blank.
        :param pulumi.Input[builtins.str] member_cid: For MSSP Master CIDs, optionally lock the token to act on behalf of this member CID
        """
        if client_id is not None:
            pulumi.set(__self__, "client_id", client_id)
        if client_secret is not None:
            pulumi.set(__self__, "client_secret", client_secret)
        if cloud is not None:
            pulumi.set(__self__, "cloud", cloud)
        if member_cid is not None:
            pulumi.set(__self__, "member_cid", member_cid)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Falcon Client Id for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_ID environment variable when left
        blank.
        """
        return pulumi.get(self, "client_id")

    @client_id.setter
    def client_id(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "client_id", value)

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Falcon Client Secret used for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_SECRET environment variable
        when left blank.
        """
        return pulumi.get(self, "client_secret")

    @client_secret.setter
    def client_secret(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "client_secret", value)

    @property
    @pulumi.getter
    def cloud(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        Falcon Cloud to authenticate to. Valid values are autodiscover, us-1, us-2, eu-1, us-gov-1. Will use FALCON_CLOUD
        environment variable when left blank.
        """
        return pulumi.get(self, "cloud")

    @cloud.setter
    def cloud(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "cloud", value)

    @property
    @pulumi.getter(name="memberCid")
    def member_cid(self) -> Optional[pulumi.Input[builtins.str]]:
        """
        For MSSP Master CIDs, optionally lock the token to act on behalf of this member CID
        """
        return pulumi.get(self, "member_cid")

    @member_cid.setter
    def member_cid(self, value: Optional[pulumi.Input[builtins.str]]):
        pulumi.set(self, "member_cid", value)


class Provider(pulumi.ProviderResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 client_id: Optional[pulumi.Input[builtins.str]] = None,
                 client_secret: Optional[pulumi.Input[builtins.str]] = None,
                 cloud: Optional[pulumi.Input[builtins.str]] = None,
                 member_cid: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        """
        The provider type for the crowdstrike package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[builtins.str] client_id: Falcon Client Id for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_ID environment variable when left
               blank.
        :param pulumi.Input[builtins.str] client_secret: Falcon Client Secret used for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_SECRET environment variable
               when left blank.
        :param pulumi.Input[builtins.str] cloud: Falcon Cloud to authenticate to. Valid values are autodiscover, us-1, us-2, eu-1, us-gov-1. Will use FALCON_CLOUD
               environment variable when left blank.
        :param pulumi.Input[builtins.str] member_cid: For MSSP Master CIDs, optionally lock the token to act on behalf of this member CID
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ProviderArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        The provider type for the crowdstrike package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param ProviderArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProviderArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 client_id: Optional[pulumi.Input[builtins.str]] = None,
                 client_secret: Optional[pulumi.Input[builtins.str]] = None,
                 cloud: Optional[pulumi.Input[builtins.str]] = None,
                 member_cid: Optional[pulumi.Input[builtins.str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProviderArgs.__new__(ProviderArgs)

            __props__.__dict__["client_id"] = None if client_id is None else pulumi.Output.secret(client_id)
            __props__.__dict__["client_secret"] = None if client_secret is None else pulumi.Output.secret(client_secret)
            __props__.__dict__["cloud"] = cloud
            __props__.__dict__["member_cid"] = member_cid
        secret_opts = pulumi.ResourceOptions(additional_secret_outputs=["clientId", "clientSecret"])
        opts = pulumi.ResourceOptions.merge(opts, secret_opts)
        super(Provider, __self__).__init__(
            'crowdstrike',
            resource_name,
            __props__,
            opts)

    @property
    @pulumi.getter(name="clientId")
    def client_id(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Falcon Client Id for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_ID environment variable when left
        blank.
        """
        return pulumi.get(self, "client_id")

    @property
    @pulumi.getter(name="clientSecret")
    def client_secret(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Falcon Client Secret used for authenticating to the CrowdStrike APIs. Will use FALCON_CLIENT_SECRET environment variable
        when left blank.
        """
        return pulumi.get(self, "client_secret")

    @property
    @pulumi.getter
    def cloud(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        Falcon Cloud to authenticate to. Valid values are autodiscover, us-1, us-2, eu-1, us-gov-1. Will use FALCON_CLOUD
        environment variable when left blank.
        """
        return pulumi.get(self, "cloud")

    @property
    @pulumi.getter(name="memberCid")
    def member_cid(self) -> pulumi.Output[Optional[builtins.str]]:
        """
        For MSSP Master CIDs, optionally lock the token to act on behalf of this member CID
        """
        return pulumi.get(self, "member_cid")

