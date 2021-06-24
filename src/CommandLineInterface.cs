using System;

public class CommandLineInterface {
    
    public CommandLineInterface() {

    }

    public string PromptString() {
        return Console.ReadLine();
    }

    public int PromptInt() {
        try {
            return Convert.ToInt32(PromptString());
        } catch (FormatException e) {
            Console.Write("You must enter a number, try again: ");
            return PromptInt();
        }
    }

}