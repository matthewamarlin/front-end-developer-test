using System;

namespace Question3
{
    public class Dna
    {
        public static string ToRna(String dna)
        {
            var output = string.Empty;

            for (var i = 0; i < dna.Length; i++)
            {
                char current = dna[i];

                if (current == 'G')
                {
                    output += 'C';
                }
                else if (current == 'C')
                {
                    output += 'G';
                }
                else if (current == 'T')
                {
                    output += 'A';
                }
                else if (current == 'A')
                {
                    output += 'U';
                }
                else
                {
                    output += current;
                }
            }

            return output;
        }
    }
}