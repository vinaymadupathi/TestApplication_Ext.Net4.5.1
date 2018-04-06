using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ext.Net.MVC
{
    public static class ExtExtension
    {
        public static Panel GeneratePanel(this HtmlHelper htmlHelper, string Title, string Url, string Mask, string id = "")
        {
            Panel panel = new Panel();
            if (id != "")
                panel.ID = id;
            panel.Title = Title;
            //panel.ID = "mainpanel";
            panel.Padding = 10;
            panel.Cls = "content";
            panel.Loader = new ComponentLoader()
            {
                //ID = "mainpanelloader",
                Url = VirtualPathUtility.ToAbsolute(string.Format("~/{0}", Url)),
                AutoLoad = true,
                Mode = LoadMode.Frame
            };
            panel.Loader.LoadMask.ShowMask = true;
            panel.Border = false;
            panel.Loader.LoadMask.Msg = Mask;


            return panel;
        }
    }
}