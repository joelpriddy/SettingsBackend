using Settings.Core.Interfaces;

namespace Settings.Core.Models
{
    public class SettingGroup : ISettingGroup
    {
        public long SettingGroupId { get; set; }
        public string GroupKey { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public virtual IEnumerable<ISetting> Settings { get; set; } = [];
    }
}
