namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Represents a ApplicationGroup definition.</summary>
    public partial class ApplicationGroup :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroup,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.TrackedResource();

        /// <summary>Resource Type of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType? ApplicationGroupType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).ApplicationGroupType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).ApplicationGroupType = value; }

        /// <summary>Description of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).Description = value; }

        /// <summary>Friendly name of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).FriendlyName = value; }

        /// <summary>HostPool arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string HostPoolArmPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).HostPoolArmPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).HostPoolArmPath = value; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Id; }

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResourceInternal)__trackedResource).Location = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ApplicationGroupProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for WorkspaceArmPath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupInternal.WorkspaceArmPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).WorkspaceArmPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).WorkspaceArmPath = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupProperties _property;

        /// <summary>Detailed properties for ApplicationGroup</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ApplicationGroupProperties()); set => this._property = value; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResourceInternal)__trackedResource).Tag = value; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IResourceInternal)__trackedResource).Type; }

        /// <summary>Workspace arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string WorkspaceArmPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupPropertiesInternal)Property).WorkspaceArmPath; }

        /// <summary>Creates an new <see cref="ApplicationGroup" /> instance.</summary>
        public ApplicationGroup()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Represents a ApplicationGroup definition.
    public partial interface IApplicationGroup :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResource
    {
        /// <summary>Resource Type of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource Type of ApplicationGroup.",
        SerializedName = @"applicationGroupType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType? ApplicationGroupType { get; set; }
        /// <summary>Description of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of ApplicationGroup.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Friendly name of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of ApplicationGroup.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>HostPool arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"HostPool arm path of ApplicationGroup.",
        SerializedName = @"hostPoolArmPath",
        PossibleTypes = new [] { typeof(string) })]
        string HostPoolArmPath { get; set; }
        /// <summary>Workspace arm path of ApplicationGroup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Workspace arm path of ApplicationGroup.",
        SerializedName = @"workspaceArmPath",
        PossibleTypes = new [] { typeof(string) })]
        string WorkspaceArmPath { get;  }

    }
    /// Represents a ApplicationGroup definition.
    internal partial interface IApplicationGroupInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.ITrackedResourceInternal
    {
        /// <summary>Resource Type of ApplicationGroup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ApplicationGroupType? ApplicationGroupType { get; set; }
        /// <summary>Description of ApplicationGroup.</summary>
        string Description { get; set; }
        /// <summary>Friendly name of ApplicationGroup.</summary>
        string FriendlyName { get; set; }
        /// <summary>HostPool arm path of ApplicationGroup.</summary>
        string HostPoolArmPath { get; set; }
        /// <summary>Detailed properties for ApplicationGroup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20191210Preview.IApplicationGroupProperties Property { get; set; }
        /// <summary>Workspace arm path of ApplicationGroup.</summary>
        string WorkspaceArmPath { get; set; }

    }
}