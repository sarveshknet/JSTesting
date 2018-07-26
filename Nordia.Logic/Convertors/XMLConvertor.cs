using System.Xml.Serialization;
using Nordia.Logic.Interfaces;
using Nordia.Logic.Entities;

namespace Nordia.Logic.Convertors
{
    /// <summary>
    /// This class will be used to convert collection of line/word from paragraph into XML format
    /// </summary>
    public class XMLConvertor : ITextConvertor
    {
        public string Convert(ParagraphText paragraph)
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(paragraph.GetType());
            serializer.Serialize(stringwriter, paragraph);
            string convertedText = stringwriter.ToString();
            // replacing string collection as this will be serilized with name string and we want word as per req.
            convertedText = convertedText.Replace("<string>", "<Word>");
            convertedText = convertedText.Replace("<Words>", string.Empty);
            convertedText = convertedText.Replace("</Words>", string.Empty);
            return convertedText.Replace("</string>", "</Word>");
        }
    }
}
