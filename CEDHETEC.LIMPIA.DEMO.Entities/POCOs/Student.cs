using System.Reflection.Metadata.Ecma335;

namespace CEDHETEC.LIMPIA.DEMO.Entities.POCOs
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
