// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void AreaUpdatedHandler(object o, AreaUpdatedArgs args);

	public class AreaUpdatedArgs : GLib.SignalArgs {
		public int X{
			get {
				return (int) Args [0];
			}
		}

		public int Y{
			get {
				return (int) Args [1];
			}
		}

		public int Width{
			get {
				return (int) Args [2];
			}
		}

		public int Height{
			get {
				return (int) Args [3];
			}
		}

	}
}
