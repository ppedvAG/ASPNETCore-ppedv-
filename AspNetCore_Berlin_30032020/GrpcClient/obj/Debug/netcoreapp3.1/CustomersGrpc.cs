// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/customers.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService.Protos {
  public static partial class Customer
  {
    static readonly string __ServiceName = "Customer";

    static readonly grpc::Marshaller<global::GrpcService.Protos.CustomerLookupModel> __Marshaller_CustomerLookupModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.CustomerLookupModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.CustomerModel> __Marshaller_CustomerModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.CustomerModel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.Protos.NewCustomerRequest> __Marshaller_NewCustomerRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.Protos.NewCustomerRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.Protos.CustomerLookupModel, global::GrpcService.Protos.CustomerModel> __Method_GetCustomerInfo = new grpc::Method<global::GrpcService.Protos.CustomerLookupModel, global::GrpcService.Protos.CustomerModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerInfo",
        __Marshaller_CustomerLookupModel,
        __Marshaller_CustomerModel);

    static readonly grpc::Method<global::GrpcService.Protos.NewCustomerRequest, global::GrpcService.Protos.CustomerModel> __Method_GetNewCustomers = new grpc::Method<global::GrpcService.Protos.NewCustomerRequest, global::GrpcService.Protos.CustomerModel>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetNewCustomers",
        __Marshaller_NewCustomerRequest,
        __Marshaller_CustomerModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.Protos.CustomersReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Customer</summary>
    public partial class CustomerClient : grpc::ClientBase<CustomerClient>
    {
      /// <summary>Creates a new client for Customer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Customer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GrpcService.Protos.CustomerModel GetCustomerInfo(global::GrpcService.Protos.CustomerLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerInfo(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcService.Protos.CustomerModel GetCustomerInfo(global::GrpcService.Protos.CustomerLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerInfo, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.CustomerModel> GetCustomerInfoAsync(global::GrpcService.Protos.CustomerLookupModel request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerInfoAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcService.Protos.CustomerModel> GetCustomerInfoAsync(global::GrpcService.Protos.CustomerLookupModel request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerInfo, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcService.Protos.CustomerModel> GetNewCustomers(global::GrpcService.Protos.NewCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetNewCustomers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcService.Protos.CustomerModel> GetNewCustomers(global::GrpcService.Protos.NewCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetNewCustomers, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerClient(configuration);
      }
    }

  }
}
#endregion
