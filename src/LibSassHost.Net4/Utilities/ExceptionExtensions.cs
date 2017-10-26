﻿#if NET40
using System;
using System.Reflection;

namespace LibSassHost.Utilities
{
	/// <summary>
	/// Exception extensions
	/// </summary>
	internal static class ExceptionExtensions
	{
		/// <summary>
		/// Preserves a stack trace of exception
		/// </summary>
		/// <param name="source">The exception</param>
		public static void PreserveStackTrace(this Exception source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}

			MethodInfo preserveStackTraceMethodInfo = typeof(Exception).GetMethod("InternalPreserveStackTrace",
				BindingFlags.Instance | BindingFlags.NonPublic);
			preserveStackTraceMethodInfo.Invoke(source, null);
		}
	}
}
#endif