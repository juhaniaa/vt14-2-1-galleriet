using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace _2_1_Galleriet.Model
{
    public class Gallery
    {
        private static readonly Regex ApprovedExtensions;
        private static string PhysicalUploadImagePath;
        private static readonly Regex SanitizePath;
        
        static Gallery()
        {
            // initiera de statiska "readonly" fälten
            ApprovedExtensions = new Regex("^.*\\.(gif|jpg|png)$");

            string virtualPath = "Pics\\";
            string appPath = AppDomain.CurrentDomain.GetData("APPBASE").ToString(); // + Path.Combine -> PhysicalUploadImagePath
            PhysicalUploadImagePath = Path.Combine(appPath, virtualPath);

            var invalidChars = new string(Path.GetInvalidFileNameChars());
            SanitizePath = new Regex(string.Format("[{0}]", Regex.Escape(invalidChars)));
        }

        public IEnumerable<string> GetImageNames(){
            throw new NotImplementedException();
        }

        public bool ImageExists(string name) {

            throw new NotImplementedException();
        }

        private bool IsValidImage(Image image) {

            // returnerar true om bilden är i jpeg, gif eller png format
            if (image.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Jpeg.Guid
                || image.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Gif.Guid
                || image.RawFormat.Guid == System.Drawing.Imaging.ImageFormat.Png.Guid)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public string SaveImage(Stream stream, string fileName) {

            // spara referens till bilden
            var image = System.Drawing.Image.FromStream(stream);

            // om det inte är en giltig bild (gif, jpg eller png), kastas ett undantag
            if (!IsValidImage(image)) 
            {
                throw new ArgumentOutOfRangeException();
            }

            // om filändelsen inte är korrekt (gif, jpg eller png), kastas ett undantag
            string path = PhysicalUploadImagePath + fileName;

            if (!ApprovedExtensions.Match(path).Success) {
                throw new ArgumentOutOfRangeException();
            }
                

            // rensa sökvägen från otillåtna tecken
            path = SanitizePath.Replace(path, "");

            // kontrollera om bilden redan finns

            

            
            image.Save(path);

            return fileName;
        }


    }
}