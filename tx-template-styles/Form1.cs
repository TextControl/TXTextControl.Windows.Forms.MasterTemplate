using System.Reflection;
using System.Xml;

namespace tx_template_styles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textControl2.Load("Templates/template.dotx", TXTextControl.StreamType.WordprocessingML);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] templateDocument;

            textControl2.Save(out templateDocument, TXTextControl.BinaryStreamType.InternalUnicodeFormat);

            TXTextControl.TemplateHandling.ApplyTemplate(templateDocument, textControl1);
        }


        
    }

   
}