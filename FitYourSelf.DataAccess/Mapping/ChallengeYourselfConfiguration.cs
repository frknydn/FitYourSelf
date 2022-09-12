using FitYorSelf.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FitYourSelf.DataAccess.Mapping
{
    public class ChallengeYourselfConfiguration:EntityTypeConfiguration<ChallengeYourSelf>
    {
        public ChallengeYourselfConfiguration()
        {
            HasKey(c => c.ChallengeYourSelfID);
            Property(c => c.ChallengeYourSelfID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(c => c.DateTime).HasColumnType("datetime2").IsRequired().HasColumnName("Meydan Okuma Başlangıcı");
            Property(c => c.ChallengeYourSelfEnum).HasColumnName("Meydan Okumalar").IsRequired();

            HasRequired(u => u.UserInfo).WithMany(s => s.ChallengeYourSelf).HasForeignKey(u => u.UserInfoID);
        }
    }
}
