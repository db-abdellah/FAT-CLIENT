using beta.Buisness;
using beta.Entities;
using beta.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = beta.Entities.Image;

namespace beta
{   
    public partial class uploadForm : Form
    {
        //All uploaded images paths
        private List<Entities.Image> images = new List<Entities.Image>();
        private int currentImage = 0;
        private Projet projet;

        public static String projectTitle;


        //constructor
        public uploadForm(Projet project)
        {
            projet = project;
            InitializeComponent();
            projectTitle = projet.nomProjet;
            

        }

        private void fileChoseBtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var openFileDialog = new OpenFileDialog();
            //filtering file types
            openFileDialog.Filter = "Image Files | *.jpg;*.jpeg;*.png";
            //default Directory
            openFileDialog.InitialDirectory = @"C:\";
            //File Dialog Title
            openFileDialog.Title = "Please select an image file to upload.";
            //Selecting Multiple Images
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {
                  
                    try
                    {
                      
                            Entities.Image image = new Entities.Image(file, mainForm.utilisateur.idUtilisateur, projet.idProjet);
                            if (imageCheck(images,image))
                                images.Add(image);
                        
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            updateImages(); 
        }
     



        //Folder chooser function
        private void folderBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //all files to a string array
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    String extension = "";
                    foreach (String path in files)
                    {
                        
                        FileInfo fi = new FileInfo(path);
                        extension = fi.Extension;
                      
                        Entities.Image image = new Entities.Image(path, mainForm.utilisateur.idUtilisateur, projet.idProjet);
                        //Extension Check
                        if (extensionCheck(extension))
                        {
                            if (imageCheck(images, image))
                                images.Add(image);
                        }
                        
                    }
                }
            }
            updateImages();
        }

        //file Extension check
        private Boolean extensionCheck(String extension)
        {
            String[] imageExtension = { ".jpeg", ".png", ".jpg" };
            if (imageExtension.Contains(extension))
            {
                return true;
            }
            return false;
        }

      
        private void updateImages()
        {
            if(images.Count > 0)
            {   
               
                imageName.Text = images[currentImage].nomImage;
                previewBox.Image = System.Drawing.Image.FromFile(images[currentImage].pathImage);
                imageNumber.Text = currentImage+1 + " / " + images.Count;
                

            }
            else { 
            imageNumber.Text = "0 / 0";
                //previewBox.Image.Dispose();
            }
        }

        private void previousImage_Click(object sender, EventArgs e)
        {
            
                if (currentImage.Equals(0))
                    return;

                if (images.Count > 1)
            {
                currentImage--;
                updateImages();

            }

        }

        private void nextImage_Click(object sender, EventArgs e)
        {
            if (currentImage.Equals(images.Count - 1))
                return;
                if (images.Count > 1)
            {
                currentImage++;
                updateImages();
               
            }
            
        }
       
        //Upload images to server and their info to DB
        private void uploadBtn_Click(object sender, EventArgs e)
        { 

           
                
                ImageBusiness imageBusiness = new ImageBusinessImp();
            if (imageBusiness.saveImages(images) == -1)
            {
                MessageBox.Show("Erreur de connexion au serveur", "Erreur de connexion", MessageBoxButtons.OK);
                return;
            }
                images.Clear();
                updateImages();
            


        }
        private Boolean imageCheck(List<Entities.Image> images , Entities.Image image)
        {
            Boolean result = true;
            foreach(Entities.Image img in images)
            {
                if (img.pathImage.Equals(image.pathImage))
                    result = false;
            }
            return result;
        }

        private void pdfBtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var openFileDialog = new OpenFileDialog();
            //filtering file types
            openFileDialog.Filter = "Image Files | *.pdf";
            //default Directory
            openFileDialog.InitialDirectory = @"C:\";
            //File Dialog Title
            openFileDialog.Title = "Please select an PDF file to upload.";
            //Selecting Multiple Images
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {

                    try
                    {
                        FileInfo fi = new FileInfo(file);



                        images.AddRange(PdfHandler.pdfToImages(file, projet.idProjet));


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            updateImages();
        }

        private void uploadForm_Load(object sender, EventArgs e)
        {

        }
    }//end of class
    
}
