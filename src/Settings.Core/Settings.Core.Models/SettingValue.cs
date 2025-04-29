using Settings.Core.Interfaces;

namespace Settings.Core.Models
{
    public class SettingValue : ISettingValue
    {
        public required long SettingValueId { get; set; }
        public required long SettingId { get; set; }
        public string AssignedValue { get; set; } = string.Empty;
        public string UserKey { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        public required virtual ISetting Setting { get; set; }
    }
}
