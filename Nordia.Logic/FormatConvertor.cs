using Nordia.Logic.Interfaces;
using Nordia.Logic.Entities;
using Nordia.Logic.Convertors;

namespace Nordia.Logic
{
    public class FormatConvertor
    {
        public string Convert(ITextConvertor convertor, string rawText)
        {
            ParagraphReader reader = new ParagraphReader();
            ParagraphText paragraph = reader.ReadParagraph(rawText);
            return convertor.Convert(paragraph);
        }
        public string Convert(string format, string rawText)
        {
            if (format.ToLower()== "xml")
            {
                return Convert(new XMLConvertor(), rawText);
            }
            else
            {
                return Convert(new CSVConvertor(), rawText);
            }
            
        }
    }
}
