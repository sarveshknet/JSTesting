using Nordia.Logic.Entities;

namespace Nordia.Logic.Interfaces
{
    /// <summary>
    /// For purpose of Multiple reader by diffrent logic
    /// </summary>
    public interface ITextReader
    {
        ParagraphText ReadParagraph(string rawtext);
    }    
}
