﻿#region Usings

using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

#endregion

namespace Extend
{
    public static partial class StringEx
    {
        /// <summary>
        ///     Searches the specified input string for the first occurrence of the specified regular expression.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>An object that contains information about the match.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static Match Match( [NotNull] this String input, [NotNull] String pattern )
        {
            input.ThrowIfNull( nameof( input ) );
            input.ThrowIfNull( nameof( pattern ) );

            return Regex.Match( input, pattern );
        }

        /// <summary>
        ///     Searches the input string for the first occurrence of the specified regular expression, using the specified
        ///     matching options.
        /// </summary>
        /// <exception cref="ArgumentNullException">input can not be null.</exception>
        /// <exception cref="ArgumentNullException">pattern can not be null.</exception>
        /// <param name="input">The string to search for a match.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
        /// <returns>An object that contains information about the match.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static Match Match( [NotNull] this String input, [NotNull] String pattern, RegexOptions options )
        {
            input.ThrowIfNull( nameof( input ) );
            input.ThrowIfNull( nameof( pattern ) );

            return Regex.Match( input, pattern, options );
        }

#if PORTABLE45
/// <summary>
///     Searches the input string for the first occurrence of the specified regular expression, using the specified
///     matching options.
/// </summary>
/// <exception cref="ArgumentNullException">input can not be null.</exception>
/// <exception cref="ArgumentNullException">pattern can not be null.</exception>
/// <param name="input">The string to search for a match.</param>
/// <param name="pattern">The regular expression pattern to match.</param>
/// <param name="options">A bitwise combination of the enumeration values that provide options for matching.</param>
/// <param name="timeOut">The timeout for the regular expression operation.</param>
/// <returns>An object that contains information about the match.</returns>
        [NotNull]
        [Pure]
        [PublicAPI]
        public static Match Match( [NotNull] this String input, [NotNull] String pattern, RegexOptions options, TimeSpan timeOut )
        {
            input.ThrowIfNull( nameof( input ) );
            input.ThrowIfNull( nameof( pattern ) );
            timeOut.ThrowIfNull( nameof( timeOut ) );

            return Regex.Match( input, pattern, options, timeOut );
        }
#endif
    }
}