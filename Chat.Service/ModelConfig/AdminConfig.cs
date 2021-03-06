using Chat.Service.Entities;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Service.ModelConfig
{
    class AdminConfig : EntityTypeConfiguration<AdminEntity>
    {
        /// <summary>
        /// 管理员用户关联数据库表配置
        /// </summary>
        public AdminConfig()
        {
            ToTable("tb_Admin");
            //多对多关系配置，配置会建一张关系表保存多对多关系
            HasMany(r => r.Roles).WithMany(u => u.AdminUsers).Map(m => m.ToTable("tb_AdminUserRole").MapLeftKey("AdminUserID").MapRightKey("RoleID"));
            //string 类型配置，根据配置生成的表字段是必须的，字符长度是50
            Property(u => u.UserName).IsRequired().HasMaxLength(50);
            Property(u => u.TrueName).HasMaxLength(50);
            Property(u => u.Password).HasMaxLength(100).IsRequired().IsUnicode(false);
            Property(u => u.SecondPassword).HasMaxLength(100).IsRequired().IsUnicode(false);
            Property(u => u.ThirdPassword).HasMaxLength(100).IsRequired().IsUnicode(false);
            Property(u => u.FourPassword).HasMaxLength(100).IsUnicode(false);
        }
    }
}
