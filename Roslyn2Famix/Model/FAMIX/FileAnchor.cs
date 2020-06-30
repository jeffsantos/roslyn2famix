using Dynamix;
using Fame;
using FAMIX;
using FILE;
using System;
using System.Collections.Generic;

namespace FAMIX
{
    [FamePackage("FAMIX")]
    [FameDescription("FileAnchor")]
    public class FileAnchor : FAMIX.AbstractFileAnchor
    {
        [FameProperty(Name = "endColumn")]
        public int endColumn { get; set; }

        [FameProperty(Name = "endLine")]
        public int endLine { get; set; }

        [FameProperty(Name = "startColumn")]
        public int startColumn { get; set; }

        [FameProperty(Name = "startLine")]
        public int startLine { get; set; }

    }
}
