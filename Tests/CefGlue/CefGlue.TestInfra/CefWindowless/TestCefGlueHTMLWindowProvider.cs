﻿using Neutronium.Core.JavascriptEngine.Control;
using Neutronium.Core.JavascriptEngine.Window;
using Tests.Infra.HTMLEngineTesterHelper.Windowless;
using Xilium.CefGlue;

namespace CefGlue.TestInfra.CefWindowless
{
    public class TestCefGlueHTMLWindowProvider : IHTMLWindowProvider
    {
        private readonly TestCefClient _TestCefClient;
        public IHTMLWindow HTMLWindow { get; }
        public IDispatcher UIDispatcher => new TestIUIDispatcher();

        public TestCefGlueHTMLWindowProvider(CefFrame iFrame, TestCefClient cefClient)
        {
            _TestCefClient = cefClient;
            HTMLWindow = new TestCefGlueWindow(iFrame, cefClient);
        }

        public void Show()
        {
        }

        public void Hide()
        {
        }

        public bool OnDebugToolsRequest() 
        {
            return false;
        }

        public void CloseDebugTools() 
        {
        }

        public void Dispose()
        {
        }
    }
}
