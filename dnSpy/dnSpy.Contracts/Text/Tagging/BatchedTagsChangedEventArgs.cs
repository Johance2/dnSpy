﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace dnSpy.Contracts.Text.Tagging {
	/// <summary>
	/// Batched tags changed event args
	/// </summary>
	public sealed class BatchedTagsChangedEventArgs : EventArgs {
		/// <summary>
		/// Gets the spans
		/// </summary>
		public ReadOnlyCollection<IMappingSpan> Spans { get; }

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="spans">Spans</param>
		public BatchedTagsChangedEventArgs(IList<IMappingSpan> spans) {
			if (spans == null)
				throw new ArgumentNullException(nameof(spans));
			Spans = new ReadOnlyCollection<IMappingSpan>(spans);
		}
	}
}
