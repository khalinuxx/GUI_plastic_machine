using System;
using System.IO.Ports;
public class SerialPortManager
{
	private static SerialPort _serialPort;
	private SerialPortManager() { }
    public static SerialPort GetInstance()
    {
        if (_serialPort == null)
        {
            _serialPort = new SerialPort();
            // Initialize serial port settings here
        }
        return _serialPort;
    }

    public static void SetSerialPortParameters(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
    {
        if (_serialPort != null)
        {
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.Parity = parity;
            _serialPort.DataBits = dataBits;
            _serialPort.StopBits = stopBits;
        }
    }
}
