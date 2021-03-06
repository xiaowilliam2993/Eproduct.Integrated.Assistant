﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eproduction.Integrated.Assistant.Start.Core {

    public class ExceptionOwnerEx : Exception {

        public int LineNo { get; private set; }

        public ExceptionOwnerEx(int lineNo)
            : base("错误:无法识别的格式        行号:" + lineNo) {
            this.LineNo = lineNo;
        }

        public ExceptionOwnerEx(int lineNo, string customMessage)
            : base("错误:无法识别的格式        行号:" + lineNo + "        详细信息: " + customMessage) {
            this.LineNo = lineNo;
        }

    }
}