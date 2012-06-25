using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel.Tables;
using PdfSharp;
using MigraDoc.DocumentObjectModel;
using System.Windows.Forms;
using MigraDoc.Rendering;
using Shoppy.Views;

namespace Shoppy
{
    // Erstellt ein PDF-Dokument welches anschliessend gedruckt werden kann.
    class PrintSell
    {
        private double totalbetrag;
        private DataGridView datagridSell;
        private int positioncounter;
        private int zeilenProSeite = 31;
        private int pageCounter = -1;
        private int position = 0;
        private XGraphics gfx;

        public PrintSell(double totalbetrag, DataGridView idatgridSell) 
        {
            this.totalbetrag = totalbetrag;
            this.datagridSell = idatgridSell;
        }
        // Initiiert den Erstellungsprozess
        public void Kontrollblatt()
        {
            PdfDocument pdfdocument = new PdfDocument();
            XFont font = new XFont("Arial", 25, XFontStyle.Bold);
            CreateDocument(pdfdocument);
            string filename = "quittung.pdf";
            pdfdocument.Save(filename);
            Process.Start(filename);
        }

        private void CreateDocument(PdfDocument pdfdocument)
        {
            positioncounter = datagridSell.Rows.Count;
            int anzNewPages = positioncounter / zeilenProSeite;
            for (int i = 0; i <= anzNewPages; i++)
            {
                pdfdocument.AddPage();
            }
            while (anzNewPages >= 0)
            {
                pageCounter++;
                AddPage(pdfdocument);
                anzNewPages--;
            }
            CreateLastPage(pdfdocument);
        }

        private Paragraph getUeberschrift(Section sec)
        {
            Paragraph ueberschrift = sec.AddParagraph();
            ueberschrift.Format.Alignment = ParagraphAlignment.Justify;
            ueberschrift.Format.Font.Name = "Arial";
            ueberschrift.Format.Font.Size = 14;
            ueberschrift.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.Black;
            ueberschrift.AddText("Quittung - ShoppyMarket");
            return ueberschrift;
        }

        private Paragraph getDate(Section sec)
        {
            Paragraph date = sec.AddParagraph();
            date.Format.Alignment = ParagraphAlignment.Justify;
            date.Format.Font.Name = "Arial";
            date.Format.Font.Size = 14;
            date.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.Black;
            date.AddText(DateTime.Now.Date.ToString().Substring(0, 10));
            return date;
        }

        private void AddPage(PdfDocument pdfdocument)
        {

            PdfPage page = pdfdocument.Pages[pageCounter];
            gfx = XGraphics.FromPdfPage(page);
            gfx.MUH = PdfFontEncoding.Unicode;
            gfx.MFEH = PdfFontEmbedding.Default;
            page.Orientation = PageOrientation.Portrait;
            Document doc = new Document();
            Section sec = doc.AddSection();
            MigraDoc.DocumentObjectModel.Tables.Table tabelle = tableheader(sec);
            Row row;
            int counterRows = CounterRows();
            position = 0;
            for (int j = 0; j < counterRows; j++)
            {
                row = tabelle.AddRow();
                row.HeightRule = RowHeightRule.Exactly;
                row.Height = 20;
                string articleName = datagridSell.Rows[j].Cells[1].Value.ToString();
                articleName = laengenkontrolle(articleName, 24);
                row.Cells[0].AddParagraph(articleName);
                row.Cells[1].AddParagraph(datagridSell.Rows[j].Cells[2].Value.ToString());
                row.Cells[2].AddParagraph(datagridSell.Rows[j].Cells[3].Value.ToString());
                row.Cells[3].AddParagraph(datagridSell.Rows[j].Cells[4].Value.ToString());
                positioncounter--;
                position++;
            }

            tabelle.SetEdge(0, 0, tabelle.Columns.Count,
            tabelle.Rows.Count, MigraDoc.DocumentObjectModel.Tables.Edge.Box,
            MigraDoc.DocumentObjectModel.BorderStyle.Single, 0.75);

            Paragraph ueberschrift = getUeberschrift(sec);
            Paragraph date = getDate(sec);
            MigraDoc.Rendering.DocumentRenderer docRendererr = new DocumentRenderer(doc);
            docRendererr.PrepareDocument();
            docRendererr.RenderObject(gfx, XUnit.FromCentimeter(2), XUnit.FromCentimeter(2), "25cm", ueberschrift);
            docRendererr.RenderObject(gfx, XUnit.FromCentimeter(15.5), XUnit.FromCentimeter(2), "25cm", date);
            docRendererr.RenderObject(gfx, XUnit.FromCentimeter(2), XUnit.FromCentimeter(3), "25cm", tabelle);
        }

        private void CreateLastPage(PdfDocument pdfdocument)
        {
            PdfPage page = pdfdocument.Pages[pageCounter];
            gfx.MUH = PdfFontEncoding.Unicode;
            gfx.MFEH = PdfFontEmbedding.Default;
            page.Orientation = PageOrientation.Portrait;
            Document doc = new Document();
            Section sec = doc.AddSection();

            Paragraph total = sec.AddParagraph();
            total.Format.Alignment = ParagraphAlignment.Justify;
            total.Format.Font.Name = "Arial";
            total.Format.Font.Size = 16;
            total.Format.Font.Bold = true;
            total.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.Black;
            total.AddText("Totalbetrag: " + String.Format("{0:0.00}", totalbetrag) + " CHF");
            
            Paragraph bediennung = sec.AddParagraph();
            bediennung.Format.Alignment = ParagraphAlignment.Justify;
            bediennung.Format.Font.Name = "Arial";
            bediennung.Format.Font.Size = 12;
            bediennung.Format.Font.Color = MigraDoc.DocumentObjectModel.Colors.Black;
            bediennung.AddText("Sie wurden bedient von '"+Login.SellerName);


            MigraDoc.Rendering.DocumentRenderer docRendererr = new DocumentRenderer(doc);
            docRendererr.PrepareDocument();
            docRendererr.RenderObject(gfx, XUnit.FromCentimeter(2), XUnit.FromCentimeter(5 + position * 0.7), "25cm", total);
            docRendererr.RenderObject(gfx, XUnit.FromCentimeter(2), XUnit.FromCentimeter(7 + position * 0.7), "25cm", bediennung);
        }

        private int CounterRows()
        {
            if (positioncounter > zeilenProSeite)
                return zeilenProSeite;
            else
                return positioncounter;
        }

        private MigraDoc.DocumentObjectModel.Tables.Table tableheader(Section sec)
        {
            Table tabelle = sec.AddTable();
            tabelle.Format.Font.Name = "Courier New";
            tabelle.Format.Font.Size = 11;
            tabelle.Rows.HeightRule = RowHeightRule.Exactly;
            tabelle.Rows.Height = 14;
            tabelle.Borders.Visible = true;
            //Produktname
            tabelle.AddColumn("7.2cm");
            //Barcode
            tabelle.AddColumn("4.4cm");
            //Preis
            tabelle.AddColumn("2.5cm");
            //Anzahl
            tabelle.AddColumn("2cm");
            //Titel der Tabelle einfüllen
            Row row = tabelle.AddRow();
            row.HeightRule = RowHeightRule.Exactly;
            row.Height = 31;
            row.Cells[0].AddParagraph("Produktname");
            row.Cells[0].Format.Font.Name = "Comic Sans MS";
            row.Cells[1].AddParagraph("Barcode");
            row.Cells[1].Format.Font.Name = "Comic Sans MS";
            row.Cells[2].AddParagraph("Preis");
            row.Cells[2].Format.Font.Name = "Comic Sans MS";
            row.Cells[3].AddParagraph("Anzahl");
            row.Cells[3].Format.Font.Name = "Comic Sans MS";
            return tabelle;
        }
       
        private string laengenkontrolle(string langertext, int maxlaenge)
        {
            string rueckgabe;
            if (langertext.Length - 3 > maxlaenge)
            {
                rueckgabe = langertext.Substring(0, maxlaenge) + "...";
            }
            else
            {
                rueckgabe = langertext;
            }
            return rueckgabe;
        }
    }
}
