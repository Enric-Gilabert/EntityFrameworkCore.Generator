using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tracker.Core.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Tracker.Core.Data.Entities.Priority" />
    /// </summary>
    public partial class PriorityMap
        : IEntityTypeConfiguration<Tracker.Core.Data.Entities.Priority>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Tracker.Core.Data.Entities.Priority" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tracker.Core.Data.Entities.Priority> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Priority", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uniqueidentifier")
                .HasDefaultValueSql("(newsequentialid())");

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.DisplayOrder)
                .IsRequired()
                .HasColumnName("DisplayOrder")
                .HasColumnType("int");

            builder.Property(t => t.IsActive)
                .IsRequired()
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .HasDefaultValueSql("((1))");

            builder.Property(t => t.Created)
                .IsRequired()
                .HasColumnName("Created")
                .HasColumnType("datetimeoffset")
                .HasDefaultValueSql("(sysutcdatetime())");

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Updated)
                .IsRequired()
                .HasColumnName("Updated")
                .HasColumnType("datetimeoffset")
                .HasDefaultValueSql("(sysutcdatetime())");

            builder.Property(t => t.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.RowVersion)
                .IsRequired()
                .IsRowVersion()
                .HasColumnName("RowVersion")
                .HasColumnType("rowversion")
                .HasMaxLength(8)
                .ValueGeneratedOnAddOrUpdate();

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Tracker.Core.Data.Entities.Priority" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Tracker.Core.Data.Entities.Priority" /></summary>
            public const string Name = "Priority";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.Name" /></summary>
            public const string Name = "Name";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.Description" /></summary>
            public const string Description = "Description";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.DisplayOrder" /></summary>
            public const string DisplayOrder = "DisplayOrder";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.IsActive" /></summary>
            public const string IsActive = "IsActive";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.Created" /></summary>
            public const string Created = "Created";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.CreatedBy" /></summary>
            public const string CreatedBy = "CreatedBy";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.Updated" /></summary>
            public const string Updated = "Updated";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.UpdatedBy" /></summary>
            public const string UpdatedBy = "UpdatedBy";
            /// <summary>Column Name constant for property <see cref="Tracker.Core.Data.Entities.Priority.RowVersion" /></summary>
            public const string RowVersion = "RowVersion";
        }
        #endregion
    }
}
