// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: message.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer.Services {
  public static partial class MessageService
  {
    static readonly string __ServiceName = "MessageService";

    static readonly grpc::Marshaller<global::GrpcServer.Services.SampleRequest> __Marshaller_SampleRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.Services.SampleRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.Services.SampleResponse> __Marshaller_SampleResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.Services.SampleResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.Services.SampleRequest, global::GrpcServer.Services.SampleResponse> __Method_Ping = new grpc::Method<global::GrpcServer.Services.SampleRequest, global::GrpcServer.Services.SampleResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Ping",
        __Marshaller_SampleRequest,
        __Marshaller_SampleResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.Services.MessageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for MessageService</summary>
    public partial class MessageServiceClient : grpc::ClientBase<MessageServiceClient>
    {
      /// <summary>Creates a new client for MessageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MessageServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MessageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MessageServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MessageServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MessageServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.Services.SampleResponse Ping(global::GrpcServer.Services.SampleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Ping(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.Services.SampleResponse Ping(global::GrpcServer.Services.SampleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Ping, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.Services.SampleResponse> PingAsync(global::GrpcServer.Services.SampleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.Services.SampleResponse> PingAsync(global::GrpcServer.Services.SampleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Ping, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MessageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MessageServiceClient(configuration);
      }
    }

  }
}
#endregion