namespace Core.Entites
{
    //owner class
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string profill { get; set; }

        public string Avatar { get; set; }

        public Address Address { get; set; }
    }


}
