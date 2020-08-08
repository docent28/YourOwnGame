using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace YourOwnGame
{
    [Serializable]
    public class Questions
    {
        public List<Question> QuestionsList { get; set; } = new List<Question>();

        public Questions() { }
    }

    [Serializable]
    public class Question
    {
        [XmlElement("Name")]
        public string nameQuestion { get; set; }
        [XmlElement("Contents")]
        public string contentsQuestion { get; set; }
        [XmlElement("Category")]
        public string categoryQuestion { get; set; }
        [XmlElement("Price")]
        public string priceQuestion { get; set; }

        public Question() { }
        public Question(string nameQuestion, string contentsQuestion, string categoryQuestion, string priceQuestion)
        {
            this.nameQuestion = nameQuestion;
            this.contentsQuestion = contentsQuestion;
            this.categoryQuestion = categoryQuestion;
            this.priceQuestion = priceQuestion;
        }

    }
}
