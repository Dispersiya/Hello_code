// See https://aka.ms/new-console-template for more information
 static void Main(string[] args)
        {
            Console.Write("Enter something for to check that is it palindrome :");
            string text = Console.ReadLine();
            int len = text.Length;
            bool flag = true;
 
            //check palindrome
            for (int i = 0; i < len/2; i++)
            {
                if (text[i] != text[len - (i + 1)])
                {
                    flag = false;
                    break;
                }
            }
 
            //if flag true, text is palindrome
            if (flag)
            {
                Console.WriteLine("{0} is palindrome", text);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", text);
            }
            Console.ReadLine();
        }
static bool IsPalindrom(string word, bool ignoreCase = true)
{
    if (ignoreCase)
    {
        word = word.ToLowerInvariant();
    }

    for (int first = 0, last = word.Length - 1; first < last; ++first, --last)
    {
        if (word[first] != word[last])
        {
            return false;
        }
    }

    return true;
}