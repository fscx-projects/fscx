using Microsoft.FSharp.Core;
using System;
using System.Globalization;

[CompilationMapping(SourceConstructFlags.Module)]
public static class FscxOutputSample1
{
	public static void f1(int a, string b, int c)
	{
		try
		{
			object obj = "Sample1: {0}:{1}";
			string arg_49_0;
			if (obj != null)
			{
				IFormattable formattable = obj as IFormattable;
				if (formattable != null)
				{
					IFormattable formattable2 = formattable;
					arg_49_0 = formattable2.ToString(null, (IFormatProvider)CultureInfo.InvariantCulture);
				}
				else
				{
					object obj2 = obj;
					arg_49_0 = obj2.ToString();
				}
			}
			else
			{
				arg_49_0 = "";
			}
			string arg_8D_0 = arg_49_0 + ", ";
			obj = a;
			string arg_8D_1;
			if (obj != null)
			{
				IFormattable formattable = obj as IFormattable;
				if (formattable != null)
				{
					IFormattable formattable2 = formattable;
					arg_8D_1 = formattable2.ToString(null, (IFormatProvider)CultureInfo.InvariantCulture);
				}
				else
				{
					object obj2 = obj;
					arg_8D_1 = obj2.ToString();
				}
			}
			else
			{
				arg_8D_1 = "";
			}
			string arg_DB_0 = arg_8D_0 + arg_8D_1 + ", ";
			obj = b;
			string arg_DB_1;
			if (obj != null)
			{
				IFormattable formattable = obj as IFormattable;
				if (formattable != null)
				{
					IFormattable formattable2 = formattable;
					arg_DB_1 = formattable2.ToString(null, (IFormatProvider)CultureInfo.InvariantCulture);
				}
				else
				{
					object obj2 = obj;
					arg_DB_1 = obj2.ToString();
				}
			}
			else
			{
				arg_DB_1 = "";
			}
			string args = arg_DB_0 + arg_DB_1;
			Console.WriteLine("calling System.Console.WriteLine [9行,4列目]. args: {0}", args);
			Console.WriteLine("Sample1: {0}:{1}", a, b);
			Console.WriteLine("called System.Console.WriteLine [9行,4列目]. args: {0}", null);
		}
		catch (object arg_10C_0)
		{
			Exception e = (Exception)arg_10C_0;
			Console.WriteLine("raised exn from System.Console.WriteLine [9行,4列目]. exn: {0}", e);
			throw;
		}
	}
}
