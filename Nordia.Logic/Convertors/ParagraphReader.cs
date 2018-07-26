using System.Linq;
using Nordia.Logic.Entities;
using Nordia.Logic.Interfaces;

namespace Nordia.Logic.Convertors
{
    /// <summary>
    /// This class will read paragraph and parse into words/lines.
    /// Convertor will used this class to generate data in required format
    /// </summary>
    public class ParagraphReader : ITextReader
    {
        public ParagraphText ReadParagraph(string rawtext)
        {
            ParagraphText paragraph = new ParagraphText();
            string[] lines = rawtext.Split('.', ',');
            foreach (string line in lines)
            {
                Sentence singleLine = new Sentence();
                string[] wordsFromLine = line.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); // filterout blank words

                //perfrom sorting
                string[] words = wordsFromLine.OrderBy(x => x).ToArray();
                foreach (string word in words)
                {
                    singleLine.Words.Add(word);
                }
                if (singleLine.Words.Count > 0)
                {
                    paragraph.Lines.Add(singleLine);
                }
            }
            return paragraph;
        }
    }
}
