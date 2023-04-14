using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UPLOAD
{
    public partial class UPLOAD_TEST1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["save_file"] != null)
            {
                MyUpload();
                Response.Write("上傳完成");
                Response.End();
            }
        }

        private void MyUpload()
        {
            for (int i = 0; i < Request.Files.Count; i++)
            {
                HttpPostedFile postedFile = Request.Files[i];

                if (postedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    postedFile.SaveAs(Server.MapPath("~/Images/") + fileName);
                }
            }
        }
    }
}
