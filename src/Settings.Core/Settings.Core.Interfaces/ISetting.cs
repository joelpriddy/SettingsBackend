namespace Settings.Core.Interfaces
{
    public interface ISetting
    {
        IEnumerable<ISettingValue> SettingValues { get; set; }
        string Description { get; set; }
        bool IsActive { get; set; }
        ISettingGroup SettingGroup { get; set; }
        long SettingGroupId { get; set; }
        long SettingId { get; set; }
        string SettingKey { get; set; }
        string ValueType { get; set; }
    }
}
