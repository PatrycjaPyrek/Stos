﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stos
{
    public class StosEmptyException : Exception
    {
        public StosEmptyException() { }

        public StosEmptyException(string message) : base(message)
        { }

        public StosEmptyException(string message, Exception inner) : base(message, inner)
        { }
    }
}