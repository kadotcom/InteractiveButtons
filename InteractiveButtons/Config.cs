using Exiled.API.Features;
using Exiled.API.Interfaces;
using System.ComponentModel;
using System.IO;

namespace InteractiveButtons
{
    public class Config : IConfig
    {
        [Description("Indicates if the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;
        [Description("Indicates if debugging mode for this plugin is enabled.")]
        public bool Debug { get; set; } = false;
        [Description("Indicates if the testbutton command will be enabled.")]
        public bool HaveTestCommand { get; set; } = true;
    }
}