using Gesk.Library.Objects;
using Gesk.Library.Objects.SubObjects;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Gesk.Library.Outputs
{
    internal class Pdf
    {
        private Document Document { get; set; }
        private PdfWriter PdfWriter { get; set; }

        private Pdf(string path, Rectangle rectangle, int[] margins)
        {
            this.Document = new Document(rectangle);
            this.Document.SetMargins(margins[0], margins[1], margins[2], margins[3]);
            this.Document.AddCreationDate();

            this.PdfWriter = PdfWriter.GetInstance(Document, new FileStream(path, FileMode.Create));
        }

        private Font GetFont(float size)
        {
            FontFactory.RegisterDirectories();
            return new Font(FontFactory.GetFont("Arial", size, Font.BOLD));
        }

        private void AddHugeTitle(string text, sbyte align)
        {
            Paragraph ph = new Paragraph(text, this.GetFont(27));

            if(align == 0) ph.Alignment = Element.ALIGN_CENTER;
            else if(align == 1) ph.Alignment = Element.ALIGN_RIGHT;

            this.Document.Add(ph);
        }

        private void AddBigTitle(string text, sbyte align)
        {
            Paragraph ph = new Paragraph(text, this.GetFont(22));

            if (align == 0) ph.Alignment = Element.ALIGN_CENTER;
            else if (align == 1) ph.Alignment = Element.ALIGN_RIGHT;

            this.Document.Add(ph);
        }

        private void AddTitle(string text, sbyte align)
        {
            Paragraph ph = new Paragraph(text, this.GetFont(13));

            if (align == 0) ph.Alignment = Element.ALIGN_CENTER;
            else if (align == 1) ph.Alignment = Element.ALIGN_RIGHT;

            this.Document.Add(ph);
        }

        private void AddSmallTitle(string text, sbyte align)
        {
            Paragraph ph = new Paragraph(text, this.GetFont(10));
            ph.Alignment = Element.ALIGN_CENTER;
            this.Document.Add(ph);
        }

        private void AddSmallParagraphBold(string text, sbyte align)
        {
            Paragraph ph = new Paragraph(text, this.GetFont(7));

            if (align == 0) ph.Alignment = Element.ALIGN_CENTER;
            else if (align == 1) ph.Alignment = Element.ALIGN_RIGHT;

            this.Document.Add(ph);
        }

        private void AddParagraphBold(string text, sbyte align)
        {
            Paragraph ph = new Paragraph(text, this.GetFont(9));

            if (align == 0) ph.Alignment = Element.ALIGN_CENTER;
            else if (align == 1) ph.Alignment = Element.ALIGN_RIGHT;

            this.Document.Add(ph);
        }

        private void BreakLine()
        {
            Paragraph ph = new Paragraph(" ", new Font(Font.FontFamily.TIMES_ROMAN, 3, 0));
            this.Document.Add(ph);
        }

        internal static void CreateProductTag(Product product, string destination)
        {
            float width = (float)72 * (float)3.14961; // 72 pixels * 3.14 inches
            float height = (float)72 * (float)1.65; // 72 pixeis * 1.65 inches
            //float height = (float)72 * (float)1.5748; // 72 pixeis * 1.57 inches

            Pdf pdf = new Pdf(@".\tag.pdf", new iTextSharp.text.Rectangle(width, height), new int[] { 10, 10, -5, -5 });

            pdf.Document.Open();

            pdf.AddSmallTitle("BÖLLHOFF SERVICE CENTER", 0);
            pdf.AddParagraphBold("CÓDIGO BÖLLHOFF: " + product.CodeBSC, -1);
            pdf.AddParagraphBold("ORIGEM: " + Address.GetAddressString(product.Address_Id), -1);
            pdf.AddParagraphBold("CÓDIGO CLIENTE: " + product.CodeClient, -1);
            pdf.AddParagraphBold("DESCRIÇÃO: " + product.Description, -1);
            pdf.AddParagraphBold("ENDEREÇO NA LINHA: " + destination, -1);

            pdf.Document.Close();
        }

        internal static void CreateKitTag(Product product, int quantity, string kitName)
        {
            float width = (float)72 * (float)3.14961; // 72 pixels * 3.14 inches
            float height = (float)72 * (float)1.65;
            //float height = (float)72 * (float)1.5748; // 72 pixeis * 1.57 inches

            Pdf pdf = new Pdf(@".\tag.pdf", new iTextSharp.text.Rectangle(width, height), new int[] { 10, 10, -5, -5 });

            pdf.Document.Open();

            pdf.AddParagraphBold("KIT: " + kitName, 0);
            pdf.AddBigTitle(product.CodeClient, 0);
            pdf.AddTitle("Qtd: " + quantity.ToString(), 0);
            pdf.AddParagraphBold("Código BSC: " + product.CodeBSC, -1);
            pdf.AddParagraphBold("Origem: " + Address.GetAddressString(product.Address_Id), -1);

            pdf.Document.Close();
        }

        internal static void CreateProductionLineTag(string codeCliente, string productDescription, string lineAddress)
        {
            float width = (float)72 * (float)3.14961; // 72 pixels * 3.14 inches
            float height = (float)72 * (float)1.65;
            //float height = (float)72 * (float)1.5748; // 72 pixeis * 1.57 inches

            Pdf pdf = new Pdf(@".\tag.pdf", new iTextSharp.text.Rectangle(width, height), new int[] { 10, 10, -5, -5 });

            pdf.Document.Open();

            pdf.AddHugeTitle(codeCliente, 0);            
            pdf.AddParagraphBold(productDescription, 0);

            pdf.BreakLine();

            pdf.AddTitle(lineAddress, 1);            

            pdf.Document.Close();
        }
    }
}
