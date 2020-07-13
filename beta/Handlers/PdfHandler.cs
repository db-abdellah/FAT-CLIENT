using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;


namespace beta.Entities
{
    class PdfHandler
    {
        public static List<Image> pdfToImages(String pdfPath, int idProjet)
        {
            List<Image> images = new List<Image>();

            // Convert PDF to JPG with high Quality
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();

            // This property is necessary only for registered version
            // f.Serial = "XXXXXXXXXXX";
            
            string pdfName = Path.GetFileNameWithoutExtension(pdfPath);
            string pdfDir = Path.GetDirectoryName(pdfPath);
            String jpegDir = ConfigurationManager.AppSettings["MainFolder"].ToString();
        

            f.OpenPdf(pdfPath);

            if (f.PageCount > 0)
            {
                // Set image properties: Jpeg, 200 dpi
                f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                f.ImageOptions.Dpi = 200;

                // Set 95 as JPEG quality
                f.ImageOptions.JpegQuality = 95;

                //Save all PDF pages to image folder, each file will have name Page 1.jpg, Page 2.jpg, Page N.jpg
                for (int page = 1; page <= f.PageCount; page++)
                {
                   
                    string jpegFile = Path.Combine(jpegDir, String.Format(pdfName+" page {0}.jpg", page));
                    Image image = new Image(jpegFile,mainForm.utilisateur.idUtilisateur,idProjet) ;

                    // 0 - converted successfully
                    // 2 - can't create output file, check the output path
                    // 3 - conversion failed
                    int result = f.ToImage(jpegFile, page);
                    if (result.Equals(0))
                    {
                        images.Add(image);
                    }
                    else
                        Console.WriteLine("error");
                   


                }
                return images;
            }
            return null;
        }
    }
}
