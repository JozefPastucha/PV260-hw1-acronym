using System;
using System.Linq;

namespace Acronym
{
    public static class Acronym
    {
        private static char[] wordSeparators =
        {
            ' ',
            '-',
            '–',
            '—'
        };

    public static string Create(string sentence)
        {
            if (sentence == null)
            {
                throw new ArgumentNullException(nameof(sentence));
            }

            if (sentence == string.Empty)
            {
                return sentence;
            }

            var s = sentence.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(String.Empty, s.Select(item => item[0].ToString().ToUpper()));
        }
    }
}
