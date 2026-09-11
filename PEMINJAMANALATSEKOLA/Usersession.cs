public static class UserSession
{
    public static int IdUser { get; set; }
    public static string NamaUser { get; set; }
    public static string Role { get; set; }

    public static void SetSession(int idUser, string namaUser, string role)
    {
        IdUser = idUser;
        NamaUser = namaUser;
        Role = role;
    }

    public static void ClearSession()
    {
        IdUser = 0;
        NamaUser = null;
        Role = null;
    }
}