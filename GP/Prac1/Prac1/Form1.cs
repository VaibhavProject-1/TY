using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Microsoft.DirectX.Direct3D.Device device;
        public Form1()
        {
            InitializeComponent();
            InitDevice();
            Console.WriteLine("Printing Form1 method1");
        }
        private void InitDevice()
        {
            PresentParameters pp = new PresentParameters(); //CREATE OBJECT
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            device = new Device(0, DeviceType.Hardware, this, CreateFlags.HardwareVertexProcessing,
            pp);
            Console.WriteLine("Printing Form1 Init");
        }
        private void Render()
        {
            device.Clear(ClearFlags.Target, Color.CornflowerBlue, 0, 1);
            device.Present();
            Console.WriteLine("Printing Form1 Render Method call");
        }
        
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Printing Form1 Render Method call paint");
            Render();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Printing Form1 Render Method call load");
        }
    }
}