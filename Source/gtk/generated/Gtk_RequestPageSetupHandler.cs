// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void RequestPageSetupHandler(object o, RequestPageSetupArgs args);

	public class RequestPageSetupArgs : GLib.SignalArgs {
		public Gtk.PrintContext Context{
			get {
				return (Gtk.PrintContext) Args [0];
			}
		}

		public int PageNr{
			get {
				return (int) Args [1];
			}
		}

		public Gtk.PageSetup Setup{
			get {
				return (Gtk.PageSetup) Args [2];
			}
		}

	}
}
