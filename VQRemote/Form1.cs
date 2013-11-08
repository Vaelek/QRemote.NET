using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;
using VQRemote.Utils;
using QRemoteNET;

namespace VQRemote
{
  public partial class Form1 : Form
  {
    private readonly KeyboardHook keyhook;
    private Keys RemoteSwitch = Keys.M;
    private Keys LocalSwitch = Keys.H;
    private ModifierKeys modifierKeys = (ModifierKeys)3; // Control + Alt
    private MouseHookListener mouseHook;
    private QRemote remote;
    private static readonly Point ScreenCenter = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);

    public Form1()
    {
      InitializeComponent();
      keyhook = new KeyboardHook();
      keyhook.KeyPressed += KeyhookOnKeyPressed;
      keyhook.RegisterHotKey(modifierKeys, RemoteSwitch);
      keyhook.RegisterHotKey(modifierKeys, LocalSwitch);
      mouseHook = new MouseHookListener(new GlobalHooker());
      mouseHook.MouseDownExt += GlobalMouseClickListener;
      mouseHook.MouseMoveExt += GlobalMouseMoveListener;

      remote = new QRemote(txtRemoteIP.Text.Trim());
      remote.Connect();
    }

    private void GlobalMouseMoveListener(object sender, MouseEventExtArgs e)
    {
      var x = e.Location.X - ScreenCenter.X;
      var y = e.Location.Y - ScreenCenter.Y;

      if (chkMouseAccel.Checked)
      {
        x *= 2;
        y *= 2;
      }

      lblCoords.Text = String.Format("X: {0}  Y: {1}", x, y);

      remote.MoveMouse(x, y);
      Cursor.Position = ScreenCenter;
      e.Handled = true;
    }

    private void GlobalMouseClickListener(object sender, MouseEventExtArgs e)
    {
      switch (e.Button)
      {
        case MouseButtons.Left:
          textBox1.AppendText("Left Click\n");
          remote.ClickMouse();
          e.Handled = true;
          break;

          case MouseButtons.Right:
          textBox1.AppendText("Right Click\n");
          remote.ClickMouse(false);
          e.Handled = true;
          break;
      }
    }

    private void KeyhookOnKeyPressed(object sender, KeyPressedEventArgs keyPressedEventArgs)
    {
      if (keyPressedEventArgs.Key.Equals(RemoteSwitch))
      {
        if (!remote.Connected)
          remote.Connect();
        if (!remote.Connected)
          throw new IOException("Unable to connect to " + remote.RemoteAddress + ":" + remote.Port);

        textBox1.AppendText("Connected\n");
        mouseHook.Enabled = true;
      }

      if (keyPressedEventArgs.Key.Equals(LocalSwitch))
      {
        if (remote.Connected)
          remote.Disconnect();

        if (!remote.Connected)
          textBox1.AppendText("Closed Connection\n");

        mouseHook.Enabled = false;
      }

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }
}
