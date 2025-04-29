namespace Settings.Core.Interfaces
{
    public interface ISettingGroup
    {
        string Description { get; set; }
        string GroupKey { get; set; }
        bool IsActive { get; set; }
        long SettingGroupId { get; set; }
        IEnumerable<ISetting> Settings { get; set; }
    }
}
