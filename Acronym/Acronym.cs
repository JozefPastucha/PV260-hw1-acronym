using System;

namespace Acronym
{
    public static class Acronym
    {
        public static string Create(string sentence)
        {
            if (sentence == null)
            {
                throw new ArgumentNullException(nameof(sentence));
            }

            return sentence;
        }
    }
}
