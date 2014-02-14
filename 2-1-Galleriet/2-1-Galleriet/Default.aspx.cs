using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_1_Galleriet
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            var fContent = FileUpload.FileContent;
            var fName = FileUpload.FileName;
            

            var PicGallery = new Model.Gallery();
            fName = PicGallery.SaveImage(fContent, fName);

            Label1.Text = fName;
            

        }
    }
}