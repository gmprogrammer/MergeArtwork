using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InDesign;

namespace MergeIndesign
{
    public partial class Form1 : Form
    {
        InDesign.Application idApp;
        InDesign.Document idDoc;
        //InDesign.Layer idLayer;
        InDesign.Page idPage;
        InDesign.Text idText;
        InDesign.Color idColor;

        InDesign.Color idCRed;
        InDesign.Color idCBlue;
        InDesign.Color idCGreen;
        //InDesign.TextFrame idTextframe;

        public Form1()
        {
            InitializeComponent();
            initializeForm();
        }

        

        private void initializeForm()
        {
            idApp = (InDesign.Application) COMCreateObject("InDesign.Application");


            System.Threading.Thread.Sleep(2000);
            idDoc = idApp.Open("C:\\prints\\indesign\\DL013GN2T Folder\\DL013GN2T2.indd", true, idOpenOptions.idDefault);

            idPage = idDoc.Pages.FirstItem();


            idCRed = setColor("Red", InDesign.idColorSpace.idRGB
                , InDesign.idColorModel.idProcess, new int[] { 255, 0, 0 });
            idCGreen = setColor("Green", InDesign.idColorSpace.idRGB
                , InDesign.idColorModel.idProcess, new int[] { 0, 255, 0 });
            idCBlue = setColor("Blue", InDesign.idColorSpace.idRGB
                , InDesign.idColorModel.idProcess, new int[] { 0, 0, 255 });
            
             //= .FirstItem();

            //idPage.TextFrames.Count
            //idDoc = idApp.Documents.Add();

            //textframe = idDoc.TextFrames.Add();
            //textframe.GeometricBounds = new string[] {"6p", "6p", "24p", "24p"};
            //textframe.Contents = "TESSSSSSSSSSSSSTTTTTTTTTTTT";
            //idLayer = idDoc.Layers.Add();


                //idApp.Open("C:\\prints\\indesign\\DL013GN2T Folder\\DL013GN2T.indd", InDesign.idColorSpace.idRGB);
        }

        public static object COMCreateObject(string sProgID)
        {
            // We get the type using just the ProgID
            Type oType = Type.GetTypeFromProgID(sProgID);
            if (oType != null)
            {
                return Activator.CreateInstance(oType) ;
            }

            return null;
        }

        private void btnIndesign_Click(object sender, EventArgs e)
        {
            string customizedText = txtLabel.Text.Trim();
            string fontName = cmbFont.SelectedItem==null ? "" : cmbFont.SelectedItem.ToString();
            string fontSize = cmbFSize.SelectedItem == null ? "" : cmbFSize.SelectedItem.ToString();
            lstResult.Items.Clear();

            idColor = null;
            if (cmbColor.SelectedItem != null)
            {
                if (cmbColor.SelectedItem.Equals("Red"))
                    idColor = idCRed;
                else if (cmbColor.SelectedItem.Equals("Green"))
                    idColor = idCGreen;
                else if (cmbColor.SelectedItem.Equals("Blue"))
                    idColor = idCBlue;
            }

            InDesign.TextFrame idTextframeStr;
            InDesign.TextFrame idTextframeCut;

            idTextframeCut = idPage.TextFrames["<cutlabel>"];
            idTextframeCut.Contents = customizedText;
            idText = idTextframeCut.Texts.FirstItem();
                if( !fontName.Equals("") )
                    idText.AppliedFont = fontName;
                if (!fontSize.Equals(""))
                    idText.PointSize = fontSize;

            if (idTextframeCut.Overflows)
            {
                lstResult.Items.Add("Label Cut overflows");
                if (chkFit.Checked)
                {
                    idTextframeCut.Fit(idFitOptions.idFrameToContent);
                    lstResult.Items.Add("Label Cut Fit adjusted");
                }
            }

            idTextframeStr = idPage.TextFrames["<strlabel>"];
            idTextframeStr.Contents = customizedText;
            //idTextframeStr.FillColor = "Blue";
            idText = idTextframeStr.Texts.FirstItem();
            //idText.FontStyle = "Bold";
            if (!fontName.Equals(""))
                idText.AppliedFont = fontName;
            if (!fontSize.Equals(""))
                idText.PointSize = fontSize;

            //idText.AppliedFont = fontName;
            //idText.PointSize = fontSize;
            if (idColor != null)
                idText.FillColor = idColor;

            if (idTextframeStr.Overflows)
            {
                lstResult.Items.Add("Label String overflows");
                if (chkFit.Checked)
                {
                    idTextframeStr.Fit(idFitOptions.idFrameToContent);
                    lstResult.Items.Add("Label String Fit adjusted");
                }
            }


            //idText.Preferences.

            //foreach (InDesign.TextFrame idTextframe in idPage.TextFrames)
            //{
            //    string nameoftxtframe = idTextframe.Name;
            //    string nameoftxtframe2 = idTextframe.Label;
            //    string text = idTextframe.Contents;
            //    idTextframe.Contents = customizedText;

            //}

        }

        private InDesign.Color setColor( string colorName, InDesign.idColorSpace colorSpace
            , InDesign.idColorModel colorModel, int[]  colorRGB )
        {
            InDesign.Color customColor;
            customColor = idDoc.Colors.Add();
            customColor.Name = colorName;

            customColor.Space = colorSpace;
            customColor.Model = colorModel;
            customColor.ColorValue = colorRGB;

            return customColor;

        }
    }
}
