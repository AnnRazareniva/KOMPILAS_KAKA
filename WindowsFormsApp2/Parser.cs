using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2;
using static ParserName.StateParser;
using static LexerName.Lexer;
using ParserName;

namespace ParserName
{
    public class StateParser
    {
        public List<StateState> state;
        public List<TypeLex> type;
        public enum StateState
        {
            None = 0,
            F,
            I,
            M,
            A,
            N,
            Q,
            S,
            U,
            T,
            V,
            L,
            H,
            C,
            Ъ,
            K,
            D,
            O, 
            J,
            B,
            W,
            END
        };

        public enum TypeLex
        {
            //DEFAULT = -3,
            EMPTY,
            //ERROR = -1,
            INTEGER,
            DECIMAL,
            PLUS,
            MINUS,
            MULTIPLY,
            DIVIDE,
            LPAREN,
            RPAREN,
            SEMICOLON,
            COMMA,
            LBRACE,
            RBRACE,
            LSQUARE,
            RSQUARE,
            NOT,
            LESS,
            GREATER,
            LESS_OR_EQUAL,
            GREATER_OR_EQUAL,
            EQUAL,
            NOT_EQUALS,
            ASSIGN,
            INT_DECLARE,
            FLOAT_DECLARE,
            ARRAY_DECLARE,
            INPUT,
            OUTPUT,
            IF,
            ELSE,
            WHILE,
            AND,
            OR,
            NAME,
            
            END
        }
    };



    

    public class Parser
    {
        public StateParser magasin = new StateParser();     

        

        Parser() 
        {
            magasin.state.Add(StateState.F);
        }

        //public List<string> Stroka = new List<string> { "int", "a", ":=", "5", ";", "\n", "a", "=", "a", "+", "5", ";", "END" };
        
        
        int i= 0;
        public Lexem Lex()
        {
            return Form1.myStorage[i];
        }

        public void Ops()
        {
            Lexem lex = Lex();
            while (lex.Type != LexemType.END && magasin.state[0] != StateState.END)
            {
                i++;

                StateParser stateMagas = magasin;
                magasin.state.Remove(0);
                magasin.type.Remove(0);

                if (stateMagas.type[0] != TypeLex.EMPTY)
                {
                    
                }
                //
            }
        }

        //public void Pair(State stateLex)
        //{
        //      if(stateLex.state[0] == F && stateLex.type[0] == NAME)
        //
        //}
    }
}

