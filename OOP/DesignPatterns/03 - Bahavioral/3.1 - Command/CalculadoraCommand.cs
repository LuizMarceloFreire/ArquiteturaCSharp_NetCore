﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns._03___Bahavioral._3._1___Command
{
    internal class CalculadoraCommand : Commander
    {
        private char _operador;
        private int _valor;
        private readonly Calculadora _calculadora;

        public CalculadoraCommand(Calculadora calculadora, char operador, int valor)
        {
            _calculadora = calculadora;
            _operador = operador;
            _valor = valor;
        }

        public char Operator
        {
            set => _operador = value;
        }

        public int Operand
        {
            set => _valor = value;
        }

        public override void Executar()
        {
            _calculadora.Operacao(_operador, _valor);
        }

        public override void Desfazer()
        {
            _calculadora.Operacao(Desfazer(_operador), _valor);
        }

        public static char Desfazer(char operador)
        {
            switch (operador)
            {
                case '+':
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default: throw new ArgumentException("Operador desconhecido");
            }
        }
    }
}
