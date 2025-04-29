using Settings.Core.Interfaces;

namespace Settings.Core.Models
{
    public class Setting : ISetting
    {
        public required long SettingId { get; set; }
        public string SettingKey { get; set; } = string.Empty;
        public string ValueType { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public long SettingGroupId { get; set; }
        public virtual required ISettingGroup SettingGroup { get; set; }
        public virtual IEnumerable<ISettingValue> SettingValues { get; set; } = [];
    }
}
