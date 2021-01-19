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
    public partial class SetUpChild : Form
    {
        Person parent;
        public SetUpChild(Person parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void sumbit_Click(object sender, EventArgs e)
        {
            
            try
            {
                var wordApp = new Word.Application();
                wordApp.Visible = true;
                string p = Application.StartupPath.ToString();
                var wordDocument = wordApp.Documents.Open(p + "//documents//SetUpChildTemplate.dotx");

                ReplaceWordStub("{name}", parent.name, wordDocument);
                ReplaceWordStub("{lastname}", parent.lastName, wordDocument);
                ReplaceWordStub("{patronymic}", parent.patronymic, wordDocument);
                ReplaceWordStub("{ID}", parent.id.ToString(), wordDocument);
                ReplaceWordStub("{year}", year_tb.Text, wordDocument);
                ReplaceWordStub("{FIO}", fio_tb.Text, wordDocument);
                ReplaceWordStub("{class}", name_tb.Text, wordDocument);

                wordDocument.SaveAs2($"{parent.id}{parent.lastName}{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}.docx");
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
