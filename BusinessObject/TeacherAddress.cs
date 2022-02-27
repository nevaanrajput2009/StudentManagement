namespace BusinessObject
{
    public class TeacherAddress
    {
        public int TeacherAddressId { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
