// GtkSharp.Generation.SymbolTable.cs - The Symbol Table Class.
//
// Author: Mike Kestner <mkestner@speakeasy.net>
//
// (c) 2001-2003 Mike Kestner

namespace GtkSharp.Generation {

	using System;
	using System.Collections;

	public class SymbolTable {
		
		static SymbolTable table = null;

		Hashtable alias = new Hashtable ();
		Hashtable types = new Hashtable ();
		
		public static SymbolTable Table {
			get {
				if (table == null)
					table = new SymbolTable ();

				return table;
			}
		}

		public SymbolTable ()
		{
			Hashtable alias = new Hashtable ();
			Hashtable types = new Hashtable ();
		
			AddType (new SimpleGen ("void", "void"));
			AddType (new SimpleGen ("gboolean", "bool"));
			AddType (new SimpleGen ("gint", "int"));
			AddType (new SimpleGen ("guint", "uint"));
			AddType (new SimpleGen ("glong", "long"));
			AddType (new SimpleGen ("gshort", "short"));
			AddType (new SimpleGen ("gushort", "ushort"));
			AddType (new SimpleGen ("guint32", "uint"));
			AddType (new SimpleGen ("guint64", "ulong"));
			// Const returned strings must be generated 
			// differently from memory-managed strings
			AddType (new ConstStringGen ("const-gchar"));
			AddType (new ConstStringGen ("const-xmlChar"));
			AddType (new ConstStringGen ("const-char"));
			AddType (new StringGen ("gchar"));
			AddType (new SimpleGen ("gfloat", "float"));
			AddType (new SimpleGen ("gdouble", "double"));
			AddType (new SimpleGen ("gint8", "sbyte"));
			AddType (new SimpleGen ("guint8", "byte"));
			AddType (new SimpleGen ("gint16", "short"));
			AddType (new SimpleGen ("gint32", "int"));
			AddType (new SimpleGen ("gint64", "long"));
			AddType (new SimpleGen ("guint16", "ushort"));
			AddType (new SimpleGen ("guint1", "bool"));
			AddType (new SimpleGen ("gpointer", "IntPtr"));
			AddType (new SimpleGen ("guchar", "byte"));
			AddType (new SimpleGen ("unsigned char", "byte"));
			AddType (new SimpleGen ("short", "short"));
			AddType (new SimpleGen ("long", "long"));
			AddType (new SimpleGen ("ulong", "ulong"));
			AddType (new SimpleGen ("gulong", "ulong"));
			AddType (new SimpleGen ("GQuark", "int"));
			AddType (new SimpleGen ("int", "int"));
			AddType (new StringGen ("char"));
			AddType (new SimpleGen ("double", "double"));
			AddType (new SimpleGen ("float", "float"));
			AddType (new StringGen ("gunichar"));
			AddType (new SimpleGen ("uint1", "bool"));
			AddType (new SimpleGen ("GC", "IntPtr"));
			AddType (new SimpleGen ("GPtrArray", "IntPtr[]"));
			AddType (new ManualGen ("GType", "GLib.GType", "Val"));
			AddType (new SimpleGen ("GError", "IntPtr"));
			// gsize is a system-specific typedef in glibconfig.h,
			// but this should work for now
			AddType (new SimpleGen ("gsize", "uint"));
			AddType (new SimpleGen ("gssize", "int"));
			AddType (new SimpleGen ("size_t", "int"));
			
			// FIXME: These ought to be handled properly.
			AddType (new SimpleGen ("GMemChunk", "IntPtr"));
			AddType (new SimpleGen ("GTimeVal", "IntPtr"));
			AddType (new SimpleGen ("GClosure", "IntPtr"));
			AddType (new SimpleGen ("GArray", "IntPtr"));
			AddType (new SimpleGen ("GByteArray", "IntPtr"));
			AddType (new SimpleGen ("GData", "IntPtr"));
			AddType (new SimpleGen ("GTypeModule", "GLib.Object"));
			AddType (new SimpleGen ("GHashTable", "System.IntPtr"));
			AddType (new SimpleGen ("va_list", "IntPtr"));
			AddType (new SimpleGen ("GParamSpec", "IntPtr"));
			AddType (new SimpleGen ("gconstpointer", "IntPtr"));

			AddType (new CustomMarshalerGen ("time_t", "System.DateTime", "GLib.time_t_CustomMarshaler"));
			AddType (new ManualGen ("GSList", "GLib.SList"));
			AddType (new ManualGen ("GList", "GLib.List"));
			AddType (new ManualGen ("GValue", "GLib.Value"));
			AddType (new ManualGen ("GObject", "GLib.Object"));
		}
		
		public void AddType (IGeneratable gen)
		{
			types [gen.CName] = gen;
		}
		
		public void AddTypes (IGeneratable[] gens)
		{
			foreach (IGeneratable gen in gens)
				types [gen.CName] = gen;
		}
		
		public int Count {
			get
			{
				return types.Count;
			}
		}
		
		public IEnumerable Generatables {
			get {
				return types.Values;
			}
		}
		
		public IGeneratable this [string ctype] {
			get {
				return DeAlias (ctype) as IGeneratable;
			}
		}

		private string Trim(string type)
		{
			// HACK: If we don't detect this here, there is no
			// way of indicating it in the symbol table
			if (type == "void*" || type == "const-void*") return "gpointer";

			string trim_type = type.TrimEnd('*');

			// HACK: Similar to above, but for const strings
			if (trim_type == "const-gchar" || trim_type == "const-char" || trim_type == "const-xmlChar") return trim_type;
			
			if (trim_type.StartsWith("const-")) return trim_type.Substring(6);
			return trim_type;
		}

		private object DeAlias (string type)
		{
			type = Trim (type);
			while (types [type] is AliasGen) {
				IGeneratable igen = types [type] as AliasGen;
				types [type] = types [igen.Name];
				type = igen.Name;
			}

			return types [type];
		}

		public string FromNativeReturn(string c_type, string val)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.FromNativeReturn (val);
		}
		
		public string ToNativeReturn(string c_type, string val)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.ToNativeReturn (val);
		}

		public string FromNative(string c_type, string val)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.FromNative (val);
		}

		public string GetCSType(string c_type)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.QualifiedName;
		}
		
		public string GetName(string c_type)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.Name;
		}
		
		public string GetMarshalReturnType(string c_type)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.MarshalReturnType;
		}
		
		public string GetMarshalType(string c_type)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.MarshalType;
		}
		
		public string CallByName(string c_type, string var_name)
		{
			IGeneratable gen = this[c_type];
			if (gen == null)
				return "";
			return gen.CallByName(var_name);
		}
	
		public bool IsOpaque(string c_type)
		{
			if (this[c_type] is OpaqueGen)
				return true;

			return false;
		}
	
		public bool IsBoxed(string c_type)
		{
			if (this[c_type] is BoxedGen)
				return true;

			return false;
		}
		
		public bool IsStruct(string c_type)
		{
			if (this[c_type] is StructGen)
				return true;

			return false;
		}
	
		public bool IsEnum(string c_type)
		{
			if (this[c_type] is EnumGen)
				return true;

			return false;
		}
	
		public bool IsEnumFlags(string c_type)
		{
			EnumGen gen = this [c_type] as EnumGen;
			return (gen != null && gen.Elem.GetAttribute ("type") == "flags");
		}
	
		public bool IsInterface(string c_type)
		{
			if (this[c_type] is InterfaceGen)
				return true;

			return false;
		}
		
		public ClassBase GetClassGen(string c_type)
		{
			return this[c_type] as ClassBase;
		}
			
		public bool IsObject(string c_type)
		{
			if (this[c_type] is ObjectGen)
				return true;

			return false;
		}

		public bool IsCallback(string c_type)
		{
			if (this[c_type] is CallbackGen)
				return true;

			return false;
		}

		public bool IsManuallyWrapped(string c_type)
		{
			if (this[c_type] is ManualGen)
				return true;

			return false;
		}

		public string MangleName(string name)
		{
			switch (name) {
			case "string":
				return "str1ng";
			case "event":
				return "evnt";
			case "null":
				return "is_null";
			case "object":
				return "objekt";
			case "params":
				return "parms";
			case "ref":
				return "reference";
			case "in":
				return "in_param";
			case "out":
				return "out_param";
			case "fixed":
				return "mfixed";
			case "byte":
				return "_byte";
			case "new":
				return "_new";
			case "base":
				return "_base";
			case "lock":
				return "_lock";
			case "callback":
				return "cb";
			case "readonly":
				return "read_only";
			case "interface":
				return "iface";
			default:
				break;
			}

			return name;
		}
	}
}
