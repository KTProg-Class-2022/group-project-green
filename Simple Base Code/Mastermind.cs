using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Base_Code
{
    //class for mastermind
    class Mastermind
    {
        public string password;
        public bool completed;
        int[] array;
        int[] array2;
        //call this class with the word to initialize the mastermind game
        public Mastermind(string theWord)
        {
            theWord = theWord.ToLower();
            password = theWord;
            completed = false;
          
        }

        int pos = 0;
        
        public void getNext3Chars()
        {
            Console.WriteLine("You ate a circus peanut");
            if (pos + 3 < password.Length-1)
            {
                pos = pos + 3;
                Console.WriteLine("you now know another 3 characters");
                Console.Write("known Characters : ");
                for(int i = 0; i < pos; i++)
                {
                    Console.Write(password[i]);
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("you now know the full password it is: " + password);
            }
        }

        public int getLength()
        {
            return password.Length;
        }
        public bool guess(string guessedWord)
        {
            guessedWord = guessedWord.ToLower();
            if(guessedWord.Length == password.Length) {
                array = new int[password.Length];
                array2 = new int[password.Length];
                if (password == guessedWord)
                {
                    completed = true;
                    return true;
                }        
                else
                {
                    int correctPos = 0;
                    int correctLetter = 0;
                    int badLetter = 0;
                    for(int i = 0; i < guessedWord.Length; i++)
                    {
                        if (guessedWord[i] == password[i]) {
                            correctPos++;
                            array[i] = 1;
                            array2[i] = 1;
                        }
                    }
                    for (int i = 0; i < guessedWord.Length; i++)
                    {
                        bool letterExistsInWord = false;
                        for(int j = 0; j<password.Length; j++)
                        {
                            if(guessedWord[i] == password[j] && (array[i]!=1 && array2[j]!=1))
                            {
                                array[i] = 1;
                                array2[j] = 1;
                                correctLetter++;
                                letterExistsInWord = true;
                            }
                        }
                        if(letterExistsInWord == false && array[i] != 1)
                        {
                            badLetter++;
                        }

                    }
                    Console.WriteLine("correct position {0}, correct letter {1}, bad letter {2}", correctPos, correctLetter, badLetter);
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Input not of correct length or not a command");
                return false;
            }
        }

    }
}
