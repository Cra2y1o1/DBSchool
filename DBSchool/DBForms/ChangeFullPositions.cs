using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace DBSchool.DBForms
{
    public partial class ChangeFullPositions : Form
    {
        Person person;
        public ChangeFullPositions(Person person)
        {
            InitializeComponent();
            this.person = person;
        }


        private void sumbit_Click(object sender, EventArgs e)
        {
            try
            {
                var wordApp = new Word.Application();
                wordApp.Visible = true;
                string p = Application.StartupPath.ToString();
                var wordDocument = wordApp.Documents.Open(p + "//documents//ChangePositionTemplate.dotx");

                ReplaceWordStub("{name}", person.name, wordDocument);
                ReplaceWordStub("{lastname}", person.lastName, wordDocument);
                ReplaceWordStub("{patronymic}", person.patronymic, wordDocument);
                ReplaceWordStub("{ID}", person.id.ToString(), wordDocument);
                ReplaceWordStub("{full position}", fullPosition.Text, wordDocument);

                ReplaceWordStub("{reason}", reason.Text, wordDocument);

                wordDocument.SaveAs2($"{person.id}{person.lastName}{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}.docx");
                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplaceWordStub(string stubToReplase, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplase, ReplaceWith: text, Replace: 2);
        }
    }
}
