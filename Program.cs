class Program {
    static void Main(string[] args){
        
        Console.WriteLine("Please select your day of week");
        Console.WriteLine("-------------------------------");
        Console.WriteLine(" Mon-Fri ");
        Console.WriteLine(" 8:00 - 18:00 ");
        Console.WriteLine(" ------------------------------- ");
        Console.WriteLine(" Breakfast set, Weekend set, Coffee ");
        Console.WriteLine(" 5/p before 11:00  2/p only weekend  3/p ");
       
        int Set1 = 5;
        int Set2 = 2;
        int Set3 = 3;
                
        Console.Write("Input your days of week: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Input your Times of day: ");
        int y = int.Parse(Console.ReadLine());
        

            if (x==1 && x==2 && x==3 && x==4 && x==5 && x==6 && x==7){
            while (Set1 != 0 && Set2 != 0 && Set3 != 0) {
                if(y < 8 && y > 18){
                    Console.WriteLine("Sorry we're close now");}
                if(Set1 == 0 && Set2 == 0 && Set3 == 0){
                    Console.WriteLine("Sorry not available now");}

        Console.Write("Please select your menu: ");
            string Food = (Console.ReadLine());
            
        
        if(Food == "Breakfast Set") {
                int A = Set1 - 1;
                Console.WriteLine("{0}/5",A);
            } if(y > 11)
               Console.WriteLine("Sorry your order is not available");

        if(Food == "Weekend Set"){
                int B = Set2 - 1;
            } if(x==1 && x==2 && x==3 && x==4 && x==5 )
               Console.WriteLine("Sorry your order is not available");

        if(Food == "Coffee"){
                int C = Set3 - 1;
            }else{
                Console.WriteLine("Please enter a valid menu");
            }
        if(Food == "End"){
            break;
        }
            }
            
        }
    
}
}
