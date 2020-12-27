
using System;
using System.Collections.Generic;

class MainClass
{

    static void Main()
    {
        // keep this function call here

        Console.WriteLine(Calculator("2+(3-1)*3"));
    }
    public static int Calculator(string str)
    {

        char[] tokens = str.ToCharArray();

        Stack<int> values = new Stack<int>();

        Stack<char> operators = new Stack<char>();

        int pos = 0;
        int n = tokens.Length;
        //add opening brackets

        operators.Push('(');

        while (pos <= n)
        {
            if (pos == n || tokens[pos] == ')')
            {
                processclosingbrackets(values, operators);
                pos++;

            }
            else if (tokens[pos] >= '0' && tokens[pos] <= '9')
            {
                pos = Processnumbers(tokens, pos, values);
            }
            else
            {
                processOperators(tokens[pos], values, operators);
                pos++;
            }
        }


        // code goes here  
        return values.Pop();

    }
    static void processclosingbrackets(Stack<int> vstack, Stack<char> opstack)
    {
        while (opstack.Peek() != '(')
        {
            executeoperations(vstack, opstack);
        }

        //remove opening brackets
        opstack.Pop();

    }
    static int Processnumbers(char[] exp, int pos, Stack<int> vstack)
    {
        int value = 0;
        while (pos < exp.Length && exp[pos] >= '0' && exp[pos] <= '9')
            value = 10 * value + (int)(exp[pos++] - '0');


        vstack.Push(value);

        return pos;


    }
    static void processOperators(char op, Stack<int> vstack, Stack<char> opstack)
    {
        while (opstack.Count > 0 && Evaluate(op, opstack.Peek()))
        {
            executeoperations(vstack, opstack);
        }
        opstack.Push(op);

    }
    static bool Evaluate(char op, char prevop)
    {
        bool evaluate = false;

        switch (op)
        {
            case '+':
            case '-':
                evaluate = (prevop != '(');
                break;
            case '*':
            case '/':
                evaluate = (prevop == '*' || prevop == '/');
                break;

            case ')':
                evaluate = true;
                break;

        }
        return evaluate;
    }

    static void executeoperations(Stack<int> vstack, Stack<char> opstack)
    {
        int rightoperand = vstack.Pop();
        int leftoperand = vstack.Pop();
        char op = opstack.Pop();

        int result = 0;
        switch (op)
        {
            case '+':
                result = leftoperand + rightoperand;
                break;
            case '-':
                result = leftoperand - rightoperand;
                break;
            case '*':
                result = leftoperand * rightoperand;
                break;
            case '/':
                result = leftoperand / rightoperand;
                break;
        }

        vstack.Push(result);
    }


}