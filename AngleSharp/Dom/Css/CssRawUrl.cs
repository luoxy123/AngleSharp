﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Extensions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a raw string taken from the CSS source.
    /// </summary>
    sealed class CssRawUrl : ICssNode
    {
        readonly String _url;

        public CssRawUrl(String url)
        {
            _url = url;
        }

        public IEnumerable<ICssNode> Children
        {
            get { return Enumerable.Empty<ICssNode>(); }
        }

        public String CssText
        {
            get { return _url; }
        }

        public String ToCss(IStyleFormatter formatter)
        {
            return _url.CssUrl();
        }
    }
}
