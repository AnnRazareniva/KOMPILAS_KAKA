using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ParserName;
using LexerName;
using static LexerName.Lexer;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        public static List<Lexem> myStorage;
        private void button1_Click(object sender, EventArgs e)
        {
            Lexer lexer = new Lexer("int a := 5 ; a := a + 5 ;");
            
            myStorage = lexer.GetLexemStorage();
            //tbOutput.Text = lexer.GetOutputText();
        }
    }
}
