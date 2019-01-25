using System;

namespace p1
{
    class Program
    {
       
          public static decimal calculateBalance(decimal c,decimal u){
                  decimal rembal=c-u; 
                  return rembal;
                   
            }
        static void Main(string[] args)
        {
            
            var EXIT_CHAR='q';
            var name=String.Empty;
            var unitCost=0.0m;
            var cash=0.0m;
            var instrument="";
            var isLimitReached=false;
            var rembal=0.0;
            var choice=0;
            Console.WriteLine("Hello User welcome to musical store!");
            while(name==""){
                Console.WriteLine("Enter your name:");
                name=Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}.");
            while(1==1){

            Console.WriteLine("Enter Your affordable amount:");
            var ans=Console.ReadLine();
            cash=Convert.ToDecimal(ans);
            Console.WriteLine("we have following instruments:\n1.Piano\n2.Guitar\n3.violin\n4.Drum");
           
                Console.WriteLine("Enter your choice:");
                var c=Console.ReadLine();
                choice=Convert.ToInt32(c);
            switch(choice){
                case 1: instrument= "Piano";
                        unitCost= 90.02m;
                        break;
                case 2: instrument= "Guitar";
                        unitCost= 100.2m;
                        break;
                case 3: instrument= "Violin";
                        unitCost= 120.2m;
                        break;
                case 4: instrument= "Drums";
                        unitCost= 80.0m;
                        break;
                default: Console.WriteLine("enter correct choice");
                            break;
            }
            var rem=Program.calculateBalance(cash,unitCost);
            rembal=Convert.ToDouble(rem);
             if(rembal<0){
                     isLimitReached=true;
                    }
            if(isLimitReached==true){
                Console.WriteLine($"Sorry, You have selected {instrument} and it's price is {unitCost} which exceeds your total amount.");
            }
            else{
                Console.WriteLine($"You have selected {instrument}, it's price is {unitCost} and Your remaining balance is {rembal}");
            }
            Console.WriteLine("press q to quit or press any key to continue");
            var s=Console.ReadLine();
            EXIT_CHAR=Convert.ToChar(s);
            if(EXIT_CHAR=='q'){
                Console.WriteLine("Done!!");
                break;
            }

            }
            
        }
            
            
        }
      
    }

