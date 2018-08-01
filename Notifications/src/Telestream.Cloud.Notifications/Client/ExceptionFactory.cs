/* 
 * Notifications API
 *
 * Notifications API V2
 *
 * OpenAPI spec version: 2.1.0
 * Contact: cloudsupport@telestream.net
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using System;
using RestSharp.Portable;

namespace Telestream.Cloud.Notifications.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
