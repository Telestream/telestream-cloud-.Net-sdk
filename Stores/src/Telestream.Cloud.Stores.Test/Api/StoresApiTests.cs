/* 
 * API
 *
 * API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Telestream.Cloud.Stores.Client;
using Telestream.Cloud.Stores.Api;
using Telestream.Cloud.Stores.Model;

namespace Telestream.Cloud.Stores.Test
{
    /// <summary>
    ///  Class for testing StoresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StoresApiTests
    {
        private StoresApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StoresApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StoresApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' StoresApi
            //Assert.IsInstanceOfType(typeof(StoresApi), instance, "instance is a StoresApi");
        }

        
        /// <summary>
        /// Test CreateStore
        /// </summary>
        [Test]
        public void CreateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Store storeBody = null;
            //var response = instance.CreateStore(storeBody);
            //Assert.IsInstanceOf<Store> (response, "response is Store");
        }
        
        /// <summary>
        /// Test CreateStoreClientLink
        /// </summary>
        [Test]
        public void CreateStoreClientLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string serviceName = null;
            //string serviceId = null;
            //instance.CreateStoreClientLink(storeId, serviceName, serviceId);
            
        }
        
        /// <summary>
        /// Test CreateWatchRule
        /// </summary>
        [Test]
        public void CreateWatchRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WatchRule watchRuleBody = null;
            //var response = instance.CreateWatchRule(watchRuleBody);
            //Assert.IsInstanceOf<WatchRule> (response, "response is WatchRule");
        }
        
        /// <summary>
        /// Test DeleteStore
        /// </summary>
        [Test]
        public void DeleteStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteStore(id);
            
        }
        
        /// <summary>
        /// Test DeleteStoreClientLink
        /// </summary>
        [Test]
        public void DeleteStoreClientLinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string storeId = null;
            //string serviceName = null;
            //string serviceId = null;
            //instance.DeleteStoreClientLink(storeId, serviceName, serviceId);
            
        }
        
        /// <summary>
        /// Test DeleteWatchRule
        /// </summary>
        [Test]
        public void DeleteWatchRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteWatchRule(id);
            
        }
        
        /// <summary>
        /// Test GetObjectUrl
        /// </summary>
        [Test]
        public void GetObjectUrlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string path = null;
            //string expiresIn = null;
            //var response = instance.GetObjectUrl(id, path, expiresIn);
            //Assert.IsInstanceOf<ObjectURL> (response, "response is ObjectURL");
        }
        
        /// <summary>
        /// Test GetStore
        /// </summary>
        [Test]
        public void GetStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetStore(id);
            //Assert.IsInstanceOf<Store> (response, "response is Store");
        }
        
        /// <summary>
        /// Test GetStoreIdsForClient
        /// </summary>
        [Test]
        public void GetStoreIdsForClientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceName = null;
            //string serviceId = null;
            //var response = instance.GetStoreIdsForClient(serviceName, serviceId);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetStores
        /// </summary>
        [Test]
        public void GetStoresTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bucketName = null;
            //string provider = null;
            //var response = instance.GetStores(bucketName, provider);
            //Assert.IsInstanceOf<List<Store>> (response, "response is List<Store>");
        }
        
        /// <summary>
        /// Test GetWatchRule
        /// </summary>
        [Test]
        public void GetWatchRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetWatchRule(id);
            //Assert.IsInstanceOf<WatchRule> (response, "response is WatchRule");
        }
        
        /// <summary>
        /// Test GetWatchRules
        /// </summary>
        [Test]
        public void GetWatchRulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serviceId = null;
            //string storeId = null;
            //var response = instance.GetWatchRules(serviceId, storeId);
            //Assert.IsInstanceOf<List<WatchRule>> (response, "response is List<WatchRule>");
        }
        
        /// <summary>
        /// Test SyncWatchRule
        /// </summary>
        [Test]
        public void SyncWatchRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.SyncWatchRule(id);
            
        }
        
        /// <summary>
        /// Test UpdateStore
        /// </summary>
        [Test]
        public void UpdateStoreTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Store storeBody = null;
            //var response = instance.UpdateStore(id, storeBody);
            //Assert.IsInstanceOf<Store> (response, "response is Store");
        }
        
        /// <summary>
        /// Test UpdateWatchRule
        /// </summary>
        [Test]
        public void UpdateWatchRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //WatchRule watchRuleBody = null;
            //var response = instance.UpdateWatchRule(id, watchRuleBody);
            //Assert.IsInstanceOf<WatchRule> (response, "response is WatchRule");
        }
        
        /// <summary>
        /// Test ValidateBucket
        /// </summary>
        [Test]
        public void ValidateBucketTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ValidateBucketBody validateBucketBody = null;
            //var response = instance.ValidateBucket(validateBucketBody);
            //Assert.IsInstanceOf<ValidateBucketResponse> (response, "response is ValidateBucketResponse");
        }
        
    }

}
