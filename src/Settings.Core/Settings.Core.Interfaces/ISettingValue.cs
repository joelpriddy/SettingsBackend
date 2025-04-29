
namespace Settings.Core.Interfaces
{
    public interface ISettingValue
    {
        string AssignedValue { get; set; }
        DateTime CreatedDate { get; set; }
        ISetting Setting { get; set; }
        long SettingId { get; set; }
        long SettingValueId { get; set; }
        string UserKey { get; set; }
    }
}
