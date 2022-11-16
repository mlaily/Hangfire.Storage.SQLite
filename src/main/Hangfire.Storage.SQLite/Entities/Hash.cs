using SQLite;
using System;

namespace Hangfire.Storage.SQLite.Entities
{
    [Table(DefaultValues.HashTblName)]
    public class Hash
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(DefaultValues.MaxLengthKeyColumn)]
        [Indexed(Name = "IX_Hash_Key", Order = 1, Unique = false)]
        public string Key { get; set; }

        [MaxLength(DefaultValues.MaxLengthValueColumn)]
        [Indexed(Name = "IX_Hash_Field", Order = 2, Unique = false)]
        public string Field { get; set; }

        [MaxLength(DefaultValues.MaxLengthVarCharColumn)]
        public string Value { get; set; }

        [Indexed(Name = "IX_Hash_ExpireAt", Order = 3, Unique = false)]
        public DateTime? ExpireAt { get; set; }
    }
}
