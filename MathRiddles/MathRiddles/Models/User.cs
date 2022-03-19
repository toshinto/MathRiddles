using SQLite;
using System;

namespace MathRiddles.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Level { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
