// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automanage.Models
{
    /// <summary> The Service Principal Id for the subscription. </summary>
    public partial class AutomanageServicePrincipalData : ResourceData
    {
        /// <summary> Initializes a new instance of AutomanageServicePrincipalData. </summary>
        public AutomanageServicePrincipalData()
        {
        }

        /// <summary> Initializes a new instance of AutomanageServicePrincipalData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="servicePrincipalId"> The Service Principal Id for the subscription. </param>
        /// <param name="isAuthorizationSet"> Returns the contributor RBAC Role exist or not for the Service Principal Id. </param>
        internal AutomanageServicePrincipalData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string servicePrincipalId, bool? isAuthorizationSet) : base(id, name, resourceType, systemData)
        {
            ServicePrincipalId = servicePrincipalId;
            IsAuthorizationSet = isAuthorizationSet;
        }

        /// <summary> The Service Principal Id for the subscription. </summary>
        public string ServicePrincipalId { get; }
        /// <summary> Returns the contributor RBAC Role exist or not for the Service Principal Id. </summary>
        public bool? IsAuthorizationSet { get; }
    }
}
