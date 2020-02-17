// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class UnixConnection : GLib.SocketConnection {

		public UnixConnection (IntPtr raw) : base(raw) {}

		protected UnixConnection() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_unix_connection_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_unix_connection_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_unix_connection_receive_credentials(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe GLib.Credentials ReceiveCredentials(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_unix_connection_receive_credentials(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			GLib.Credentials ret = GLib.Object.GetObject(raw_ret) as GLib.Credentials;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_unix_connection_receive_credentials_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void ReceiveCredentialsAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_unix_connection_receive_credentials_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr g_unix_connection_receive_credentials_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe GLib.Credentials ReceiveCredentialsFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_unix_connection_receive_credentials_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			GLib.Credentials ret = GLib.Object.GetObject(raw_ret) as GLib.Credentials;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe int g_unix_connection_receive_fd(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe int ReceiveFd(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_unix_connection_receive_fd(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			int ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_unix_connection_send_credentials(IntPtr raw, IntPtr cancellable, out IntPtr error);

		public unsafe bool SendCredentials(GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_unix_connection_send_credentials(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_unix_connection_send_credentials_async(IntPtr raw, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public void SendCredentialsAsync(GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) {
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			cb_wrapper.PersistUntilCalled ();
			g_unix_connection_send_credentials_async(Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_unix_connection_send_credentials_finish(IntPtr raw, IntPtr result, out IntPtr error);

		public unsafe bool SendCredentialsFinish(GLib.IAsyncResult result) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_unix_connection_send_credentials_finish(Handle, result == null ? IntPtr.Zero : ((result is GLib.Object) ? (result as GLib.Object).Handle : (result as GLib.AsyncResultAdapter).Handle), out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool g_unix_connection_send_fd(IntPtr raw, int fd, IntPtr cancellable, out IntPtr error);

		public unsafe bool SendFd(int fd, GLib.Cancellable cancellable) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_unix_connection_send_fd(Handle, fd, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

#endregion
	}
}
