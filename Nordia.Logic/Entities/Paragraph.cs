using System.Collections.Generic;
using System.Linq;

namespace Nordia.Logic.Entities
{
    /// <summary>
    /// This class will used to keep lines/words collection in object.
    /// Convertor will used this class to generate data in required format
    /// </summary>
    public class ParagraphText
    {
        List<Sentence> _Lines = new List<Sentence>();

        public List<Sentence> Lines
        {
            get { return _Lines; }
            set { _Lines = value; }
        }

        /// <summary>
        /// This propoerty will keep count of max number of word in biggest line
        /// Because in case of CSV file format , no of column will be same as number of column in biggest line(Biggest line means a line with max number of words)
        /// </summary>
        public int MaxWordsInLine
        {
            get
            {
                return (_Lines.Max(x => x.WordCount));
            }
        }

        public string LineTerminator 
        { 
            get
            {
                return ".";
            }
        }
    }

    /// <summary>
    /// This class will used to keep words collection in object.
    /// </summary>
    public class Sentence
    {
        List<string> _Words = new List<string>();

        public List<string> Words
        {
            get { return _Words; }
            set { _Words = value; }
        }
        public int WordCount { get { return _Words.Count; } }
    }    
}
