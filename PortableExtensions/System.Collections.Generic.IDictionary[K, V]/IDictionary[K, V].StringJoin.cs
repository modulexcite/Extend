﻿#region Using

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace PortableExtensions
{
    /// <summary>
    ///     Class containing some extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
// ReSharper disable once InconsistentNaming
    public static partial class IDictionaryEx
    {
        /// <summary>
        /// Concatenates all the elements of a dictionary  using the specified separator between each element.
        /// </summary>
        /// <exception cref="ArgumentNullException">The dictionary can not be null.</exception>
        /// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
        /// <typeparam name="TKey">The type of the keys in the dictionary.</typeparam>
        /// <param name="dictionary">A dictionary that contains the elements to concatenate.</param>
        /// <param name="keyValueSeparator">The string to use as a separator between each key and value.</param>
        /// <param name="separator">
        ///     The string to use as a separator.
        ///     The separator is included in the returned string only if the given dictionary has more than one item.
        /// </param>
        /// <returns>
        ///     A string that consists of the elements in the dictionary delimited by the separator string.
        ///     If the given dictionary is empty, the method returns String.Empty.
        /// </returns>
        public static String StringJoin<TValue, TKey>( this IDictionary<TValue, TKey> dictionary, String keyValueSeparator = "=", String separator = "" )
        {
            dictionary.ThrowIfNull( () => dictionary );

            return dictionary.Select( x => x.Key + keyValueSeparator + x.Value ).StringJoin( separator );
        }
    }
}