﻿using System;
using System.Collections.Generic;

using Bau.Libraries.LibRest.Messages.Parameters;

namespace Bau.Libraries.LibRest.Messages
{
	/// <summary>
	///		Clase base para los mensajes
	/// </summary>
	public abstract class BaseMessage
	{
		public BaseMessage()
		{ Headers = new Headers.HeadersCollection();
		}

		/// <summary>
		///		Cabeceras
		/// </summary>
		public Headers.HeadersCollection Headers { get; set; }
	}
}
