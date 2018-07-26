using System.Text;
using Nordia.Logic.Interfaces;
using Nordia.Logic.Entities;

namespace Nordia.Logic.Convertors
{
    /// <summary>
    /// This class will be used to convert collection of line/word from paragraph into CSV format
    /// </summary>
    public class CSVConvertor : ITextConvertor
    {
        public string Convert(ParagraphText paragraph)
        {
            if (paragraph == null)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();

            int maxColumns = paragraph.MaxWordsInLine;

            sb.Append("Lines");
            //Add CSV Header till max columns
            for (int i = 1; i <= maxColumns; i++)
            {
                sb.Append(",Word" + i.ToString());
            }

            //Add CSV data to rows
            int lineCount = 0;
            foreach (Sentence line in paragraph.Lines)
            {
                lineCount++;
                sb.AppendLine("<br/>");
                sb.Append("Line" + lineCount.ToString());
                foreach (string word in line.Words)
                {
                    sb.Append("," + word);
                }
            }
            return sb.ToString();
        }
    }
}
