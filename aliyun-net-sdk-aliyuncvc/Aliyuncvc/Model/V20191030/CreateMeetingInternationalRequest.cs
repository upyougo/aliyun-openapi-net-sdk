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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.aliyuncvc.Transform;
using Aliyun.Acs.aliyuncvc.Transform.V20191030;

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
    public class CreateMeetingInternationalRequest : RpcAcsRequest<CreateMeetingInternationalResponse>
    {
        public CreateMeetingInternationalRequest()
            : base("aliyuncvc", "2019-10-30", "CreateMeetingInternational", "aliyuncvc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string meetingName;

		private string userId;

		private string openPasswordFlag;

		private string password;

		public string MeetingName
		{
			get
			{
				return meetingName;
			}
			set	
			{
				meetingName = value;
				DictionaryUtil.Add(BodyParameters, "MeetingName", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value);
			}
		}

		public string OpenPasswordFlag
		{
			get
			{
				return openPasswordFlag;
			}
			set	
			{
				openPasswordFlag = value;
				DictionaryUtil.Add(BodyParameters, "OpenPasswordFlag", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(BodyParameters, "Password", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateMeetingInternationalResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateMeetingInternationalResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
