namespace WorldLib
{
    public class WorderTDD
    {


        public string IsPalindromeWord(string inputWord)
        {

         
            if (string.IsNullOrEmpty(inputWord))
            {
                throw new ArgumentException("Input string can't be empty.Try again");
            }

            string inputString, reverseString = string.Empty;
            inputString = inputWord;


           

            for (int i = inputWord.Length - 1; i >= 0; i--)
            {
                reverseString += inputWord[i];
            }

            return reverseString;



        }

        public int CheckingString(string inputWord)
        {

  
            if (string.IsNullOrEmpty(inputWord))
            {
                throw new ArgumentException("Input string can't be empty.Try again");
            }

            int numbersInLetter = inputWord.Length;

            return numbersInLetter;
        }
    }
}