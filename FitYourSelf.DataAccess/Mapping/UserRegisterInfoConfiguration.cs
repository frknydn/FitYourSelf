using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class UserRegisterInfoConfiguration : EntityTypeConfiguration<UserRegisterInfo>
    {
        public UserRegisterInfoConfiguration()
        {
            HasKey(x => x.RegisterID);
            Property(c => c.RegisterID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Email)
                .HasColumnType("nvarchar")
                .IsRequired();

            Property(x => x.Password)
                .HasColumnType("nvarchar")
                .HasColumnName("Şifre")
                .IsRequired();

            HasOptional(x => x.UserInfo)
                .WithRequired(x => x.UserRegister).WillCascadeOnDelete(false);


        }
    }
}
