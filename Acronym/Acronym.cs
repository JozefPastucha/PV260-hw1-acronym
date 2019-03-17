using System;
using System.Linq;

namespace Acronym
{
    /*
     * For omitting articles, prepositions or conjunctions, replacing "and" with & I would add
     * boolean parameters for the Create method, so the user could choose which parts of speech
     * he wants to omit.
     */
    public static class Acronym
    {
        private static char[] WORD_DIVIDERS =
        {
            ' ',
            '-',
            '–',
            '—'
            //expect space after tilde, slash, comma or dot
            //don't expect underscore in a text
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

            var sentenceSplit = sentence.Split(WORD_DIVIDERS, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(String.Empty, sentenceSplit.Select(word => word[0].ToString().ToUpper()));
        }
    }
}
