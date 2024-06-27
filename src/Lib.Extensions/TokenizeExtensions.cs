using Semantica.Extensions.Tokenizer;

namespace Semantica.Extensions
{
    /// <summary>
    /// A number of extension methods used for tokenizing/splitting strings into <see cref="ReadOnlySpan{T}"/>, using a fluent
    /// syntax. The methods cause no heap allocations.   
    /// </summary>
    public static class TokenizeExtensions
    {
        /// <summary>
        /// Finds the part of the input string up until the first occurrence of the separator char, and outputs it as a
        /// <see cref="ReadOnlySpan{T}"/> of chars. Returns a <see cref="CharTokenizer"/> instance to facilitate retrieval of
        /// subsequent tokens.
        /// <list type="bullet">
        /// <item>
        /// <see cref="Next(CharTokenizer,out ReadOnlySpan{char})"/>: Finds the next separator char and outputs a token.
        /// </item>
        /// <item>
        /// <see cref="NextOptional(CharTokenizer,char,out ReadOnlySpan{char})"/>: Finds the next separator char and outputs a token
        /// if it is found.
        /// </item>
        /// <item>
        /// <see cref="Rest(CharTokenizer,out ReadOnlySpan{char})"/>: Ouputs a token containing of the rest of the input string.
        /// </item>
        /// <item> <see cref="Try(CharTokenizer)"/>: Finalizes the tokenizer and returns <see langword="true"/> on success. </item>
        /// </list>
        /// </summary>
        /// <param name="input"> The input string to tokenize. </param>
        /// <param name="separator"> The separator char to find. </param>
        /// <param name="token"> Out paramater containing the first token if the separator is found. </param>
        /// <returns> A <see cref="CharTokenizer"/> instance that should be used as input for the subsequent tokenizer. </returns>
        /// <example>
        /// <code>if (input.Tokenize(',', out var token1).Next(out var token2).Rest(out var token3).Try())</code>
        /// </example>
        public static CharTokenizer Tokenize(
            this string input,
            char separator,
            out ReadOnlySpan<char> token)
        {
            var index = input.IndexOf(separator);
            token = index <= 0 ? default : input.AsSpan(0, index);
            return new CharTokenizer(input, separator, index + 1);
        }

        /// <summary>
        /// Finds the part of the input string up until the first occurrence of the separator string, and outputs it as a
        /// <see cref="ReadOnlySpan{T}"/> of chars. Returns a <see cref="StringTokenizer"/> instance to facilitate retrieval of
        /// subsequent tokens.
        /// <list type="bullet">
        /// <item>
        /// <see cref="Next(CharTokenizer,out ReadOnlySpan{char})"/>: Finds the next separator string and outputs a token.
        /// </item>
        /// <item>
        /// <see cref="NextOptional(CharTokenizer,char,out ReadOnlySpan{char})"/>: Finds the next separator string and outputs a
        /// token if it is found.
        /// </item>
        /// <item>
        /// <see cref="Rest(CharTokenizer,out ReadOnlySpan{char})"/>: Ouputs a token containing of the rest of the input string.
        /// </item>
        /// <item> <see cref="Try(CharTokenizer)"/>: Finalizes the tokenizer and returns <see langword="true"/> on success. </item>
        /// </list>
        /// </summary>
        /// <param name="input"> The input string to tokenize. </param>
        /// <param name="separator"> The separator string to find. </param>
        /// <param name="token"> Out paramater containing the first token if the separator is found. </param>
        /// <param name="stringComparison"> Specifies the rules for the search. </param>
        /// <returns> A <see cref="StringTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        /// <example>
        /// <code>if (input.Tokenize("--", out var token1).Next(out var token2).Rest(out var token3).Try())</code>
        /// </example>
        public static StringTokenizer Tokenize(
            this string input,
            string separator,
            out ReadOnlySpan<char> token,
            StringComparison stringComparison = StringComparison.InvariantCulture)
        {
            if (!input.TryIndexOf(separator, out var index, stringComparison))
            {
                token = default;
                return new StringTokenizer(input, separator, 0, stringComparison);
            }
            token = input.AsSpan(0, index);
            return new StringTokenizer(input, separator, index + separator.Length, stringComparison);
        }

        /// <summary>
        /// Tokenizer method that finds the next occurrence of the separator char in the input string, and outputs the part of the
        /// input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If separator is
        /// not found subsequent searches are skipped.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="CharTokenizer"/>. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="CharTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static CharTokenizer Next(
            this CharTokenizer tokenizer,
            out ReadOnlySpan<char> token)
        {
            if (tokenizer.RestIndex <= 0 || !tokenizer.Input.TryIndexOf(tokenizer.Separator, tokenizer.RestIndex, out var index))
            {
                token = default;
                return tokenizer with { RestIndex = 0 };
            }
            token = tokenizer.Input.AsSpan(tokenizer.RestIndex, index - tokenizer.RestIndex);
            return tokenizer with { RestIndex = index + 1 };
            
        }

        /// <summary>
        /// Tokenizer method that finds the next occurrence of a different separator char in the input string, and outputs the part
        /// of the input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If
        /// separator is not found subsequent searches are skipped.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="CharTokenizer"/>. </param>
        /// <param name="separator"> The new separator char to search for. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="CharTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static CharTokenizer Next(
            this CharTokenizer tokenizer,
            char separator,
            out ReadOnlySpan<char> token) => Next(tokenizer with { Separator = separator }, out token);

        /// <summary>
        /// Tokenizer method that finds the next occurrence of the separator string in the input string, and outputs the part of the
        /// input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If separator is
        /// not found subsequent searches are skipped.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="StringTokenizer"/>. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="StringTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static StringTokenizer Next(
            this StringTokenizer tokenizer,
            out ReadOnlySpan<char> token)
        {
            if (tokenizer.RestIndex <= 0
                || !tokenizer.Input.TryIndexOf(tokenizer.Separator, tokenizer.RestIndex, out var index, tokenizer.StringComparison))
            {
                token = default;
                return tokenizer with { RestIndex = 0 };
            }
            token = tokenizer.Input.AsSpan(tokenizer.RestIndex, index - tokenizer.RestIndex);
            return tokenizer with { RestIndex = index + tokenizer.Separator.Length };
        }

        /// <summary>
        /// Tokenizer method that finds the next occurrence of a different separator string in the input string, and outputs the
        /// part of the input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If
        /// separator is not found subsequent searches are skipped.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="StringTokenizer"/>. </param>
        /// <param name="separator"> The new separator string to search for. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="StringTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static StringTokenizer Next(
            this StringTokenizer tokenizer,
            string separator,
            out ReadOnlySpan<char> token) => Next(tokenizer with { Separator = separator }, out token);

        /// <summary>
        /// Tokenizer method that finds the next occurrence of the separator char in the input string, and outputs the part of the
        /// input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If separator is
        /// not found subsequent searches are not affected.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="CharTokenizer"/>. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="CharTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static CharTokenizer NextOptional(
            this CharTokenizer tokenizer,
            out ReadOnlySpan<char> token)
        {
            if (tokenizer.RestIndex <= 0 || !tokenizer.Input.TryIndexOf(tokenizer.Separator, tokenizer.RestIndex, out var index))
            {
                token = default;
                return tokenizer;
            }
            token = tokenizer.Input.AsSpan(tokenizer.RestIndex, index - tokenizer.RestIndex);
            return tokenizer with { RestIndex = index + 1 };
        }

        /// <summary>
        /// Tokenizer method that finds the next occurrence of a different separator char in the input string, and outputs the part
        /// of the input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If
        /// separator is not found subsequent searches are not affected.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="CharTokenizer"/>. </param>
        /// <param name="separator"> The new separator char to search for. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="CharTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static CharTokenizer NextOptional(
            this CharTokenizer tokenizer,
            char separator,
            out ReadOnlySpan<char> token) => NextOptional(tokenizer with { Separator = separator },  out token);

        /// <summary>
        /// Tokenizer method that finds the next occurrence of the separator string in the input string, and outputs the part of the
        /// input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If separator is
        /// not found subsequent searches are not affected.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="StringTokenizer"/>. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="StringTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static StringTokenizer NextOptional(
            this StringTokenizer tokenizer,
            out ReadOnlySpan<char> token)
        {
            if (tokenizer.RestIndex <= 0
                || !tokenizer.Input.TryIndexOf(tokenizer.Separator, tokenizer.RestIndex, out var index, tokenizer.StringComparison))
            {
                token = default;
                return tokenizer;
            }
            var length = index - tokenizer.RestIndex;
            token = length <= 0 ? default : tokenizer.Input.AsSpan(tokenizer.RestIndex, length);
            return tokenizer with { RestIndex = index + tokenizer.Separator.Length };
        }

        /// <summary>
        /// Tokenizer method that finds the next occurrence of a different separator string in the input string, and outputs the
        /// part of the input between the found and the previously found separator as a <see cref="ReadOnlySpan{T}"/> of chars. If
        /// separator is not found subsequent searches are not affected.
        /// </summary>
        /// <param name="tokenizer"> A <see cref="StringTokenizer"/>. </param>
        /// <param name="separator"> The new separator string to search for. </param>
        /// <param name="token"> Out paramater containing the next token if the separator is found. </param>
        /// <returns> A <see cref="StringTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static StringTokenizer NextOptional(
            this StringTokenizer tokenizer,
            string separator,
            out ReadOnlySpan<char> token) => NextOptional(tokenizer with { Separator = separator },  out token);

        /// <summary>
        /// Tokenizer method that outputs the part of the input string after the last found separator. 
        /// </summary>
        /// <param name="tokenizer"> A <see cref="CharTokenizer"/>. </param>
        /// <param name="token"> Out paramater containing the last token. </param>
        /// <returns> A <see cref="CharTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static CharTokenizer Rest(
            this CharTokenizer tokenizer,
            out ReadOnlySpan<char> token)
        {
            var length = tokenizer.Input.Length - tokenizer.RestIndex;
            token = length <= 0 ? default : tokenizer.Input.AsSpan(tokenizer.RestIndex, length);
            return tokenizer;
        }

        /// <summary>
        /// Tokenizer method that outputs the part of the input string after the last found separator. 
        /// </summary>
        /// <param name="tokenizer"> A <see cref="StringTokenizer"/>. </param>
        /// <param name="token"> Out paramater containing the last token. </param>
        /// <returns> A <see cref="StringTokenizer"/> instance that subsequent tokenizer methods can be called on. </returns>
        public static StringTokenizer Rest(
            this StringTokenizer tokenizer,
            out ReadOnlySpan<char> token)
        {
            var length = tokenizer.Input.Length - tokenizer.RestIndex;
            token = length <= 0 ? default : tokenizer.Input.AsSpan(tokenizer.RestIndex, length);
            return tokenizer;
        }

        /// <summary>
        /// Tokenizer finalizer method that determines if all previously searched (non-optional) tokens have been found, and the
        /// rest of the input does not contain any more of the last searched separator. 
        /// </summary>
        /// <param name="tokenizer"> A <see cref="CharTokenizer"/>. </param>
        /// <returns>
        /// <see langword="true"/> if all expected (non-optional) tokens have been found, and the rest does not contain more
        /// separators; <see langword="false"/> otherwise.
        /// </returns>
        public static bool Try(this CharTokenizer tokenizer)
        {
            return tokenizer.RestIndex > 0 && tokenizer.Input.IndexOf(tokenizer.Separator, tokenizer.RestIndex) == -1;
        }

        /// <summary>
        /// Tokenizer finalizer method that determines if all previously searched (non-optional) tokens have been found, and the
        /// rest of the input does not contain any more of the last searched separator. 
        /// </summary>
        /// <param name="tokenizer"> A <see cref="StringTokenizer"/>. </param>
        /// <returns>
        /// <see langword="true"/> if all expected (non-optional) tokens have been found, and the rest does not contain more
        /// separators; <see langword="false"/> otherwise.
        /// </returns>
        public static bool Try(this StringTokenizer tokenizer)
        {
            return tokenizer.RestIndex > 0
                   && tokenizer.Input.IndexOf(tokenizer.Separator, tokenizer.RestIndex, tokenizer.StringComparison) == -1;
        }
    }

    namespace Tokenizer
    {
        /// <summary>
        /// Struct that contains the intermediate result of a
        /// <see cref="TokenizeExtensions.Tokenize(string,char,out ReadOnlySpan{char})"/> call, on which the fluentAPI-like
        /// extensions are based.  
        /// </summary>
        /// <param name="Input"> String that's being tokenized. </param>
        /// <param name="Separator"> Separator char that was previously searched for. </param>
        /// <param name="RestIndex">
        /// Index of the character in <paramref name="Input"/> directly after the previously found separator. A value of 0 means that
        /// a previous (non-optional) separator was not found, and all subsequent tokenizing will be skipped.
        /// </param>
        public readonly record struct CharTokenizer(string Input, char Separator, int RestIndex);

        /// <summary>
        /// Struct that contains the intermediate result of a
        /// <see cref="TokenizeExtensions.Tokenize(string,string,out ReadOnlySpan{char},StringComparison)"/> call, on which the
        /// fluentAPI-like extensions are based.  
        /// </summary>
        /// <param name="Input"> String that's being tokenized. </param>
        /// <param name="Separator"> Separator string that was previously searched for. </param>
        /// <param name="RestIndex">
        /// Index of the character in <paramref name="Input"/> directly after the previously found separator. A value of 0 means that
        /// a previous (non-optional) separator was not found, and all subsequent tokenizing will be skipped.
        /// </param>
        /// <param name="StringComparison"> Specifies the rules for the search. </param>
        public readonly record struct StringTokenizer(
            string Input,
            string Separator,
            int RestIndex,
            StringComparison StringComparison);
    }
}
