﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XadrezConsole.Tabuleiro.Exceptions
{
    internal class TabuleiroException : Exception
    {

        public TabuleiroException(string msg) :base(msg) { }
    }
}
