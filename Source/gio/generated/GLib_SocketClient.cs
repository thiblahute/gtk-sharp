// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SocketClient : GLib.Object {

		public SocketClient (IntPtr raw) : base(raw) {}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_client_new();

		public SocketClient () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SocketClient)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = g_socket_client_new();
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_socket_client_get_family(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_family(IntPtr raw, int family);

		[GLib.Property ("family")]
		public GLib.SocketFamily Family {
			get  {
				int raw_ret = g_socket_client_get_family(Handle);
				GLib.SocketFamily ret = (GLib.SocketFamily) raw_ret;
				return ret;
			}
			set  {
				g_socket_client_set_family(Handle, (int) value);
			}
		}

		[GLib.Property ("type")]
		public GLib.SocketType Type {
			get {
				GLib.Value val = GetProperty ("type");
				GLib.SocketType ret = (GLib.SocketType) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("type", val);
				val.Dispose ();
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_socket_client_get_protocol(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_protocol(IntPtr raw, int protocol);

		[GLib.Property ("protocol")]
		public GLib.SocketProtocol Protocol {
			get  {
				int raw_ret = g_socket_client_get_protocol(Handle);
				GLib.SocketProtocol ret = (GLib.SocketProtocol) raw_ret;
				return ret;
			}
			set  {
				g_socket_client_set_protocol(Handle, (int) value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_client_get_local_address(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_local_address(IntPtr raw, IntPtr address);

		[GLib.Property ("local-address")]
		public GLib.SocketAddress LocalAddress {
			get  {
				IntPtr raw_ret = g_socket_client_get_local_address(Handle);
				GLib.SocketAddress ret = GLib.Object.GetObject(raw_ret) as GLib.SocketAddress;
				return ret;
			}
			set  {
				g_socket_client_set_local_address(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_socket_client_get_timeout(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_timeout(IntPtr raw, uint timeout);

		[GLib.Property ("timeout")]
		public uint Timeout {
			get  {
				uint raw_ret = g_socket_client_get_timeout(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				g_socket_client_set_timeout(Handle, value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_socket_client_get_enable_proxy(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_enable_proxy(IntPtr raw, bool enable);

		[GLib.Property ("enable-proxy")]
		public bool EnableProxy {
			get  {
				bool raw_ret = g_socket_client_get_enable_proxy(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				g_socket_client_set_enable_proxy(Handle, value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_socket_client_get_tls(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_tls(IntPtr raw, bool tls);

		[GLib.Property ("tls")]
		public bool Tls {
			get  {
				bool raw_ret = g_socket_client_get_tls(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				g_socket_client_set_tls(Handle, value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_socket_client_get_tls_validation_flags(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_tls_validation_flags(IntPtr raw, int flags);

		[GLib.Property ("tls-validation-flags")]
		public GLib.TlsCertificateFlags TlsValidationFlags {
			get  {
				int raw_ret = g_socket_client_get_tls_validation_flags(Handle);
				GLib.TlsCertificateFlags ret = (GLib.TlsCertificateFlags) raw_ret;
				return ret;
			}
			set  {
				g_socket_client_set_tls_validation_flags(Handle, (int) value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_client_get_proxy_resolver(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_proxy_resolver(IntPtr raw, IntPtr proxy_resolver);

		[GLib.Property ("proxy-resolver")]
		public GLib.IProxyResolver ProxyResolver {
			get  {
				IntPtr raw_ret = g_socket_client_get_proxy_resolver(Handle);
				GLib.IProxyResolver ret = GLib.ProxyResolverAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				g_socket_client_set_proxy_resolver(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as GLib.ProxyResolverAdapter).Handle));
			}
		}

		[GLib.Signal("event")]
		public event GLib.EventHandler Event {
			add {
				this.AddSignalHandler ("event", value, typeof (GLib.EventArgs));
			}
			remove {
				this.RemoveSignalHandler ("event", value);
			}
		}

		static EventNativeDelegate Event_cb_delegate;
		static EventNativeDelegate EventVMCallback {
			get {
				if (Event_cb_delegate == null)
					Event_cb_delegate = new EventNativeDelegate (Event_cb);
				return Event_cb_delegate;
			}
		}

		static void OverrideEvent (GLib.GType gtype)
		{
			OverrideEvent (gtype, EventVMCallback);
		}

		static void OverrideEvent (GLib.GType gtype, EventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EventNativeDelegate (IntPtr inst, int evnt, IntPtr connectable, IntPtr connection);

		static void Event_cb (IntPtr inst, int evnt, IntPtr connectable, IntPtr connection)
		{
			try {
				SocketClient __obj = GLib.Object.GetObject (inst, false) as SocketClient;
				__obj.OnEvent ((GLib.SocketClientEvent) evnt, GLib.SocketConnectableAdapter.GetObject (connectable, false), GLib.Object.GetObject(connection) as GLib.IOStream);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.SocketClient), ConnectionMethod="OverrideEvent")]
		protected virtual void OnEvent (GLib.SocketClientEvent evnt, GLib.ISocketConnectable connectable, GLib.IOStream connection)
		{
			InternalEvent (evnt, connectable, connection);
		}

		private void InternalEvent (GLib.SocketClientEvent evnt, GLib.ISocketConnectable connectable, GLib.IOStream connection)
		{
			EventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("event"));
				unmanaged = (EventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(EventNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) evnt, connectable == null ? IntPtr.Zero : ((connectable is GLib.Object) ? (connectable as GLib.Object).Handle : (connectable as GLib.SocketConnectableAdapter).Handle), connection == null ? IntPtr.Zero : connection.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("event"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // event
							, null
							, "_g_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved1
							, "event"
							, "_g_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved2
							, "_g_reserved1"
							, "_g_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved3
							, "_g_reserved2"
							, "_g_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_g_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _g_reserved4
							, "_g_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_add_application_proxy(IntPtr raw, IntPtr protocol);

		public void AddApplicationProxy(string protocol) {
			IntPtr native_protocol = GLib.Marshaller.StringToPtrGStrdup (protocol);
			g_socket_client_add_application_proxy(Handle, native_protocol);
			GLib.Marshaller.Free (native_protocol);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect(IntPtr raw, IntPtr connectable, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.SocketConnection Connect(GLib.ISocketConnectable connectable, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect(Handle, connectable == null ? IntPtr.Zero : ((connectable is GLib.Object) ? (connectable as GLib.Object).Handle : (connectable as GLib.SocketConnectableAdapter).Handle), cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_connect_async(IntPtr raw, IntPtr connectable, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ConnectAsync(GLib.ISocketConnectable connectable, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_socket_client_connect_async(Handle, connectable == null ? IntPtr.Zero : ((connectable is GLib.Object) ? (connectable as GLib.Object).Handle : (connectable as GLib.SocketConnectableAdapter).Handle), cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.SocketConnection ConnectFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect_to_host(IntPtr raw, IntPtr host_and_port, ushort default_port, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.SocketConnection ConnectToHost(string host_and_port, ushort default_port, GLib.Cancellable cancellable) {
			IntPtr native_host_and_port = GLib.Marshaller.StringToPtrGStrdup (host_and_port);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect_to_host(Handle, native_host_and_port, default_port, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			GLib.Marshaller.Free (native_host_and_port);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_connect_to_host_async(IntPtr raw, IntPtr host_and_port, ushort default_port, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ConnectToHostAsync(string host_and_port, ushort default_port, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_host_and_port = GLib.Marshaller.StringToPtrGStrdup (host_and_port);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_socket_client_connect_to_host_async(Handle, native_host_and_port, default_port, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_host_and_port);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect_to_host_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.SocketConnection ConnectToHostFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect_to_host_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect_to_service(IntPtr raw, IntPtr domain, IntPtr service, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.SocketConnection ConnectToService(string domain, string service, GLib.Cancellable cancellable) {
			IntPtr native_domain = GLib.Marshaller.StringToPtrGStrdup (domain);
			IntPtr native_service = GLib.Marshaller.StringToPtrGStrdup (service);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect_to_service(Handle, native_domain, native_service, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			GLib.Marshaller.Free (native_domain);
			GLib.Marshaller.Free (native_service);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_connect_to_service_async(IntPtr raw, IntPtr domain, IntPtr service, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ConnectToServiceAsync(string domain, string service, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_domain = GLib.Marshaller.StringToPtrGStrdup (domain);
			IntPtr native_service = GLib.Marshaller.StringToPtrGStrdup (service);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_socket_client_connect_to_service_async(Handle, native_domain, native_service, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_domain);
			GLib.Marshaller.Free (native_service);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect_to_service_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.SocketConnection ConnectToServiceFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect_to_service_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect_to_uri(IntPtr raw, IntPtr uri, ushort default_port, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.SocketConnection ConnectToUri(string uri, ushort default_port, GLib.Cancellable cancellable) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect_to_uri(Handle, native_uri, default_port, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_connect_to_uri_async(IntPtr raw, IntPtr uri, ushort default_port, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ConnectToUriAsync(string uri, ushort default_port, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_socket_client_connect_to_uri_async(Handle, native_uri, default_port, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
			GLib.Marshaller.Free (native_uri);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_socket_client_connect_to_uri_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.SocketConnection ConnectToUriFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_socket_client_connect_to_uri_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.SocketConnection ret = GLib.Object.GetObject(raw_ret) as GLib.SocketConnection;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_socket_client_get_socket_type(IntPtr raw);

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_socket_client_set_socket_type(IntPtr raw, int type);

		public GLib.SocketType SocketType { 
			get {
				int raw_ret = g_socket_client_get_socket_type(Handle);
				GLib.SocketType ret = (GLib.SocketType) raw_ret;
				return ret;
			}
			set {
				g_socket_client_set_socket_type(Handle, (int) value);
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_socket_client_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_socket_client_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
