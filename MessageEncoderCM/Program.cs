// See https://aka.ms/new-console-template for more information
using System;


class Program
{
   
    static void Main(string[] args)
    {
        

        while (true)

        {
            try
            {
              
              
                //MENU

                Console.WriteLine("Would you like to encode or decode?");
                string selection = Console.ReadLine();
                if (selection == "encode" || selection == "Encode" || selection == "ENCODE" )
                {
                    Encode();
                }
                else if (selection =="decode" || selection == "Decode" || selection == "DECODE")
                {
                    Decode();
                }
                else
                {
                    Console.WriteLine("Invalid input, please type encode or decode");
                }
                 


               
                //await response
                Console.ReadKey();
            }

            catch
            { Console.WriteLine("ERROR"); }
        }

    }
    static string Encode()
    {
        string input = "";
        string encodedMessage = "";
        string encodedUniMessage = "";
        int modUni = 0;
        //prompt user for input
        Console.WriteLine("Please Enter the message you would like to encode");
        input = Console.ReadLine();
        Console.WriteLine("Please create your a key");
        string stringkey = Console.ReadLine();
        int key = int.Parse(stringkey);
        Console.WriteLine("Your encoded message is");

        //message printed at end of Encode
        



        int[] possibleValues = { 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126 };
        //randomizing the array
        int j = input.Length;

        Random rng = new Random(key);


        //change possible values based on key
        //Fisher-Yates shuffle algorithm
        for (int i = possibleValues.Length - 1; i >= 1; i--)
        {
            // Generate a random index j between 0 and i (inclusive) using the Random object
            int r = rng.Next(i);

            // Swap the element at index i with the element at index j

            int temp = possibleValues[r];
            possibleValues[r] = possibleValues[i];
            possibleValues[i] = temp;

        }


        //setting encoded message to random possible values using each chars unicode value as an index
        char Encodedchar = '0';
        for (int i = 0; i < j; i++)
        {
            //if input is unrecognized it will not be encoded
            try
            {
                int unicode = (int)input[i];
                 modUni = possibleValues[unicode - 31];
            }
            catch
            { Encodedchar = input[i];  }
           

           Encodedchar = (char)modUni;

            encodedMessage += Encodedchar;
            

        }
        Console.WriteLine(encodedMessage);

        return ("");





    }
    static string Decode()

    {
        string stringkey = "";
        string stringkeyinput = "";
        string DecipherMessage = "";

        //prompt user for input

        Console.WriteLine("Please enter the message you would like to deciepher");
        string message = Console.ReadLine();
        Console.WriteLine("Please enter the key");
        stringkeyinput = Console.ReadLine();
        int keyinput = int.Parse(stringkeyinput);
        Console.WriteLine(DecipherMessage);

        //must randomize array seperately in case key is different from encoding or user does not encode
        int[] possibleValues = { 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126 };

        //randomizing the array


        Random rng = new Random(keyinput);


        //change possible values based on key
        //Fisher-Yates shuffle algorithm
        for (int i = possibleValues.Length - 1; i >= 1; i--)
        {
            // Generate a random index j between 0 and i (inclusive) using the Random object
            int r = rng.Next(i);

            // Swap the element at index i with the element at index j

            int temp = possibleValues[r];
            possibleValues[r] = possibleValues[i];
            possibleValues[i] = temp;

        }


        string decodedMessage = "";


        for (int i = 0; i < message.Length; i++)
        {
            int modUnidecode = 0;
            int unicode = (int)message[i];

            //nested for loop checks if each value in the random array is the value of encoded char, counts how many it takes to get to value, to find what index was
            for (int x = 0; x < possibleValues.Length; x++)
            {
                modUnidecode++;
                if (possibleValues[x] == message[i])
                { break; }
                    



            }
         
            //converts index unicode number back to letter
            char Decodedchar = (char)(modUnidecode + 30);
           

            decodedMessage += Decodedchar;
            

        }
        
        Console.WriteLine(decodedMessage);
        return ("");
    }
}






