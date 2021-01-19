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
    public partial class SetUpClass : Form
    {
        Person child;
        public SetUpClass(Person child)
        {
            InitializeComponent();
            this.child = child;
        }

        private void sumbit_Click(object sender, EventArgs e)
        {
            try
            {
                var wordApp = new Word.Application();
                wordApp.Visible = true;
                string p = Application.StartupPath.ToString();
                var wordDocument = wordApp.Documents.Open(p + "//documents//SetUpClassTemplate.dotx");

                ReplaceWordStub("{name}", child.name, wordDocument);
                ReplaceWordStub("{lastname}", child.lastName, wordDocument);
                ReplaceWordStub("{patronymic}", child.patronymic, wordDocument);
                ReplaceWordStub("{ID}", child.id.ToString(), wordDocument);
                ReplaceWordStub("{year}", year_tb.Text, wordDocument);

                ReplaceWordStub("{class}", name_tb.Text, wordDocument);

                wordDocument.SaveAs2($"{child.id}{child.lastName}{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}.docx");
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
