namespace AcademicInfoSystem
{
    public static class UserSession
    {
        public static int UserId { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Role { get; set; }
        public static string Login { get; set; }

        public static void Clear()
        {
            UserId = 0;
            FirstName = "";
            LastName = "";
            Role = "";
            Login = "";
        }
    }
}