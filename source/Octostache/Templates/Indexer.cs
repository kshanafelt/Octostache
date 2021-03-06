﻿namespace Octostache.Templates
{
    class Indexer : SymbolExpressionStep
    {
        readonly string _index;

        public Indexer(string index)
        {
            _index = index;
        }

        public string Index
        {
            get { return _index; }
        }

        public override string ToString()
        {
            return "[" + Index + "]";
        }
    }
}