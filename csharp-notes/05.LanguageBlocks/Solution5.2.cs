class Solution5_2 {
    public static void Login(string username, string password) {
        if(password == "test") {
            System.Console.WriteLine($"{username} ALLOWED");
        } else {
            System.Console.WriteLine($"{username} DENIED");
        }
    }

    public static string GeneratePassword() {
        string[] passes = { "test", "guest" };

        int seed = (int)(System.Diagnostics.Stopwatch.GetTimestamp() % 1000);
        return passes[new System.Random(seed).Next(passes.Length)];
    }

    public static string GetUsername(int id = 0) {
        return (new string[] { "guest", "staff", "admin" })[id];
    }

    public static void Solution() {
		Login(GetUsername(), GeneratePassword());
		Login(GetUsername(1), GeneratePassword());
		Login(GetUsername(2), GeneratePassword());

        Login(password: GeneratePassword(), username: GetUsername());
    }
}