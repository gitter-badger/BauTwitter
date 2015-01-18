﻿using System;
using System.Collections.Generic;

namespace Bau.Libraries.LibMarkupLanguage
{
	/// <summary>
	///		Colección de <see cref="MLNameSpace"/>
	/// </summary>
	public class MLNameSpacesCollection : List<MLNameSpace>
	{
		/// <summary>
		///		Añade un espacio de nombres
		/// </summary>
		public void Add(string strPrefix, string strNameSpace)
		{ if (!Exists(strPrefix))
				Add(new MLNameSpace(strPrefix, strNameSpace));
		}

		/// <summary>
		///		Comprueba si existe un prefijo
		/// </summary>
		private bool Exists(string strPrefix)
		{ // Recorre la colección
				foreach (MLNameSpace objNameSpace in this)
					if (objNameSpace.Prefix == strPrefix)
						return true;
			// Si ha llegado hasta aquí es porque no ha encontrado nada
				return false;
		}
	}
}
