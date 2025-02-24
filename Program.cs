﻿using Armstrong.SecretTool.Models;
using Armstrong.SecretTool.Utilits;

namespace Armstrong.SecretTool
{
    public static class Propgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Constants.TextConstants.Licence);
            
            JsonParser.GetSecrets();

            Console.ReadLine();

            int input;

            Console.WriteLine(Constants.TextConstants.ActionChoice);
            Console.Write(Constants.TextConstants.PromptToInput);

            while (!(int.TryParse(Console.ReadLine(), out input) && (input > 0 && input < 4)))
            {
                Console.Write(Constants.TextConstants.WrongInput);
            }

            Secrets secrets = JsonParser.GetSecrets() as Secrets;

            EnvironmentHelper.SetEnvironments(secrets: secrets, (SecretType)input);
            EnvironmentHelper.GetEnvironments(secrets: secrets, (SecretType)input);

            Console.WriteLine("Done!");

            Console.ReadLine();
        }
    }
}