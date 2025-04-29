using Microsoft.EntityFrameworkCore;
using Settings.Core.Interfaces;

namespace Settings.Core.Models.Context
{
    public class SettingsContext : DbContext
    {
        public DbSet<ISettingGroup> SettingGroups { get; set; }
        public DbSet<ISetting> Settings { get; set; }
        public DbSet<ISettingValue> SettingValues { get; set; }
    }
}
