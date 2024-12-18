namespace LibraryOccupancy.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string LibraryName { get; set; }
        public int StudyTableCapacity { get; set; }
        public int StudyTableOccupied { get; set; }
        public int ComputerTableCapacity { get; set; }
        public int ComputerTableOccupied { get; set; }
    }
}
