// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Message.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer.Proto {
  public static partial class GetEmployee
  {
    static readonly string __ServiceName = "GetEmployee";

    static readonly grpc::Marshaller<global::GrpcServer.Proto.GetByNoRequest> __Marshaller_GetByNoRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.Proto.GetByNoRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.Proto.GetResponse> __Marshaller_GetResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.Proto.GetResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcServer.Proto.GetAllRequest> __Marshaller_GetAllRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcServer.Proto.GetAllRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcServer.Proto.GetByNoRequest, global::GrpcServer.Proto.GetResponse> __Method_GetByNo = new grpc::Method<global::GrpcServer.Proto.GetByNoRequest, global::GrpcServer.Proto.GetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetByNo",
        __Marshaller_GetByNoRequest,
        __Marshaller_GetResponse);

    static readonly grpc::Method<global::GrpcServer.Proto.GetAllRequest, global::GrpcServer.Proto.GetResponse> __Method_GetAll = new grpc::Method<global::GrpcServer.Proto.GetAllRequest, global::GrpcServer.Proto.GetResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAll",
        __Marshaller_GetAllRequest,
        __Marshaller_GetResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.Proto.MessageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for GetEmployee</summary>
    public partial class GetEmployeeClient : grpc::ClientBase<GetEmployeeClient>
    {
      /// <summary>Creates a new client for GetEmployee</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GetEmployeeClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GetEmployee that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GetEmployeeClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GetEmployeeClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GetEmployeeClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcServer.Proto.GetResponse GetByNo(global::GrpcServer.Proto.GetByNoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByNo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcServer.Proto.GetResponse GetByNo(global::GrpcServer.Proto.GetByNoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetByNo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.Proto.GetResponse> GetByNoAsync(global::GrpcServer.Proto.GetByNoRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetByNoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcServer.Proto.GetResponse> GetByNoAsync(global::GrpcServer.Proto.GetByNoRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetByNo, null, options, request);
      }
      /// <summary>
      /// 获取所有
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServer.Proto.GetResponse> GetAll(global::GrpcServer.Proto.GetAllRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// 获取所有
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncServerStreamingCall<global::GrpcServer.Proto.GetResponse> GetAll(global::GrpcServer.Proto.GetAllRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetAll, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GetEmployeeClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GetEmployeeClient(configuration);
      }
    }

  }
}
#endregion
