/*   
    Copyright (C) 2009 Galaktika Corporation ZAO

    This file is a part of Ranet.UILibrary.Olap
 
    Ranet.UILibrary.Olap is a free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.
      
    You should have received a copy of the GNU General Public License
    along with Ranet.UILibrary.Olap.  If not, see <http://www.gnu.org/licenses/>.
  
    If GPL v.3 is not suitable for your products or company,
    Galaktika Corp provides Ranet.UILibrary.Olap under a flexible commercial license
    designed to meet your specific usage and distribution requirements.
    If you have already obtained a commercial license from Galaktika Corp,
    you can use this file under those license terms.
*/


// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System;

namespace Ranet.Olap.Mdx.Compiler.Parser
{
	using Antlr.Runtime;

	public partial class mdxLexer : Lexer
	{
		public const int T__68 = 68;
		public const int T__69 = 69;
		public const int T__66 = 66;
		public const int WHERE = 13;
		public const int T__67 = 67;
		public const int MEMBER = 15;
		public const int T__64 = 64;
		public const int T__65 = 65;
		public const int PROPERTIES = 10;
		public const int T__62 = 62;
		public const int T__63 = 63;
		public const int NON = 19;
		public const int CASE = 36;
		public const int UPDATE = 4;
		public const int FOR = 18;
		public const int CELL = 9;
		public const int FLOAT = 35;
		public const int NOT = 32;
		public const int USE_WEIGHTED_INCREMENT = 49;
		public const int USE_WEIGHTED_ALLOCATION = 48;
		public const int ID = 41;
		public const int AND = 31;
		public const int T__61 = 61;
		public const int EOF = -1;
		public const int T__60 = 60;
		public const int QUOTED_ID = 42;
		public const int VISUAL = 24;
		public const int T__55 = 55;
		public const int T__56 = 56;
		public const int AS = 16;
		public const int T__57 = 57;
		public const int CREATE = 43;
		public const int T__58 = 58;
		public const int THEN = 40;
		public const int T__53 = 53;
		public const int T__54 = 54;
		public const int IS = 33;
		public const int T__59 = 59;
		public const int FORMATTED_VALUE = 28;
		public const int DIMENSION = 21;
		public const int COMMENT = 52;
		public const int SELECT = 11;
		public const int RANET_EXPRESSION = 25;
		public const int WITH = 8;
		public const int INTEGER = 23;
		public const int BY = 7;
		public const int XOR = 29;
		public const int LINE_COMMENT = 51;
		public const int CELL_ORDINAL = 26;
		public const int ELSE = 37;
		public const int USE_EQUAL_ALLOCATION = 46;
		public const int ON = 22;
		public const int SET = 6;
		public const int SESSION = 45;
		public const int VALUE = 27;
		public const int EMPTY = 20;
		public const int T__71 = 71;
		public const int WS = 50;
		public const int CALCULATED = 14;
		public const int T__72 = 72;
		public const int T__70 = 70;
		public const int CUBE = 5;
		public const int WHEN = 39;
		public const int USE_EQUAL_INCREMENT = 47;
		public const int OR = 30;
		public const int CALCULATION = 17;
		public const int FROM = 12;
		public const int END = 38;
		public const int GLOBAL = 44;
		public const int T__75 = 75;
		public const int T__74 = 74;
		public const int T__73 = 73;
		public const int STRING = 34;

		// delegates
		// delegators

		public mdxLexer()
		{
			InitializeCyclicDFAs();
		}
		public mdxLexer(ICharStream input)
			: this(input, null)
		{
		}
		public mdxLexer(ICharStream input, RecognizerSharedState state)
			: base(input, state)
		{
			InitializeCyclicDFAs();

		}

		override public string GrammarFileName
		{
			get { return "D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g"; }
		}

		// $ANTLR start "T__53"
		public void mT__53() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__53;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:10:7: ( '=' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:10:9: '='
				{
					Match('=');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__53"

		// $ANTLR start "T__54"
		public void mT__54() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__54;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:11:7: ( 'USE_EQUAL_ALLOCATION' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:11:9: 'USE_EQUAL_ALLOCATION'
				{
					Match("USE_EQUAL_ALLOCATION");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__54"

		// $ANTLR start "T__55"
		public void mT__55() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__55;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:12:7: ( 'USE_EQUAL_INCREMENT' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:12:9: 'USE_EQUAL_INCREMENT'
				{
					Match("USE_EQUAL_INCREMENT");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__55"

		// $ANTLR start "T__56"
		public void mT__56() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__56;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:13:7: ( 'USE_WEIGHTED_ALLOCATION' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:13:9: 'USE_WEIGHTED_ALLOCATION'
				{
					Match("USE_WEIGHTED_ALLOCATION");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__56"

		// $ANTLR start "T__57"
		public void mT__57() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__57;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:14:7: ( 'USE_WEIGHTED_INCREMENT' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:14:9: 'USE_WEIGHTED_INCREMENT'
				{
					Match("USE_WEIGHTED_INCREMENT");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__57"

		// $ANTLR start "T__58"
		public void mT__58() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__58;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:15:7: ( ',' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:15:9: ','
				{
					Match(',');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__58"

		// $ANTLR start "T__59"
		public void mT__59() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__59;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:16:7: ( '*' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:16:9: '*'
				{
					Match('*');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__59"

		// $ANTLR start "T__60"
		public void mT__60() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__60;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:17:7: ( '.' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:17:9: '.'
				{
					Match('.');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__60"

		// $ANTLR start "T__61"
		public void mT__61() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__61;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:18:7: ( '(' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:18:9: '('
				{
					Match('(');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__61"

		// $ANTLR start "T__62"
		public void mT__62() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__62;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:19:7: ( ')' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:19:9: ')'
				{
					Match(')');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__62"

		// $ANTLR start "T__63"
		public void mT__63() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__63;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:20:7: ( '<>' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:20:9: '<>'
				{
					Match("<>");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__63"

		// $ANTLR start "T__64"
		public void mT__64() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__64;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:21:7: ( '<' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:21:9: '<'
				{
					Match('<');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__64"

		// $ANTLR start "T__65"
		public void mT__65() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__65;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:22:7: ( '>' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:22:9: '>'
				{
					Match('>');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__65"

		// $ANTLR start "T__66"
		public void mT__66() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__66;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:23:7: ( '<=' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:23:9: '<='
				{
					Match("<=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__66"

		// $ANTLR start "T__67"
		public void mT__67() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__67;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:24:7: ( '>=' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:24:9: '>='
				{
					Match(">=");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__67"

		// $ANTLR start "T__68"
		public void mT__68() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__68;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:25:7: ( '+' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:25:9: '+'
				{
					Match('+');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__68"

		// $ANTLR start "T__69"
		public void mT__69() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__69;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:26:7: ( '-' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:26:9: '-'
				{
					Match('-');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__69"

		// $ANTLR start "T__70"
		public void mT__70() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__70;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:27:7: ( '/' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:27:9: '/'
				{
					Match('/');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__70"

		// $ANTLR start "T__71"
		public void mT__71() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__71;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:28:7: ( '^' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:28:9: '^'
				{
					Match('^');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__71"

		// $ANTLR start "T__72"
		public void mT__72() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__72;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:29:7: ( ':' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:29:9: ':'
				{
					Match(':');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__72"

		// $ANTLR start "T__73"
		public void mT__73() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__73;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:30:7: ( '&' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:30:9: '&'
				{
					Match('&');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__73"

		// $ANTLR start "T__74"
		public void mT__74() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__74;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:31:7: ( '{' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:31:9: '{'
				{
					Match('{');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__74"

		// $ANTLR start "T__75"
		public void mT__75() // throws RecognitionException [2]
		{
			try
			{
				int _type = T__75;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:32:7: ( '}' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:32:9: '}'
				{
					Match('}');

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "T__75"

		// $ANTLR start "AND"
		public void mAND() // throws RecognitionException [2]
		{
			try
			{
				int _type = AND;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:369:5: ( ( 'A' | 'a' ) ( 'N' | 'n' ) ( 'D' | 'd' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:369:7: ( 'A' | 'a' ) ( 'N' | 'n' ) ( 'D' | 'd' )
				{
					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "AND"

		// $ANTLR start "AS"
		public void mAS() // throws RecognitionException [2]
		{
			try
			{
				int _type = AS;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:370:5: ( ( 'A' | 'a' ) ( 'S' | 's' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:370:7: ( 'A' | 'a' ) ( 'S' | 's' )
				{
					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "AS"

		// $ANTLR start "BY"
		public void mBY() // throws RecognitionException [2]
		{
			try
			{
				int _type = BY;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:371:5: ( ( 'B' | 'b' ) ( 'Y' | 'y' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:371:7: ( 'B' | 'b' ) ( 'Y' | 'y' )
				{
					if (input.LA(1) == 'B' || input.LA(1) == 'b')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'Y' || input.LA(1) == 'y')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "BY"

		// $ANTLR start "CASE"
		public void mCASE() // throws RecognitionException [2]
		{
			try
			{
				int _type = CASE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:372:7: ( ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'S' | 's' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:372:9: ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'S' | 's' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "CASE"

		// $ANTLR start "CALCULATED"
		public void mCALCULATED() // throws RecognitionException [2]
		{
			try
			{
				int _type = CALCULATED;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:374:2: ( ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'C' | 'c' ) ( 'U' | 'u' ) ( 'L' | 'l' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:374:4: ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'C' | 'c' ) ( 'U' | 'u' ) ( 'L' | 'l' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' )
				{
					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "CALCULATED"

		// $ANTLR start "CALCULATION"
		public void mCALCULATION() // throws RecognitionException [2]
		{
			try
			{
				int _type = CALCULATION;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:376:2: ( ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'C' | 'c' ) ( 'U' | 'u' ) ( 'L' | 'l' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:376:4: ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'C' | 'c' ) ( 'U' | 'u' ) ( 'L' | 'l' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "CALCULATION"

		// $ANTLR start "CELL"
		public void mCELL() // throws RecognitionException [2]
		{
			try
			{
				int _type = CELL;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:377:7: ( ( 'C' | 'c' ) ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'L' | 'l' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:377:9: ( 'C' | 'c' ) ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'L' | 'l' )
				{
					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "CELL"

		// $ANTLR start "CELL_ORDINAL"
		public void mCELL_ORDINAL() // throws RecognitionException [2]
		{
			try
			{
				int _type = CELL_ORDINAL;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:379:2: ( ( 'C' | 'c' ) ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'L' | 'l' ) ( '_' ) ( 'O' | 'o' ) ( 'R' | 'r' ) ( 'D' | 'd' ) ( 'I' | 'i' ) ( 'N' | 'n' ) ( 'A' | 'a' ) ( 'L' | 'l' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:379:4: ( 'C' | 'c' ) ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'L' | 'l' ) ( '_' ) ( 'O' | 'o' ) ( 'R' | 'r' ) ( 'D' | 'd' ) ( 'I' | 'i' ) ( 'N' | 'n' ) ( 'A' | 'a' ) ( 'L' | 'l' )
				{
					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:379:40: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:379:41: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "CELL_ORDINAL"

		// $ANTLR start "CREATE"
		public void mCREATE() // throws RecognitionException [2]
		{
			try
			{
				int _type = CREATE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:380:9: ( ( 'C' | 'c' ) ( 'R' | 'r' ) ( 'E' | 'e' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:380:11: ( 'C' | 'c' ) ( 'R' | 'r' ) ( 'E' | 'e' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "CREATE"

		// $ANTLR start "CUBE"
		public void mCUBE() // throws RecognitionException [2]
		{
			try
			{
				int _type = CUBE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:381:7: ( ( 'C' | 'c' ) ( 'U' | 'u' ) ( 'B' | 'b' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:381:9: ( 'C' | 'c' ) ( 'U' | 'u' ) ( 'B' | 'b' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'B' || input.LA(1) == 'b')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "CUBE"

		// $ANTLR start "DIMENSION"
		public void mDIMENSION() // throws RecognitionException [2]
		{
			try
			{
				int _type = DIMENSION;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:383:2: ( ( 'D' | 'd' ) ( 'I' | 'i' ) ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'S' | 's' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:383:4: ( 'D' | 'd' ) ( 'I' | 'i' ) ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'S' | 's' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "DIMENSION"

		// $ANTLR start "ELSE"
		public void mELSE() // throws RecognitionException [2]
		{
			try
			{
				int _type = ELSE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:384:6: ( ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'S' | 's' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:384:8: ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'S' | 's' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "ELSE"

		// $ANTLR start "EMPTY"
		public void mEMPTY() // throws RecognitionException [2]
		{
			try
			{
				int _type = EMPTY;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:385:7: ( ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'P' | 'p' ) ( 'T' | 't' ) ( 'Y' | 'y' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:385:9: ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'P' | 'p' ) ( 'T' | 't' ) ( 'Y' | 'y' )
				{
					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'P' || input.LA(1) == 'p')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'Y' || input.LA(1) == 'y')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "EMPTY"

		// $ANTLR start "END"
		public void mEND() // throws RecognitionException [2]
		{
			try
			{
				int _type = END;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:386:5: ( ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'D' | 'd' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:386:7: ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'D' | 'd' )
				{
					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "END"

		// $ANTLR start "FORMATTED_VALUE"
		public void mFORMATTED_VALUE() // throws RecognitionException [2]
		{
			try
			{
				int _type = FORMATTED_VALUE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:388:2: ( ( 'F' | 'f' ) ( 'O' | 'o' ) ( 'R' | 'r' ) ( 'M' | 'm' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' ) ( '_' ) ( 'V' | 'v' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'U' | 'u' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:388:4: ( 'F' | 'f' ) ( 'O' | 'o' ) ( 'R' | 'r' ) ( 'M' | 'm' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' ) ( '_' ) ( 'V' | 'v' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'U' | 'u' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'F' || input.LA(1) == 'f')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:388:85: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:388:86: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'V' || input.LA(1) == 'v')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "FORMATTED_VALUE"

		// $ANTLR start "FOR"
		public void mFOR() // throws RecognitionException [2]
		{
			try
			{
				int _type = FOR;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:389:5: ( ( 'F' | 'f' ) ( 'O' | 'o' ) ( 'R' | 'r' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:389:7: ( 'F' | 'f' ) ( 'O' | 'o' ) ( 'R' | 'r' )
				{
					if (input.LA(1) == 'F' || input.LA(1) == 'f')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "FOR"

		// $ANTLR start "FROM"
		public void mFROM() // throws RecognitionException [2]
		{
			try
			{
				int _type = FROM;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:390:6: ( ( 'F' | 'f' ) ( 'R' | 'r' ) ( 'O' | 'o' ) ( 'M' | 'm' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:390:8: ( 'F' | 'f' ) ( 'R' | 'r' ) ( 'O' | 'o' ) ( 'M' | 'm' )
				{
					if (input.LA(1) == 'F' || input.LA(1) == 'f')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "FROM"

		// $ANTLR start "SELECT"
		public void mSELECT() // throws RecognitionException [2]
		{
			try
			{
				int _type = SELECT;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:391:8: ( ( 'S' | 's' ) ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'E' | 'e' ) ( 'C' | 'c' ) ( 'T' | 't' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:391:10: ( 'S' | 's' ) ( 'E' | 'e' ) ( 'L' | 'l' ) ( 'E' | 'e' ) ( 'C' | 'c' ) ( 'T' | 't' )
				{
					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "SELECT"

		// $ANTLR start "IS"
		public void mIS() // throws RecognitionException [2]
		{
			try
			{
				int _type = IS;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:392:4: ( ( 'I' | 'i' ) ( 'S' | 's' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:392:6: ( 'I' | 'i' ) ( 'S' | 's' )
				{
					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "IS"

		// $ANTLR start "GLOBAL"
		public void mGLOBAL() // throws RecognitionException [2]
		{
			try
			{
				int _type = GLOBAL;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:393:8: ( ( 'G' | 'g' ) ( 'L' | 'l' ) ( 'O' | 'o' ) ( 'B' | 'b' ) ( 'A' | 'a' ) ( 'L' | 'l' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:393:10: ( 'G' | 'g' ) ( 'L' | 'l' ) ( 'O' | 'o' ) ( 'B' | 'b' ) ( 'A' | 'a' ) ( 'L' | 'l' )
				{
					if (input.LA(1) == 'G' || input.LA(1) == 'g')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'B' || input.LA(1) == 'b')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "GLOBAL"

		// $ANTLR start "MEMBER"
		public void mMEMBER() // throws RecognitionException [2]
		{
			try
			{
				int _type = MEMBER;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:394:8: ( ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'B' | 'b' ) ( 'E' | 'e' ) ( 'R' | 'r' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:394:10: ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'B' | 'b' ) ( 'E' | 'e' ) ( 'R' | 'r' )
				{
					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'B' || input.LA(1) == 'b')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "MEMBER"

		// $ANTLR start "NON"
		public void mNON() // throws RecognitionException [2]
		{
			try
			{
				int _type = NON;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:395:5: ( ( 'N' | 'n' ) ( 'O' | 'o' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:395:7: ( 'N' | 'n' ) ( 'O' | 'o' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "NON"

		// $ANTLR start "NOT"
		public void mNOT() // throws RecognitionException [2]
		{
			try
			{
				int _type = NOT;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:396:5: ( ( 'N' | 'n' ) ( 'O' | 'o' ) ( 'T' | 't' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:396:7: ( 'N' | 'n' ) ( 'O' | 'o' ) ( 'T' | 't' )
				{
					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "NOT"

		// $ANTLR start "ON"
		public void mON() // throws RecognitionException [2]
		{
			try
			{
				int _type = ON;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:397:4: ( ( 'O' | 'o' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:397:6: ( 'O' | 'o' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "ON"

		// $ANTLR start "OR"
		public void mOR() // throws RecognitionException [2]
		{
			try
			{
				int _type = OR;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:398:4: ( ( 'O' | 'o' ) ( 'R' | 'r' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:398:6: ( 'O' | 'o' ) ( 'R' | 'r' )
				{
					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "OR"

		// $ANTLR start "PROPERTIES"
		public void mPROPERTIES() // throws RecognitionException [2]
		{
			try
			{
				int _type = PROPERTIES;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:400:2: ( ( 'P' | 'p' ) ( 'R' | 'r' ) ( 'O' | 'o' ) ( 'P' | 'p' ) ( 'E' | 'e' ) ( 'R' | 'r' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'E' | 'e' ) ( 'S' | 's' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:400:4: ( 'P' | 'p' ) ( 'R' | 'r' ) ( 'O' | 'o' ) ( 'P' | 'p' ) ( 'E' | 'e' ) ( 'R' | 'r' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'E' | 'e' ) ( 'S' | 's' )
				{
					if (input.LA(1) == 'P' || input.LA(1) == 'p')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'P' || input.LA(1) == 'p')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "PROPERTIES"

		// $ANTLR start "SESSION"
		public void mSESSION() // throws RecognitionException [2]
		{
			try
			{
				int _type = SESSION;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:401:9: ( ( 'S' | 's' ) ( 'E' | 'e' ) ( 'S' | 's' ) ( 'S' | 's' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:401:11: ( 'S' | 's' ) ( 'E' | 'e' ) ( 'S' | 's' ) ( 'S' | 's' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "SESSION"

		// $ANTLR start "SET"
		public void mSET() // throws RecognitionException [2]
		{
			try
			{
				int _type = SET;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:402:5: ( ( 'S' | 's' ) ( 'E' | 'e' ) ( 'T' | 't' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:402:7: ( 'S' | 's' ) ( 'E' | 'e' ) ( 'T' | 't' )
				{
					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "SET"

		// $ANTLR start "THEN"
		public void mTHEN() // throws RecognitionException [2]
		{
			try
			{
				int _type = THEN;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:403:6: ( ( 'T' | 't' ) ( 'H' | 'h' ) ( 'E' | 'e' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:403:8: ( 'T' | 't' ) ( 'H' | 'h' ) ( 'E' | 'e' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'H' || input.LA(1) == 'h')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "THEN"

		// $ANTLR start "UPDATE"
		public void mUPDATE() // throws RecognitionException [2]
		{
			try
			{
				int _type = UPDATE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:404:8: ( ( 'U' | 'u' ) ( 'P' | 'p' ) ( 'D' | 'd' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:404:10: ( 'U' | 'u' ) ( 'P' | 'p' ) ( 'D' | 'd' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'P' || input.LA(1) == 'p')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "UPDATE"

		// $ANTLR start "VALUE"
		public void mVALUE() // throws RecognitionException [2]
		{
			try
			{
				int _type = VALUE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:405:7: ( ( 'V' | 'v' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'U' | 'u' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:405:9: ( 'V' | 'v' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'U' | 'u' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'V' || input.LA(1) == 'v')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "VALUE"

		// $ANTLR start "USE_EQUAL_ALLOCATION"
		public void mUSE_EQUAL_ALLOCATION() // throws RecognitionException [2]
		{
			try
			{
				int _type = USE_EQUAL_ALLOCATION;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:407:2: ( ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'E' | 'e' ) ( 'Q' | 'q' ) ( 'U' | 'u' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( '_' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'L' | 'l' ) ( 'O' | 'o' ) ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:407:4: ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'E' | 'e' ) ( 'Q' | 'q' ) ( 'U' | 'u' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( '_' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'L' | 'l' ) ( 'O' | 'o' ) ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:407:31: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:407:32: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'Q' || input.LA(1) == 'q')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:407:81: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:407:82: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "USE_EQUAL_ALLOCATION"

		// $ANTLR start "USE_EQUAL_INCREMENT"
		public void mUSE_EQUAL_INCREMENT() // throws RecognitionException [2]
		{
			try
			{
				int _type = USE_EQUAL_INCREMENT;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:411:2: ( ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'E' | 'e' ) ( 'Q' | 'q' ) ( 'U' | 'u' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( '_' ) ( 'I' | 'i' ) ( 'N' | 'n' ) ( 'C' | 'c' ) ( 'R' | 'r' ) ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'T' | 't' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:411:4: ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'E' | 'e' ) ( 'Q' | 'q' ) ( 'U' | 'u' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( '_' ) ( 'I' | 'i' ) ( 'N' | 'n' ) ( 'C' | 'c' ) ( 'R' | 'r' ) ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'T' | 't' )
				{
					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:411:31: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:411:32: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'Q' || input.LA(1) == 'q')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:411:81: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:411:82: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "USE_EQUAL_INCREMENT"

		// $ANTLR start "USE_WEIGHTED_ALLOCATION"
		public void mUSE_WEIGHTED_ALLOCATION() // throws RecognitionException [2]
		{
			try
			{
				int _type = USE_WEIGHTED_ALLOCATION;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:415:2: ( ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'W' | 'w' ) ( 'E' | 'e' ) ( 'I' | 'i' ) ( 'G' | 'g' ) ( 'H' | 'h' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' ) ( '_' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'L' | 'l' ) ( 'O' | 'o' ) ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:415:4: ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'W' | 'w' ) ( 'E' | 'e' ) ( 'I' | 'i' ) ( 'G' | 'g' ) ( 'H' | 'h' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' ) ( '_' ) ( 'A' | 'a' ) ( 'L' | 'l' ) ( 'L' | 'l' ) ( 'O' | 'o' ) ( 'C' | 'c' ) ( 'A' | 'a' ) ( 'T' | 't' ) ( 'I' | 'i' ) ( 'O' | 'o' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:415:31: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:415:32: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'W' || input.LA(1) == 'w')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'G' || input.LA(1) == 'g')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'H' || input.LA(1) == 'h')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:415:108: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:415:109: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "USE_WEIGHTED_ALLOCATION"

		// $ANTLR start "USE_WEIGHTED_INCREMENT"
		public void mUSE_WEIGHTED_INCREMENT() // throws RecognitionException [2]
		{
			try
			{
				int _type = USE_WEIGHTED_INCREMENT;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:419:2: ( ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'W' | 'w' ) ( 'E' | 'e' ) ( 'I' | 'i' ) ( 'G' | 'g' ) ( 'H' | 'h' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' ) ( '_' ) ( 'I' | 'i' ) ( 'N' | 'n' ) ( 'C' | 'c' ) ( 'R' | 'r' ) ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'T' | 't' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:419:4: ( 'U' | 'u' ) ( 'S' | 's' ) ( 'E' | 'e' ) ( '_' ) ( 'W' | 'w' ) ( 'E' | 'e' ) ( 'I' | 'i' ) ( 'G' | 'g' ) ( 'H' | 'h' ) ( 'T' | 't' ) ( 'E' | 'e' ) ( 'D' | 'd' ) ( '_' ) ( 'I' | 'i' ) ( 'N' | 'n' ) ( 'C' | 'c' ) ( 'R' | 'r' ) ( 'E' | 'e' ) ( 'M' | 'm' ) ( 'E' | 'e' ) ( 'N' | 'n' ) ( 'T' | 't' )
				{
					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:419:31: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:419:32: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'W' || input.LA(1) == 'w')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'G' || input.LA(1) == 'g')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'H' || input.LA(1) == 'h')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'D' || input.LA(1) == 'd')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:419:108: ( '_' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:419:109: '_'
					{
						Match('_');

					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'C' || input.LA(1) == 'c')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'M' || input.LA(1) == 'm')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "USE_WEIGHTED_INCREMENT"

		// $ANTLR start "VISUAL"
		public void mVISUAL() // throws RecognitionException [2]
		{
			try
			{
				int _type = VISUAL;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:422:8: ( ( 'V' | 'v' ) ( 'I' | 'i' ) ( 'S' | 's' ) ( 'U' | 'u' ) ( 'A' | 'a' ) ( 'L' | 'l' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:422:10: ( 'V' | 'v' ) ( 'I' | 'i' ) ( 'S' | 's' ) ( 'U' | 'u' ) ( 'A' | 'a' ) ( 'L' | 'l' )
				{
					if (input.LA(1) == 'V' || input.LA(1) == 'v')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'S' || input.LA(1) == 's')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'U' || input.LA(1) == 'u')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'A' || input.LA(1) == 'a')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'L' || input.LA(1) == 'l')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "VISUAL"

		// $ANTLR start "WITH"
		public void mWITH() // throws RecognitionException [2]
		{
			try
			{
				int _type = WITH;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:423:6: ( ( 'W' | 'w' ) ( 'I' | 'i' ) ( 'T' | 't' ) ( 'H' | 'h' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:423:8: ( 'W' | 'w' ) ( 'I' | 'i' ) ( 'T' | 't' ) ( 'H' | 'h' )
				{
					if (input.LA(1) == 'W' || input.LA(1) == 'w')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'I' || input.LA(1) == 'i')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'T' || input.LA(1) == 't')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'H' || input.LA(1) == 'h')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "WITH"

		// $ANTLR start "WHEN"
		public void mWHEN() // throws RecognitionException [2]
		{
			try
			{
				int _type = WHEN;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:424:6: ( ( 'W' | 'w' ) ( 'H' | 'h' ) ( 'E' | 'e' ) ( 'N' | 'n' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:424:8: ( 'W' | 'w' ) ( 'H' | 'h' ) ( 'E' | 'e' ) ( 'N' | 'n' )
				{
					if (input.LA(1) == 'W' || input.LA(1) == 'w')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'H' || input.LA(1) == 'h')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'N' || input.LA(1) == 'n')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "WHEN"

		// $ANTLR start "WHERE"
		public void mWHERE() // throws RecognitionException [2]
		{
			try
			{
				int _type = WHERE;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:425:7: ( ( 'W' | 'w' ) ( 'H' | 'h' ) ( 'E' | 'e' ) ( 'R' | 'r' ) ( 'E' | 'e' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:425:9: ( 'W' | 'w' ) ( 'H' | 'h' ) ( 'E' | 'e' ) ( 'R' | 'r' ) ( 'E' | 'e' )
				{
					if (input.LA(1) == 'W' || input.LA(1) == 'w')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'H' || input.LA(1) == 'h')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'E' || input.LA(1) == 'e')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "WHERE"

		// $ANTLR start "XOR"
		public void mXOR() // throws RecognitionException [2]
		{
			try
			{
				int _type = XOR;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:426:5: ( ( 'X' | 'x' ) ( 'O' | 'o' ) ( 'R' | 'r' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:426:7: ( 'X' | 'x' ) ( 'O' | 'o' ) ( 'R' | 'r' )
				{
					if (input.LA(1) == 'X' || input.LA(1) == 'x')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'O' || input.LA(1) == 'o')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					if (input.LA(1) == 'R' || input.LA(1) == 'r')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "XOR"

		// $ANTLR start "FLOAT"
		public void mFLOAT() // throws RecognitionException [2]
		{
			try
			{
				int _type = FLOAT;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:429:7: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:429:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
				{
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:429:9: ( '0' .. '9' )+
					int cnt1 = 0;
					do
					{
						int alt1 = 2;
						int LA1_0 = input.LA(1);

						if (((LA1_0 >= '0' && LA1_0 <= '9')))
						{
							alt1 = 1;
						}


						switch (alt1)
						{
							case 1:
								// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:429:9: '0' .. '9'
								{
									MatchRange('0', '9');

								}
								break;

							default:
								if (cnt1 >= 1) goto loop1;
								EarlyExitException eee1 =
										new EarlyExitException(1, input);
								throw eee1;
						}
						cnt1++;
					} while (true);

				loop1:
					;	// Stops C# compiler whinging that label 'loop1' has no statements

					Match('.');
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:429:23: ( '0' .. '9' )*
					do
					{
						int alt2 = 2;
						int LA2_0 = input.LA(1);

						if (((LA2_0 >= '0' && LA2_0 <= '9')))
						{
							alt2 = 1;
						}


						switch (alt2)
						{
							case 1:
								// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:429:23: '0' .. '9'
								{
									MatchRange('0', '9');

								}
								break;

							default:
								goto loop2;
						}
					} while (true);

				loop2:
					;	// Stops C# compiler whining that label 'loop2' has no statements


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "FLOAT"

		// $ANTLR start "INTEGER"
		public void mINTEGER() // throws RecognitionException [2]
		{
			try
			{
				int _type = INTEGER;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:430:9: ( ( '0' .. '9' )+ )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:430:11: ( '0' .. '9' )+
				{
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:430:11: ( '0' .. '9' )+
					int cnt3 = 0;
					do
					{
						int alt3 = 2;
						int LA3_0 = input.LA(1);

						if (((LA3_0 >= '0' && LA3_0 <= '9')))
						{
							alt3 = 1;
						}


						switch (alt3)
						{
							case 1:
								// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:430:12: '0' .. '9'
								{
									MatchRange('0', '9');

								}
								break;

							default:
								if (cnt3 >= 1) goto loop3;
								EarlyExitException eee3 =
										new EarlyExitException(3, input);
								throw eee3;
						}
						cnt3++;
					} while (true);

				loop3:
					;	// Stops C# compiler whinging that label 'loop3' has no statements


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "INTEGER"

		// $ANTLR start "ID"
		public void mID() // throws RecognitionException [2]
		{
			try
			{
				int _type = ID;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:432:4: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '$' | '\\u0410' .. '\\u0451' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' | '\\u0410' .. '\\u0451' )* )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:432:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '$' | '\\u0410' .. '\\u0451' ) ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' | '\\u0410' .. '\\u0451' )*
				{
					if (input.LA(1) == '$' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0410' && input.LA(1) <= '\u0451'))
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null, input);
						Recover(mse);
						throw mse;
					}

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:432:54: ( 'a' .. 'z' | 'A' .. 'Z' | '_' | '0' .. '9' | '\\u0410' .. '\\u0451' )*
					do
					{
						int alt4 = 2;
						int LA4_0 = input.LA(1);

						if (((LA4_0 >= '0' && LA4_0 <= '9') || (LA4_0 >= 'A' && LA4_0 <= 'Z') || LA4_0 == '_' || (LA4_0 >= 'a' && LA4_0 <= 'z') || (LA4_0 >= '\u0410' && LA4_0 <= '\u0451')))
						{
							alt4 = 1;
						}


						switch (alt4)
						{
							case 1:
								// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:
								{
									if ((input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u0410' && input.LA(1) <= '\u0451'))
									{
										input.Consume();

									}
									else
									{
										MismatchedSetException mse = new MismatchedSetException(null, input);
										Recover(mse);
										throw mse;
									}


								}
								break;

							default:
								goto loop4;
						}
					} while (true);

				loop4:
					;	// Stops C# compiler whining that label 'loop4' has no statements


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "ID"

		// $ANTLR start "QUOTED_ID"
		public void mQUOTED_ID() // throws RecognitionException [2]
		{
			try
			{
				int _type = QUOTED_ID;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:435:2: ( ( '[' (~ ']' )* ']' ) )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:435:4: ( '[' (~ ']' )* ']' )
				{
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:435:4: ( '[' (~ ']' )* ']' )
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:435:5: '[' (~ ']' )* ']'
					{
						Match('[');
						// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:435:9: (~ ']' )*
						do
						{
							int alt5 = 2;
							int LA5_0 = input.LA(1);

							if (((LA5_0 >= '\u0000' && LA5_0 <= '\\') || (LA5_0 >= '^' && LA5_0 <= '\uFFFF')))
							{
								alt5 = 1;
							}


							switch (alt5)
							{
								case 1:
									// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:435:10: ~ ']'
									{
										if ((input.LA(1) >= '\u0000' && input.LA(1) <= '\\') || (input.LA(1) >= '^' && input.LA(1) <= '\uFFFF'))
										{
											input.Consume();

										}
										else
										{
											MismatchedSetException mse = new MismatchedSetException(null, input);
											Recover(mse);
											throw mse;
										}


									}
									break;

								default:
									goto loop5;
							}
						} while (true);

					loop5:
						;	// Stops C# compiler whining that label 'loop5' has no statements

						Match(']');

					}


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "QUOTED_ID"

		// $ANTLR start "STRING"
		public void mSTRING() // throws RecognitionException [2]
		{
			try
			{
				int _type = STRING;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:437:9: ( '\"' (~ '\"' )* '\"' | '\\'' (~ '\\'' )* '\\'' )
				int alt8 = 2;
				int LA8_0 = input.LA(1);

				if ((LA8_0 == '\"'))
				{
					alt8 = 1;
				}
				else if ((LA8_0 == '\''))
				{
					alt8 = 2;
				}
				else
				{
					NoViableAltException nvae_d8s0 =
							new NoViableAltException("", 8, 0, input);

					throw nvae_d8s0;
				}
				switch (alt8)
				{
					case 1:
						// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:437:11: '\"' (~ '\"' )* '\"'
						{
							Match('\"');
							// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:437:15: (~ '\"' )*
							do
							{
								int alt6 = 2;
								int LA6_0 = input.LA(1);

								if (((LA6_0 >= '\u0000' && LA6_0 <= '!') || (LA6_0 >= '#' && LA6_0 <= '\uFFFF')))
								{
									alt6 = 1;
								}


								switch (alt6)
								{
									case 1:
										// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:437:16: ~ '\"'
										{
											if ((input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF'))
											{
												input.Consume();

											}
											else
											{
												MismatchedSetException mse = new MismatchedSetException(null, input);
												Recover(mse);
												throw mse;
											}


										}
										break;

									default:
										goto loop6;
								}
							} while (true);

						loop6:
							;	// Stops C# compiler whining that label 'loop6' has no statements

							Match('\"');

						}
						break;
					case 2:
						// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:438:4: '\\'' (~ '\\'' )* '\\''
						{
							Match('\'');
							// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:438:9: (~ '\\'' )*
							do
							{
								int alt7 = 2;
								int LA7_0 = input.LA(1);

								if (((LA7_0 >= '\u0000' && LA7_0 <= '&') || (LA7_0 >= '(' && LA7_0 <= '\uFFFF')))
								{
									alt7 = 1;
								}


								switch (alt7)
								{
									case 1:
										// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:438:10: ~ '\\''
										{
											if ((input.LA(1) >= '\u0000' && input.LA(1) <= '&') || (input.LA(1) >= '(' && input.LA(1) <= '\uFFFF'))
											{
												input.Consume();

											}
											else
											{
												MismatchedSetException mse = new MismatchedSetException(null, input);
												Recover(mse);
												throw mse;
											}


										}
										break;

									default:
										goto loop7;
								}
							} while (true);

						loop7:
							;	// Stops C# compiler whining that label 'loop7' has no statements

							Match('\'');

						}
						break;

				}
				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "STRING"

		// $ANTLR start "RANET_EXPRESSION"
		public void mRANET_EXPRESSION() // throws RecognitionException [2]
		{
			try
			{
				int _type = RANET_EXPRESSION;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:441:2: ( '<%' ( options {greedy=false; } : . )+ '%>' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:441:4: '<%' ( options {greedy=false; } : . )+ '%>'
				{
					Match("<%");

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:441:9: ( options {greedy=false; } : . )+
					int cnt9 = 0;
					do
					{
						int alt9 = 2;
						int LA9_0 = input.LA(1);

						if ((LA9_0 == '%'))
						{
							int LA9_1 = input.LA(2);

							if ((LA9_1 == '>'))
							{
								alt9 = 2;
							}
							else if (((LA9_1 >= '\u0000' && LA9_1 <= '=') || (LA9_1 >= '?' && LA9_1 <= '\uFFFF')))
							{
								alt9 = 1;
							}


						}
						else if (((LA9_0 >= '\u0000' && LA9_0 <= '$') || (LA9_0 >= '&' && LA9_0 <= '\uFFFF')))
						{
							alt9 = 1;
						}


						switch (alt9)
						{
							case 1:
								// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:441:38: .
								{
									MatchAny();

								}
								break;

							default:
								if (cnt9 >= 1) goto loop9;
								EarlyExitException eee9 =
										new EarlyExitException(9, input);
								throw eee9;
						}
						cnt9++;
					} while (true);

				loop9:
					;	// Stops C# compiler whinging that label 'loop9' has no statements

					Match("%>");


				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "RANET_EXPRESSION"

		// $ANTLR start "WS"
		public void mWS() // throws RecognitionException [2]
		{
			try
			{
				int _type = WS;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:444:4: ( ( ' ' | '\\t' | '\\r' | '\\f' | '\\n' | '\\u00A0' )+ )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:444:6: ( ' ' | '\\t' | '\\r' | '\\f' | '\\n' | '\\u00A0' )+
				{
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:444:6: ( ' ' | '\\t' | '\\r' | '\\f' | '\\n' | '\\u00A0' )+
					int cnt10 = 0;
					do
					{
						int alt10 = 2;
						int LA10_0 = input.LA(1);

						if (((LA10_0 >= '\t' && LA10_0 <= '\n') || (LA10_0 >= '\f' && LA10_0 <= '\r') || LA10_0 == ' ' || LA10_0 == '\u00A0'))
						{
							alt10 = 1;
						}


						switch (alt10)
						{
							case 1:
								// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:
								{
									if ((input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' || input.LA(1) == '\u00A0')
									{
										input.Consume();

									}
									else
									{
										MismatchedSetException mse = new MismatchedSetException(null, input);
										Recover(mse);
										throw mse;
									}


								}
								break;

							default:
								if (cnt10 >= 1) goto loop10;
								EarlyExitException eee10 =
										new EarlyExitException(10, input);
								throw eee10;
						}
						cnt10++;
					} while (true);

				loop10:
					;	// Stops C# compiler whinging that label 'loop10' has no statements

					_channel = HIDDEN;

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "WS"

		// $ANTLR start "LINE_COMMENT"
		public void mLINE_COMMENT() // throws RecognitionException [2]
		{
			try
			{
				int _type = LINE_COMMENT;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:455:2: ( '//' (~ ( '\\n' | '\\r' ) )* | '--' (~ ( '\\n' | '\\r' ) )* )
				int alt13 = 2;
				int LA13_0 = input.LA(1);

				if ((LA13_0 == '/'))
				{
					alt13 = 1;
				}
				else if ((LA13_0 == '-'))
				{
					alt13 = 2;
				}
				else
				{
					NoViableAltException nvae_d13s0 =
							new NoViableAltException("", 13, 0, input);

					throw nvae_d13s0;
				}
				switch (alt13)
				{
					case 1:
						// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:455:4: '//' (~ ( '\\n' | '\\r' ) )*
						{
							Match("//");

							// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:455:9: (~ ( '\\n' | '\\r' ) )*
							do
							{
								int alt11 = 2;
								int LA11_0 = input.LA(1);

								if (((LA11_0 >= '\u0000' && LA11_0 <= '\t') || (LA11_0 >= '\u000B' && LA11_0 <= '\f') || (LA11_0 >= '\u000E' && LA11_0 <= '\uFFFF')))
								{
									alt11 = 1;
								}


								switch (alt11)
								{
									case 1:
										// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:455:9: ~ ( '\\n' | '\\r' )
										{
											if ((input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF'))
											{
												input.Consume();

											}
											else
											{
												MismatchedSetException mse = new MismatchedSetException(null, input);
												Recover(mse);
												throw mse;
											}


										}
										break;

									default:
										goto loop11;
								}
							} while (true);

						loop11:
							;	// Stops C# compiler whining that label 'loop11' has no statements

							_channel = HIDDEN;

						}
						break;
					case 2:
						// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:457:4: '--' (~ ( '\\n' | '\\r' ) )*
						{
							Match("--");

							// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:457:9: (~ ( '\\n' | '\\r' ) )*
							do
							{
								int alt12 = 2;
								int LA12_0 = input.LA(1);

								if (((LA12_0 >= '\u0000' && LA12_0 <= '\t') || (LA12_0 >= '\u000B' && LA12_0 <= '\f') || (LA12_0 >= '\u000E' && LA12_0 <= '\uFFFF')))
								{
									alt12 = 1;
								}


								switch (alt12)
								{
									case 1:
										// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:457:9: ~ ( '\\n' | '\\r' )
										{
											if ((input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF'))
											{
												input.Consume();

											}
											else
											{
												MismatchedSetException mse = new MismatchedSetException(null, input);
												Recover(mse);
												throw mse;
											}


										}
										break;

									default:
										goto loop12;
								}
							} while (true);

						loop12:
							;	// Stops C# compiler whining that label 'loop12' has no statements

							_channel = HIDDEN;

						}
						break;

				}
				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "LINE_COMMENT"

		// $ANTLR start "COMMENT"
		public void mCOMMENT() // throws RecognitionException [2]
		{
			try
			{
				int _type = COMMENT;
				int _channel = DEFAULT_TOKEN_CHANNEL;
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:461:2: ( '/*' ( options {greedy=false; } : . )* '*/' )
				// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:461:4: '/*' ( options {greedy=false; } : . )* '*/'
				{
					Match("/*");

					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:461:9: ( options {greedy=false; } : . )*
					do
					{
						int alt14 = 2;
						int LA14_0 = input.LA(1);

						if ((LA14_0 == '*'))
						{
							int LA14_1 = input.LA(2);

							if ((LA14_1 == '/'))
							{
								alt14 = 2;
							}
							else if (((LA14_1 >= '\u0000' && LA14_1 <= '.') || (LA14_1 >= '0' && LA14_1 <= '\uFFFF')))
							{
								alt14 = 1;
							}


						}
						else if (((LA14_0 >= '\u0000' && LA14_0 <= ')') || (LA14_0 >= '+' && LA14_0 <= '\uFFFF')))
						{
							alt14 = 1;
						}


						switch (alt14)
						{
							case 1:
								// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:461:37: .
								{
									MatchAny();

								}
								break;

							default:
								goto loop14;
						}
					} while (true);

				loop14:
					;	// Stops C# compiler whining that label 'loop14' has no statements

					Match("*/");

					_channel = HIDDEN;

				}

				state.type = _type;
				state.channel = _channel;
			}
			finally
			{
			}
		}
		// $ANTLR end "COMMENT"

		override public void mTokens() // throws RecognitionException 
		{
			// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:8: ( T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | AND | AS | BY | CASE | CALCULATED | CALCULATION | CELL | CELL_ORDINAL | CREATE | CUBE | DIMENSION | ELSE | EMPTY | END | FORMATTED_VALUE | FOR | FROM | SELECT | IS | GLOBAL | MEMBER | NON | NOT | ON | OR | PROPERTIES | SESSION | SET | THEN | UPDATE | VALUE | USE_EQUAL_ALLOCATION | USE_EQUAL_INCREMENT | USE_WEIGHTED_ALLOCATION | USE_WEIGHTED_INCREMENT | VISUAL | WITH | WHEN | WHERE | XOR | FLOAT | INTEGER | ID | QUOTED_ID | STRING | RANET_EXPRESSION | WS | LINE_COMMENT | COMMENT )
			int alt15 = 72;
			alt15 = dfa15.Predict(input);
			switch (alt15)
			{
				case 1:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:10: T__53
					{
						mT__53();

					}
					break;
				case 2:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:16: T__54
					{
						mT__54();

					}
					break;
				case 3:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:22: T__55
					{
						mT__55();

					}
					break;
				case 4:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:28: T__56
					{
						mT__56();

					}
					break;
				case 5:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:34: T__57
					{
						mT__57();

					}
					break;
				case 6:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:40: T__58
					{
						mT__58();

					}
					break;
				case 7:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:46: T__59
					{
						mT__59();

					}
					break;
				case 8:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:52: T__60
					{
						mT__60();

					}
					break;
				case 9:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:58: T__61
					{
						mT__61();

					}
					break;
				case 10:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:64: T__62
					{
						mT__62();

					}
					break;
				case 11:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:70: T__63
					{
						mT__63();

					}
					break;
				case 12:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:76: T__64
					{
						mT__64();

					}
					break;
				case 13:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:82: T__65
					{
						mT__65();

					}
					break;
				case 14:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:88: T__66
					{
						mT__66();

					}
					break;
				case 15:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:94: T__67
					{
						mT__67();

					}
					break;
				case 16:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:100: T__68
					{
						mT__68();

					}
					break;
				case 17:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:106: T__69
					{
						mT__69();

					}
					break;
				case 18:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:112: T__70
					{
						mT__70();

					}
					break;
				case 19:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:118: T__71
					{
						mT__71();

					}
					break;
				case 20:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:124: T__72
					{
						mT__72();

					}
					break;
				case 21:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:130: T__73
					{
						mT__73();

					}
					break;
				case 22:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:136: T__74
					{
						mT__74();

					}
					break;
				case 23:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:142: T__75
					{
						mT__75();

					}
					break;
				case 24:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:148: AND
					{
						mAND();

					}
					break;
				case 25:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:152: AS
					{
						mAS();

					}
					break;
				case 26:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:155: BY
					{
						mBY();

					}
					break;
				case 27:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:158: CASE
					{
						mCASE();

					}
					break;
				case 28:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:163: CALCULATED
					{
						mCALCULATED();

					}
					break;
				case 29:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:174: CALCULATION
					{
						mCALCULATION();

					}
					break;
				case 30:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:186: CELL
					{
						mCELL();

					}
					break;
				case 31:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:191: CELL_ORDINAL
					{
						mCELL_ORDINAL();

					}
					break;
				case 32:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:204: CREATE
					{
						mCREATE();

					}
					break;
				case 33:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:211: CUBE
					{
						mCUBE();

					}
					break;
				case 34:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:216: DIMENSION
					{
						mDIMENSION();

					}
					break;
				case 35:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:226: ELSE
					{
						mELSE();

					}
					break;
				case 36:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:231: EMPTY
					{
						mEMPTY();

					}
					break;
				case 37:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:237: END
					{
						mEND();

					}
					break;
				case 38:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:241: FORMATTED_VALUE
					{
						mFORMATTED_VALUE();

					}
					break;
				case 39:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:257: FOR
					{
						mFOR();

					}
					break;
				case 40:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:261: FROM
					{
						mFROM();

					}
					break;
				case 41:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:266: SELECT
					{
						mSELECT();

					}
					break;
				case 42:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:273: IS
					{
						mIS();

					}
					break;
				case 43:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:276: GLOBAL
					{
						mGLOBAL();

					}
					break;
				case 44:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:283: MEMBER
					{
						mMEMBER();

					}
					break;
				case 45:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:290: NON
					{
						mNON();

					}
					break;
				case 46:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:294: NOT
					{
						mNOT();

					}
					break;
				case 47:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:298: ON
					{
						mON();

					}
					break;
				case 48:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:301: OR
					{
						mOR();

					}
					break;
				case 49:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:304: PROPERTIES
					{
						mPROPERTIES();

					}
					break;
				case 50:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:315: SESSION
					{
						mSESSION();

					}
					break;
				case 51:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:323: SET
					{
						mSET();

					}
					break;
				case 52:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:327: THEN
					{
						mTHEN();

					}
					break;
				case 53:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:332: UPDATE
					{
						mUPDATE();

					}
					break;
				case 54:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:339: VALUE
					{
						mVALUE();

					}
					break;
				case 55:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:345: USE_EQUAL_ALLOCATION
					{
						mUSE_EQUAL_ALLOCATION();

					}
					break;
				case 56:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:366: USE_EQUAL_INCREMENT
					{
						mUSE_EQUAL_INCREMENT();

					}
					break;
				case 57:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:386: USE_WEIGHTED_ALLOCATION
					{
						mUSE_WEIGHTED_ALLOCATION();

					}
					break;
				case 58:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:410: USE_WEIGHTED_INCREMENT
					{
						mUSE_WEIGHTED_INCREMENT();

					}
					break;
				case 59:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:433: VISUAL
					{
						mVISUAL();

					}
					break;
				case 60:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:440: WITH
					{
						mWITH();

					}
					break;
				case 61:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:445: WHEN
					{
						mWHEN();

					}
					break;
				case 62:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:450: WHERE
					{
						mWHERE();

					}
					break;
				case 63:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:456: XOR
					{
						mXOR();

					}
					break;
				case 64:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:460: FLOAT
					{
						mFLOAT();

					}
					break;
				case 65:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:466: INTEGER
					{
						mINTEGER();

					}
					break;
				case 66:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:474: ID
					{
						mID();

					}
					break;
				case 67:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:477: QUOTED_ID
					{
						mQUOTED_ID();

					}
					break;
				case 68:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:487: STRING
					{
						mSTRING();

					}
					break;
				case 69:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:494: RANET_EXPRESSION
					{
						mRANET_EXPRESSION();

					}
					break;
				case 70:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:511: WS
					{
						mWS();

					}
					break;
				case 71:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:514: LINE_COMMENT
					{
						mLINE_COMMENT();

					}
					break;
				case 72:
					// D:\\tfs\\Ranet.UILibrary.OLAP4\\trunk\\UILibrary.Olap\\Ranet.Olap.Mdx\\Compiler\\Parser\\mdx.g:1:527: COMMENT
					{
						mCOMMENT();

					}
					break;

			}

		}


		protected DFA15 dfa15;
		private void InitializeCyclicDFAs()
		{
			this.dfa15 = new DFA15(this);
		}

		const string DFA15_eotS =
				"\x02\uffff\x01\x25\x05\uffff\x01\x2f\x01\x31\x01\uffff\x01\x33" +
				"\x01\x35\x05\uffff\x12\x25\x01\x52\x04\uffff\x03\x25\x0a\uffff\x01" +
				"\x25\x01\x57\x01\x58\x0b\x25\x01\x67\x03\x25\x01\x6c\x01\x6d\x07" +
				"\x25\x02\uffff\x03\x25\x01\x78\x02\uffff\x08\x25\x01\u0081\x01\u0083" +
				"\x03\x25\x01\u0087\x01\uffff\x02\x25\x01\u008a\x01\u008b\x02\uffff" +
				"\x06\x25\x01\u0093\x03\x25\x01\uffff\x01\u0099\x01\x25\x01\u009c" +
				"\x01\x25\x01\u009e\x01\x25\x01\u00a0\x01\x25\x01\uffff\x01\x25\x01" +
				"\uffff\x01\u00a3\x02\x25\x01\uffff\x02\x25\x02\uffff\x01\x25\x01" +
				"\u00a9\x02\x25\x01\u00ac\x01\u00ad\x01\x25\x01\uffff\x05\x25\x01" +
				"\uffff\x02\x25\x01\uffff\x01\x25\x01\uffff\x01\x25\x01\uffff\x01" +
				"\u00b8\x01\x25\x01\uffff\x05\x25\x01\uffff\x01\u00bf\x01\x25\x02" +
				"\uffff\x01\u00c1\x04\x25\x01\u00c6\x02\x25\x01\u00c9\x01\x25\x01" +
				"\uffff\x01\x25\x01\u00cc\x01\x25\x01\u00ce\x01\u00cf\x01\x25\x01" +
				"\uffff\x01\u00d1\x01\uffff\x04\x25\x01\uffff\x02\x25\x01\uffff\x02" +
				"\x25\x01\uffff\x01\u00da\x02\uffff\x01\x25\x01\uffff\x08\x25\x01" +
				"\uffff\x08\x25\x01\u00ed\x06\x25\x01\u00f6\x02\x25\x01\uffff\x01" +
				"\x25\x01\u00fa\x06\x25\x01\uffff\x01\u0101\x02\x25\x01\uffff\x06" +
				"\x25\x01\uffff\x01\u010a\x07\x25\x01\uffff\x12\x25\x01\u0126\x08" +
				"\x25\x01\uffff\x12\x25\x01\u0141\x01\u0142\x04\x25\x01\u0147\x01" +
				"\u0148\x02\uffff\x04\x25\x02\uffff\x06\x25\x01\u0153\x01\u0154\x01" +
				"\u0155\x01\u0156\x04\uffff";
		const string DFA15_eofS =
				"\u0157\uffff";
		const string DFA15_minS =
				"\x01\x09\x01\uffff\x01\x50\x05\uffff\x01\x25\x01\x3d\x01\uffff" +
				"\x01\x2d\x01\x2a\x05\uffff\x01\x4e\x01\x59\x01\x41\x01\x49\x01\x4c" +
				"\x01\x4f\x01\x45\x01\x53\x01\x4c\x01\x45\x01\x4f\x01\x4e\x01\x52" +
				"\x01\x48\x01\x50\x01\x41\x01\x48\x01\x4f\x01\x2e\x04\uffff\x01\x45" +
				"\x01\x44\x01\x45\x0a\uffff\x01\x44\x02\x30\x02\x4c\x01\x45\x01\x42" +
				"\x01\x4d\x01\x53\x01\x50\x01\x44\x01\x52\x01\x4f\x01\x4c\x01\x30" +
				"\x01\x4f\x01\x4d\x01\x4e\x02\x30\x01\x4f\x01\x45\x01\x4c\x01\x53" +
				"\x01\x54\x01\x45\x01\x52\x02\uffff\x02\x5f\x01\x41\x01\x30\x02\uffff" +
				"\x01\x45\x01\x43\x01\x4c\x01\x41\x03\x45\x01\x54\x02\x30\x01\x4d" +
				"\x01\x45\x01\x53\x01\x30\x01\uffff\x02\x42\x02\x30\x02\uffff\x01" +
				"\x50\x01\x4e\x02\x55\x01\x48\x01\x4e\x01\x30\x02\x45\x01\x54\x01" +
				"\uffff\x01\x30\x01\x55\x01\x30\x01\x54\x01\x30\x01\x4e\x01\x30\x01" +
				"\x59\x01\uffff\x01\x41\x01\uffff\x01\x30\x01\x43\x01\x49\x01\uffff" +
				"\x01\x41\x01\x45\x02\uffff\x01\x45\x01\x30\x01\x45\x01\x41\x02\x30" +
				"\x01\x45\x01\uffff\x01\x51\x01\x45\x01\x51\x02\x45\x01\uffff\x01" +
				"\x4c\x01\x4f\x01\uffff\x01\x45\x01\uffff\x01\x53\x01\uffff\x01\x30" +
				"\x01\x54\x01\uffff\x01\x54\x01\x4f\x01\x4c\x02\x52\x01\uffff\x01" +
				"\x30\x01\x4c\x02\uffff\x01\x30\x02\x55\x02\x49\x01\x30\x01\x41\x01" +
				"\x52\x01\x30\x01\x49\x01\uffff\x01\x54\x01\x30\x01\x4e\x02\x30\x01" +
				"\x54\x01\uffff\x01\x30\x01\uffff\x02\x41\x02\x47\x01\uffff\x01\x54" +
				"\x01\x44\x01\uffff\x01\x4f\x01\x45\x01\uffff\x01\x30\x02\uffff\x01" +
				"\x49\x01\uffff\x02\x4c\x02\x48\x01\x45\x01\x49\x01\x4e\x01\x44\x01" +
				"\uffff\x01\x45\x02\x5f\x02\x54\x01\x44\x01\x4f\x01\x4e\x01\x30\x01" +
				"\x5f\x01\x53\x02\x41\x02\x45\x01\x30\x01\x4e\x01\x41\x01\uffff\x01" +
				"\x56\x01\x30\x01\x4c\x01\x4e\x01\x4c\x01\x4e\x02\x44\x01\uffff\x01" +
				"\x30\x01\x4c\x01\x41\x01\uffff\x02\x4c\x02\x43\x02\x5f\x01\uffff" +
				"\x01\x30\x01\x4c\x02\x4f\x02\x52\x02\x41\x01\uffff\x01\x55\x02\x43" +
				"\x02\x45\x01\x4c\x01\x4e\x01\x4c\x01\x4e\x01\x45\x02\x41\x02\x4d" +
				"\x02\x4c\x02\x43\x01\x30\x02\x54\x02\x45\x02\x4f\x02\x52\x01\uffff" +
				"\x02\x49\x02\x4e\x02\x43\x02\x45\x02\x4f\x02\x54\x02\x41\x02\x4d" +
				"\x02\x4e\x02\x30\x02\x54\x02\x45\x02\x30\x02\uffff\x02\x49\x02\x4e" +
				"\x02\uffff\x02\x4f\x02\x54\x02\x4e\x04\x30\x04\uffff";
		const string DFA15_maxS =
				"\x01\u0451\x01\uffff\x01\x73\x05\uffff\x01\x3e\x01\x3d\x01\uffff" +
				"\x01\x2d\x01\x2f\x05\uffff\x01\x73\x01\x79\x01\x75\x01\x69\x01\x6e" +
				"\x01\x72\x01\x65\x01\x73\x01\x6c\x01\x65\x01\x6f\x02\x72\x01\x68" +
				"\x01\x73\x02\x69\x01\x6f\x01\x39\x04\uffff\x01\x65\x01\x64\x01\x65" +
				"\x0a\uffff\x01\x64\x02\u0451\x01\x73\x01\x6c\x01\x65\x01\x62\x01" +
				"\x6d\x01\x73\x01\x70\x01\x64\x01\x72\x01\x6f\x01\x74\x01\u0451\x01" +
				"\x6f\x01\x6d\x01\x74\x02\u0451\x01\x6f\x01\x65\x01\x6c\x01\x73\x01" +
				"\x74\x01\x65\x01\x72\x02\uffff\x02\x5f\x01\x61\x01\u0451\x02\uffff" +
				"\x01\x65\x01\x63\x01\x6c\x01\x61\x03\x65\x01\x74\x02\u0451\x01\x6d" +
				"\x01\x65\x01\x73\x01\u0451\x01\uffff\x02\x62\x02\u0451\x02\uffff" +
				"\x01\x70\x01\x6e\x02\x75\x01\x68\x01\x72\x01\u0451\x02\x77\x01\x74" +
				"\x01\uffff\x01\u0451\x01\x75\x01\u0451\x01\x74\x01\u0451\x01\x6e" +
				"\x01\u0451\x01\x79\x01\uffff\x01\x61\x01\uffff\x01\u0451\x01\x63" +
				"\x01\x69\x01\uffff\x01\x61\x01\x65\x02\uffff\x01\x65\x01\u0451\x01" +
				"\x65\x01\x61\x02\u0451\x01\x65\x01\uffff\x01\x71\x01\x65\x01\x71" +
				"\x02\x65\x01\uffff\x01\x6c\x01\x6f\x01\uffff\x01\x65\x01\uffff\x01" +
				"\x73\x01\uffff\x01\u0451\x01\x74\x01\uffff\x01\x74\x01\x6f\x01\x6c" +
				"\x02\x72\x01\uffff\x01\u0451\x01\x6c\x02\uffff\x01\u0451\x02\x75" +
				"\x02\x69\x01\u0451\x01\x61\x01\x72\x01\u0451\x01\x69\x01\uffff\x01" +
				"\x74\x01\u0451\x01\x6e\x02\u0451\x01\x74\x01\uffff\x01\u0451\x01" +
				"\uffff\x02\x61\x02\x67\x01\uffff\x01\x74\x01\x64\x01\uffff\x01\x6f" +
				"\x01\x65\x01\uffff\x01\u0451\x02\uffff\x01\x69\x01\uffff\x02\x6c" +
				"\x02\x68\x02\x69\x01\x6e\x01\x64\x01\uffff\x01\x65\x02\x5f\x02\x74" +
				"\x01\x64\x01\x6f\x01\x6e\x01\u0451\x01\x5f\x01\x73\x02\x69\x02\x65" +
				"\x01\u0451\x01\x6e\x01\x61\x01\uffff\x01\x76\x01\u0451\x01\x6c\x01" +
				"\x6e\x01\x6c\x01\x6e\x02\x64\x01\uffff\x01\u0451\x01\x6c\x01\x61" +
				"\x01\uffff\x02\x6c\x02\x63\x02\x5f\x01\uffff\x01\u0451\x01\x6c\x02" +
				"\x6f\x02\x72\x02\x69\x01\uffff\x01\x75\x02\x63\x02\x65\x01\x6c\x01" +
				"\x6e\x01\x6c\x01\x6e\x01\x65\x02\x61\x02\x6d\x02\x6c\x02\x63\x01" +
				"\u0451\x02\x74\x02\x65\x02\x6f\x02\x72\x01\uffff\x02\x69\x02\x6e" +
				"\x02\x63\x02\x65\x02\x6f\x02\x74\x02\x61\x02\x6d\x02\x6e\x02\u0451" +
				"\x02\x74\x02\x65\x02\u0451\x02\uffff\x02\x69\x02\x6e\x02\uffff\x02" +
				"\x6f\x02\x74\x02\x6e\x04\u0451\x04\uffff";
		const string DFA15_acceptS =
				"\x01\uffff\x01\x01\x01\uffff\x01\x06\x01\x07\x01\x08\x01\x09\x01" +
				"\x0a\x02\uffff\x01\x10\x02\uffff\x01\x13\x01\x14\x01\x15\x01\x16" +
				"\x01\x17\x13\uffff\x01\x42\x01\x43\x01\x44\x01\x46\x03\uffff\x01" +
				"\x0b\x01\x0e\x01\x45\x01\x0c\x01\x0f\x01\x0d\x01\x47\x01\x11\x01" +
				"\x48\x01\x12\x1b\uffff\x01\x40\x01\x41\x04\uffff\x01\x19\x01\x1a" +
				"\x0e\uffff\x01\x2a\x04\uffff\x01\x2f\x01\x30\x0a\uffff\x01\x18\x08" +
				"\uffff\x01\x25\x01\uffff\x01\x27\x03\uffff\x01\x33\x02\uffff\x01" +
				"\x2d\x01\x2e\x07\uffff\x01\x3f\x05\uffff\x01\x1b\x02\uffff\x01\x1e" +
				"\x01\uffff\x01\x21\x01\uffff\x01\x23\x02\uffff\x01\x28\x05\uffff" +
				"\x01\x34\x02\uffff\x01\x3c\x01\x3d\x0a\uffff\x01\x24\x06\uffff\x01" +
				"\x36\x01\uffff\x01\x3e\x04\uffff\x01\x35\x02\uffff\x01\x20\x02\uffff" +
				"\x01\x29\x01\uffff\x01\x2b\x01\x2c\x01\uffff\x01\x3b\x08\uffff\x01" +
				"\x32\x12\uffff\x01\x22\x08\uffff\x01\x1c\x03\uffff\x01\x31\x06\uffff" +
				"\x01\x1d\x08\uffff\x01\x1f\x1b\uffff\x01\x26\x1a\uffff\x01\x03\x01" +
				"\x38\x04\uffff\x01\x02\x01\x37\x0a\uffff\x01\x05\x01\x3a\x01\x04" +
				"\x01\x39";
		const string DFA15_specialS =
				"\u0157\uffff}>";
		static readonly string[] DFA15_transitionS = {
            "\x02\x28\x01\uffff\x02\x28\x12\uffff\x01\x28\x01\uffff\x01"+
            "\x27\x01\uffff\x01\x25\x01\uffff\x01\x0f\x01\x27\x01\x06\x01"+
            "\x07\x01\x04\x01\x0a\x01\x03\x01\x0b\x01\x05\x01\x0c\x0a\x24"+
            "\x01\x0e\x01\uffff\x01\x08\x01\x01\x01\x09\x02\uffff\x01\x12"+
            "\x01\x13\x01\x14\x01\x15\x01\x16\x01\x17\x01\x1a\x01\x25\x01"+
            "\x19\x03\x25\x01\x1b\x01\x1c\x01\x1d\x01\x1e\x02\x25\x01\x18"+
            "\x01\x1f\x01\x02\x01\x21\x01\x22\x01\x23\x02\x25\x01\x26\x02"+
            "\uffff\x01\x0d\x01\x25\x01\uffff\x01\x12\x01\x13\x01\x14\x01"+
            "\x15\x01\x16\x01\x17\x01\x1a\x01\x25\x01\x19\x03\x25\x01\x1b"+
            "\x01\x1c\x01\x1d\x01\x1e\x02\x25\x01\x18\x01\x1f\x01\x20\x01"+
            "\x21\x01\x22\x01\x23\x02\x25\x01\x10\x01\uffff\x01\x11\x22\uffff"+
            "\x01\x28\u036f\uffff\x42\x25",
            "",
            "\x01\x2a\x02\uffff\x01\x29\x1c\uffff\x01\x2a\x02\uffff\x01"+
            "\x2b",
            "",
            "",
            "",
            "",
            "",
            "\x01\x2e\x17\uffff\x01\x2d\x01\x2c",
            "\x01\x30",
            "",
            "\x01\x32",
            "\x01\x34\x04\uffff\x01\x32",
            "",
            "",
            "",
            "",
            "",
            "\x01\x36\x04\uffff\x01\x37\x1a\uffff\x01\x36\x04\uffff\x01"+
            "\x37",
            "\x01\x38\x1f\uffff\x01\x38",
            "\x01\x39\x03\uffff\x01\x3a\x0c\uffff\x01\x3b\x02\uffff\x01"+
            "\x3c\x0b\uffff\x01\x39\x03\uffff\x01\x3a\x0c\uffff\x01\x3b\x02"+
            "\uffff\x01\x3c",
            "\x01\x3d\x1f\uffff\x01\x3d",
            "\x01\x3e\x01\x3f\x01\x40\x1d\uffff\x01\x3e\x01\x3f\x01\x40",
            "\x01\x41\x02\uffff\x01\x42\x1c\uffff\x01\x41\x02\uffff\x01"+
            "\x42",
            "\x01\x43\x1f\uffff\x01\x43",
            "\x01\x44\x1f\uffff\x01\x44",
            "\x01\x45\x1f\uffff\x01\x45",
            "\x01\x46\x1f\uffff\x01\x46",
            "\x01\x47\x1f\uffff\x01\x47",
            "\x01\x48\x03\uffff\x01\x49\x1b\uffff\x01\x48\x03\uffff\x01"+
            "\x49",
            "\x01\x4a\x1f\uffff\x01\x4a",
            "\x01\x4b\x1f\uffff\x01\x4b",
            "\x01\x2a\x02\uffff\x01\x2b\x1c\uffff\x01\x2a\x02\uffff\x01"+
            "\x2b",
            "\x01\x4c\x07\uffff\x01\x4d\x17\uffff\x01\x4c\x07\uffff\x01"+
            "\x4d",
            "\x01\x4f\x01\x4e\x1e\uffff\x01\x4f\x01\x4e",
            "\x01\x50\x1f\uffff\x01\x50",
            "\x01\x51\x01\uffff\x0a\x24",
            "",
            "",
            "",
            "",
            "\x01\x53\x1f\uffff\x01\x54",
            "\x01\x55\x1f\uffff\x01\x55",
            "\x01\x54\x1f\uffff\x01\x54",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x56\x1f\uffff\x01\x56",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\x5a\x06\uffff\x01\x59\x18\uffff\x01\x5a\x06\uffff\x01"+
            "\x59",
            "\x01\x5b\x1f\uffff\x01\x5b",
            "\x01\x5c\x1f\uffff\x01\x5c",
            "\x01\x5d\x1f\uffff\x01\x5d",
            "\x01\x5e\x1f\uffff\x01\x5e",
            "\x01\x5f\x1f\uffff\x01\x5f",
            "\x01\x60\x1f\uffff\x01\x60",
            "\x01\x61\x1f\uffff\x01\x61",
            "\x01\x62\x1f\uffff\x01\x62",
            "\x01\x63\x1f\uffff\x01\x63",
            "\x01\x64\x06\uffff\x01\x65\x01\x66\x17\uffff\x01\x64\x06\uffff"+
            "\x01\x65\x01\x66",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\x68\x1f\uffff\x01\x68",
            "\x01\x69\x1f\uffff\x01\x69",
            "\x01\x6a\x05\uffff\x01\x6b\x19\uffff\x01\x6a\x05\uffff\x01"+
            "\x6b",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\x6e\x1f\uffff\x01\x6e",
            "\x01\x6f\x1f\uffff\x01\x6f",
            "\x01\x70\x1f\uffff\x01\x70",
            "\x01\x71\x1f\uffff\x01\x71",
            "\x01\x72\x1f\uffff\x01\x72",
            "\x01\x73\x1f\uffff\x01\x73",
            "\x01\x74\x1f\uffff\x01\x74",
            "",
            "",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77\x1f\uffff\x01\x77",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "",
            "",
            "\x01\x79\x1f\uffff\x01\x79",
            "\x01\x7a\x1f\uffff\x01\x7a",
            "\x01\x7b\x1f\uffff\x01\x7b",
            "\x01\x7c\x1f\uffff\x01\x7c",
            "\x01\x7d\x1f\uffff\x01\x7d",
            "\x01\x7e\x1f\uffff\x01\x7e",
            "\x01\x7f\x1f\uffff\x01\x7f",
            "\x01\u0080\x1f\uffff\x01\u0080",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x0c\x25\x01\u0082\x0d\x25\x04\uffff\x01"+
            "\x25\x01\uffff\x0c\x25\x01\u0082\x0d\x25\u0395\uffff\x42\x25",
            "\x01\u0084\x1f\uffff\x01\u0084",
            "\x01\u0085\x1f\uffff\x01\u0085",
            "\x01\u0086\x1f\uffff\x01\u0086",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "",
            "\x01\u0088\x1f\uffff\x01\u0088",
            "\x01\u0089\x1f\uffff\x01\u0089",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "",
            "",
            "\x01\u008c\x1f\uffff\x01\u008c",
            "\x01\u008d\x1f\uffff\x01\u008d",
            "\x01\u008e\x1f\uffff\x01\u008e",
            "\x01\u008f\x1f\uffff\x01\u008f",
            "\x01\u0090\x1f\uffff\x01\u0090",
            "\x01\u0091\x03\uffff\x01\u0092\x1b\uffff\x01\u0091\x03\uffff"+
            "\x01\u0092",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u0094\x11\uffff\x01\u0095\x0d\uffff\x01\u0096\x11\uffff"+
            "\x01\u0097",
            "\x01\u0096\x11\uffff\x01\u0097\x0d\uffff\x01\u0096\x11\uffff"+
            "\x01\u0097",
            "\x01\u0098\x1f\uffff\x01\u0098",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u009a\x1f\uffff\x01\u009a",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\u009b\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u009d\x1f\uffff\x01\u009d",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u009f\x1f\uffff\x01\u009f",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00a1\x1f\uffff\x01\u00a1",
            "",
            "\x01\u00a2\x1f\uffff\x01\u00a2",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00a4\x1f\uffff\x01\u00a4",
            "\x01\u00a5\x1f\uffff\x01\u00a5",
            "",
            "\x01\u00a6\x1f\uffff\x01\u00a6",
            "\x01\u00a7\x1f\uffff\x01\u00a7",
            "",
            "",
            "\x01\u00a8\x1f\uffff\x01\u00a8",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00aa\x1f\uffff\x01\u00aa",
            "\x01\u00ab\x1f\uffff\x01\u00ab",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00ae\x1f\uffff\x01\u00ae",
            "",
            "\x01\u00af\x1f\uffff\x01\u00b0",
            "\x01\u00b1\x1f\uffff\x01\u00b2",
            "\x01\u00b0\x1f\uffff\x01\u00b0",
            "\x01\u00b2\x1f\uffff\x01\u00b2",
            "\x01\u00b3\x1f\uffff\x01\u00b3",
            "",
            "\x01\u00b4\x1f\uffff\x01\u00b4",
            "\x01\u00b5\x1f\uffff\x01\u00b5",
            "",
            "\x01\u00b6\x1f\uffff\x01\u00b6",
            "",
            "\x01\u00b7\x1f\uffff\x01\u00b7",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00b9\x1f\uffff\x01\u00b9",
            "",
            "\x01\u00ba\x1f\uffff\x01\u00ba",
            "\x01\u00bb\x1f\uffff\x01\u00bb",
            "\x01\u00bc\x1f\uffff\x01\u00bc",
            "\x01\u00bd\x1f\uffff\x01\u00bd",
            "\x01\u00be\x1f\uffff\x01\u00be",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00c0\x1f\uffff\x01\u00c0",
            "",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00c2\x1f\uffff\x01\u00c3",
            "\x01\u00c3\x1f\uffff\x01\u00c3",
            "\x01\u00c4\x1f\uffff\x01\u00c5",
            "\x01\u00c5\x1f\uffff\x01\u00c5",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00c7\x1f\uffff\x01\u00c7",
            "\x01\u00c8\x1f\uffff\x01\u00c8",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00ca\x1f\uffff\x01\u00ca",
            "",
            "\x01\u00cb\x1f\uffff\x01\u00cb",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00cd\x1f\uffff\x01\u00cd",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00d0\x1f\uffff\x01\u00d0",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "",
            "\x01\u00d2\x1f\uffff\x01\u00d3",
            "\x01\u00d3\x1f\uffff\x01\u00d3",
            "\x01\u00d4\x1f\uffff\x01\u00d5",
            "\x01\u00d5\x1f\uffff\x01\u00d5",
            "",
            "\x01\u00d6\x1f\uffff\x01\u00d6",
            "\x01\u00d7\x1f\uffff\x01\u00d7",
            "",
            "\x01\u00d8\x1f\uffff\x01\u00d8",
            "\x01\u00d9\x1f\uffff\x01\u00d9",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "",
            "",
            "\x01\u00db\x1f\uffff\x01\u00db",
            "",
            "\x01\u00dc\x1f\uffff\x01\u00dd",
            "\x01\u00dd\x1f\uffff\x01\u00dd",
            "\x01\u00de\x1f\uffff\x01\u00df",
            "\x01\u00df\x1f\uffff\x01\u00df",
            "\x01\u00e0\x03\uffff\x01\u00e1\x1b\uffff\x01\u00e0\x03\uffff"+
            "\x01\u00e1",
            "\x01\u00e2\x1f\uffff\x01\u00e2",
            "\x01\u00e3\x1f\uffff\x01\u00e3",
            "\x01\u00e4\x1f\uffff\x01\u00e4",
            "",
            "\x01\u00e5\x1f\uffff\x01\u00e5",
            "\x01\u00e6",
            "\x01\u00e7",
            "\x01\u00e8\x1f\uffff\x01\u00e9",
            "\x01\u00e9\x1f\uffff\x01\u00e9",
            "\x01\u00ea\x1f\uffff\x01\u00ea",
            "\x01\u00eb\x1f\uffff\x01\u00eb",
            "\x01\u00ec\x1f\uffff\x01\u00ec",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00ee",
            "\x01\u00ef\x1f\uffff\x01\u00ef",
            "\x01\u00f0\x07\uffff\x01\u00f1\x17\uffff\x01\u00f2\x07\uffff"+
            "\x01\u00f3",
            "\x01\u00f2\x07\uffff\x01\u00f3\x17\uffff\x01\u00f2\x07\uffff"+
            "\x01\u00f3",
            "\x01\u00f4\x1f\uffff\x01\u00f5",
            "\x01\u00f5\x1f\uffff\x01\u00f5",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00f7\x1f\uffff\x01\u00f7",
            "\x01\u00f8\x1f\uffff\x01\u00f8",
            "",
            "\x01\u00f9\x1f\uffff\x01\u00f9",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u00fb\x1f\uffff\x01\u00fc",
            "\x01\u00fd\x1f\uffff\x01\u00fe",
            "\x01\u00fc\x1f\uffff\x01\u00fc",
            "\x01\u00fe\x1f\uffff\x01\u00fe",
            "\x01\u00ff\x1f\uffff\x01\u0100",
            "\x01\u0100\x1f\uffff\x01\u0100",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u0102\x1f\uffff\x01\u0102",
            "\x01\u0103\x1f\uffff\x01\u0103",
            "",
            "\x01\u0104\x1f\uffff\x01\u0105",
            "\x01\u0105\x1f\uffff\x01\u0105",
            "\x01\u0106\x1f\uffff\x01\u0107",
            "\x01\u0107\x1f\uffff\x01\u0107",
            "\x01\u0108",
            "\x01\u0109",
            "",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u010b\x1f\uffff\x01\u010b",
            "\x01\u010c\x1f\uffff\x01\u010d",
            "\x01\u010d\x1f\uffff\x01\u010d",
            "\x01\u010e\x1f\uffff\x01\u010f",
            "\x01\u010f\x1f\uffff\x01\u010f",
            "\x01\u0110\x07\uffff\x01\u0111\x17\uffff\x01\u0112\x07\uffff"+
            "\x01\u0113",
            "\x01\u0112\x07\uffff\x01\u0113\x17\uffff\x01\u0112\x07\uffff"+
            "\x01\u0113",
            "",
            "\x01\u0114\x1f\uffff\x01\u0114",
            "\x01\u0115\x1f\uffff\x01\u0116",
            "\x01\u0116\x1f\uffff\x01\u0116",
            "\x01\u0117\x1f\uffff\x01\u0118",
            "\x01\u0118\x1f\uffff\x01\u0118",
            "\x01\u0119\x1f\uffff\x01\u011a",
            "\x01\u011b\x1f\uffff\x01\u011c",
            "\x01\u011a\x1f\uffff\x01\u011a",
            "\x01\u011c\x1f\uffff\x01\u011c",
            "\x01\u011d\x1f\uffff\x01\u011d",
            "\x01\u011e\x1f\uffff\x01\u011f",
            "\x01\u011f\x1f\uffff\x01\u011f",
            "\x01\u0120\x1f\uffff\x01\u0121",
            "\x01\u0121\x1f\uffff\x01\u0121",
            "\x01\u0122\x1f\uffff\x01\u0123",
            "\x01\u0123\x1f\uffff\x01\u0123",
            "\x01\u0124\x1f\uffff\x01\u0125",
            "\x01\u0125\x1f\uffff\x01\u0125",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u0127\x1f\uffff\x01\u0128",
            "\x01\u0128\x1f\uffff\x01\u0128",
            "\x01\u0129\x1f\uffff\x01\u012a",
            "\x01\u012a\x1f\uffff\x01\u012a",
            "\x01\u012b\x1f\uffff\x01\u012c",
            "\x01\u012c\x1f\uffff\x01\u012c",
            "\x01\u012d\x1f\uffff\x01\u012e",
            "\x01\u012e\x1f\uffff\x01\u012e",
            "",
            "\x01\u012f\x1f\uffff\x01\u0130",
            "\x01\u0130\x1f\uffff\x01\u0130",
            "\x01\u0131\x1f\uffff\x01\u0132",
            "\x01\u0132\x1f\uffff\x01\u0132",
            "\x01\u0133\x1f\uffff\x01\u0134",
            "\x01\u0134\x1f\uffff\x01\u0134",
            "\x01\u0135\x1f\uffff\x01\u0136",
            "\x01\u0136\x1f\uffff\x01\u0136",
            "\x01\u0137\x1f\uffff\x01\u0138",
            "\x01\u0138\x1f\uffff\x01\u0138",
            "\x01\u0139\x1f\uffff\x01\u013a",
            "\x01\u013a\x1f\uffff\x01\u013a",
            "\x01\u013b\x1f\uffff\x01\u013c",
            "\x01\u013c\x1f\uffff\x01\u013c",
            "\x01\u013d\x1f\uffff\x01\u013e",
            "\x01\u013e\x1f\uffff\x01\u013e",
            "\x01\u013f\x1f\uffff\x01\u0140",
            "\x01\u0140\x1f\uffff\x01\u0140",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x01\u0143\x1f\uffff\x01\u0144",
            "\x01\u0144\x1f\uffff\x01\u0144",
            "\x01\u0145\x1f\uffff\x01\u0146",
            "\x01\u0146\x1f\uffff\x01\u0146",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "",
            "",
            "\x01\u0149\x1f\uffff\x01\u014a",
            "\x01\u014a\x1f\uffff\x01\u014a",
            "\x01\u014b\x1f\uffff\x01\u014c",
            "\x01\u014c\x1f\uffff\x01\u014c",
            "",
            "",
            "\x01\u014d\x1f\uffff\x01\u014e",
            "\x01\u014e\x1f\uffff\x01\u014e",
            "\x01\u014f\x1f\uffff\x01\u0150",
            "\x01\u0150\x1f\uffff\x01\u0150",
            "\x01\u0151\x1f\uffff\x01\u0152",
            "\x01\u0152\x1f\uffff\x01\u0152",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "\x0a\x25\x07\uffff\x1a\x25\x04\uffff\x01\x25\x01\uffff\x1a"+
            "\x25\u0395\uffff\x42\x25",
            "",
            "",
            "",
            ""
    };

		static readonly short[] DFA15_eot = DFA.UnpackEncodedString(DFA15_eotS);
		static readonly short[] DFA15_eof = DFA.UnpackEncodedString(DFA15_eofS);
		static readonly char[] DFA15_min = DFA.UnpackEncodedStringToUnsignedChars(DFA15_minS);
		static readonly char[] DFA15_max = DFA.UnpackEncodedStringToUnsignedChars(DFA15_maxS);
		static readonly short[] DFA15_accept = DFA.UnpackEncodedString(DFA15_acceptS);
		static readonly short[] DFA15_special = DFA.UnpackEncodedString(DFA15_specialS);
		static readonly short[][] DFA15_transition = DFA.UnpackEncodedStringArray(DFA15_transitionS);

		protected class DFA15 : DFA
		{
			public DFA15(BaseRecognizer recognizer)
			{
				this.recognizer = recognizer;
				this.decisionNumber = 15;
				this.eot = DFA15_eot;
				this.eof = DFA15_eof;
				this.min = DFA15_min;
				this.max = DFA15_max;
				this.accept = DFA15_accept;
				this.special = DFA15_special;
				this.transition = DFA15_transition;

			}

			override public string Description
			{
				get { return "1:1: Tokens : ( T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | AND | AS | BY | CASE | CALCULATED | CALCULATION | CELL | CELL_ORDINAL | CREATE | CUBE | DIMENSION | ELSE | EMPTY | END | FORMATTED_VALUE | FOR | FROM | SELECT | IS | GLOBAL | MEMBER | NON | NOT | ON | OR | PROPERTIES | SESSION | SET | THEN | UPDATE | VALUE | USE_EQUAL_ALLOCATION | USE_EQUAL_INCREMENT | USE_WEIGHTED_ALLOCATION | USE_WEIGHTED_INCREMENT | VISUAL | WITH | WHEN | WHERE | XOR | FLOAT | INTEGER | ID | QUOTED_ID | STRING | RANET_EXPRESSION | WS | LINE_COMMENT | COMMENT );"; }
			}

		}



	}
}