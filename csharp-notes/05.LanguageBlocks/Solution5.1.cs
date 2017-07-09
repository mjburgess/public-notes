
class Solution5_1 {
    public static void Solution() {
        string[] people = new string[3];

        for (int i = 0; i < 3; i++) {
            System.Console.WriteLine("Name? ");
            people[i] = System.Console.ReadLine();
        }

        foreach(string name in people) {
            System.Console.WriteLine(name);
        }

        System.Console.WriteLine("Command? ");
        int command = int.Parse(System.Console.ReadLine());

        switch(command) {
            case 1:
		        foreach(string name in people) {
		            System.Console.WriteLine(name);
		        }
                break;
            case 2:
                Solution();
                break;
            default:
                System.Console.WriteLine("Not Recognized!");
                break;
        }
    }
}