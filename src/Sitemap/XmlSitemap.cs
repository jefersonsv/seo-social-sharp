﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSocial.Sitemap
{
    public class XmlSitemap
    {
        IList<Uri> list = new List<Uri>();

        public void Add(Uri uri)
        {
            list.Add(uri);
        }
    }
}
