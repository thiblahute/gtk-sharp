// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class CellView : Gtk.Widget, Gtk.ICellLayout, Gtk.IOrientable {

		public CellView (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_new();

		public CellView () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellView)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_cell_view_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_new_with_context(IntPtr area, IntPtr context);

		public CellView (Gtk.CellArea area, Gtk.CellAreaContext context) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellView)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_cell_view_new_with_context(area == null ? IntPtr.Zero : area.Handle, context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_new_with_markup(IntPtr markup);

		public CellView (string markup) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellView)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_markup = GLib.Marshaller.StringToPtrGStrdup (markup);
			Raw = gtk_cell_view_new_with_markup(native_markup);
			GLib.Marshaller.Free (native_markup);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_new_with_pixbuf(IntPtr pixbuf);

		public CellView (Gdk.Pixbuf pixbuf) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellView)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_cell_view_new_with_pixbuf(pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_new_with_text(IntPtr text);

		public static CellView NewWithText(string text)
		{
			IntPtr native_text = GLib.Marshaller.StringToPtrGStrdup (text);
			CellView result = new CellView (gtk_cell_view_new_with_text(native_text));
			GLib.Marshaller.Free (native_text);
			return result;
		}

		[GLib.Property ("background")]
		public string Background {
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("background", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("background-gdk")]
		public Gdk.Color BackgroundGdk {
			get {
				GLib.Value val = GetProperty ("background-gdk");
				Gdk.Color ret = (Gdk.Color) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = (GLib.Value) value;
				SetProperty("background-gdk", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_view_set_background_rgba(IntPtr raw, IntPtr value);

		[GLib.Property ("background-rgba")]
		public Gdk.RGBA BackgroundRgba {
			get {
				GLib.Value val = GetProperty ("background-rgba");
				Gdk.RGBA ret = (Gdk.RGBA) val;
				val.Dispose ();
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gtk_cell_view_set_background_rgba(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_get_model(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_view_set_model(IntPtr raw, IntPtr model);

		[GLib.Property ("model")]
		public Gtk.ITreeModel Model {
			get  {
				IntPtr raw_ret = gtk_cell_view_get_model(Handle);
				Gtk.ITreeModel ret = Gtk.TreeModelAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set  {
				gtk_cell_view_set_model(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as Gtk.TreeModelAdapter).Handle));
			}
		}

		[GLib.Property ("cell-area")]
		public Gtk.CellArea CellArea {
			get {
				GLib.Value val = GetProperty ("cell-area");
				Gtk.CellArea ret = (Gtk.CellArea) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("cell-area-context")]
		public Gtk.CellAreaContext CellAreaContext {
			get {
				GLib.Value val = GetProperty ("cell-area-context");
				Gtk.CellAreaContext ret = (Gtk.CellAreaContext) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_cell_view_get_draw_sensitive(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_view_set_draw_sensitive(IntPtr raw, bool draw_sensitive);

		[GLib.Property ("draw-sensitive")]
		public bool DrawSensitive {
			get  {
				bool raw_ret = gtk_cell_view_get_draw_sensitive(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_cell_view_set_draw_sensitive(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_cell_view_get_fit_model(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_view_set_fit_model(IntPtr raw, bool fit_model);

		[GLib.Property ("fit-model")]
		public bool FitModel {
			get  {
				bool raw_ret = gtk_cell_view_get_fit_model(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_cell_view_set_fit_model(Handle, value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Widget.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_get_displayed_row(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_view_set_displayed_row(IntPtr raw, IntPtr path);

		public Gtk.TreePath DisplayedRow { 
			get {
				IntPtr raw_ret = gtk_cell_view_get_displayed_row(Handle);
				Gtk.TreePath ret = raw_ret == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TreePath), false);
				return ret;
			}
			set {
				gtk_cell_view_set_displayed_row(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_cell_view_get_size_of_row(IntPtr raw, IntPtr path, IntPtr requisition);

		[Obsolete]
		public bool GetSizeOfRow(Gtk.TreePath path, Gtk.Requisition requisition) {
			IntPtr native_requisition = GLib.Marshaller.StructureToPtrAlloc (requisition);
			bool raw_ret = gtk_cell_view_get_size_of_row(Handle, path == null ? IntPtr.Zero : path.Handle, native_requisition);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_requisition);
			return ret;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_view_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_cell_view_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_view_set_background_color(IntPtr raw, IntPtr value);

		[Obsolete]
		public Gdk.Color BackgroundColor { 
			set {
				IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
				gtk_cell_view_set_background_color(Handle, native_value);
				Marshal.FreeHGlobal (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_add_attribute(IntPtr raw, IntPtr cell, IntPtr attribute, int column);

		public void AddAttribute(Gtk.CellRenderer cell, string attribute, int column) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			gtk_cell_layout_add_attribute(Handle, cell == null ? IntPtr.Zero : cell.Handle, native_attribute, column);
			GLib.Marshaller.Free (native_attribute);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_clear(IntPtr raw);

		public void Clear() {
			gtk_cell_layout_clear(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_clear_attributes(IntPtr raw, IntPtr cell);

		public void ClearAttributes(Gtk.CellRenderer cell) {
			gtk_cell_layout_clear_attributes(Handle, cell == null ? IntPtr.Zero : cell.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_layout_get_area(IntPtr raw);

		public Gtk.CellArea Area { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_area(Handle);
				Gtk.CellArea ret = GLib.Object.GetObject(raw_ret) as Gtk.CellArea;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_layout_get_cells(IntPtr raw);

		public Gtk.CellRenderer[] Cells { 
			get {
				IntPtr raw_ret = gtk_cell_layout_get_cells(Handle);
				Gtk.CellRenderer[] ret = (Gtk.CellRenderer[]) GLib.Marshaller.ListPtrToArray (raw_ret, typeof(GLib.List), true, false, typeof(Gtk.CellRenderer));
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_pack_end(IntPtr raw, IntPtr cell, bool expand);

		public void PackEnd(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_end(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_pack_start(IntPtr raw, IntPtr cell, bool expand);

		public void PackStart(Gtk.CellRenderer cell, bool expand) {
			gtk_cell_layout_pack_start(Handle, cell == null ? IntPtr.Zero : cell.Handle, expand);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_reorder(IntPtr raw, IntPtr cell, int position);

		public void Reorder(Gtk.CellRenderer cell, int position) {
			gtk_cell_layout_reorder(Handle, cell == null ? IntPtr.Zero : cell.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_cell_layout_set_cell_data_func(IntPtr raw, IntPtr cell, GtkSharp.CellLayoutDataFuncNative func, IntPtr func_data, GLib.DestroyNotify destroy);

		public void SetCellDataFunc(Gtk.CellRenderer cell, Gtk.CellLayoutDataFunc func) {
			GtkSharp.CellLayoutDataFuncWrapper func_wrapper = new GtkSharp.CellLayoutDataFuncWrapper (func);
			IntPtr func_data;
			GLib.DestroyNotify destroy;
			if (func == null) {
				func_data = IntPtr.Zero;
				destroy = null;
			} else {
				func_data = (IntPtr) GCHandle.Alloc (func_wrapper);
				destroy = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_cell_layout_set_cell_data_func(Handle, cell == null ? IntPtr.Zero : cell.Handle, func_wrapper.NativeDelegate, func_data, destroy);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_orientable_get_orientation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_orientable_set_orientation(IntPtr raw, int orientation);

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Widget.abi_info.Fields
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
