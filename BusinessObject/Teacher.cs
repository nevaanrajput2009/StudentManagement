namespace BusinessObject
{
    public class Teacher
    {
        public int TeachedId { get; set; }

        public string TeacherName { get; set; } = null!;

        public List<TeacherAddress> TeacherAddress { get; set; }

    }
}
