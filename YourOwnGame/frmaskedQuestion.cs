using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourOwnGame
{
    public partial class frmAskedQuestion : Form
    {
        public frmAskedQuestion()
        {
            InitializeComponent();
        }

        public void fillForm()
        {
            var parentForm = this.Owner as frmBasicForm;
            var currentLabelNumber = parentForm.currentLabelNumber;
            this.lblNumber.Text = currentLabelNumber.ToString("000");
            this.txtQuestion.Text = parentForm.listRndQuestions.QuestionsList[currentLabelNumber - 1].nameQuestion;
        }
    }
}
