// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Chat
{
    internal partial class ChatRestClient
    {
        private string endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ChatRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The endpoint of the Azure Communication resource. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public ChatRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2021-04-05-preview6")
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateChatThreadRequest(string topic, string repeatabilityRequestId, IEnumerable<ChatParticipantInternal> participants)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/chat/threads", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (repeatabilityRequestId != null)
            {
                request.Headers.Add("repeatability-request-id", repeatabilityRequestId);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            CreateChatThreadRequest createChatThreadRequest = new CreateChatThreadRequest(topic);
            foreach (var value in participants)
            {
                createChatThreadRequest.Participants.Add(value);
            }
            var model = createChatThreadRequest;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Creates a chat thread. </summary>
        /// <param name="topic"> The chat thread topic. </param>
        /// <param name="repeatabilityRequestId"> If specified, the client directs that the request is repeatable; that is, that the client can make the request multiple times with the same Repeatability-Request-Id and get back an appropriate response without the server executing the request multiple times. The value of the Repeatability-Request-Id is an opaque string representing a client-generated, globally unique for all time, identifier for the request. It is recommended to use version 4 (random) UUIDs. </param>
        /// <param name="participants"> Participants to be added to the chat thread. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topic"/> is null. </exception>
        public async Task<Response<CreateChatThreadResultInternal>> CreateChatThreadAsync(string topic, string repeatabilityRequestId = null, IEnumerable<ChatParticipantInternal> participants = null, CancellationToken cancellationToken = default)
        {
            if (topic == null)
            {
                throw new ArgumentNullException(nameof(topic));
            }

            using var message = CreateCreateChatThreadRequest(topic, repeatabilityRequestId, participants);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CreateChatThreadResultInternal value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = CreateChatThreadResultInternal.DeserializeCreateChatThreadResultInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates a chat thread. </summary>
        /// <param name="topic"> The chat thread topic. </param>
        /// <param name="repeatabilityRequestId"> If specified, the client directs that the request is repeatable; that is, that the client can make the request multiple times with the same Repeatability-Request-Id and get back an appropriate response without the server executing the request multiple times. The value of the Repeatability-Request-Id is an opaque string representing a client-generated, globally unique for all time, identifier for the request. It is recommended to use version 4 (random) UUIDs. </param>
        /// <param name="participants"> Participants to be added to the chat thread. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topic"/> is null. </exception>
        public Response<CreateChatThreadResultInternal> CreateChatThread(string topic, string repeatabilityRequestId = null, IEnumerable<ChatParticipantInternal> participants = null, CancellationToken cancellationToken = default)
        {
            if (topic == null)
            {
                throw new ArgumentNullException(nameof(topic));
            }

            using var message = CreateCreateChatThreadRequest(topic, repeatabilityRequestId, participants);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 201:
                    {
                        CreateChatThreadResultInternal value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = CreateChatThreadResultInternal.DeserializeCreateChatThreadResultInternal(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListChatThreadsRequest(int? maxPageSize, DateTimeOffset? startTime)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/chat/threads", false);
            if (maxPageSize != null)
            {
                uri.AppendQuery("maxPageSize", maxPageSize.Value, true);
            }
            if (startTime != null)
            {
                uri.AppendQuery("startTime", startTime.Value, "O", true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of chat threads of a user. </summary>
        /// <param name="maxPageSize"> The maximum number of chat threads returned per page. </param>
        /// <param name="startTime"> The earliest point in time to get chat threads up to. The timestamp should be in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ChatThreadsItemCollection>> ListChatThreadsAsync(int? maxPageSize = null, DateTimeOffset? startTime = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListChatThreadsRequest(maxPageSize, startTime);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChatThreadsItemCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChatThreadsItemCollection.DeserializeChatThreadsItemCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of chat threads of a user. </summary>
        /// <param name="maxPageSize"> The maximum number of chat threads returned per page. </param>
        /// <param name="startTime"> The earliest point in time to get chat threads up to. The timestamp should be in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ChatThreadsItemCollection> ListChatThreads(int? maxPageSize = null, DateTimeOffset? startTime = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListChatThreadsRequest(maxPageSize, startTime);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChatThreadsItemCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChatThreadsItemCollection.DeserializeChatThreadsItemCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteChatThreadRequest(string chatThreadId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendPath("/chat/threads/", false);
            uri.AppendPath(chatThreadId, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes a thread. </summary>
        /// <param name="chatThreadId"> Id of the thread to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="chatThreadId"/> is null. </exception>
        public async Task<Response> DeleteChatThreadAsync(string chatThreadId, CancellationToken cancellationToken = default)
        {
            if (chatThreadId == null)
            {
                throw new ArgumentNullException(nameof(chatThreadId));
            }

            using var message = CreateDeleteChatThreadRequest(chatThreadId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes a thread. </summary>
        /// <param name="chatThreadId"> Id of the thread to be deleted. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="chatThreadId"/> is null. </exception>
        public Response DeleteChatThread(string chatThreadId, CancellationToken cancellationToken = default)
        {
            if (chatThreadId == null)
            {
                throw new ArgumentNullException(nameof(chatThreadId));
            }

            using var message = CreateDeleteChatThreadRequest(chatThreadId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListChatThreadsNextPageRequest(string nextLink, int? maxPageSize, DateTimeOffset? startTime)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(endpoint, false);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets the list of chat threads of a user. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> The maximum number of chat threads returned per page. </param>
        /// <param name="startTime"> The earliest point in time to get chat threads up to. The timestamp should be in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ChatThreadsItemCollection>> ListChatThreadsNextPageAsync(string nextLink, int? maxPageSize = null, DateTimeOffset? startTime = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListChatThreadsNextPageRequest(nextLink, maxPageSize, startTime);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChatThreadsItemCollection value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChatThreadsItemCollection.DeserializeChatThreadsItemCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the list of chat threads of a user. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="maxPageSize"> The maximum number of chat threads returned per page. </param>
        /// <param name="startTime"> The earliest point in time to get chat threads up to. The timestamp should be in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<ChatThreadsItemCollection> ListChatThreadsNextPage(string nextLink, int? maxPageSize = null, DateTimeOffset? startTime = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateListChatThreadsNextPageRequest(nextLink, maxPageSize, startTime);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChatThreadsItemCollection value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChatThreadsItemCollection.DeserializeChatThreadsItemCollection(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
