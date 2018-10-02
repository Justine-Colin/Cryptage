using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLIN_Justine_Cryptage
{
    class Vigenere
    {        
        public static String Encryption(String texte, String cle)
        {
            char[] Text = texte.ToCharArray();
                       StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Text.Length; i++)
            { 
                if (Text[i] < 65 || Text[i] > 90)
                { //ASCII character (capital letter)
                    throw new InvalidProgramException("" +
                            "Le texte doit être en lettres majuscules uniquement");
                }
                //add shift modularly
                char encyphered = Text[i] + getShift(cle, i) > 90 ? (char)((Text[i] + getShift(cle, i)) - 26) : (char)(Text[i] + getShift(cle, i));
                builder.Append(encyphered);
            }
            return builder.ToString();
        }

        public static String Decryption(String texte, String cle)
        {
            char[] Text = texte.ToCharArray();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] < 65 || Text[i] > 90)
                { //ASCII character (capital letter)
                    throw new InvalidProgramException("" +
                            "La clé doit être en lettres majuscules uniquement");
                }
                //subtract shift modularly
                char decyphered = Text[i] - getShift(cle, i) < 65 ? (char)((Text[i] - getShift(cle, i)) + 26) : (char)(Text[i] - getShift(cle, i));
                builder.Append(decyphered);
            }
            return builder.ToString();
        }

        private static int getShift(String cle, int i)
        {
            char[] Key = cle.ToCharArray();
            if (Key[i % Key.Length] < 65 || Key[i % Key.Length] > 90)
            {
                throw new InvalidProgramException("" +
                            "La clé doit être en lettres majuscules uniquement");
            }
            return ((int)Key[i % Key.Length]) - 65;
        }
    }
}
