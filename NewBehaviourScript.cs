using UnityEngine;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;
using System.Linq;

public class NewBehaviourScript : MonoBehaviour
{

    public static bool IsNumeric(string value)
    {
        return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
    }
    


   

//用来显示结果
public string result = "";
    //第一个操作数
    public static string str1 = "";
    //第二个操作数
    public static bool haveDot = false;

    public static bool isCaclutate = false;


    void OnGUI()
    {
        
        //对数字进行处理
        if (GUI.Button(new Rect(100, 100, 100, 60), "CE"))
        {
            result = "";
            str1 = "";
            haveDot = false;
        }
        if (GUI.Button(new Rect(210, 100, 100, 60), "×") && str1.Substring(str1.Length - 1, 1) != "-" && str1.Substring(str1.Length - 1, 1) != "+" && str1.Substring(str1.Length - 1, 1) != ".")
        {
            if (IsNumeric(str1.Substring(str1.Length - 1, 1)))
            {
                Debug.Log(str1.Substring(str1.Length - 1, 1));
                str1 += "*";
                haveDot = false;
                isCaclutate = false;
            }
            result = str1;
        }
        if (GUI.Button(new Rect(320, 100, 100, 60), "÷") && str1.Substring(str1.Length - 1, 1) != "-" && str1.Substring(str1.Length - 1, 1) != "+" && str1.Substring(str1.Length - 1, 1) != ".")
        {
            if (IsNumeric(str1.Substring(str1.Length - 1, 1)))
            {
                str1 += "/";
                haveDot = false;
                isCaclutate = false;
            }
            result = str1;
        }
        if (GUI.Button(new Rect(430, 100, 100, 60), "←"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
            } else if (result.Length != 0)
            {

                str1 = str1.Substring(0, str1.Length - 1);
                
            }
            result = str1;


        }
        if (GUI.Button(new Rect(100, 170, 100, 60), "1"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "1";
            result = str1;
        }
        if (GUI.Button(new Rect(210, 170, 100, 60), "2"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "2";
            result = str1;
        }
        if (GUI.Button(new Rect(320, 170, 100, 60), "3"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "3";
            result = str1;
        }
        if (GUI.Button(new Rect(430, 170, 100, 60), "-"))
        {
            if (IsNumeric(str1.Substring(str1.Length - 1, 1)) && str1.Substring(str1.Length - 1, 1) != "-" && str1.Substring(str1.Length - 1, 1) != "+" && str1.Substring(str1.Length - 1, 1) != ".")
            {
                str1 += "-";
                haveDot = false;
                isCaclutate = false;
            }
            result = str1;
        }
        if (GUI.Button(new Rect(100, 240, 100, 60), "4"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "4";
            result = str1;
        }
        if (GUI.Button(new Rect(210, 240, 100, 60), "5"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "5";
            result = str1;
        }
        if (GUI.Button(new Rect(320, 240, 100, 60), "6"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "6";
            result = str1;
        }
        if (GUI.Button(new Rect(430, 240, 100, 60), "+") && str1.Substring(str1.Length - 1, 1) != "+" && str1.Substring(str1.Length - 1, 1) != "-" && str1.Substring(str1.Length - 1, 1) != ".")
        {
            if (IsNumeric(str1.Substring(str1.Length - 1, 1)))
            {
                str1 += "+";
                haveDot = false;
                isCaclutate = false;
            }
            result = str1;
        }
        if (GUI.Button(new Rect(100, 310, 100, 60), "7"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "7";
            result = str1;
        }
        if (GUI.Button(new Rect(210, 310, 100, 60), "8"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "8";
            result = str1;
        }
        if (GUI.Button(new Rect(320, 310, 100, 60), "9"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "9";
            result = str1;
        }
        if (GUI.Button(new Rect(430, 310, 100, 130), "="))
        {
            
            var tmp = Evaluator.Eval(result);
            Debug.Log(tmp.ToString());
            result = tmp.ToString();
            str1 = result;
            isCaclutate = true;
            if (result.Contains("."))
            {
                haveDot = true;
            }

        }
        if (GUI.Button(new Rect(100, 380, 210, 60), "0"))
        {
            if (isCaclutate == true)
            {
                str1 = "";
                isCaclutate = false;
                haveDot = false;
            }
            str1 += "0";
            result = str1;
        }

        if (GUI.Button(new Rect(320, 380, 100, 60), "."))
        {
            if (isCaclutate == true)
            {
                str1 = "0.";
                isCaclutate = false;
            }
            if (IsNumeric(str1.Substring(str1.Length - 1, 1)) && str1.Substring(str1.Length - 1, 1) != "." && haveDot == false)
            {
                Debug.Log(str1.Substring(str1.Length - 1, 1));
                str1 += ".";
                haveDot = true;
                isCaclutate = false;
            }
            result = str1;
        }


   

        GUI.TextArea(new Rect(100, 20, 430, 60), result);

    }
    /**/
    /// <summary>
    /// 动态求值
    /// </summary>
    public class Evaluator
    {
        /**/
        /// <summary>
        /// 计算结果,如果表达式出错则抛出异常
        /// </summary>
        /// <param name="statement">表达式,如"1+2+3+4"</param>
        /// <returns>结果</returns>
        public static object Eval(string statement)
        {
            if (statement.Trim() != string.Empty)
            {
                Evaluator evaluator = new Evaluator();
                return evaluator.GetFormulaResult(statement);
            }
            else
            {
                return null;
            }
        }


        private object GetFormulaResult(string s)
        {
            if (s == "")
            {
                return null;
            }
            string S = BuildingRPN(s);

            string tmp = "";
            System.Collections.Stack sk = new System.Collections.Stack();

            char c = ' ';
            System.Text.StringBuilder Operand = new System.Text.StringBuilder();
            double x, y;
            for (int i = 0;
                i < S.Length;
                i++)
            {
                c = S[i];
                //added c==',' for germany culture
                if (char.IsDigit(c) || c == '.' || c == ',')
                {
                    //数据值收集.
                    Operand.Append(c);
                }
                else if (c == ' ' && Operand.Length > 0)
                {
                    #region 运算数转换
                    try
                    {
                        tmp = Operand.ToString();
                        if (tmp.StartsWith("-"))//负数的转换一定要小心...它不被直接支持.
                        {
                            //现在我的算法里这个分支可能永远不会被执行.
                            sk.Push(-((double)Convert.ToDouble(tmp.Substring(1, tmp.Length - 1))));
                        }
                        else
                        {
                            sk.Push(Convert.ToDouble(tmp));
                        }
                    }
                    catch
                    {
                        return null; //
                    }
                    Operand = new System.Text.StringBuilder();
                    #endregion
                }
                else if (c == '+'//运算符处理.双目运算处理.
                    || c == '-'
                    || c == '*'
                    || c == '/'
                    || c == '%'
                    || c == '^')
                {
                    #region 双目运算
                    if (sk.Count > 0)/*如果输入的表达式根本没有包含运算符.或是根本就是空串.这里的逻辑就有意义了.*/
                    {
                        y = (double)sk.Pop();
                    }
                    else
                    {
                        sk.Push(0);
                        break;
                    }
                    if (sk.Count > 0)
                        x = (double)sk.Pop();
                    else
                    {
                        sk.Push(y);
                        break;
                    }
                    switch (c)
                    {
                        case '+':
                            sk.Push(x + y);
                            break;
                        case '-':
                            sk.Push(x - y);
                            break;
                        case '*':
                            if (y == 0)
                            {
                                sk.Push(x * 1);
                            }
                            else
                            {
                                sk.Push(x * y);
                            }
                            break;
                        case '/':
                            if (y == 0)
                            {
                                sk.Push(x / 0);
                            }
                            else
                            {
                                sk.Push(x / y);
                            }
                            break;
                        case '%':
                            sk.Push(x % y);
                            break;
                        case '^'://
                            if (x > 0)//
                            {
                                //我原本还想,如果被计算的数是负数,又要开真分数次方时如何处理的问题.后来我想还是算了吧.
                                sk.Push(System.Math.Pow(x, y));
                                //
                            }
                            //
                            else//
                            {
                                //
                                double t = y;
                                //
                                string ts = "";
                                //
                                t = 1 / (2 * t);
                                //
                                ts = t.ToString();
                                //
                                if (ts.ToUpper().LastIndexOf('E') > 0)//
                                {
                                    //
                                    ;
                                    //
                                }
                                //
                            }
                            break;
                    }
                    #endregion
                }
                else if (c == '!')//单目取反. )
                {
                    sk.Push(-((double)sk.Pop()));
                }
            }
            if (sk.Count > 1)
            {
                return null;//;
            }
            if (sk.Count == 0)
            {
                return null;//;
            }
            return sk.Pop();
        }
        /**/
        /// <summary>
        /// 
        /// </summary>
        private string BuildingRPN(string s)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(s);
            System.Collections.Stack sk = new System.Collections.Stack();
            System.Text.StringBuilder re = new System.Text.StringBuilder();

            char c = ' ';
            //sb.Replace( " ","" );
            //一开始,我只去掉了空格.后来我不想不支持函数和常量能滤掉的全OUT掉.
            for (int i = 0;
                i < sb.Length;
                i++)
            {
                c = sb[i];
                //added c==',' for german culture
                if (char.IsDigit(c) || c == ',')//数字当然要了.
                    re.Append(c);
                //if( char.IsWhiteSpace( c )||
                char.IsLetter(c);//如果是空白,那么不要.现在字母也不要.
                //continue;
                switch (c)//如果是其它字符...列出的要,没有列出的不要.
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '%':
                    case '^':
                    case '!':
                    case '(':
                    case ')':
                    case '.':
                        re.Append(c);
                        break;
                    default:
                        continue;
                }
            }
            sb = new System.Text.StringBuilder(re.ToString());
            #region 对负号进行预转义处理.负号变单目运算符求反.
            for (int i = 0; i < sb.Length - 1; i++)
                if (sb[i] == '-' && (i == 0 || sb[i - 1] == '('))
                    sb[i] = '!';
            //字符转义.
            #endregion
            #region 将中缀表达式变为后缀表达式.
            re = new System.Text.StringBuilder();
            for (int i = 0;
                i < sb.Length;
                i++)
            {
                if (char.IsDigit(sb[i]) || sb[i] == '.')//如果是数值.
                {
                    re.Append(sb[i]);
                    //加入后缀式
                }
                else if (sb[i] == '+'
                    || sb[i] == '-'
                    || sb[i] == '*'
                    || sb[i] == '/'
                    || sb[i] == '%'
                    || sb[i] == '^'
                    || sb[i] == '!')//.
                {
                    #region 运算符处理
                    while (sk.Count > 0) //栈不为空时
                    {
                        c = (char)sk.Pop();
                        //将栈中的操作符弹出.
                        if (c == '(') //如果发现左括号.停.
                        {
                            sk.Push(c);
                            //将弹出的左括号压回.因为还有右括号要和它匹配.
                            break;
                            //中断.
                        }
                        else
                        {
                            if (Power(c) < Power(sb[i]))//如果优先级比上次的高,则压栈.
                            {
                                sk.Push(c);
                                break;
                            }
                            else
                            {
                                re.Append(' ');
                                re.Append(c);
                            }
                            //如果不是左括号,那么将操作符加入后缀式中.
                        }
                    }
                    sk.Push(sb[i]);
                    //把新操作符入栈.
                    re.Append(' ');
                    #endregion
                }
                else if (sb[i] == '(')//基本优先级提升
                {
                    sk.Push('(');
                    re.Append(' ');
                }
                else if (sb[i] == ')')//基本优先级下调
                {
                    while (sk.Count > 0) //栈不为空时
                    {
                        c = (char)sk.Pop();
                        //pop Operator
                        if (c != '(')
                        {
                            re.Append(' ');
                            re.Append(c);
                            //加入空格主要是为了防止不相干的数据相临产生解析错误.
                            re.Append(' ');
                        }
                        else
                            break;
                    }
                }
                else
                    re.Append(sb[i]);
            }
            while (sk.Count > 0)//这是最后一个弹栈啦.
            {
                re.Append(' ');
                re.Append(sk.Pop());
            }
            #endregion
            re.Append(' ');
            return FormatSpace(re.ToString());
            //在这里进行一次表达式格式化.这里就是后缀式了.  
        }

        /// <summary>  
        /// 优先级别测试函数.  
        /// </summary>  
        /// <param name="opr"></param>  
        /// <returns></returns>  
        private static int Power(char opr)
        {
            switch (opr)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '%':
                case '^':
                case '!':
                    return 3;
                default:
                    return 0;
            }
        }

        /// <summary>  
        /// 规范化逆波兰表达式.
        /// </summary>  
        /// <param name="s"></param>  
        /// <returns></returns>  
        private static string FormatSpace(string s)
        {
            System.Text.StringBuilder ret = new System.Text.StringBuilder();
            for (int i = 0;
                i < s.Length;
                i++)
            {
                if (!(s.Length > i + 1 && s[i] == ' ' && s[i + 1] == ' '))
                    ret.Append(s[i]);
                else
                    ret.Append(s[i]);
            }
            return ret.ToString();
            //.Replace( '!','-' );
        }
    }
}


