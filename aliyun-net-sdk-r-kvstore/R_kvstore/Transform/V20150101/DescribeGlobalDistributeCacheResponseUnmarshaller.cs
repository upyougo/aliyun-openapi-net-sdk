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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeGlobalDistributeCacheResponseUnmarshaller
    {
        public static DescribeGlobalDistributeCacheResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGlobalDistributeCacheResponse describeGlobalDistributeCacheResponse = new DescribeGlobalDistributeCacheResponse();

			describeGlobalDistributeCacheResponse.HttpResponse = context.HttpResponse;
			describeGlobalDistributeCacheResponse.RequestId = context.StringValue("DescribeGlobalDistributeCache.RequestId");
			describeGlobalDistributeCacheResponse.TotalRecordCount = context.IntegerValue("DescribeGlobalDistributeCache.TotalRecordCount");
			describeGlobalDistributeCacheResponse.PageNumber = context.IntegerValue("DescribeGlobalDistributeCache.PageNumber");
			describeGlobalDistributeCacheResponse.PageSize = context.IntegerValue("DescribeGlobalDistributeCache.PageSize");

			List<DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache> describeGlobalDistributeCacheResponse_globalDistributeCaches = new List<DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache>();
			for (int i = 0; i < context.Length("DescribeGlobalDistributeCache.GlobalDistributeCaches.Length"); i++) {
				DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache globalDistributeCache = new DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache();
				globalDistributeCache.GlobalInstanceId = context.StringValue("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].GlobalInstanceId");
				globalDistributeCache.GlobalInstanceName = context.StringValue("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].GlobalInstanceName");
				globalDistributeCache.Status = context.StringValue("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].Status");

				List<DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache.DescribeGlobalDistributeCache_SubInstance> globalDistributeCache_subInstances = new List<DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache.DescribeGlobalDistributeCache_SubInstance>();
				for (int j = 0; j < context.Length("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].SubInstances.Length"); j++) {
					DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache.DescribeGlobalDistributeCache_SubInstance subInstance = new DescribeGlobalDistributeCacheResponse.DescribeGlobalDistributeCache_GlobalDistributeCache.DescribeGlobalDistributeCache_SubInstance();
					subInstance.GlobalInstanceId = context.StringValue("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].SubInstances["+ j +"].GlobalInstanceId");
					subInstance.InstanceID = context.StringValue("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].SubInstances["+ j +"].InstanceID");
					subInstance.RegionId = context.StringValue("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].SubInstances["+ j +"].RegionId");
					subInstance.InstanceStatus = context.StringValue("DescribeGlobalDistributeCache.GlobalDistributeCaches["+ i +"].SubInstances["+ j +"].InstanceStatus");

					globalDistributeCache_subInstances.Add(subInstance);
				}
				globalDistributeCache.SubInstances = globalDistributeCache_subInstances;

				describeGlobalDistributeCacheResponse_globalDistributeCaches.Add(globalDistributeCache);
			}
			describeGlobalDistributeCacheResponse.GlobalDistributeCaches = describeGlobalDistributeCacheResponse_globalDistributeCaches;
        
			return describeGlobalDistributeCacheResponse;
        }
    }
}
