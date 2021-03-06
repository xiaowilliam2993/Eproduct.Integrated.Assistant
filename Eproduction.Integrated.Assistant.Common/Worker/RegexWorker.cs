﻿using System.Text.RegularExpressions;

namespace Eproduction.Integrated.Assistant.Common.Worker {
    public static class RegexWorker {
        public static bool IsHttpUrl(this string value) {
            return Regex.IsMatch(value, @"^[a-zA-Z]+://.+$");
        }
        public static bool IsIPAddress(this string value) {
            Regex regex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            return regex.IsMatch(value);
        }
    }
}
