// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

	public delegate void ActionAddedHandler(object o, ActionAddedArgs args);

	public class ActionAddedArgs : GLib.SignalArgs {
		public string ActionName{
			get {
				return (string) Args [0];
			}
		}

	}
}
