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
            this.HasKey(x => x.RegisterID);
            this.Property(c => c.RegisterID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(x => x.Email)
                .HasColumnType("nvarchar")
                .IsRequired();

            this.Property(x => x.Password)
                .HasColumnType("nvarchar")
                .HasColumnName("Şifre")
                .IsRequired();

            //this.HasOptional(x => x.UserInfo)
            //    .WithRequired(x => x.UserRegister).WillCascadeOnDelete(false);


        }
    }
}
