// <auto-generated/>
using Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientScopes.Item.ScopeMappings.Clients.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Admin.Realms.Item.ClientScopes.Item.ScopeMappings.Clients {
    /// <summary>
    /// Builds and executes requests for operations under \admin\realms\{realm}\client-scopes\{client-scope-id}\scope-mappings\clients
    /// </summary>
    public class ClientsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Keycloak.AuthServices.Sdk.Kiota.Admin.admin.realms.item.clientScopes.item.scopeMappings.clients.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="WithClientItemRequestBuilder"/></returns>
        public WithClientItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("client", position);
            return new WithClientItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="ClientsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClientsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/client-scopes/{client%2Dscope%2Did}/scope-mappings/clients", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="ClientsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ClientsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/realms/{realm}/client-scopes/{client%2Dscope%2Did}/scope-mappings/clients", rawUrl) {
        }
    }
}