// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void DragDataReceivedHandler(object o, DragDataReceivedArgs args);

	public class DragDataReceivedArgs : GLib.SignalArgs {
		public Gdk.DragContext Context{
			get {
				return (Gdk.DragContext) Args [0];
			}
		}

		public int X{
			get {
				return (int) Args [1];
			}
		}

		public int Y{
			get {
				return (int) Args [2];
			}
		}

		public Gtk.SelectionData SelectionData{
			get {
				return (Gtk.SelectionData) Args [3];
			}
		}

		public uint Info{
			get {
				return (uint) Args [4];
			}
		}

		public uint Time{
			get {
				return (uint) Args [5];
			}
		}

	}
}