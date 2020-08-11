using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace YourOwnGame
{
    public partial class frmQuestion : Form
    {
        public frmQuestion()
        {
            InitializeComponent();
            ClearInput();
        }

        private void ClearInput()
        {
            txtNameQuestion.Text = string.Empty;
            txtContentQuestion.Text = string.Empty;
            cbCategoryQuestion.Text = "-- Выбрать --";
            txtPriceQuestion.Text = string.Empty;
        }

        private void Add(Question question)
        {
            ListViewItem LVI = new ListViewItem(question.nameQuestion);
            LVI.Tag = question;

            lvQuestions.Items.Add(LVI);
        }

        private Questions DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Questions));

            using (FileStream fs = new FileStream("questions.xml", FileMode.OpenOrCreate))
            {
                return (Questions)xml.Deserialize(fs);
            }

        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            ClearInput();

            lvQuestions.Clear();
           
            Questions questions = DeserializeXML();

            foreach (Question question in questions.QuestionsList)
            {
                Add(question);
            }
        }

        private void SerializeXML(Questions questions)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Questions));

            using(FileStream fs = new FileStream("questions.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, questions);
            }
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            Questions questions = new Questions();

            foreach (ListViewItem item in lvQuestions.Items)
            {
                if (item.Tag != null)
                {
                    questions.QuestionsList.Add((Question)item.Tag);
                }
            }

            SerializeXML(questions);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Question question = new Question(txtNameQuestion.Text, txtContentQuestion.Text, cbCategoryQuestion.Text, txtPriceQuestion.Text);

            Add(question);

            ClearInput();
        }

        private void lvQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvQuestions.SelectedItems.Count == 1)
            {
                Question question = (Question)lvQuestions.SelectedItems[0].Tag;

                if (question != null)
                {
                    txtNameQuestion.Text = question.nameQuestion;
                    txtContentQuestion.Text = question.contentsQuestion;
                    cbCategoryQuestion.Text = question.categoryQuestion;
                    txtPriceQuestion.Text = question.priceQuestion;
                }
            }
            else
            {
                ClearInput();
            }
        }
    }
}
