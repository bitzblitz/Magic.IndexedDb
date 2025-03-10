﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.IndexedDb.Models
{
    internal class MagicJsPackage
    {
        public string MethodName { get; set; }
        public string?[]? Parameters { get; set; }
        public bool IsVoid { get; set; } = false;

        public bool IsDebug { get; set; } = false;
    }
}
