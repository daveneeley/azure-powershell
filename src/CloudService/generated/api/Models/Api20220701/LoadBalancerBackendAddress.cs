// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>Load balancer backend addresses.</summary>
    public partial class LoadBalancerBackendAddress :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddress,
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressInternal
    {

        /// <summary>
        /// A list of administrative states which once set can override health probe so that Load Balancer will always forward new
        /// connections to backend, or deny new connections and reset existing connections.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState? AdminState { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).AdminState; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).AdminState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState)""); }

        /// <summary>IP Address belonging to the referenced virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string IPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).IPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).IPAddress = value ?? null; }

        /// <summary>Collection of inbound NAT rule port mappings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] InboundNatRulesPortMapping { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).InboundNatRulesPortMapping; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string LoadBalancerFrontendIPConfigurationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).LoadBalancerFrontendIPConfigurationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).LoadBalancerFrontendIPConfigurationId = value ?? null; }

        /// <summary>Internal Acessors for InboundNatRulesPortMapping</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressInternal.InboundNatRulesPortMapping { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).InboundNatRulesPortMapping; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).InboundNatRulesPortMapping = value; }

        /// <summary>Internal Acessors for LoadBalancerFrontendIPConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressInternal.LoadBalancerFrontendIPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).LoadBalancerFrontendIPConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).LoadBalancerFrontendIPConfiguration = value; }

        /// <summary>Internal Acessors for NetworkInterfaceIPConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressInternal.NetworkInterfaceIPConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).NetworkInterfaceIPConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).NetworkInterfaceIPConfiguration = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormat Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.LoadBalancerBackendAddressPropertiesFormat()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Subnet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressInternal.Subnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).Subnet = value; }

        /// <summary>Internal Acessors for VirtualNetwork</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressInternal.VirtualNetwork { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).VirtualNetwork; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).VirtualNetwork = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the backend address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string NetworkInterfaceIPConfigurationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).NetworkInterfaceIPConfigurationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).NetworkInterfaceIPConfigurationId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormat _property;

        /// <summary>Properties of load balancer backend address pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormat Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.LoadBalancerBackendAddressPropertiesFormat()); set => this._property = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string SubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).SubnetId = value ?? null; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Origin(Microsoft.Azure.PowerShell.Cmdlets.CloudService.PropertyOrigin.Inlined)]
        public string VirtualNetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).VirtualNetworkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormatInternal)Property).VirtualNetworkId = value ?? null; }

        /// <summary>Creates an new <see cref="LoadBalancerBackendAddress" /> instance.</summary>
        public LoadBalancerBackendAddress()
        {

        }
    }
    /// Load balancer backend addresses.
    public partial interface ILoadBalancerBackendAddress :
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A list of administrative states which once set can override health probe so that Load Balancer will always forward new
        /// connections to backend, or deny new connections and reset existing connections.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A list of administrative states which once set can override health probe so that Load Balancer will always forward new connections to backend, or deny new connections and reset existing connections.",
        SerializedName = @"adminState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState? AdminState { get; set; }
        /// <summary>IP Address belonging to the referenced virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"IP Address belonging to the referenced virtual network.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>Collection of inbound NAT rule port mappings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Collection of inbound NAT rule port mappings.",
        SerializedName = @"inboundNatRulesPortMapping",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping) })]
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] InboundNatRulesPortMapping { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string LoadBalancerFrontendIPConfigurationId { get; set; }
        /// <summary>Name of the backend address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the backend address.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInterfaceIPConfigurationId { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualNetworkId { get; set; }

    }
    /// Load balancer backend addresses.
    internal partial interface ILoadBalancerBackendAddressInternal

    {
        /// <summary>
        /// A list of administrative states which once set can override health probe so that Load Balancer will always forward new
        /// connections to backend, or deny new connections and reset existing connections.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Support.LoadBalancerBackendAddressAdminState? AdminState { get; set; }
        /// <summary>IP Address belonging to the referenced virtual network.</summary>
        string IPAddress { get; set; }
        /// <summary>Collection of inbound NAT rule port mappings.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INatRulePortMapping[] InboundNatRulesPortMapping { get; set; }
        /// <summary>
        /// Reference to the frontend ip address configuration defined in regional loadbalancer.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated LoadBalancerFrontendIPConfiguration { get; set; }
        /// <summary>Resource ID.</summary>
        string LoadBalancerFrontendIPConfigurationId { get; set; }
        /// <summary>Name of the backend address.</summary>
        string Name { get; set; }
        /// <summary>Reference to IP address defined in network interfaces.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated NetworkInterfaceIPConfiguration { get; set; }
        /// <summary>Resource ID.</summary>
        string NetworkInterfaceIPConfigurationId { get; set; }
        /// <summary>Properties of load balancer backend address pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ILoadBalancerBackendAddressPropertiesFormat Property { get; set; }
        /// <summary>Reference to an existing subnet.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated Subnet { get; set; }
        /// <summary>Resource ID.</summary>
        string SubnetId { get; set; }
        /// <summary>Reference to an existing virtual network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.ISubResourceAutoGenerated VirtualNetwork { get; set; }
        /// <summary>Resource ID.</summary>
        string VirtualNetworkId { get; set; }

    }
}