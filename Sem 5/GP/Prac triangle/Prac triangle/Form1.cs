using Microsoft.DirectX.Direct3D;

using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Drawing;
using System.Windows.Forms;
namespace DxPrac1
{
    public partial class Form1 : Form
    {
        Device d;
        public Form1()
        {
            InitializeComponent();
            InitDevice();
        }
        void InitDevice()
        {
            PresentParameters presentParameters = new
            PresentParameters();
            presentParameters.Windowed = true;
            presentParameters.SwapEffect =
            SwapEffect.Discard;
            d = new Device(0, DeviceType.Hardware, this,
            CreateFlags.HardwareVertexProcessing,
            presentParameters);
        }
        void Render()
        {
            CustomVertex.TransformedColored[] vertex = new
            CustomVertex.TransformedColored[3];
            vertex[0].Position = new Vector4(200, 75, 0,
            0);
            vertex[0].Color = Color.Red.ToArgb();
            vertex[1].Position = new Vector4(300, 250, 0,
            0);
            vertex[1].Color = Color.Green.ToArgb();
            vertex[2].Position = new Vector4(100, 250, 0,
            0);
            vertex[2].Color = Color.Blue.ToArgb();
            d.Clear(ClearFlags.Target, Color.White, 0, 1);
            d.BeginScene();
            d.VertexFormat =
            CustomVertex.TransformedColored.Format;
            d.DrawUserPrimitives(PrimitiveType.TriangleList
            , 1, vertex);
            d.EndScene();
            d.Present();
        }



        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Render();
        }
    }
}