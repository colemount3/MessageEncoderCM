// See https://aka.ms/new-console-template for more information
using System;


class Program
{
   
    static void Main(string[] args)
    {
        //int[] possibleValues = { 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126 };
        int modUni = 0;
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

        Console.WriteLine("Please Enter the message you would like to encode");
        input = Console.ReadLine();
        Console.WriteLine("Please create your a key");
        string stringkey = Console.ReadLine();
        int key = int.Parse(stringkey);
        //string encodedMessage = Encode(input, key);
        Console.WriteLine("Your encoded message is");
        



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
       


        


        char Encodedchar = '0';
        int modUni = 0;
        //setting encoded message to random possible values
        for (int i = 0; i < j; i++)
        {
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

        Console.WriteLine("Please enter the message you would like to deciepher");
        string message = Console.ReadLine();
        Console.WriteLine("Please enter the key");
        stringkeyinput = Console.ReadLine();
        int keyinput = int.Parse(stringkeyinput);
       // string DecipherMessage = Decode(message, keyinput);
        Console.WriteLine(DecipherMessage);

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

        ////////////////////

        string decodedMessage = "";
       

        


        

        for (int i = 0; i < message.Length; i++)
        {
            int modUnidecode = 0;
            int unicode = (int)message[i];
            for (int x = 0; x < possibleValues.Length; x++)
            {
                modUnidecode++;
                if (possibleValues[x] == message[i])
                { break; }
                    



            }
         

            char Decodedchar = (char)(modUnidecode + 30);
           

            decodedMessage += Decodedchar;
            

        }
        
        Console.WriteLine(decodedMessage);
        return ("");
    }
}






