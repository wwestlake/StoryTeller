using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.Utilities
{
    public static class ApplicationInformation
    {
        public static readonly Func<Version> Version = () =>
        {
            return Assembly.GetEntryAssembly().GetName().Version;
        };

        public static readonly Func<string> Name = () =>
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).ProductName;
        };

        public static readonly Func<string> Company = () =>
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).CompanyName;
        };

        public static readonly Func<string> Copyright = () =>
        {
            return FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).LegalCopyright;
        };


    }
}
