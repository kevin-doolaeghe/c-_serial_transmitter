using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace Serial {

    class SerialException : Exception {

        public SerialException() : base() { }
        
        public SerialException(string message) : base(message) { }
        
        public SerialException(string message, Exception inner) : base(message, inner) { }

    }

    class SerialCom {

        private SerialPort port;

        public SerialCom() {
            this.port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);
        }

        public SerialCom(String port, int speed, int parity, int data, int stop) {
            this.port = new SerialPort(port, speed, (Parity) parity, data, (StopBits) stop);
        }

        public void Open() {
            try {
                port.Open();
            } catch (IOException e) {
                throw new SerialException(e.Message);
            }
        }

        public void Close() {
            port.Close();
        }

        public String ReadAll() {
            return port.ReadExisting();
        }

        public String ReadLine() {
            return port.ReadLine();
        }

        public void Write(String data) {
            port.Write(data);
        }

        public String GetPortName() {
            return port.PortName;
        }

    }

}