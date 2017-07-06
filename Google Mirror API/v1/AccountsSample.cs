﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 07/06/2017 15:31:21
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Mirror v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Interacts with Glass users via the timeline.
// API Documentation Link https://developers.google.com/glass
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Mirror/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Mirror.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Mirror.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Mirror.v1;
using Google.Apis.Mirror.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Mirrorv1.Methods
{
  
    public static class AccountsSample
    {


        /// <summary>
        /// Inserts a new account for a user 
        /// Documentation https://developers.google.com/mirror/v1/reference/accounts/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Mirror service.</param>  
        /// <param name="userToken">The ID for the user.</param>
        /// <param name="accountType">Account type to be passed to Android Account Manager.</param>
        /// <param name="accountName">The name of the account to be passed to the Android Account Manager.</param>
        /// <param name="body">A valid Mirror v1 body.</param>
        /// <returns>AccountResponse</returns>
        public static Account Insert(MirrorService service, string userToken, string accountType, string accountName, Account body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userToken == null)
                    throw new ArgumentNullException(userToken);
                if (accountType == null)
                    throw new ArgumentNullException(accountType);
                if (accountName == null)
                    throw new ArgumentNullException(accountName);

                // Make the request.
                return service.Accounts.Insert(body, userToken, accountType, accountName).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Accounts.Insert failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}