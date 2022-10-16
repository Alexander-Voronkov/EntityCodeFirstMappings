using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using static CodeFirstMappings.Form1;

namespace CodeFirstMappings
{
    internal class ParticipantMap:EntityTypeConfiguration<Participant>
    {
        public ParticipantMap()
        {
            HasKey(p=>p.Id);
            Property(p=>p.Id).IsRequired().HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name).IsRequired().HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(100);
            Property(p => p.Birth).IsRequired().HasColumnName("Birth").HasColumnType("date");
            Property(p => p.Country).IsRequired().HasColumnName("Country").HasColumnType("nvarchar").HasMaxLength(100);
            Property(p => p.Weight).IsRequired().HasColumnName("Weight").HasColumnType("float");
            Property(p => p.Height).IsRequired().HasColumnName("Height").HasColumnType("float");
            ToTable("Participants", "dbo");
        }
    }

    internal class CompetitionMap : EntityTypeConfiguration<Competition>
    {
        public CompetitionMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).IsRequired().HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p=>p.CompetitionName).IsRequired().HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(100);
            Property(p => p.Date).IsRequired().HasColumnName("Date").HasColumnType("date");
            Property(p => p.City).IsRequired().HasColumnName("City").HasColumnType("nvarchar").HasMaxLength(100);
            ToTable("Competitions", "dbo");

        }
    }

    internal class ResultMap : EntityTypeConfiguration<Result>
    {
        public ResultMap()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).IsRequired().HasColumnName("Id").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Place).IsRequired().HasColumnName("Place").HasColumnType("int");
            
            ToTable("Results", "dbo");

        }
    }
}
