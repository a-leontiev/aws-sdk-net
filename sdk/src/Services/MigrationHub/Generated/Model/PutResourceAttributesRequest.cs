/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourceAttributes operation.
    /// Provides identifying details of the resource being migrated so that it can be associated
    /// in the Application Discovery Service (ADS)'s repository. This association occurs asynchronously
    /// after <code>PutResourceAttributes</code> returns.
    /// 
    ///  <important> 
    /// <para>
    /// Keep in mind that subsequent calls to PutResourceAttributes will override previously
    /// stored attributes. For example, if it is first called with a MAC address, but later,
    /// it is desired to <i>add</i> an IP address, it will then be required to call it with
    /// <i>both</i> the IP and MAC addresses to prevent overiding the MAC address.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// Because this is an asynchronous call, it will always return 200, whether an association
    /// occurs or not. To confirm if an association was found based on the provided details,
    /// call <code>ListAssociatedResource</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutResourceAttributesRequest : AmazonMigrationHubRequest
    {
        private bool? _dryRun;
        private string _migrationTaskName;
        private string _progressUpdateStream;
        private List<ResourceAttribute> _resourceAttributeList = new List<ResourceAttribute>();

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Optional boolean flag to indicate whether any effect should take place. Used to test
        /// if the caller has permission to make the call.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// Unique identifier that references the migration task.
        /// </para>
        /// </summary>
        public string MigrationTaskName
        {
            get { return this._migrationTaskName; }
            set { this._migrationTaskName = value; }
        }

        // Check to see if MigrationTaskName property is set
        internal bool IsSetMigrationTaskName()
        {
            return this._migrationTaskName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// The name of the ProgressUpdateStream. 
        /// </para>
        /// </summary>
        public string ProgressUpdateStream
        {
            get { return this._progressUpdateStream; }
            set { this._progressUpdateStream = value; }
        }

        // Check to see if ProgressUpdateStream property is set
        internal bool IsSetProgressUpdateStream()
        {
            return this._progressUpdateStream != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAttributeList. 
        /// <para>
        /// Information about the resource that is being migrated. This data will be used to map
        /// the task to a resource in the Application Discovery Service (ADS)'s repository.
        /// </para>
        /// </summary>
        public List<ResourceAttribute> ResourceAttributeList
        {
            get { return this._resourceAttributeList; }
            set { this._resourceAttributeList = value; }
        }

        // Check to see if ResourceAttributeList property is set
        internal bool IsSetResourceAttributeList()
        {
            return this._resourceAttributeList != null && this._resourceAttributeList.Count > 0; 
        }

    }
}