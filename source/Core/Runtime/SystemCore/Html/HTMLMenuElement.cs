//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLMenuElement : HTMLElement
    {
        internal HTMLMenuElement() { }

        [ScriptField]
        public string type { get; set; }

        [ScriptField]
        public string label { get; set; }
    }
}