
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;




class Sample
{
    public static void Main()
    {
        string s = "(){}}{"; //случайная комбинация скобо "(", ")", "{", "}", "[", "]"
        int _parenthesis1 = 0;
        int _parenthesis2 = 0;
        int _brace1 = 0;
        int _brace2 = 0;
        int _squarebracket1 = 0;
        int _squarebracket2 = 0;
        int _correctbrackets = 0;
        int a = 0;
        int sLength = 0;
        sLength = s.Length;
        string[] _simvols = new string[sLength];
        char[] arr;
        int midlesLength = sLength / 2;
        arr = s.ToCharArray(a, sLength);
        if(sLength % 2 == 0)
        {
            for (int i = 0; i < sLength; i++)
            {
                switch (arr[i])
                {
                    case '(':
                        _parenthesis1++;
                    break;
                    case '{':
                        _brace1++;
                        break;
                    case '[':
                        _squarebracket1++; 
                        break;
                    case ')':
                        _parenthesis2++;
                        break;
                    case '}':
                        _brace2++;
                        break;
                    case ']':
                        _squarebracket2++;
                        break;
                }     
            }
            if(_parenthesis1==_parenthesis2 & _brace1== _brace2 & _squarebracket1== _squarebracket2)
            {
                if (_parenthesis1 > 0)
                {
                    for (int i = 0; i < sLength; i++)
                    {

                        if (arr[i] == '(')
                        {
                            int sLength2 = i + 1;
                            if (sLength2 < sLength)
                            {
                                if (arr[sLength2] == '}')
                                {
                                    _correctbrackets = -1000;
                                }
                            }
                            if (sLength2 < sLength)
                            {
                                if (arr[sLength2] == ']')
                                {
                                    _correctbrackets = -1000;
                                }
                            }
                            for (int j = 0; midlesLength > j; j++)
                            {
                                if (sLength2 < sLength)
                                {
                                    if (arr[sLength2] == ')')
                                    {
                                        _correctbrackets++;
                                        j = midlesLength;
                                    }
                                    sLength2 += 2;
                                }
                            }
                            
                        }
                    }
                }
                if (_brace1 > 0)
                {
                    for (int i = 0; i < sLength; i++)
                    {
                        if (arr[i] == '{')
                        {
                            int sLength2 = i + 1;
                            if (sLength2 < sLength)
                            {
                                if (arr[sLength2] == ')')
                                {
                                    _correctbrackets = -1000;
                                }
                            }
                            if (sLength2 < sLength)
                            {
                                if (arr[sLength2] == ']')
                                {
                                    _correctbrackets = -1000;
                                }
                            }
                            for (int j = 0; midlesLength > j; j++)
                            {
                                if (sLength2 < sLength)
                                {
                                    if (arr[sLength2] == '}')
                                    {
                                        _correctbrackets++;
                                        j = midlesLength;
                                    }
                                    sLength2 += 2;
                                }
                            }
                            
                        }
                    }
                }
                if (_squarebracket1 > 0)
                {
                    for (int i = 0; i < sLength; i++)
                    {
                        if (arr[i] == '[')
                        {
                            int sLength2 = i + 1;
                            if (sLength2 < sLength)
                            {
                                if (arr[sLength2] == ')')
                                {
                                    _correctbrackets = -1000;
                                }
                            }
                            if (sLength2 < sLength)
                            {
                                if (arr[sLength2] == '}')
                                {
                                    _correctbrackets = -1000;
                                }
                            }
                            for (int j = 0; midlesLength > j; j++)
                            {
                                if (sLength2 < sLength)
                                {
                                    if (arr[sLength2] == ']')
                                    {
                                        _correctbrackets++;
                                        j = midlesLength;
                                    }
                                    sLength2 += 2;
                                }
                            }
                            
                        }
                    }
                }
            }
            if(_correctbrackets == midlesLength)
            {
                a = 1; //если а == 1 значит true, если осталось 0 значит false
            }
        }
        
        Console.WriteLine(a);
    }
}


