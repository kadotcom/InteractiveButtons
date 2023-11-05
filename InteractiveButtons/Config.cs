using Exiled.API.Features;
using Exiled.API.Interfaces;
using System.ComponentModel;
using System.IO;

namespace InteractiveButtons
{
    public class Config : IConfig
    {
        [Description("Indicates if the plugin is enabled or not.")]
        public bool IsEnabled { get; set; } = true;
        [Description("Indicates if debugging mode for this plugin is enabled or not.")]
        public bool Debug { get; set; } = false;
        [Description("Indicates if the TestButton command will be enabled or not.")]
        public bool HaveTestCommand { get; set; } = true;
        [Description("Indicates if the InteractiveButtons API gets initiated/uninitiated by an external plugin or not.")]
        public bool InitApiUsingExternalPlugin { get; set; } = false;
    }
}