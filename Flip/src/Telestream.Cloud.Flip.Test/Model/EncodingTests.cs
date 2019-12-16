/* 
 * Flip API
 *
 * Description
 *
 * OpenAPI spec version: 2.0.1
 * Contact: cloudsupport@telestream.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Telestream.Cloud.Flip.Api;
using Telestream.Cloud.Flip.Model;
using Telestream.Cloud.Flip.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Telestream.Cloud.Flip.Test
{
    /// <summary>
    ///  Class for testing Encoding
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EncodingTests
    {
        // TODO uncomment below to declare an instance variable for Encoding
        //private Encoding instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Encoding
            //instance = new Encoding();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Encoding
        /// </summary>
        [Test]
        public void EncodingInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Encoding
            //Assert.IsInstanceOfType<Encoding> (instance, "variable 'instance' is a Encoding");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'AudioBitrate'
        /// </summary>
        [Test]
        public void AudioBitrateTest()
        {
            // TODO unit test for the property 'AudioBitrate'
        }
        /// <summary>
        /// Test the property 'AudioChannels'
        /// </summary>
        [Test]
        public void AudioChannelsTest()
        {
            // TODO unit test for the property 'AudioChannels'
        }
        /// <summary>
        /// Test the property 'AudioCodec'
        /// </summary>
        [Test]
        public void AudioCodecTest()
        {
            // TODO unit test for the property 'AudioCodec'
        }
        /// <summary>
        /// Test the property 'AudioSampleRate'
        /// </summary>
        [Test]
        public void AudioSampleRateTest()
        {
            // TODO unit test for the property 'AudioSampleRate'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'Duration'
        /// </summary>
        [Test]
        public void DurationTest()
        {
            // TODO unit test for the property 'Duration'
        }
        /// <summary>
        /// Test the property 'EncodingProgress'
        /// </summary>
        [Test]
        public void EncodingProgressTest()
        {
            // TODO unit test for the property 'EncodingProgress'
        }
        /// <summary>
        /// Test the property 'EncodingTime'
        /// </summary>
        [Test]
        public void EncodingTimeTest()
        {
            // TODO unit test for the property 'EncodingTime'
        }
        /// <summary>
        /// Test the property 'ErrorClass'
        /// </summary>
        [Test]
        public void ErrorClassTest()
        {
            // TODO unit test for the property 'ErrorClass'
        }
        /// <summary>
        /// Test the property 'ErrorMessage'
        /// </summary>
        [Test]
        public void ErrorMessageTest()
        {
            // TODO unit test for the property 'ErrorMessage'
        }
        /// <summary>
        /// Test the property 'ExternalId'
        /// </summary>
        [Test]
        public void ExternalIdTest()
        {
            // TODO unit test for the property 'ExternalId'
        }
        /// <summary>
        /// Test the property 'Extname'
        /// </summary>
        [Test]
        public void ExtnameTest()
        {
            // TODO unit test for the property 'Extname'
        }
        /// <summary>
        /// Test the property 'FileSize'
        /// </summary>
        [Test]
        public void FileSizeTest()
        {
            // TODO unit test for the property 'FileSize'
        }
        /// <summary>
        /// Test the property 'Files'
        /// </summary>
        [Test]
        public void FilesTest()
        {
            // TODO unit test for the property 'Files'
        }
        /// <summary>
        /// Test the property 'Fps'
        /// </summary>
        [Test]
        public void FpsTest()
        {
            // TODO unit test for the property 'Fps'
        }
        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Test]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }
        /// <summary>
        /// Test the property 'Width'
        /// </summary>
        [Test]
        public void WidthTest()
        {
            // TODO unit test for the property 'Width'
        }
        /// <summary>
        /// Test the property 'LogfileUrl'
        /// </summary>
        [Test]
        public void LogfileUrlTest()
        {
            // TODO unit test for the property 'LogfileUrl'
        }
        /// <summary>
        /// Test the property 'MimeType'
        /// </summary>
        [Test]
        public void MimeTypeTest()
        {
            // TODO unit test for the property 'MimeType'
        }
        /// <summary>
        /// Test the property 'ParentEncodingId'
        /// </summary>
        [Test]
        public void ParentEncodingIdTest()
        {
            // TODO unit test for the property 'ParentEncodingId'
        }
        /// <summary>
        /// Test the property 'Path'
        /// </summary>
        [Test]
        public void PathTest()
        {
            // TODO unit test for the property 'Path'
        }
        /// <summary>
        /// Test the property 'ProfileId'
        /// </summary>
        [Test]
        public void ProfileIdTest()
        {
            // TODO unit test for the property 'ProfileId'
        }
        /// <summary>
        /// Test the property 'ProfileName'
        /// </summary>
        [Test]
        public void ProfileNameTest()
        {
            // TODO unit test for the property 'ProfileName'
        }
        /// <summary>
        /// Test the property 'Screenshots'
        /// </summary>
        [Test]
        public void ScreenshotsTest()
        {
            // TODO unit test for the property 'Screenshots'
        }
        /// <summary>
        /// Test the property 'StartedEncodingAt'
        /// </summary>
        [Test]
        public void StartedEncodingAtTest()
        {
            // TODO unit test for the property 'StartedEncodingAt'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'VideoBitrate'
        /// </summary>
        [Test]
        public void VideoBitrateTest()
        {
            // TODO unit test for the property 'VideoBitrate'
        }
        /// <summary>
        /// Test the property 'VideoCodec'
        /// </summary>
        [Test]
        public void VideoCodecTest()
        {
            // TODO unit test for the property 'VideoCodec'
        }
        /// <summary>
        /// Test the property 'VideoId'
        /// </summary>
        [Test]
        public void VideoIdTest()
        {
            // TODO unit test for the property 'VideoId'
        }

    }

}
