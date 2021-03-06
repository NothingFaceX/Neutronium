﻿using System;
using Xilium.CefGlue;

namespace Neutronium.WebBrowserEngine.CefGlue.WindowImplementation
{
    public class ConsoleMessageEventArgs : EventArgs
    {
        public CefBrowser CefBrowser { get; private set; }
        public string Message { get; private set; }
        public string Source { get; private set; }
        public int Line { get; private set; }

        public ConsoleMessageEventArgs(CefBrowser browser, string message, string source, int line)
        {
            this.CefBrowser = browser;
            this.Message = message;
            this.Source = source;
            this.Line = line;
        }
    }
}
