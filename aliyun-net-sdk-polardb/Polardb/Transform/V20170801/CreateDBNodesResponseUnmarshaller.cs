/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class CreateDBNodesResponseUnmarshaller
    {
        public static CreateDBNodesResponse Unmarshall(UnmarshallerContext context)
        {
			CreateDBNodesResponse createDBNodesResponse = new CreateDBNodesResponse();

			createDBNodesResponse.HttpResponse = context.HttpResponse;
			createDBNodesResponse.RequestId = context.StringValue("CreateDBNodes.RequestId");
			createDBNodesResponse.DBClusterId = context.StringValue("CreateDBNodes.DBClusterId");
			createDBNodesResponse.OrderId = context.StringValue("CreateDBNodes.OrderId");

			List<string> createDBNodesResponse_dBNodeIds = new List<string>();
			for (int i = 0; i < context.Length("CreateDBNodes.DBNodeIds.Length"); i++) {
				createDBNodesResponse_dBNodeIds.Add(context.StringValue("CreateDBNodes.DBNodeIds["+ i +"]"));
			}
			createDBNodesResponse.DBNodeIds = createDBNodesResponse_dBNodeIds;
        
			return createDBNodesResponse;
        }
    }
}
