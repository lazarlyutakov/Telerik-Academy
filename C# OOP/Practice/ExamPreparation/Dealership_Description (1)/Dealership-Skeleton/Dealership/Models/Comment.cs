using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common;
using Dealership.Contracts;

namespace Dealership.Models
{
   public class Comment : IComment
    {
        private const string CommentHeader = "    ----------";
        private const string ContentProperty = "Content";
        private const string CommentIndentation = "    ";
        private const string AuthorHeader = "      User: ";

        private readonly string content;

        public Comment(string content)
        {
            this.content = content;

            this.ValidateFields();
        }

        public string Content
        {
            get
            {
                return this.Content;
            }
        }

        public string Author { get; set; }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();

            text.AppendLine(string.Format("{0}", CommentHeader));
            text.AppendLine(CommentIndentation + this.Content);
            text.AppendLine(AuthorHeader + this.Author);
            text.AppendLine(string.Format("{0}", CommentHeader));

            return text.ToString();
        }

        private void ValidateFields()
        {
            Validator.ValidateNull(this.content, string.Format(Constants.PropertyCannotBeNull, ContentProperty));
            Validator.ValidateIntRange(this.content.Length, Constants.MinCommentLength, Constants.MaxCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, ContentProperty, Constants.MinCommentLength, Constants.MaxCommentLength));
        }

    }
}
