using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace QRemoteNET
{
  public class QRemote
  {
    private string _remoteAddress = "127.0.0.1";
    private int _port = 5583;

    private TcpClient QRClient;
    private NetworkStream QRStream;
    private BinaryWriter QRWriter;

    #region Public Properties

    public string RemoteAddress
    {
      get { return _remoteAddress; }
      set { _remoteAddress = value; }
    }

    public int Port
    {
      get { return _port; }
      set { _port = value; }
    }

    public bool Connected
    {
      get { return QRClient.Connected; }
    }

    #endregion

    public QRemote(string RemoteIP = "127.0.0.1", int RemotePort = 5583)
    {
      _remoteAddress = RemoteIP;
      _port = RemotePort;
    }


    #region Connection Functions

    public int Connect()
    {
      var retVal = -2;

      try
      {
        if (QRClient != null)
        {
          if (QRClient.Connected)
            QRClient.Close();
        }

        QRClient = new TcpClient(_remoteAddress, _port);
        QRStream = QRClient.GetStream();
        QRWriter = new BinaryWriter(QRStream);

        retVal = 0;
      }
      catch (IOException exception)
      {
        //Log(exception.StackTrace);
      }

      return retVal;
    }

    public void Disconnect()
    {
      if (QRWriter != null)
        QRWriter.Close();

      if (QRStream != null)
        QRStream.Close();

      if (QRClient != null)
        if (QRClient.Connected)
          QRClient.Close();
    }

    #endregion

    #region Remote Commands

    public void MoveMouse(int x, int y)
    {
      if (!QRClient.Connected)
        throw new IOException("Socket is disconnected");

      try
      {
        var val = ConvertCompoundTouchCommand(x, y);
        QRWriter.Write(val);
        QRWriter.Flush();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public void ClickMouse(bool IsLeftButton = true)
    {
      handleCompoundCommand(5, 4, IsLeftButton ? 0 : 1);
    }

    #endregion

    #region Utility Functions
    public void handleCompoundCommand(int i, int j, int k)
    {
      if (!QRClient.Connected)
        throw new IOException("Socket is disconnected");

      try
      {
      var val = ConvertCompoundKeyCommand(i, j, k);
      QRWriter.Write(val);
      QRWriter.Flush();
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    private static byte[] ConcatenateByteArrays(byte[] abyte0, byte[] abyte1, byte[] abyte2, byte[] abyte3)
    {
      var abyte4 = new byte[abyte0.Length + abyte1.Length + abyte2.Length + abyte3.Length];
      Array.Copy(abyte0, 0, abyte4, 0, abyte0.Length);
      Array.Copy(abyte1, 0, abyte4, abyte0.Length, abyte1.Length);
      Array.Copy(abyte2, 0, abyte4, abyte0.Length + abyte1.Length, abyte2.Length);
      Array.Copy(abyte3, 0, abyte4, abyte0.Length + abyte1.Length + abyte2.Length, abyte3.Length);
      return abyte4;
    }

    private static byte[] ConcatenateTwoKeyEventByteArray(byte[] abyte0, byte[] abyte1)
    {
      var abyte2 = new byte[abyte0.Length + abyte1.Length];
      Array.Copy(abyte0, 0, abyte2, 0, abyte0.Length);
      Array.Copy(abyte1, 0, abyte2, abyte0.Length, abyte1.Length);
      return abyte2;
    }

    public static byte[] ConvertCompoundKeyCommand(int i, int j, int k)
    {
      return ConcatenateTwoKeyEventByteArray(IntToByteArray(i, k, 0, 0), IntToByteArray(j, k, 0, 0));
    }

    public static byte[] ConvertCompoundTouchCommand(int i, int j)
    {
      return ConcatenateTwoKeyEventByteArray(IntToByteArray(6, i, 0, 0), IntToByteArray(7, j, 0, 0));
    }

    public static byte[] ConvertOneCommand(int i, int j)
    {
      return IntToByteArray(i, j, 0, 0);
    }

    private static byte[] IntToByteArray(int i, int j, int k, int l)
    {
      var bI = BitConverter.GetBytes(i);
      var bJ = BitConverter.GetBytes(j);
      var bK = BitConverter.GetBytes(k);
      var bL = BitConverter.GetBytes(l);

      Array.Reverse(bI, 0, bI.Length);
      Array.Reverse(bJ, 0, bI.Length);
      Array.Reverse(bK, 0, bI.Length);
      Array.Reverse(bL, 0, bI.Length);

      return ConcatenateByteArrays(bI, bJ, bK, bL);
    }
    #endregion
  }
}

