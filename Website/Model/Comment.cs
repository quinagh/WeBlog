﻿
using System.Collections.Specialized;
namespace Sitecore.Modules.WeBlog.Model
{
    /// <summary>
    /// Represents an abstract comment
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Gets or sets the name of the author
        /// </summary>
        public string AuthorName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the author's email address
        /// </summary>
        public string AuthorEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text of the comment
        /// </summary>
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a collection of additional fields for this comment submission
        /// </summary>
        public NameValueCollection Fields
        {
            get;
            set;
        }

        public Comment()
        {
            Fields = new NameValueCollection();
        }
    }
}
