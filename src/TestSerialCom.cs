using System;
using System.Text;
using Serial;

public class TestSerialCOM {
    
    public static void TestCom() {
        CommandLineInterface cli = new CommandLineInterface();

        Console.Write("Enter port number: ");
        String portName = "COM" + cli.PromptInt();

        SerialCom com = new SerialCom(portName, 9600, 0, 8, 1);
        try {
            com.Open();

            Console.Write("Enter data to trasmit: ");
            try {
                String data = cli.PromptString();
                ASCIIEncoding ascii = new ASCIIEncoding();
                String decodedString = ascii.GetString(ascii.GetBytes(data));
                com.Write(decodedString);
            } catch (Exception e) {
                Console.WriteLine(e);
            }

            com.Close();
        } catch (SerialException e) {
            Console.WriteLine("Can't open port " + com.GetPortName() + "!");
        }
    }
    
    public static int Main(String[] args) {
        TestCom();
        
        Console.WriteLine("Press key to finish..");
        Console.ReadKey();
        return 0;
    }

}