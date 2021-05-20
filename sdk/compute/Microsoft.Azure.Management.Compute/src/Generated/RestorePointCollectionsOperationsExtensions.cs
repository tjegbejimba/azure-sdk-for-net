// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RestorePointCollectionsOperations.
    /// </summary>
    public static partial class RestorePointCollectionsOperationsExtensions
    {
            /// <summary>
            /// The operation to create or update the restore point collection. Please
            /// refer to https://aka.ms/RestorePoints for more details. When updating a
            /// restore point collection, only tags may be modified.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the restore point collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update restore point collection
            /// operation.
            /// </param>
            public static RestorePointCollection CreateOrUpdate(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, RestorePointCollection parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, restorePointCollectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to create or update the restore point collection. Please
            /// refer to https://aka.ms/RestorePoints for more details. When updating a
            /// restore point collection, only tags may be modified.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the restore point collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create or Update restore point collection
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorePointCollection> CreateOrUpdateAsync(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, RestorePointCollection parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, restorePointCollectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to update the restore point collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the restore point collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update restore point collection operation.
            /// </param>
            public static RestorePointCollection Update(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, RestorePointCollectionUpdate parameters)
            {
                return operations.UpdateAsync(resourceGroupName, restorePointCollectionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to update the restore point collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the restore point collection.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update restore point collection operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorePointCollection> UpdateAsync(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, RestorePointCollectionUpdate parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, restorePointCollectionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the restore point collection. This operation will
            /// also delete all the contained restore points.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the Restore Point Collection.
            /// </param>
            public static void Delete(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName)
            {
                operations.DeleteAsync(resourceGroupName, restorePointCollectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the restore point collection. This operation will
            /// also delete all the contained restore points.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the Restore Point Collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, restorePointCollectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The operation to get the restore point collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the restore point collection.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. If expand=restorePoints,
            /// server will return all contained restore points in the
            /// restorePointCollection. Possible values include: 'restorePoints'
            /// </param>
            public static RestorePointCollection Get(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, restorePointCollectionName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to get the restore point collection.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the restore point collection.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. If expand=restorePoints,
            /// server will return all contained restore points in the
            /// restorePointCollection. Possible values include: 'restorePoints'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RestorePointCollection> GetAsync(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, restorePointCollectionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of restore point collections in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<RestorePointCollection> List(this IRestorePointCollectionsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of restore point collections in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RestorePointCollection>> ListAsync(this IRestorePointCollectionsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of restore point collections in the subscription. Use
            /// nextLink property in the response to get the next page of restore point
            /// collections. Do this till nextLink is not null to fetch all the restore
            /// point collections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<RestorePointCollection> ListAll(this IRestorePointCollectionsOperations operations)
            {
                return operations.ListAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of restore point collections in the subscription. Use
            /// nextLink property in the response to get the next page of restore point
            /// collections. Do this till nextLink is not null to fetch all the restore
            /// point collections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RestorePointCollection>> ListAllAsync(this IRestorePointCollectionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The operation to delete the restore point collection. This operation will
            /// also delete all the contained restore points.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the Restore Point Collection.
            /// </param>
            public static void BeginDelete(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName)
            {
                operations.BeginDeleteAsync(resourceGroupName, restorePointCollectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The operation to delete the restore point collection. This operation will
            /// also delete all the contained restore points.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='restorePointCollectionName'>
            /// The name of the Restore Point Collection.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IRestorePointCollectionsOperations operations, string resourceGroupName, string restorePointCollectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, restorePointCollectionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of restore point collections in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RestorePointCollection> ListNext(this IRestorePointCollectionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of restore point collections in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RestorePointCollection>> ListNextAsync(this IRestorePointCollectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of restore point collections in the subscription. Use
            /// nextLink property in the response to get the next page of restore point
            /// collections. Do this till nextLink is not null to fetch all the restore
            /// point collections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RestorePointCollection> ListAllNext(this IRestorePointCollectionsOperations operations, string nextPageLink)
            {
                return operations.ListAllNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of restore point collections in the subscription. Use
            /// nextLink property in the response to get the next page of restore point
            /// collections. Do this till nextLink is not null to fetch all the restore
            /// point collections.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RestorePointCollection>> ListAllNextAsync(this IRestorePointCollectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAllNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
