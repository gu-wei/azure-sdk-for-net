// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.SiteRecovery;

namespace Microsoft.Azure.Management.SiteRecovery
{
    public partial class SiteRecoveryManagementClient : ServiceClient<SiteRecoveryManagementClient>, ISiteRecoveryManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _resourceGroupName;
        
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }
        
        private string _resourceName;
        
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }
        
        private string _resourceNamespace;
        
        public string ResourceNamespace
        {
            get { return this._resourceNamespace; }
            set { this._resourceNamespace = value; }
        }
        
        private string _resourceType;
        
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }
        
        private IAlertSettingsOperations _alertSettings;
        
        /// <summary>
        /// Definition of alert settings operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual IAlertSettingsOperations AlertSettings
        {
            get { return this._alertSettings; }
        }
        
        private IEventOperations _events;
        
        /// <summary>
        /// Definition of event operations for the Site Recovery extension.
        /// </summary>
        public virtual IEventOperations Events
        {
            get { return this._events; }
        }
        
        private IFabricOperations _fabrics;
        
        /// <summary>
        /// Definition of fabric operations for the Site Recovery extension.
        /// </summary>
        public virtual IFabricOperations Fabrics
        {
            get { return this._fabrics; }
        }
        
        private IJobOperations _jobs;
        
        /// <summary>
        /// Definition for Job Operations.
        /// </summary>
        public virtual IJobOperations Jobs
        {
            get { return this._jobs; }
        }
        
        private ILogicalNetworkOperations _logicalNetwork;
        
        /// <summary>
        /// Definition of Logical Network operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual ILogicalNetworkOperations LogicalNetwork
        {
            get { return this._logicalNetwork; }
        }
        
        private INetworkMappingOperations _networkMapping;
        
        /// <summary>
        /// Definition of NetworkMapping operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual INetworkMappingOperations NetworkMapping
        {
            get { return this._networkMapping; }
        }
        
        private INetworkOperations _network;
        
        /// <summary>
        /// Definition of Network operations for the Site Recovery extension.
        /// </summary>
        public virtual INetworkOperations Network
        {
            get { return this._network; }
        }
        
        private IPolicyOperations _policies;
        
        /// <summary>
        /// Definition of Policy operations for the Site Recovery extension.
        /// </summary>
        public virtual IPolicyOperations Policies
        {
            get { return this._policies; }
        }
        
        private IProtectableItemOperations _protectableItem;
        
        /// <summary>
        /// Definition of Protectable Item operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual IProtectableItemOperations ProtectableItem
        {
            get { return this._protectableItem; }
        }
        
        private IProtectionContainerMappingOperations _protectionContainerMapping;
        
        /// <summary>
        /// Definition of Protection Container mapping operations for the Site
        /// Recovery extension.
        /// </summary>
        public virtual IProtectionContainerMappingOperations ProtectionContainerMapping
        {
            get { return this._protectionContainerMapping; }
        }
        
        private IProtectionContainerOperations _protectionContainer;
        
        /// <summary>
        /// Definition of Protection Container operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual IProtectionContainerOperations ProtectionContainer
        {
            get { return this._protectionContainer; }
        }
        
        private IRecoveryPlanOperations _recoveryPlan;
        
        /// <summary>
        /// Definition of recovery plan operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual IRecoveryPlanOperations RecoveryPlan
        {
            get { return this._recoveryPlan; }
        }
        
        private IRecoveryPointOperations _recoveryPoint;
        
        /// <summary>
        /// Definition of recovery point operations for Site recovery extension.
        /// </summary>
        public virtual IRecoveryPointOperations RecoveryPoint
        {
            get { return this._recoveryPoint; }
        }
        
        private IRecoveryServicesProviderOperations _recoveryServicesProvider;
        
        /// <summary>
        /// Definition of provider operations for the Site Recovery extension.
        /// </summary>
        public virtual IRecoveryServicesProviderOperations RecoveryServicesProvider
        {
            get { return this._recoveryServicesProvider; }
        }
        
        private IReplicationProtectedItemOperations _replicationProtectedItem;
        
        /// <summary>
        /// Definition of Replication protected item operations for the Site
        /// Recovery extension.
        /// </summary>
        public virtual IReplicationProtectedItemOperations ReplicationProtectedItem
        {
            get { return this._replicationProtectedItem; }
        }
        
        private IStorageMappingOperations _storageMapping;
        
        /// <summary>
        /// Definition of storage mapping operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual IStorageMappingOperations StorageMapping
        {
            get { return this._storageMapping; }
        }
        
        private IStorageOperations _storage;
        
        /// <summary>
        /// Definition of storage operations for the Site Recovery extension.
        /// </summary>
        public virtual IStorageOperations Storage
        {
            get { return this._storage; }
        }
        
        private IVCenterOperations _vCenters;
        
        /// <summary>
        /// Definition of vCenter entity operations for the Site Recovery
        /// extension.
        /// </summary>
        public virtual IVCenterOperations VCenters
        {
            get { return this._vCenters; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SiteRecoveryManagementClient
        /// class.
        /// </summary>
        public SiteRecoveryManagementClient()
            : base()
        {
            this._alertSettings = new AlertSettingsOperations(this);
            this._events = new EventOperations(this);
            this._fabrics = new FabricOperations(this);
            this._jobs = new JobOperations(this);
            this._logicalNetwork = new LogicalNetworkOperations(this);
            this._networkMapping = new NetworkMappingOperations(this);
            this._network = new NetworkOperations(this);
            this._policies = new PolicyOperations(this);
            this._protectableItem = new ProtectableItemOperations(this);
            this._protectionContainerMapping = new ProtectionContainerMappingOperations(this);
            this._protectionContainer = new ProtectionContainerOperations(this);
            this._recoveryPlan = new RecoveryPlanOperations(this);
            this._recoveryPoint = new RecoveryPointOperations(this);
            this._recoveryServicesProvider = new RecoveryServicesProviderOperations(this);
            this._replicationProtectedItem = new ReplicationProtectedItemOperations(this);
            this._storageMapping = new StorageMappingOperations(this);
            this._storage = new StorageOperations(this);
            this._vCenters = new VCenterOperations(this);
            this._apiVersion = "2015-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SiteRecoveryManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='resourceType'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public SiteRecoveryManagementClient(string resourceName, string resourceGroupName, string resourceNamespace, string resourceType, SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException("resourceType");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._resourceNamespace = resourceNamespace;
            this._resourceType = resourceType;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SiteRecoveryManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='resourceType'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public SiteRecoveryManagementClient(string resourceName, string resourceGroupName, string resourceNamespace, string resourceType, SubscriptionCloudCredentials credentials)
            : this()
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException("resourceType");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._resourceNamespace = resourceNamespace;
            this._resourceType = resourceType;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SiteRecoveryManagementClient
        /// class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SiteRecoveryManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._alertSettings = new AlertSettingsOperations(this);
            this._events = new EventOperations(this);
            this._fabrics = new FabricOperations(this);
            this._jobs = new JobOperations(this);
            this._logicalNetwork = new LogicalNetworkOperations(this);
            this._networkMapping = new NetworkMappingOperations(this);
            this._network = new NetworkOperations(this);
            this._policies = new PolicyOperations(this);
            this._protectableItem = new ProtectableItemOperations(this);
            this._protectionContainerMapping = new ProtectionContainerMappingOperations(this);
            this._protectionContainer = new ProtectionContainerOperations(this);
            this._recoveryPlan = new RecoveryPlanOperations(this);
            this._recoveryPoint = new RecoveryPointOperations(this);
            this._recoveryServicesProvider = new RecoveryServicesProviderOperations(this);
            this._replicationProtectedItem = new ReplicationProtectedItemOperations(this);
            this._storageMapping = new StorageMappingOperations(this);
            this._storage = new StorageOperations(this);
            this._vCenters = new VCenterOperations(this);
            this._apiVersion = "2015-01-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the SiteRecoveryManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='resourceType'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SiteRecoveryManagementClient(string resourceName, string resourceGroupName, string resourceNamespace, string resourceType, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException("resourceType");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._resourceNamespace = resourceNamespace;
            this._resourceType = resourceType;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the SiteRecoveryManagementClient
        /// class.
        /// </summary>
        /// <param name='resourceName'>
        /// Required.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required.
        /// </param>
        /// <param name='resourceNamespace'>
        /// Required.
        /// </param>
        /// <param name='resourceType'>
        /// Required.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public SiteRecoveryManagementClient(string resourceName, string resourceGroupName, string resourceNamespace, string resourceType, SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException("resourceName");
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException("resourceType");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._resourceName = resourceName;
            this._resourceGroupName = resourceGroupName;
            this._resourceNamespace = resourceNamespace;
            this._resourceType = resourceType;
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// SiteRecoveryManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of SiteRecoveryManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<SiteRecoveryManagementClient> client)
        {
            base.Clone(client);
            
            if (client is SiteRecoveryManagementClient)
            {
                SiteRecoveryManagementClient clonedClient = ((SiteRecoveryManagementClient)client);
                
                clonedClient._resourceName = this._resourceName;
                clonedClient._resourceGroupName = this._resourceGroupName;
                clonedClient._resourceNamespace = this._resourceNamespace;
                clonedClient._resourceType = this._resourceType;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
