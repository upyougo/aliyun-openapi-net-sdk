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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext context)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = context.HttpResponse;
			listUsersResponse.Code = context.IntegerValue("ListUsers.Code");
			listUsersResponse.ErrorMsg = context.StringValue("ListUsers.ErrorMsg");
			listUsersResponse.PageNumber = context.IntegerValue("ListUsers.PageNumber");
			listUsersResponse.PageSize = context.IntegerValue("ListUsers.PageSize");
			listUsersResponse.RequestId = context.StringValue("ListUsers.RequestId");
			listUsersResponse.TotalCount = context.LongValue("ListUsers.TotalCount");

			List<ListUsersResponse.ListUsers_ListUserResponse> listUsersResponse_data = new List<ListUsersResponse.ListUsers_ListUserResponse>();
			for (int i = 0; i < context.Length("ListUsers.Data.Length"); i++) {
				ListUsersResponse.ListUsers_ListUserResponse listUserResponse = new ListUsersResponse.ListUsers_ListUserResponse();
				listUserResponse.UserId = context.StringValue("ListUsers.Data["+ i +"].UserId");
				listUserResponse.UserType = context.StringValue("ListUsers.Data["+ i +"].UserType");
				listUserResponse.RealName = context.StringValue("ListUsers.Data["+ i +"].RealName");

				listUsersResponse_data.Add(listUserResponse);
			}
			listUsersResponse.Data = listUsersResponse_data;
        
			return listUsersResponse;
        }
    }
}
