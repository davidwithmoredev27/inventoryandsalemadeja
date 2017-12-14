using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace INVENTORYSYSTEM.PL
{
    class Program
    {
        public static string UserName, Password,  pass = "Admin" ;
      
        // All Required Containers Goes In here
        public static string mainS;
        public static int passwordcounter;
        public static int QUANTITY;
        public static int orderQuantity;
        public static int receiptCounter;
        public static int checkfordisplay;
        public static int orderidentifier;
        public static int index;
        public static string size;
        public static double currentBalanceTotal;
        public static double receiptcurrent;
        public static double finalbalace;
        public static string globalquestion;
        public static int counter = 0;
        public static int capital = 5000;
        public static string stock;
        public static string brands;
        public static int money;
        public static double balance;
        public static string PasswordTrue;
        public static int sizeCounter;
        public static int rows;
        public static double globalquestionConvertToNum;
        public static string[,] totalsizeContainer = new string[3, 10000];
        public static double[,] confirmsizeQuantity = new double[3, 10];
        public static string[] concantenateMenuAndSize = new string[10000];
   
        public static double[,] totalbrandQuantityContainer = new double[4, 10] {
            {
                60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60
            },
  
            {
                60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60
            },
         
            {
                 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60
          
            },
            {
                 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60 , 60
          
            },
        };
        // collection of order name and price
        public static double[] orderPriceCapacity = new double[1000];
        public static string[] orderNameCapacity = new string[1000];
        
        // total order;
        public static double totalorder;
       
        // all stock in here

        public static int[] NikeStock = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };
        public static int[] LevisStock = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };
        public static int[] AdidasStock = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };

        public static int[] trivalstock = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };


        public static int[] NikeStockTwo = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };
        public static int[] LevisStockTwo = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };
        public static int[] AdidasStockTwo = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };

        public static int[] trivalstockTwo = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };


        public static int[] NikeStockThree = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };
        public static int[] LevisStockThree = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };
        public static int[] AdidasStockThree = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };

        public static int[] trivalstockThree = new int[10] {
            20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20 , 20
        };
        public static int receiptcounter;
        public static string NIKETITLESTOCK = "NiKe\t\t\t\t\t\tPRICE\t\tSMALL\tMEDIUM\tLARGE\tQUANTITY";
        public static string NIKETITLE = "NiKe\t\t\t\t\t\t\t\t\tPrice";
        public static string[] Nike = new string[11]
        {
        "1. High Quality Hoodies Fleece", "2. Sexy off the  Shoulder Shirt", "3. Dry Fit Yoga Wear, Sport wear",
        "4. Freediving Swimwear ", "5. A love letter to my Puffer Coat ", "6. Bunny Cute Clothes", 
        "7. Curvy Dress", "8. Stretchy Jeans", "9. Denim Jacket ", "10. M.Pajamas that are picture perfect" ,"11. Back"
        };

        public static double[] NikePrice = new double[10]
        {
            800.00, 600.00, 900.00, 
            1000.00, 870.00, 560.00, 
            780.00, 980.00, 470.00, 550.00
        };

        public static string LEVISTITLESTOCK = "Levis\t\t\t\t\t\tPRICE\t\tSMALL\tMEDIUM\tLARGE\tQUANTITY";
        public static string LEVISTITLE = "Levis\t\t\t\t\t\t\t\t\tPrice";
        public static string[] Levis = new string[11] 
        { 
        "1. Casual Style Denim Leader", "2. Slim Taper Fit Jeans", "3. Shortie Shorts",
        "4. Role Turtleneck ", "5. Leggings for Exercise", "6. Elevating Turtlenecks",
        "7. Tube/Bandeau Dresses","8. Blouson Dresses", "9. Tunic Dress ", "10. Pencil Dresses","11. Back"
        };

        public static double[] LevisPrice = new double[10] 
        { 
            750.00, 900.00, 560.00,
            880.00, 340.00, 990.00,
            1010.00, 890.00, 780.00, 699.00
        };


        public static string ADIDASTITLESTOCK = "Adidas\t\t\t\t\t\tPRICE\t\tSMALL\tMEDIUM\tLARGE\tQUANTITY";
        public static string ADIDASTITLE = "Adidas\t\t\t\t\t\t\t\t\tPrice";
        public static string[] Adidas = new string[11]
        { 
        "1. Ruffles Decoration Long Sleeve", "2. short sleeve calssic", "3. Winter Wardrobe",
        "4. Hot Dress for Summer ", "5. 0ff Shoulder Shirt", "6. Spaghetti Strap ",
        "7. High-Low Short", "8. Body Con Short Shorts", "9. Skater Blouse","10. Maxi Long Dresses" ,"11. Back"
        };

        public static double[] AdidasPrice = new double[10] 
        { 
            400.00, 990.00, 670.00,
            1000.00, 240.00, 430.00,
            599.00, 620.00, 670.00, 899.00
        };

        public static string TRIBALTITLESTOCK = "Tribal\t\t\t\t\t\tPRICE\t\tSMALL\tMEDIUM\tLARGE\tQUANTITY";
        public static string TRIBALTITLE = "Tribal\t\t\t\t\t\t\t\t\tPrice";
        public static string[] Tribal = new string[11] 
        { 
        "1. Chic Rompers", "2. Flattering High-Waisted Bikini", "3. Chic Beach Towels",
        "4. Fresh Summer Dress", "5. Kaftan Blouse", "6. Shirt Dresses ", 
        "7. Off Shoulder Blouse", "8. Peplum Formal Dresses", "9. Backless Shirt", "10. Fringe Details Dresses","11. Back"
        };

        public static double[] TribalPrice = new double[10] 
        {
            750.00, 899.00, 790.00,
            990.00, 450.00, 999.00,
            470.00, 777.00, 390.00, 1111.00
        };

        public static void Pass()
        {
            string Password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    Password += info.KeyChar;
                }
                info = Console.ReadKey(true);
            }

            Console.WriteLine();
            PasswordTrue = Password;
        }
        public static void maximux()
        {
            if (counter > 1000)
            {
                Console.WriteLine("you reach the maximum of 1000 orders");
                Console.WriteLine("1. Get Receipt");
                for (; ; )
                {
                    Console.Write("please choose options on the obove statement:");
                    globalquestion = Convert.ToString(Console.ReadLine());

                    if (globalquestion == "1")
                    {
                        getReceipt();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }
         public static void brand() {
            Console.Clear();
            
            maximux();
            
            Console.WriteLine("BRAND OF CLOTHES\n");
            Console.WriteLine("1.  NIKE");
            Console.WriteLine("2.  LEVIS");
            Console.WriteLine("3.  ADIDAS");
            Console.WriteLine("4.  TRIBAL");
            Console.WriteLine("5.  Go back to Main Screen");
            for (; ; )
            {
                Console.Write("Enter the number of your desired brand:");
                brands = Convert.ToString(Console.ReadLine());
                

                if (brands == "1")
                {
                    displayProduct(1);
                   
                    break;
                }
                if (brands == "2")
                {
                    displayProduct(2);
                    break;
                }
                if (brands == "3")
                {
                    displayProduct(3);
                    break;
                }
                if (brands == "4")
                {
                    displayProduct(4);
                    break;
                }
                if (brands == "5")
                {
                    main();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }

         public static void displayProduct(int productcategory)
         {
             maximux(); 
             Console.Clear();
             if (productcategory == 1)
             {
                 orderidentifier = 1;
                 Console.WriteLine(NIKETITLE);
               for (index = 0 ; index < Nike.Length ;index++) {
                   if (index == 0) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 1) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 2) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 3) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 4) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 5) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 6) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 7) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 8) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   } else if (index == 9) {
                       Console.WriteLine(Nike[index] + "\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00");
                   }
                   else if (index == 10)
                   {
                       Console.WriteLine(Nike[index]);
                   }
               }
               
             } 
             else if (productcategory == 2) 
             {

                 orderidentifier = 2;
                 Console.WriteLine(LEVISTITLE);
                 for (index = 0; index < Levis.Length; index++)
                 {
                     if (index == 0)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 1)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 2)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 3)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 4)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 5)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 6)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 7)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 8)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 9)
                     {
                         Console.WriteLine(Levis[index] + "\t\t\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00");
                     }
                     else if (index == 10)
                     {
                         Console.WriteLine(Nike[index]);
                     }
                 }
                 
             }
             else if (productcategory == 3)
             {
                 Console.WriteLine(ADIDASTITLE);
                 orderidentifier = 3;
                 for (index = 0; index < Adidas.Length; index++ )
                 {
                     if (index == 0)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 1)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 2)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 3)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 4)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 5)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 6)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 7)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 8)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 9)
                     {
                         Console.WriteLine(Adidas[index] + "\t\t\t\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00");
                     }
                     else if (index == 10)
                     {
                         Console.WriteLine(Nike[index]);
                     }
                 }
                
             }
             else if (productcategory == 4)
             {
                 orderidentifier = 4;
                 Console.WriteLine(TRIBALTITLE);

                 for (index = 0; index < Tribal.Length; index++)
                 {
                     if (index == 0)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 1)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 2)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 3)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 4)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 5)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 6)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 7)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 8)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 9)
                     {
                         Console.WriteLine(Tribal[index] + "\t\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00");
                     }
                     else if (index == 10)
                     {
                         Console.WriteLine(Nike[index]);
                     }
                 }
                 
             }
             maximux();
             AddOrder();
         }
        public static void AddOrder() {
            
            goto firstOrder;
            Another:
            for(;;)  {
                if (counter > 10000) {
                    Console.Clear();
                    maximux();
                    break;
                }
                Console.WriteLine("1 .Yes");
                Console.WriteLine("2. No");
          
                Console.Write("you want to add another item from this brand:?");
               globalquestion = Convert.ToString(Console.ReadLine());
                if (globalquestion ==  "1") {
                        maximux();
                        break;
                    
                }
                else if (globalquestion == "2")
                {
                    Console.WriteLine("1. Go back to brands category");
                    Console.WriteLine("2. Go back to main screen");
                    Console.WriteLine("3. Payment");
                    for (; ; )
                    {
                        Console.Write("choose options on the list above:");
                        globalquestion = Convert.ToString(Console.ReadLine());
                        if (globalquestion == "1") {
                            Console.Clear();
                            brand();
                            break;
                        } else if (globalquestion == "2") {
                            main();                           
                            break;
                        }
                        else if (globalquestion == "3") {
                            
                            getReceipt();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    goto Another;
                }
            }
            

           firstOrder:
            //Console.WriteLine("1 .Yes");
            //Console.WriteLine("2. No");
            for (; ; )
            {
           
            repeatq:
                /*while(true) {
                    Console.Write("Do you want To go Back to Brands?:");
                    globalquestion = Convert.ToString(Console.ReadLine());

                    if (globalquestion == "1" )
                    {
                        Console.Clear();
                        brand();
                        break;
                    } else if (globalquestion == "2") {
                        break;
                    } else {
                        Console.WriteLine("Invalid Input");
                    }
                }*/

            repeatorder:
                Console.Write("choose Order:");
                globalquestion = Convert.ToString(Console.ReadLine());
                // for quantity and size
                
                if (globalquestion == "11") {
                    Console.Clear();
                    brand();
                    break;
                }

       
                    // for nike products
                    if (orderidentifier == 1)
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {
                        repeatSize:
                            globalquestionConvertToNum  = Convert.ToDouble(globalquestion);
                            Console.Write("What Size you want");
                            size = Convert.ToString(Console.ReadLine());
                            if (size == "1")
                            {
                        
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2) 
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3) 
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }

                            }
                            else if (size == "2")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[1, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                            }
                            else if (size == "3")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input!");
                                goto repeatSize;
                            }


                            for (; ; )
                            {
                            repeatQuantity:
                                Console.Write("How Many Quantity:");
                                orderQuantity = Convert.ToInt32(Console.ReadLine());

                                if (orderQuantity.GetType() == typeof(int) || (orderQuantity != 0 && orderQuantity == 20))
                                {
                                    if (orderQuantity >= 21) {
                                        Console.WriteLine("Lack of Stock less than 21");
                                        goto repeatQuantity;
                                    } else if (orderQuantity == 20 || (orderQuantity >= 1 && orderQuantity <= 20)) {
                                       
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("invalid quantity");
                                    goto repeatQuantity;
                                }
                                break;
                            }
                            break;
                        }
                        
                        for (; ; )
                        {
                            if (globalquestion == "1")
                            {

                                if (NikeStock[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[0];
                                orderPriceCapacity[counter] = NikePrice[0];
                                counter++;
                                totalorder += NikePrice[0];

                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                        

                                if (size == "1") {
                                    NikeStock[0] -= orderQuantity;                                                
                                    confirmsizeQuantity[0, 0] = orderQuantity;
                                    
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[0]);
                                    totalbrandQuantityContainer[0, 0] -= orderQuantity;
         
                                } else if (size == "2") {
                                    NikeStockTwo[0] -= orderQuantity;

                                    confirmsizeQuantity[1, 0] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[0]);
                                    totalbrandQuantityContainer[0, 0] -= orderQuantity;
                                    
                                } else if (size == "3") {
                                    NikeStockThree[0] -= orderQuantity;
                                    confirmsizeQuantity[2, 0] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[0]);
                                    totalbrandQuantityContainer[0, 0] -= orderQuantity;

                                    Console.WriteLine(NikeStockThree[0]);
                                }

                                goto Another;
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStock[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[1];
                                orderPriceCapacity[counter] = NikePrice[1];
                 
                                counter++;
                                totalorder += NikePrice[1];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[1] -= orderQuantity;
                                    confirmsizeQuantity[0, 1] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[1]);
                                    totalbrandQuantityContainer[0, 1] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[1] -= orderQuantity;
                                    confirmsizeQuantity[1, 1] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[1]);
                                    NikeStockTwo[1] += orderQuantity;
                                    totalbrandQuantityContainer[0, 1] -= orderQuantity;
                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[1] -= orderQuantity;
                                    confirmsizeQuantity[1, 3] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[1]);
                                    totalbrandQuantityContainer[0, 1] -= orderQuantity;
                            
                                }
                                goto Another;
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStock[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[2];
                                orderPriceCapacity[counter] = NikePrice[2];
                                counter++;
             
                                totalorder += NikePrice[2];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[2] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[2]);
                                    totalbrandQuantityContainer[0, 2] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[2] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[2]);
                                    totalbrandQuantityContainer[0, 2] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[2] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[2]);
                                    totalbrandQuantityContainer[0, 2] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "4")
                            {
                                if (NikeStock[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[3];
                                orderPriceCapacity[counter] = NikePrice[3];
                                counter++;
          
                                totalorder += NikePrice[3];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[3] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[3]);
                                    totalbrandQuantityContainer[0, 3] -= orderQuantity;
                               
                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[3] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[3]);
                                    totalbrandQuantityContainer[0, 3] -= orderQuantity;
                           
                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[3] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[3]);
                                    totalbrandQuantityContainer[0, 3] -= orderQuantity;
                                }
                                goto Another;
                            }
                            else if (globalquestion == "5")
                            {
                                if (NikeStock[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[4];
                                orderPriceCapacity[counter] = NikePrice[4];
                                counter++;

                                totalorder += NikePrice[4];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[4] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[4]);
                                    totalbrandQuantityContainer[0, 4] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[4] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[4]);
                                    totalbrandQuantityContainer[0, 4] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[4] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[4]);
                                    totalbrandQuantityContainer[0, 4] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "6")
                            {
                                if (NikeStock[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[5];
                                orderPriceCapacity[counter] = NikePrice[5];
                                counter++;
 
                                totalorder += NikePrice[5];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[5] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[5]);
                                    totalbrandQuantityContainer[0, 5] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[5] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[5]);
                                    totalbrandQuantityContainer[0, 5] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[5] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[5]);
                                    totalbrandQuantityContainer[0, 5] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "7")
                            {
                                if (NikeStock[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[6];
                                orderPriceCapacity[counter] = NikePrice[6];
                                counter++;

                                totalorder += NikePrice[6];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[6] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[6]);
                                    totalbrandQuantityContainer[0, 6] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[6] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[6]);
                                    totalbrandQuantityContainer[0, 6] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[6] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[6]);
                                    totalbrandQuantityContainer[0, 6] -= orderQuantity;

                                }
                                goto Another;
                            }

                            else if (globalquestion == "8")
                            {
                                if (NikeStock[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[7];
                                orderPriceCapacity[counter] = NikePrice[7];
                                counter++;
 
                                totalorder += NikePrice[7];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[7] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[7]);
                                    totalbrandQuantityContainer[0, 7] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[6] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[7]);
                                    totalbrandQuantityContainer[0, 7] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[7] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[7]);
                                    NikeStockThree[7] += orderQuantity;
                                    totalbrandQuantityContainer[0, 7] -= orderQuantity;
                                }
                                goto Another;
                            }
                            else if (globalquestion == "9")
                            {
                                if (NikeStock[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[8];
                                orderPriceCapacity[counter] = NikePrice[8];
                                counter++;
                     
                                totalorder += NikePrice[8];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[8] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[8]);
                                    totalbrandQuantityContainer[0, 8] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[8] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[8]);
                                    totalbrandQuantityContainer[0, 8] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[8] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[8]);
                                    totalbrandQuantityContainer[0, 8] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "10")
                            {
                                if (NikeStock[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockTwo[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (NikeStockThree[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[9];
                                orderPriceCapacity[counter] = NikePrice[9];
                                counter++;
      
                                totalorder += NikePrice[9];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    NikeStock[9] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStock[9]);
                                    totalbrandQuantityContainer[0, 9] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    NikeStockTwo[9] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockTwo[9]);
                                    totalbrandQuantityContainer[0, 9] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    NikeStockThree[9] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + NikeStockThree[9]);
                                    totalbrandQuantityContainer[0, 9] -= orderQuantity;

                                }
                                goto Another;
                            }
                            
                            else if (globalquestion == "11") {
                                Console.Clear();
                                brand();
                               
                            }
                            else
                            {
                                Console.WriteLine("Invalid input !!");
                                goto repeatq;
                            }
                        }

                    }
                    else if (orderidentifier == 2)
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {
                        repeatSize:
                            globalquestionConvertToNum = Convert.ToDouble(globalquestion);
                            Console.Write("What Size you want");
                            size = Convert.ToString(Console.ReadLine());
                            if (size == "1")
                            {

                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }

                            }
                            else if (size == "2")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[1, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                            }
                            else if (size == "3")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input!");
                                goto repeatSize;
                            }


                            for (; ; )
                            {
                            repeatQuantity:
                                Console.Write("How Many Quantity:");
                                orderQuantity = Convert.ToInt32(Console.ReadLine());

                                if (orderQuantity.GetType() == typeof(int) || (orderQuantity != 0 && orderQuantity == 20))
                                {
                                    if (orderQuantity >= 21)
                                    {
                                        Console.WriteLine("Lack of Stock less than 21");
                                        goto repeatQuantity;
                                    }
                                    else if (orderQuantity == 20 || (orderQuantity >= 1 && orderQuantity <= 20))
                                    {

                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("invalid quantity");
                                    goto repeatQuantity;
                                }
                                break;
                            }
                            break;
                        }
                        for (; ; )
                        {
                            if (globalquestion == "1")
                            {
                                if (LevisStock[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[0];
                                orderPriceCapacity[counter] = LevisPrice[0];
                                counter++;

                                totalorder += LevisPrice[0];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                Console.WriteLine("The Quantity of this item are now: " + LevisStock[0]);
                                if (size == "1")
                                {
                                    LevisStock[0] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[0]);
                                    totalbrandQuantityContainer[1, 0] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[0] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[0]);
                                    LevisStockTwo[0] += orderQuantity;
                                    totalbrandQuantityContainer[1, 0] -= orderQuantity;
                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[0] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[0]);
                                    totalbrandQuantityContainer[1, 0] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStock[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[1];
                                orderPriceCapacity[counter] = LevisPrice[1];
                                counter++;
                 
                                totalorder += LevisPrice[1];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[1] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[1]);
                                    totalbrandQuantityContainer[1, 1] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[1] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[1]);
                                    totalbrandQuantityContainer[1, 1] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[1] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[1]);
                                    totalbrandQuantityContainer[1, 1] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStock[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[2];
                                orderPriceCapacity[counter] = LevisPrice[2];
                                counter++;

                                totalorder += LevisPrice[2];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[2] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[2]);
                                    totalbrandQuantityContainer[1, 2] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[2] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[2]);
                                    totalbrandQuantityContainer[1, 2] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[2] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[2]);
                                    totalbrandQuantityContainer[1, 2] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "4")
                            {
                                if (LevisStock[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[3];
                                orderPriceCapacity[counter] = LevisPrice[3];
                                counter++;

                                totalorder += LevisPrice[3];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[3] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[3]);
                                    totalbrandQuantityContainer[1, 3] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[3] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[3]);
                                    totalbrandQuantityContainer[1, 3] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[3] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[3]);
                                    totalbrandQuantityContainer[1, 3] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "5")
                            {
                                if (LevisStock[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[4];
                                orderPriceCapacity[counter] = LevisPrice[4];
                                counter++;
                                totalorder += LevisPrice[4];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[4] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[4]);
                                    totalbrandQuantityContainer[1, 4] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[4] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[4]);
                                    totalbrandQuantityContainer[1, 4] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[4] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[4]);
                                    totalbrandQuantityContainer[1, 4] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "6")
                            {
                                if (LevisStock[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[5];
                                orderPriceCapacity[counter] = LevisPrice[5];
                                counter++;

                                totalorder += LevisPrice[5];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[5] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[5]);
                                    totalbrandQuantityContainer[1, 5] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[5] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[5]);
                                    totalbrandQuantityContainer[1, 5] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[5] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[5]);
                                    totalbrandQuantityContainer[1, 5] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "7")
                            {
                                if (LevisStock[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[6];
                                orderPriceCapacity[counter] = LevisPrice[6];
                                counter++;
                               
                                totalorder += LevisPrice[6];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[6] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[6]);
                                    totalbrandQuantityContainer[1, 6] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[6] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[6]);
                                    totalbrandQuantityContainer[1, 6] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[6] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[6]);
                                    totalbrandQuantityContainer[1, 6] -= orderQuantity;

                                }
                                goto Another;
                            }

                            else if (globalquestion == "8")
                            {
                                if (LevisStock[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[7];
                                orderPriceCapacity[counter] = LevisPrice[7];
                                counter++;
                
                                totalorder += LevisPrice[7];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[7] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[7]);
                                    totalbrandQuantityContainer[1, 7] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[7] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[7]);
                                    totalbrandQuantityContainer[1, 7] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[7] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[7]);
                                    totalbrandQuantityContainer[1, 7] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "9")
                            {
                                if (LevisStock[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Nike[8];
                                orderPriceCapacity[counter] = NikePrice[8];
                                counter++;
                        
                                totalorder += LevisPrice[8];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[8] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[8]);
                                    totalbrandQuantityContainer[1, 8] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[8] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[8]);
                                    totalbrandQuantityContainer[1, 8] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[8] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[8]);
                                    totalbrandQuantityContainer[1, 8] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "10")
                            {
                                if (LevisStock[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockTwo[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (LevisStockThree[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Levis[9];
                                orderPriceCapacity[counter] = LevisPrice[9];
                                counter++;
             
                                totalorder += LevisPrice[9];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    LevisStock[9] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStock[9]);
                                    totalbrandQuantityContainer[1, 9] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    LevisStockTwo[9] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockTwo[9]);
                                    totalbrandQuantityContainer[1, 9] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    LevisStockThree[9] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + LevisStockThree[9]);
                                    totalbrandQuantityContainer[1, 9] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "11")
                            {
                                Console.Clear();
                                brand();

                            }
                            else
                            {
                                Console.WriteLine("Invalid input !!");
                                goto repeatq;
                            }
                        }

                    }
                    else if (orderidentifier == 3)
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {
                        repeatSize:
                            globalquestionConvertToNum = Convert.ToDouble(globalquestion);
                            Console.Write("What Size you want");
                            size = Convert.ToString(Console.ReadLine());
                            if (size == "1")
                            {

                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }

                            }
                            else if (size == "2")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[1, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                            }
                            else if (size == "3")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input!");
                                goto repeatSize;
                            }


                            for (; ; )
                            {
                            repeatQuantity:
                                Console.Write("How Many Quantity:");
                                orderQuantity = Convert.ToInt32(Console.ReadLine());

                                if (orderQuantity.GetType() == typeof(int) || (orderQuantity != 0 && orderQuantity == 20))
                                {
                                    if (orderQuantity >= 21)
                                    {
                                        Console.WriteLine("Lack of Stock less than 21");
                                        goto repeatQuantity;
                                    }
                                    else if (orderQuantity == 20 || (orderQuantity >= 1 && orderQuantity <= 20))
                                    {

                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("invalid quantity");
                                    goto repeatQuantity;
                                }
                                break;
                            }
                            break;
                        }
                        for (; ; )
                        {
                            if (globalquestion == "1")
                            {
                                if (AdidasStock[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[0];
                                orderPriceCapacity[counter] = AdidasPrice[0];
                                counter++;
                   
                                totalorder += AdidasPrice[0];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[0] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[0]);
                                    AdidasStock[0] += orderQuantity;
                                    totalbrandQuantityContainer[2, 0] -= orderQuantity;
                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[0] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[0]);
                                    AdidasStockTwo[0] += orderQuantity;
                                    totalbrandQuantityContainer[2, 0] -= orderQuantity;
                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[0] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[0]);
                                    AdidasStockThree[0] += orderQuantity;
                                    totalbrandQuantityContainer[2, 0] -= orderQuantity;
                                }
                                goto Another;
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStock[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[1];
                                orderPriceCapacity[counter] = AdidasPrice[1];
                                counter++;
                    
                                totalorder += AdidasPrice[1];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[1] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[1]);
                                    totalbrandQuantityContainer[2, 1] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[1] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[1]);
                                    totalbrandQuantityContainer[2, 1] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[1] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[1]);
                                    totalbrandQuantityContainer[2, 1] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStock[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[2];
                                orderPriceCapacity[counter] = AdidasPrice[2];
                                counter++;

                                totalorder += AdidasPrice[2];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[2] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[2]);
                                    totalbrandQuantityContainer[2, 2] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[2] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[2]);
                                    totalbrandQuantityContainer[2, 2] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[2] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[2]);
                                    totalbrandQuantityContainer[2, 2] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "4")
                            {
                                if (AdidasStock[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[3];
                                orderPriceCapacity[counter] = AdidasPrice[3];
                                counter++;
                        
                                totalorder += AdidasPrice[3];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[3] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[3]);
                                    totalbrandQuantityContainer[2, 3] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[3] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[3]);
                                    totalbrandQuantityContainer[2, 3] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[3] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[3]);
                                    totalbrandQuantityContainer[2, 3] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "5")
                            {
                                if (AdidasStock[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[4];
                                orderPriceCapacity[counter] = AdidasPrice[4];
                                counter++;
                
                                totalorder += AdidasPrice[4];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[4] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[4]);
                                    totalbrandQuantityContainer[2, 4] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[4] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[4]);
                                    totalbrandQuantityContainer[2, 4] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[4] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[4]);
                                    totalbrandQuantityContainer[2, 4] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "6")
                            {
                                if (AdidasStock[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[5];
                                orderPriceCapacity[counter] = AdidasPrice[5];
                                counter++;
                        
                                totalorder += AdidasPrice[5];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[5] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[5]);
                                    totalbrandQuantityContainer[2, 5] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[5] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[5]);
                                    totalbrandQuantityContainer[2, 5] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[5] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[5]);
                                    totalbrandQuantityContainer[2, 5] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "7")
                            {
                                if (AdidasStock[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[6];
                                orderPriceCapacity[counter] = AdidasPrice[6];
                                counter++;

                                totalorder += AdidasPrice[6];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[6] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[6]);
                                    totalbrandQuantityContainer[2, 6] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[6] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[6]);
                                    totalbrandQuantityContainer[2, 6] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[6] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[6]);
                                    totalbrandQuantityContainer[2, 6] -= orderQuantity;

                                }
                                goto Another;
                            }

                            else if (globalquestion == "8")
                            {
                                if (AdidasStock[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[7];
                                orderPriceCapacity[counter] = AdidasPrice[7];
                                counter++;
              
                                totalorder += AdidasPrice[7];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[7] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[7]);
                                    totalbrandQuantityContainer[2, 2] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[7] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[7]);
                                    totalbrandQuantityContainer[2, 2] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[7] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[7]);
                                    totalbrandQuantityContainer[2, 7] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "9")
                            {
                                if (AdidasStock[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[8];
                                orderPriceCapacity[counter] = AdidasPrice[8];
                                counter++;

                                totalorder += AdidasPrice[8];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[8] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[8]);
                                    totalbrandQuantityContainer[2, 8] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[2] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[8]);
                                    totalbrandQuantityContainer[2, 8] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[8] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[8]);
                                    totalbrandQuantityContainer[2, 8] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "10")
                            {
                                if (AdidasStock[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockTwo[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (AdidasStockThree[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Adidas[9];
                                orderPriceCapacity[counter] = AdidasPrice[9];
                                counter++;
      
                                totalorder += AdidasPrice[9];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    AdidasStock[9] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStock[9]);
                                    totalbrandQuantityContainer[2, 9] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    AdidasStockTwo[9] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[9]);
                                    totalbrandQuantityContainer[2, 9] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    AdidasStockThree[9] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockThree[9]);
                                    totalbrandQuantityContainer[2, 9] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "11")
                            {
                                Console.Clear();
                                brand();

                            }
                            else
                            {
                                Console.WriteLine("Invalid input !!");
                                goto repeatq;
                            }
                        }
                    }
                    else if (orderidentifier == 4)
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {
                        repeatSize:
                            globalquestionConvertToNum = Convert.ToDouble(globalquestion);
                            Console.Write("What Size you want");
                            size = Convert.ToString(Console.ReadLine());
                            if (size == "1")
                            {

                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "S";
                                    sizeCounter++;
                                }

                            }
                            else if (size == "2")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[1, sizeCounter] = "M";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[1, sizeCounter] = "S";
                                    sizeCounter++;
                                }
                            }
                            else if (size == "3")
                            {
                                if (globalquestionConvertToNum == 1)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 2)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 3)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 4)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 5)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 6)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 7)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 8)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 9)
                                {
                                    totalsizeContainer[2, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                                else if (globalquestionConvertToNum == 10)
                                {
                                    totalsizeContainer[0, sizeCounter] = "L";
                                    sizeCounter++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("invalid Input!");
                                goto repeatSize;
                            }


                            for (; ; )
                            {
                            repeatQuantity:
                                Console.Write("How Many Quantity:");
                                orderQuantity = Convert.ToInt32(Console.ReadLine());

                                if (orderQuantity.GetType() == typeof(int) || (orderQuantity != 0 && orderQuantity == 20))
                                {
                                    if (orderQuantity >= 21)
                                    {
                                        Console.WriteLine("Lack of Stock less than 21");
                                        goto repeatQuantity;
                                    }
                                    else if (orderQuantity == 20 || (orderQuantity >= 1 && orderQuantity <= 20))
                                    {

                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("invalid quantity");
                                    goto repeatQuantity;
                                }
                                break;
                            }
                            break;
                        }
                        for (; ; )
                        {
                            if (globalquestion == "1")
                            {
                                if (trivalstock[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[0] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[0];
                                orderPriceCapacity[counter] = TribalPrice[0];
                                counter++;
                        
                                totalorder += TribalPrice[0];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[0] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[0]);
                                    totalbrandQuantityContainer[3, 0] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[0] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[0]);
                                    totalbrandQuantityContainer[3, 0] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[0] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[0]);
                                    totalbrandQuantityContainer[3, 0] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstock[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[1] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[1];
                                orderPriceCapacity[counter] = TribalPrice[1];
                                counter++;
                          
                                totalorder += TribalPrice[1];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[1] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[1]);
                                    totalbrandQuantityContainer[3, 1] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[1] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[1]);
                                    totalbrandQuantityContainer[3, 0] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[1] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[1]);
                                    totalbrandQuantityContainer[3, 1] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstock[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[2] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[2];
                                orderPriceCapacity[counter] = TribalPrice[2];
                                counter++;

                                totalorder += TribalPrice[2];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[2] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[2]);
                                    totalbrandQuantityContainer[3, 2] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[2] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[2]);
                                    totalbrandQuantityContainer[3, 2] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[2] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[2]);
                                    totalbrandQuantityContainer[3, 2] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "4")
                            {
                                if (trivalstock[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[3] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[3];
                                orderPriceCapacity[counter] = TribalPrice[3];
                                counter++;
                           
                                totalorder += TribalPrice[3];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[3] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[3]);
                                    totalbrandQuantityContainer[3, 3] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[3] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[3]);
                                    totalbrandQuantityContainer[3, 3] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[3] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[3]);
                                    totalbrandQuantityContainer[3, 3] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "5")
                            {
                                if (trivalstock[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[4] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[4];
                                orderPriceCapacity[counter] = TribalPrice[4];
                                counter++;
      
                                totalorder += TribalPrice[4];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[4] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[4]);
                                    totalbrandQuantityContainer[3, 4] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[4] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[4]);
                                    totalbrandQuantityContainer[3,4] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[4] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[4]);
                                    totalbrandQuantityContainer[3, 4] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "6")
                            {
                                if (trivalstock[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[5] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[5];
                                orderPriceCapacity[counter] = TribalPrice[5];
                                counter++;

                                totalorder += TribalPrice[5];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[5] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[5]);
                                    totalbrandQuantityContainer[3, 5] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[5] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[5]);
                                    totalbrandQuantityContainer[3, 5] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[5] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[5]);
                                    totalbrandQuantityContainer[3, 5] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "7")
                            {
                                if (trivalstock[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[6] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[6];
                                orderPriceCapacity[counter] = TribalPrice[6];
                                counter++;
      
                                totalorder += TribalPrice[6];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[6] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[6]);
                                    totalbrandQuantityContainer[3, 6] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[6] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[6]);
                                    totalbrandQuantityContainer[3, 6] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[6] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[6]);
                                    totalbrandQuantityContainer[3, 6] -= orderQuantity;

                                }
                                goto Another;
                            }

                            else if (globalquestion == "8")
                            {
                                if (trivalstock[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[7] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[7];
                                orderPriceCapacity[counter] = TribalPrice[7];
                                counter++;
                               
                                totalorder += TribalPrice[7];
                                balance = totalorder;
                                currentBalanceTotal = balance + totalorder;
                                if (size == "1")
                                {
                                    trivalstock[7] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[7]);
                                    totalbrandQuantityContainer[3, 7] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[7] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[7]);
                                    totalbrandQuantityContainer[3, 7] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[7] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[7]);
                                    totalbrandQuantityContainer[3, 7] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "9")
                            {
                                if (trivalstock[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[8] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[8];
                                orderPriceCapacity[counter] = TribalPrice[8];
                                counter++;
              
                                totalorder += TribalPrice[8];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[8] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[8]);
                                    totalbrandQuantityContainer[3, 8] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[8] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[8]);
                                    totalbrandQuantityContainer[3, 0] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[8] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[8]);
                                    totalbrandQuantityContainer[3, 8] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "10")
                            {
                                if (trivalstock[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockTwo[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                else if (trivalstockThree[9] == 0)
                                {
                                    Console.WriteLine("This Item is out of Stock");
                                    Console.WriteLine("please choose other item");
                                    goto repeatorder;
                                }
                                orderNameCapacity[counter] = Tribal[9];
                                orderPriceCapacity[counter] = TribalPrice[9];
                                counter++;

                                totalorder += TribalPrice[9];
                                balance = totalorder;
                                currentBalanceTotal = totalorder;
                                if (size == "1")
                                {
                                    trivalstock[9] -= orderQuantity;
                                    confirmsizeQuantity[0, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstock[9]);
                                    totalbrandQuantityContainer[3, 9] -= orderQuantity;

                                }
                                else if (size == "2")
                                {
                                    trivalstockTwo[9] -= orderQuantity;
                                    confirmsizeQuantity[1, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + AdidasStockTwo[9]);
                                    totalbrandQuantityContainer[3, 9] -= orderQuantity;

                                }
                                else if (size == "3")
                                {
                                    trivalstockThree[9] -= orderQuantity;
                                    confirmsizeQuantity[2, counter] = orderQuantity;
                                    Console.WriteLine("The Quantity of this item are now: " + trivalstockThree[9]);
                                    totalbrandQuantityContainer[3, 9] -= orderQuantity;

                                }
                                goto Another;
                            }
                            else if (globalquestion == "11")
                            {
                                Console.Clear();
                                brand();

                            }
                            else
                            {
                                Console.WriteLine("Invalid input !!");
                                goto repeatq;
                            }
                        }
                    }
            }
        }
        public static void ST()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");
            repeatstock:
            Console.WriteLine("\n\n\nSTOCKS");
            Console.WriteLine("");
            Console.WriteLine("1. Display Inventory");
            Console.WriteLine("2. Add Stock");
            Console.WriteLine("3. Go back to Main Screen");
            for (; ; )
            {
                Console.Write("Enter a Number: ");
                stock = Convert.ToString(Console.ReadLine());

                if (stock == "1")
                {
                    
                    Console.Clear();
                    IN();
                    break;
                }
                if (stock == "2")
                {
                    Console.Clear();
                    Console.WriteLine("1 .Yes");
                    Console.WriteLine("2. No");
                    while(true) {
                        Console.Write("do you want to add stocks:");
                        globalquestion = Convert.ToString(Console.ReadLine());

                         if (globalquestion == "1")
                         {
                             Console.Clear();
                             Addstock();
                             break;
                         }
                         else if (globalquestion == "2")
                         {
                             Console.Clear();
                             goto repeatstock;
                             
                         }
                         else
                         {
                             Console.WriteLine("Invalid input!");
                         }

                    }
                    break;
                }
                if (stock == "3")
                {
                    Console.Clear();
                    main();
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT!");
                    Console.Write("Press Enter to go back, Thank you");
                    Console.ReadLine();
                    //goto ST;

                }
            }
           
        
        }
        public static void individualStock()
        {
            if (checkfordisplay == 1)
            {
                Console.WriteLine(NIKETITLESTOCK);
                for (index = 0; index < Nike.Length; index++)
                {
                    if (index == 0)
                    {
                        Console.WriteLine(Nike[index] + "\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[0] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                    }
                    else if (index == 1)
                    {
                        Console.WriteLine(Nike[index] + "\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);

                    }
                    else if (index == 2)
                    {
                        Console.WriteLine(Nike[index] + "\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                    }
                    else if (index == 3)
                    {
                        Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);

                    }
                    else if (index == 4)
                    {
                        Console.WriteLine(Nike[index] + "\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, 4]);

                    }
                    else if (index == 5)
                    {

                        Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                    }
                    else if (index == 6)
                    {
                        Console.WriteLine(Nike[index] + "\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[0] + "\t" + NikeStockThree[0] + "\t" + totalbrandQuantityContainer[0, index]);
                    }
                    else if (index == 7)
                    {
                        Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);

                    }
                    else if (index == 8)
                    {
                        Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);

                    }
                    else if (index == 9)
                    {
                        Console.WriteLine(Nike[index] + "\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[9] +
                            "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);

                    }
                }
                
            }
            else if (checkfordisplay == 2)
            {
                Console.WriteLine();
                Console.WriteLine(LEVISTITLESTOCK);
                Console.WriteLine();
                for (index = 0; index < Levis.Length; index++)
                {
                    if (index == 0)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);

                    }
                    else if (index == 1)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 2)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 3)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 4)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 5)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 6)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 7)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 8)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                    else if (index == 9)
                    {
                        Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                            "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                    }
                }
            }
            else if (checkfordisplay == 3)
            {
                Console.WriteLine();
                Console.WriteLine(ADIDASTITLESTOCK);
                Console.WriteLine();
                for (index = 0; index < Adidas.Length; index++)
                {
                    if (index == 0)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[0] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 1)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 2)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 3)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 4)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 5)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 6)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 7)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 8)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                    else if (index == 9)
                    {
                        Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                            + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                    }
                }
            }
            else if (checkfordisplay == 4)
            {
                Console.WriteLine();
                Console.WriteLine(TRIBALTITLESTOCK);
                Console.WriteLine();
                for (index = 0; index < Tribal.Length; index++)
                {
                    if (index == 0)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 1)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 2)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 3)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 4)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 5)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 6)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 7)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                            "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 8)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" + "\t" + trivalstock[index] +
                            "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                    else if (index == 9)
                    {
                        Console.WriteLine(Tribal[index] + "\t\t\t" + "PHP " + TribalPrice[index] + ".00" + "\t" + trivalstock[index] +
                            "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                    }
                }
            }
            Console.WriteLine("1 .Yes");
            Console.WriteLine("2. No");
            for (; ; )
            {
                Console.Write("go back:");
                globalquestion = Convert.ToString(Console.ReadLine());

                if (globalquestion == "1") {
                    Console.Clear();
                    ST();
                    break;
                    }
                else if (globalquestion == "2")
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!!");
                }
            }
        }

        public static void IN()
        {
            
            
            Console.WriteLine("\t\t\t\t\tBRAND OF CLOTHES");
            Console.WriteLine();
            Console.WriteLine(NIKETITLESTOCK);
            for (index = 0; index < Nike.Length; index++ )
            {
                if (index == 0)
                {
                    Console.WriteLine(Nike[index] + "\t\t\t" + "PHP "+ NikePrice[index]+ ".00" + "\t" + NikeStock[0]+
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                }
                else if (index == 1)
                {
                    Console.WriteLine(Nike[index] + "\t\t\t" +"PHP " + NikePrice[index] +".00" + "\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                   
                }
                else if (index == 2)
                {
                    Console.WriteLine(Nike[index] + "\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                }
                else if (index == 3)
                {
                    Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                    
                }
                else if (index == 4)
                {
                    Console.WriteLine(Nike[index] + "\t\t" + "PHP " + NikePrice[index] + ".00" +  "\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, 4]);
           
                }
                else if (index == 5)
                {

                    Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " + NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
                }
                else if (index == 6)
                {
                    Console.WriteLine(Nike[index] + "\t\t\t\t\t" + "PHP " + NikePrice[index] + ".00" +"\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[0] + "\t" + NikeStockThree[0] + "\t" + totalbrandQuantityContainer[0, index]);
                }
                else if (index == 7)
                {
                    Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " +NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
 
                }
                else if (index == 8)
                {
                    Console.WriteLine(Nike[index] + "\t\t\t\t" + "PHP " +NikePrice[index] + ".00" + "\t" + NikeStock[index] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
             
                }
                else if (index == 9)
                {
                    Console.WriteLine(Nike[index] + "\t\t" + "PHP " + NikePrice[index] + ".00" +"\t" + NikeStock[9] +
                        "\t" + NikeStockTwo[index] + "\t" + NikeStockThree[index] + "\t" + totalbrandQuantityContainer[0, index]);
     
                }
            }
            Console.WriteLine();
            Console.WriteLine(LEVISTITLESTOCK);
            Console.WriteLine();
            for (index = 0; index < Levis.Length; index++)
            {
                if (index == 0)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t" + "PHP " +LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);

                }
                else if (index == 1)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " +LevisPrice[index]+ ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 2)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " +LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 3)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " +LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 4)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 5)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t" + "PHP "+LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 6)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t\t" +"PHP "+ LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 7)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t\t" +"PHP " + LevisPrice[index] +".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 8)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t\t\t"  + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
                else if (index == 9)
                {
                    Console.WriteLine(Levis[index] + "\t\t\t\t" + "PHP " + LevisPrice[index] + ".00" + "\t" + LevisStock[index] +
                        "\t" + LevisStockTwo[index] + "\t" + LevisStockThree[index] + "\t" + totalbrandQuantityContainer[1, index]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(ADIDASTITLESTOCK);
            Console.WriteLine();
            for (index = 0; index < Adidas.Length; index++)
            {
                if (index == 0)
                {
                    Console.WriteLine(Adidas[index] + "\t\t" + "PHP " +AdidasPrice[index] + ".00" + "\t" + AdidasStock[0] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2 ,index]);
                }
                else if (index == 1)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " +AdidasPrice[index] + ".00" + "\t" + AdidasStock[index]+ "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2 ,index]);
                }
                else if (index == 2)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " +AdidasPrice[index] + ".00" +"\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
                else if (index == 3)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t" + "PHP " + AdidasPrice[index] +".00" + "\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
                else if (index == 4)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" +"\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
                else if (index == 5)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP "+ AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
                else if (index == 6)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
                else if (index == 7)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t" + "PHP "+ AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
                else if (index == 8)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
                else if (index == 9)
                {
                    Console.WriteLine(Adidas[index] + "\t\t\t\t" + "PHP " + AdidasPrice[index] + ".00" + "\t" + AdidasStock[index] + "\t"
                        + AdidasStockTwo[index] + "\t" + AdidasStockThree[index] + "\t" + totalbrandQuantityContainer[2, index]);
                }
            }
            Console.WriteLine();
            Console.WriteLine(TRIBALTITLESTOCK);
            Console.WriteLine();
            for (index = 0; index < Tribal.Length; index++ )
            {
                if (index == 0)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" + 
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 1)
                {
                    Console.WriteLine(Tribal[index] + "\t\t" + "PHP " + TribalPrice[index] + ".00" +
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 2)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 3)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" + 
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 4)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 5)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" + 
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 6)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 7)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t" + "PHP " + TribalPrice[index] + ".00" +
                        "\t" + trivalstock[index] + "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 8)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t\t" + "PHP " + TribalPrice[index] + ".00" + "\t" + trivalstock[index] +
                        "\t"  + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
                else if (index == 9)
                {
                    Console.WriteLine(Tribal[index] + "\t\t\t" + "PHP " + TribalPrice[index] + ".00" + "\t" + trivalstock[index] +
                        "\t" + trivalstockTwo[index] + "\t" + trivalstockThree[index] + "\t" + totalbrandQuantityContainer[3, index]);
                }
            }
            Console.WriteLine("1 .Yes");
            Console.WriteLine("2. No");
            for (; ; )
            {
            repeatstock:
                Console.Write("you want add another stock:?");
                globalquestion = Convert.ToString(Console.ReadLine());

                if (globalquestion == "1") {
                    
                    Addstock();
                    break;
                    }
                else if (globalquestion == "2" )
                {
                    Console.WriteLine("1. Go Back to Main Screen");
                    Console.WriteLine("2. Continue to view Stocks");
                    for (; ; )
                    {
                        Console.Write("choose number in above statement:");
                        globalquestion = Convert.ToString(Console.ReadLine());
                        if (globalquestion == "1") {
                            //Console.Clear();
                            main();
                            break;
                        } else if (globalquestion == "2") {
                            Console.WriteLine("Ok Stay in here");
                            goto repeatstock;
                        } else  {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    //Console.Clear();
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input");
                }


            }
        }
        public static void Addstock()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. NIKE");
            Console.WriteLine("2. LEVIS");
            Console.WriteLine("3. ADIDAS");
            Console.WriteLine("4. TRIVAL");
            Console.WriteLine("5. Back");
            for (; ; )
            {
                Console.Write("choose a number on above statement:");
                globalquestion = Convert.ToString(Console.ReadLine());
                if (globalquestion == "1") {
                    checkfordisplay = 1;
                    individualStock();
                    AddStockProcess(1);
                    break;

                } else if (globalquestion == "2") {
                    checkfordisplay = 2;
                    individualStock();
                    AddStockProcess(2);
                    break;

                } else if (globalquestion == "3") {
                    checkfordisplay = 3;
                    individualStock();
                    AddStockProcess(3);
                    break;
                } else if (globalquestion == "4") {
                    checkfordisplay = 4;
                    individualStock();
                    AddStockProcess(4);
                    break;
                } else if (globalquestion == "5") {
                    Console.Clear();
                    ST();
                    break;
                } else {
                    Console.WriteLine("Invalid input");
                }

            }
        }
        public static void AddStockProcess(int checkforStockInput)
        {

            if (checkforStockInput == 1) {
                for (; ;  )
                {
                    Console.Write("please select the stock item you want:");
                    globalquestion = Convert.ToString(Console.ReadLine());
                    if (globalquestion == "1")
                    {
                        
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1") { 
                                if (NikeStock[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[0] + QUANTITY) == 20) || ((NikeStock[0] + QUANTITY) <= 20))
                                        {
                                            NikeStock[0] += QUANTITY;
                                            totalbrandQuantityContainer[0, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            } else if (globalquestion == "2") {
                                if (NikeStockTwo[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[0] + QUANTITY) == 20) || ((NikeStockTwo[0] + QUANTITY) <= 20))
                                        {

                                            NikeStockTwo[0] += QUANTITY;
                                            totalbrandQuantityContainer[0, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[0] + QUANTITY) == 20) || ((NikeStockThree[0] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[0] += QUANTITY;
                                            totalbrandQuantityContainer[0, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                        
                        
                        
                    }
                    else if (globalquestion == "2")
                    {
                        /*if (NikeStock[1] == 20)
                        {
                            Console.WriteLine("the item stock is full");
                            Console.WriteLine();
                            Addstock();
                            break;
                        }*/
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[1] + QUANTITY) == 20) || ((NikeStock[1] + QUANTITY) <= 20))
                                        {
                                            NikeStock[1] += QUANTITY;
                                            totalbrandQuantityContainer[0, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[1] + QUANTITY) == 20) || ((NikeStockTwo[1] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[1] += QUANTITY;
                                            totalbrandQuantityContainer[0, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[1] + QUANTITY) == 20) || ((NikeStockThree[1] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[1] += QUANTITY;
                                            totalbrandQuantityContainer[0, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "3")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[2] + QUANTITY) == 20) || ((NikeStock[2] + QUANTITY) <= 20))
                                        {
                                            NikeStock[2] += QUANTITY;
                                            totalbrandQuantityContainer[0, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                } 
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[2] + QUANTITY) == 20) || ((NikeStockTwo[2] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[2] += QUANTITY;

                                            totalbrandQuantityContainer[0, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[2] + QUANTITY) == 20) || ((NikeStockThree[2] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[2] += QUANTITY;
                                            totalbrandQuantityContainer[0, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "4")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[3] + QUANTITY) == 20) || ((NikeStock[3] + QUANTITY) <= 20))
                                        {
                                            NikeStock[3] += QUANTITY;
                                            totalbrandQuantityContainer[0, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[3] + QUANTITY) == 20) || ((NikeStockTwo[3] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[2] += QUANTITY;
                                            totalbrandQuantityContainer[0, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[3] + QUANTITY) == 20) || ((NikeStockThree[3] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[3] += QUANTITY;
                                            totalbrandQuantityContainer[0, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "5")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[4] + QUANTITY) == 20) || ((NikeStock[4] + QUANTITY) <= 20))
                                        {
                                            NikeStock[4] += QUANTITY;
                                            totalbrandQuantityContainer[0, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[4] + QUANTITY) == 20) || ((NikeStockTwo[4] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[4] += QUANTITY;
                                            totalbrandQuantityContainer[0, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[4] + QUANTITY) == 20) || ((NikeStockThree[4] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[4] += QUANTITY;
                                            totalbrandQuantityContainer[0, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "6")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[5] + QUANTITY) == 20) || ((NikeStock[5] + QUANTITY) <= 20))
                                        {
                                            NikeStock[5] += QUANTITY;
                                            totalbrandQuantityContainer[0, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[5] + QUANTITY) == 20) || ((NikeStockTwo[5] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[5] += QUANTITY;
                                            totalbrandQuantityContainer[0, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[5] + QUANTITY) == 20) || ((NikeStockThree[5] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[5] += QUANTITY;
                                            totalbrandQuantityContainer[0, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "7")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[6] + QUANTITY) == 20) || ((NikeStock[6] + QUANTITY) <= 20))
                                        {
                                            NikeStock[6] += QUANTITY;
                                            totalbrandQuantityContainer[0, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[6] + QUANTITY) == 20) || ((NikeStockTwo[6] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[6] += QUANTITY;
                                            totalbrandQuantityContainer[0, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[6] + QUANTITY) == 20) || ((NikeStockThree[6] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[6] += QUANTITY;
                                            totalbrandQuantityContainer[0, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "8")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[7] + QUANTITY) == 20) || ((NikeStock[7] + QUANTITY) <= 20))
                                        {
                                            NikeStock[7] += QUANTITY;
                                            totalbrandQuantityContainer[0, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[7] + QUANTITY) == 20) || ((NikeStockTwo[7] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[7] += QUANTITY;
                                            totalbrandQuantityContainer[0, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[7] + QUANTITY) == 20) || ((NikeStockThree[7] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[7] += QUANTITY;
                                            totalbrandQuantityContainer[0, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "9")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[8] + QUANTITY) == 20) || ((NikeStock[8] + QUANTITY) <= 20))
                                        {
                                            NikeStock[8] += QUANTITY;
                                            totalbrandQuantityContainer[0, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[8] + QUANTITY) == 20) || ((NikeStockTwo[8] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[8] += QUANTITY;
                                            totalbrandQuantityContainer[0, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[8] + QUANTITY) == 20) || ((NikeStockThree[8] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[8] += QUANTITY;
                                            totalbrandQuantityContainer[0, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "10")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (NikeStock[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStock[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStock[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStock[9] + QUANTITY) == 20) || ((NikeStock[9] + QUANTITY) <= 20))
                                        {
                                            NikeStock[9] += QUANTITY;
                                            totalbrandQuantityContainer[0, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (NikeStockTwo[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockTwo[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockTwo[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockTwo[9] + QUANTITY) == 20) || ((NikeStockTwo[9] + QUANTITY) <= 20))
                                        {
                                            NikeStockTwo[9] += QUANTITY;
                                            totalbrandQuantityContainer[0, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (NikeStockThree[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (NikeStockThree[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((NikeStockThree[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((NikeStockThree[9] + QUANTITY) == 20) || ((NikeStockThree[9] + QUANTITY) <= 20))
                                        {
                                            NikeStockThree[9] += QUANTITY;
                                            totalbrandQuantityContainer[0, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            } else if (checkforStockInput == 2) {
                for (; ; )
                {
                    Console.Write("please select the stock item you want:");
                    globalquestion = Convert.ToString(Console.ReadLine());
                    if (globalquestion == "1")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[0] + QUANTITY) == 20) || ((LevisStock[0] + QUANTITY) <= 20))
                                        {
                                            LevisStock[0] += QUANTITY;
                                            totalbrandQuantityContainer[1, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[0] + QUANTITY) == 20) || ((LevisStockTwo[0] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[0] += QUANTITY;
                                            totalbrandQuantityContainer[1, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[0] + QUANTITY) == 20) || ((LevisStockThree[0] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[0] += QUANTITY;
                                            totalbrandQuantityContainer[1, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "2")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[1] + QUANTITY) == 20) || ((LevisStock[1] + QUANTITY) <= 20))
                                        {
                                            LevisStock[1] += QUANTITY;
                                            totalbrandQuantityContainer[1, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[1] + QUANTITY) == 20) || ((LevisStockTwo[1] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[1] += QUANTITY;
                                            totalbrandQuantityContainer[1, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[1] + QUANTITY) == 20) || ((LevisStockThree[1] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[1] += QUANTITY;
                                            totalbrandQuantityContainer[1, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "3")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[2] + QUANTITY) == 20) || ((LevisStock[2] + QUANTITY) <= 20))
                                        {
                                            LevisStock[2] += QUANTITY;
                                            totalbrandQuantityContainer[1, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[2] + QUANTITY) == 20) || ((LevisStockTwo[2] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[2] += QUANTITY;
                                            totalbrandQuantityContainer[1, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[2] + QUANTITY) == 20) || ((LevisStockThree[2] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[2] += QUANTITY;
                                            totalbrandQuantityContainer[1, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "4")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[3] + QUANTITY) == 20) || ((LevisStock[3] + QUANTITY) <= 20))
                                        {
                                            LevisStock[3] += QUANTITY;
                                            totalbrandQuantityContainer[1, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[3] + QUANTITY) == 20) || ((LevisStockTwo[3] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[3] += QUANTITY;
                                            totalbrandQuantityContainer[1, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[3] + QUANTITY) == 20) || ((LevisStockThree[3] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[3] += QUANTITY;
                                            totalbrandQuantityContainer[1, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "5")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[4] + QUANTITY) == 20) || ((LevisStock[4] + QUANTITY) <= 20))
                                        {
                                            LevisStock[4] += QUANTITY;
                                            totalbrandQuantityContainer[1, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[4] + QUANTITY) == 20) || ((LevisStockTwo[4] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[4] += QUANTITY;
                                            totalbrandQuantityContainer[1, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[4] + QUANTITY) == 20) || ((LevisStockThree[4] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[4] += QUANTITY;
                                            totalbrandQuantityContainer[1, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "6")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[5] + QUANTITY) == 20) || ((LevisStock[5] + QUANTITY) <= 20))
                                        {
                                            LevisStock[5] += QUANTITY;
                                            totalbrandQuantityContainer[1, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[5] + QUANTITY) == 20) || ((LevisStockTwo[5] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[5] += QUANTITY;
                                            totalbrandQuantityContainer[1, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[5] + QUANTITY) == 20) || ((LevisStockThree[5] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[5] += QUANTITY;
                                            totalbrandQuantityContainer[1, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "7")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[6] + QUANTITY) == 20) || ((LevisStock[6] + QUANTITY) <= 20))
                                        {
                                            LevisStock[6] += QUANTITY;
                                            totalbrandQuantityContainer[1, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[6] + QUANTITY) == 20) || ((LevisStockTwo[6] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[6] += QUANTITY;
                                            totalbrandQuantityContainer[1, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[6] + QUANTITY) == 20) || ((LevisStockThree[6] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[6] += QUANTITY;
                                            totalbrandQuantityContainer[1, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "8")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[7] + QUANTITY) == 20) || ((LevisStock[7] + QUANTITY) <= 20))
                                        {
                                            LevisStock[7] += QUANTITY;
                                            totalbrandQuantityContainer[1, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[7] + QUANTITY) == 20) || ((LevisStockTwo[7] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[7] += QUANTITY;
                                            totalbrandQuantityContainer[1, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[7] + QUANTITY) == 20) || ((LevisStockThree[7] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[7] += QUANTITY;
                                            totalbrandQuantityContainer[1, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "9")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[8] + QUANTITY) == 20) || ((LevisStock[8] + QUANTITY) <= 20))
                                        {
                                            LevisStock[8] += QUANTITY;
                                            totalbrandQuantityContainer[1, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[2] + QUANTITY) == 20) || ((LevisStockTwo[8] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[8] += QUANTITY;
                                            totalbrandQuantityContainer[1, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[8] + QUANTITY) == 20) || ((LevisStockThree[8] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[8] += QUANTITY;
                                            totalbrandQuantityContainer[1, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "10")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (LevisStock[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStock[9] + QUANTITY) == 20) || ((LevisStock[9] + QUANTITY) <= 20))
                                        {
                                            LevisStock[9] += QUANTITY;
                                            totalbrandQuantityContainer[1, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (LevisStockTwo[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockTwo[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockTwo[9] + QUANTITY) == 20) || ((LevisStockTwo[9] + QUANTITY) <= 20))
                                        {
                                            LevisStockTwo[9] += QUANTITY;
                                            totalbrandQuantityContainer[1, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (LevisStockThree[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStockThree[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockThree[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[9] + QUANTITY) == 20) || ((LevisStockThree[9] + QUANTITY) <= 20))
                                        {
                                            LevisStockThree[9] += QUANTITY;
                                            totalbrandQuantityContainer[1, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            } else if (checkforStockInput == 3) {
                for (; ; )
                {
                    Console.Write("please select the stock item you want:");
                    globalquestion = Convert.ToString(Console.ReadLine());
                    if (globalquestion == "1")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[0] + QUANTITY) == 20) || ((AdidasStock[0] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[0] += QUANTITY;
                                            totalbrandQuantityContainer[2, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[0] + QUANTITY) == 20) || ((AdidasStockTwo[0] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[0] += QUANTITY;
                                            totalbrandQuantityContainer[2, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[0] + QUANTITY) == 20) || ((AdidasStockThree[0] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[0] += QUANTITY;
                                            totalbrandQuantityContainer[2, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "2")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[1] + QUANTITY) == 20) || ((AdidasStock[1] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[1] += QUANTITY;
                                            totalbrandQuantityContainer[2, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[1] + QUANTITY) == 20) || ((AdidasStockTwo[1] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[1] += QUANTITY;
                                            totalbrandQuantityContainer[2, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[1] + QUANTITY) == 20) || ((AdidasStockThree[1] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[1] += QUANTITY;
                                            totalbrandQuantityContainer[2, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "3")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[2] + QUANTITY) == 20) || ((AdidasStock[2] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[2] += QUANTITY;
                                            totalbrandQuantityContainer[2, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[2] + QUANTITY) == 20) || ((AdidasStockTwo[2] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[2] += QUANTITY;
                                            totalbrandQuantityContainer[2, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[2] + QUANTITY) == 20) || ((AdidasStockThree[2] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[2] += QUANTITY;
                                            totalbrandQuantityContainer[2, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "4")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[3] + QUANTITY) == 20) || ((AdidasStock[3] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[3] += QUANTITY;
                                            totalbrandQuantityContainer[2, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[3] + QUANTITY) == 20) || ((AdidasStockTwo[3] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[3] += QUANTITY;
                                            totalbrandQuantityContainer[2, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((LevisStockThree[3] + QUANTITY) == 20) || ((LevisStockThree[3] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[3] += QUANTITY;
                                            totalbrandQuantityContainer[2, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "5")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[4] + QUANTITY) == 20) || ((AdidasStock[4] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[4] += QUANTITY;
                                            totalbrandQuantityContainer[2, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[4] + QUANTITY) == 20) || ((AdidasStockTwo[4] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[4] += QUANTITY;
                                            totalbrandQuantityContainer[1, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[4] + QUANTITY) == 20) || ((AdidasStockThree[4] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[4] += QUANTITY;
                                            totalbrandQuantityContainer[2, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "6")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStock[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[5] + QUANTITY) == 20) || ((AdidasStock[5] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[5] += QUANTITY;
                                            totalbrandQuantityContainer[2, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((LevisStockTwo[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[5] + QUANTITY) == 20) || ((AdidasStockTwo[5] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[5] += QUANTITY;
                                            totalbrandQuantityContainer[2, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[5] + QUANTITY) == 20) || ((AdidasStockThree[5] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[5] += QUANTITY;
                                            totalbrandQuantityContainer[5, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "7")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[6] + QUANTITY) == 20) || ((AdidasStock[6] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[6] += QUANTITY;
                                            totalbrandQuantityContainer[2, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[6] + QUANTITY) == 20) || ((AdidasStockTwo[6] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[6] += QUANTITY;
                                            totalbrandQuantityContainer[2, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[6] + QUANTITY) == 20) || ((AdidasStockThree[6] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[6] += QUANTITY;
                                            totalbrandQuantityContainer[2, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "8")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[7] + QUANTITY) == 20) || ((AdidasStock[7] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[7] += QUANTITY;
                                            totalbrandQuantityContainer[2, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[7] + QUANTITY) == 20) || ((AdidasStockTwo[7] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[7] += QUANTITY;
                                            totalbrandQuantityContainer[2, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[7] + QUANTITY) == 20) || ((AdidasStockThree[7] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[7] += QUANTITY;
                                            totalbrandQuantityContainer[2, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "9")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[8] + QUANTITY) == 20) || ((AdidasStock[8] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[8] += QUANTITY;
                                            totalbrandQuantityContainer[1, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[2] + QUANTITY) == 20) || ((AdidasStockTwo[8] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[8] += QUANTITY;
                                            totalbrandQuantityContainer[2, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[8] + QUANTITY) == 20) || ((AdidasStockThree[8] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[8] += QUANTITY;
                                            totalbrandQuantityContainer[2, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "10")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (AdidasStock[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStock[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStock[9] + QUANTITY) == 20) || ((AdidasStock[9] + QUANTITY) <= 20))
                                        {
                                            AdidasStock[9] += QUANTITY;
                                            totalbrandQuantityContainer[2, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (AdidasStockTwo[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockTwo[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockTwo[9] + QUANTITY) == 20) || ((AdidasStockTwo[9] + QUANTITY) <= 20))
                                        {
                                            AdidasStockTwo[9] += QUANTITY;
                                            totalbrandQuantityContainer[2, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockThree[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((AdidasStockThree[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((AdidasStockThree[9] + QUANTITY) == 20) || ((AdidasStockThree[9] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[9] += QUANTITY;
                                            totalbrandQuantityContainer[2, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }

            } else if (checkforStockInput == 4) {
                for (; ; )
                {
                    Console.Write("please select the stock item you want:");
                    globalquestion = Convert.ToString(Console.ReadLine());
                    if (globalquestion == "1")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstock[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[0] + QUANTITY) == 20) || ((trivalstock[0] + QUANTITY) <= 20))
                                        {
                                            trivalstock[0] += QUANTITY;
                                            totalbrandQuantityContainer[3, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[0] + QUANTITY) == 20) || ((trivalstockTwo[0] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[0] += QUANTITY;
                                            totalbrandQuantityContainer[3, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[0] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[0] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[0] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[0] + QUANTITY) == 20) || ((trivalstockThree[0] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[0] += QUANTITY;
                                            totalbrandQuantityContainer[3, 0] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "2")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (LevisStock[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[1] + QUANTITY) == 20) || ((trivalstock[1] + QUANTITY) <= 20))
                                        {
                                            trivalstock[1] += QUANTITY;
                                            totalbrandQuantityContainer[3, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[1] + QUANTITY) == 20) || ((trivalstockTwo[1] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[1] += QUANTITY;
                                            totalbrandQuantityContainer[2, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[1] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[1] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[1] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[1] + QUANTITY) == 20) || ((trivalstockThree[1] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[1] += QUANTITY;
                                            totalbrandQuantityContainer[2, 1] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "3")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[2] + QUANTITY) == 20) || ((trivalstock[2] + QUANTITY) <= 20))
                                        {
                                            trivalstock[2] += QUANTITY;
                                            totalbrandQuantityContainer[3, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[2] + QUANTITY) == 20) || ((trivalstockTwo[2] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[2] += QUANTITY;
                                            totalbrandQuantityContainer[3, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[2] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[2] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[2] + QUANTITY) == 20) || ((trivalstockThree[2] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[2] += QUANTITY;
                                            totalbrandQuantityContainer[2, 2] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "4")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstock[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[3] + QUANTITY) == 20) || ((trivalstock[3] + QUANTITY) <= 20))
                                        {
                                            trivalstock[3] += QUANTITY;
                                            totalbrandQuantityContainer[3, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[3] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[3] + QUANTITY) == 20) || ((trivalstockTwo[3] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[3] += QUANTITY;
                                            totalbrandQuantityContainer[3, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (AdidasStockThree[2] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[3] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[3] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[3] + QUANTITY) == 20) || ((trivalstockThree[3] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[3] += QUANTITY;
                                            totalbrandQuantityContainer[3, 3] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "5")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstock[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[4] + QUANTITY) == 20) || ((trivalstock[4] + QUANTITY) <= 20))
                                        {
                                            trivalstock[4] += QUANTITY;
                                            totalbrandQuantityContainer[3, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStockTwo[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[4] + QUANTITY) == 20) || ((trivalstockTwo[4] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[4] += QUANTITY;
                                            totalbrandQuantityContainer[3, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[4] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[4] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[4] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[4] + QUANTITY) == 20) || ((trivalstockThree[4] + QUANTITY) <= 20))
                                        {
                                            AdidasStockThree[4] += QUANTITY;
                                            totalbrandQuantityContainer[4, 4] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "6")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstock[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[5] + QUANTITY) == 20) || ((trivalstock[5] + QUANTITY) <= 20))
                                        {
                                            trivalstock[5] += QUANTITY;
                                            totalbrandQuantityContainer[3, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[5] + QUANTITY) == 20) || ((trivalstockTwo[5] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[5] += QUANTITY;
                                            totalbrandQuantityContainer[2, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[5] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[5] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[5] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[5] + QUANTITY) == 20) || ((trivalstockThree[5] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[5] += QUANTITY;
                                            totalbrandQuantityContainer[5, 5] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "7")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (AdidasStock[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[6] + QUANTITY) == 20) || ((trivalstock[6] + QUANTITY) <= 20))
                                        {
                                            trivalstock[6] += QUANTITY;
                                            totalbrandQuantityContainer[3, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[6] + QUANTITY) == 20) || ((trivalstockTwo[6] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[6] += QUANTITY;
                                            totalbrandQuantityContainer[3, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[6] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[6] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[6] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[6] + QUANTITY) == 20) || ((trivalstockThree[6] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[6] += QUANTITY;
                                            totalbrandQuantityContainer[4, 6] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "8")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstockTwo[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstock[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[7] + QUANTITY) == 20) || ((trivalstock[7] + QUANTITY) <= 20))
                                        {
                                            trivalstock[7] += QUANTITY;
                                            totalbrandQuantityContainer[4, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[7] + QUANTITY) == 20) || ((trivalstockTwo[7] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[7] += QUANTITY;
                                            totalbrandQuantityContainer[3, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[7] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[7] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[7] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[7] + QUANTITY) == 20) || ((trivalstockThree[7] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[7] += QUANTITY;
                                            totalbrandQuantityContainer[3, 7] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "9")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstock[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[8] + QUANTITY) == 20) || ((trivalstock[8] + QUANTITY) <= 20))
                                        {
                                            trivalstock[8] += QUANTITY;
                                            totalbrandQuantityContainer[3, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[2] + QUANTITY) == 20) || ((trivalstockTwo[8] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[8] += QUANTITY;
                                            totalbrandQuantityContainer[3, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[8] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[8] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[8] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[8] + QUANTITY) == 20) || ((trivalstockThree[8] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[8] += QUANTITY;
                                            totalbrandQuantityContainer[3, 8] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else if (globalquestion == "10")
                    {
                        Console.WriteLine("1. Small");
                        Console.WriteLine("2. Medium");
                        Console.WriteLine("3. Large");
                        for (; ; )
                        {

                        reapeatSize:
                            Console.Write("What size you want:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                if (trivalstock[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstock[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstock[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstock[9] + QUANTITY) == 20) || ((trivalstock[9] + QUANTITY) <= 20))
                                        {
                                            trivalstock[9] += QUANTITY;
                                            totalbrandQuantityContainer[3, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "2")
                            {
                                if (trivalstockTwo[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockTwo[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockTwo[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockTwo[9] + QUANTITY) == 20) || ((trivalstockTwo[9] + QUANTITY) <= 20))
                                        {
                                            trivalstockTwo[9] += QUANTITY;
                                            totalbrandQuantityContainer[3, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else if (globalquestion == "3")
                            {
                                if (trivalstockThree[9] == 20)
                                {
                                    Console.WriteLine("this item stock is full");
                                    Console.WriteLine();
                                    Addstock();
                                    break;
                                }
                                else if (trivalstockThree[9] < 20)
                                {
                                    for (; ; )
                                    {
                                        Console.Write("How Many Quantity ?:");
                                        globalquestion = Convert.ToString(Console.ReadLine());
                                        QUANTITY = Convert.ToInt32(globalquestion);
                                        if ((trivalstockThree[9] + QUANTITY) > 20)
                                        {
                                            Console.WriteLine("Your quantiy are higher to your maximum stock");
                                            Console.WriteLine("please repeat!!");
                                        }
                                        else if (((trivalstockThree[9] + QUANTITY) == 20) || ((trivalstockThree[9] + QUANTITY) <= 20))
                                        {
                                            trivalstockThree[9] += QUANTITY;
                                            totalbrandQuantityContainer[3, 9] += QUANTITY;
                                            Console.WriteLine("the quantity are now change");
                                            Console.WriteLine("1. Go back to Main Screen");
                                            Console.WriteLine("2 . Go back to brands");
                                            while (true)
                                            {
                                                Console.Write("choose a number on above statement:");
                                                globalquestion = Convert.ToString(Console.ReadLine());

                                                if (globalquestion == "1")
                                                {
                                                    Console.Clear();
                                                    main();
                                                    break;
                                                }
                                                else if (globalquestion == "2")
                                                {
                                                    Console.Clear();
                                                    brand();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid input");
                                                }
                                            }
                                            break;
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                goto reapeatSize;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }

            
        }
        public static void Sales()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");
            string path = @"C:\Users\Public\Sales.txt";

            Console.WriteLine("Your Sales is now:" + finalbalace);
            Console.WriteLine();
            Console.WriteLine("1. Go back to main screen");
            Console.WriteLine("2 . Get the Softcopy of your current Sales");

            while (true)
            {
                Console.Write("choose number on the above statement:");
                globalquestion = Convert.ToString(Console.ReadLine());
                if (globalquestion == "1")
                {
                    Console.Clear();
                    main();
                    break;
                }
                else if (globalquestion == "2")
                {
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                    
                            sw.WriteLine("Your Sales is now:" + finalbalace);
                            sw.WriteLine();
                            Console.WriteLine("the Sales softcopy has been generated in" + path);
                        }
                        Console.WriteLine("1. Go Back to Main Screen");

                        while (true)
                        {
                            Console.Write("choose the number in above statement:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                Console.Clear();
                                main();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                        }
                    }
                    else if (File.Exists(path))
                    {
                        Console.WriteLine("Sales Exist");
                        Console.WriteLine("Create Another Sales");
                        using (StreamWriter sw = File.CreateText(@"C:\Users\Public\Sales" + receiptcounter++ + ".txt"))
                        {

                            sw.WriteLine("Your Sales is now:" + finalbalace);
                            sw.WriteLine();
                            Console.WriteLine("the Sales softcopy has been generated in C:|Users|Public|Sales" + receiptcounter + ".txt");
                        }
                        Console.WriteLine("1. Go Back to Main Screen");

                        while (true)
                        {
                            Console.Write("choose the number in above statement:");
                            globalquestion = Convert.ToString(Console.ReadLine());

                            if (globalquestion == "1")
                            {
                                Console.Clear();
                                main();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
         
        }
        public static void getReceipt()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");
            if (totalorder == 0 ) {
                Console.WriteLine("\t\t\t\tyou dont have any order yet");
                Console.WriteLine("press anykey to add order");
                Console.ReadKey();
                Console.Clear();
                brand();
            }
            string path = @"C:\Users\Public\Receipt.txt";



            // list all the order
            Console.WriteLine("Menu\t\t\t\t\t\t\t\t\t\t\tPrice");
            /*for (index = 0; index < orderNameCapacity.Length; index++ )
            {
                if (orderPriceCapacity[index] <= 0) {
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tTOTAL");
                    Console.WriteLine("\t\t\t\t\t\t\t\t___________________");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t" + totalorder);
                    
                    break;
                }
                Console.WriteLine("["+ index +"]"+orderNameCapacity[index] + "\t\t\t\t\t" + orderPriceCapacity[index]);
                
            }*/
            bool checkforZero = false;
            bool checkforZeroTwo = false;
            int colscounter = 0;
            int totalCounter;
            
            for (index = 0; index < orderNameCapacity.Length; index++ )
            {
                if (orderNameCapacity[index] == null) {
                    Console.WriteLine("\t\t\t\t\t\t\t\t\tTOTAL");
                    Console.WriteLine("\t\t\t\t\t\t\t\t___________________");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t" + totalorder);
                    break;
                }
                concantenateMenuAndSize[index] = orderNameCapacity[index] + "\t\t\t"+ "PHP " + orderPriceCapacity[index] + ".00";
                Console.WriteLine(concantenateMenuAndSize[index]);

            }
                
            

           
    
            Console.WriteLine();
           
            
            Console.WriteLine("1. Go back to main screen");
            Console.WriteLine("2 . Get the Softcopy of your Receipt");

            while (true)
            {
                Console.Write("choose number on the above statement:");
                globalquestion = Convert.ToString(Console.ReadLine());
                if (globalquestion == "1")
                {
                    Console.Clear();
                    main();
                    break;
                }
                else if (globalquestion == "2")
                {
                    while(true) {
                        Console.Write("Enter your payment:");
                        money = Convert.ToInt32(Console.ReadLine());
                        if (money >= totalorder)
                        {
                            
                            if (!File.Exists(path))
                            {
                                finalbalace = currentBalanceTotal;
                                using (StreamWriter sw = File.CreateText(path))
                                {

                                    Console.WriteLine("Menu\t\t\t\t\t\t\t\t\tPrice");
                                    for (index = 0; index < orderNameCapacity.Length; index++)
                                    {
                                        if (orderPriceCapacity[index] <= 0)
                                        {
                                            sw.WriteLine("\t\t\t\t\t\t\t\t\tTOTAL");
                                            sw.WriteLine("\t\t\t\t\t\t\t\t___________________");
                                            sw.WriteLine("\t\t\t\t\t\t\t\t\t" + totalorder);
                                            sw.WriteLine("payment:" +"PHP" + money + ".00");
                                            sw.WriteLine("Change:" + "PHP" +(money - totalorder) + ".00");
                                            Console.WriteLine("payment:" +"PHP" + money + ".00");
                                            Console.WriteLine("change:" + "PHP" + (money - totalorder) + ".00");
                                            
                                            break;
                                        }
                                        sw.WriteLine("[" + index + "]" + orderNameCapacity[index] + "\t\t\t\t\t" + "PHP "+ orderPriceCapacity[index] + ".00");
                                        
                                    }
                                    totalorder = 0;
                                    for (index = 0; index < orderNameCapacity.Length; index++ )
                                    {
                                        orderNameCapacity[index] = null;
                                        orderPriceCapacity[index] = 0;
                                    }
                                }
                                
                                Console.WriteLine("the receipt has been generated  C:|Users|Public|Receipt.txt");
                                
                              

                                Console.WriteLine("1. Go Back to Main Screen");

                                while (true)
                                {
                                    Console.Write("choose the number in above statement:");
                                    globalquestion = Convert.ToString(Console.ReadLine());

                                    if (globalquestion == "1")
                                    {
                                        Console.Clear();
                                        main();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }
                            }
                            else if (File.Exists(path))
                            {

                                
                                finalbalace = currentBalanceTotal;
                                receiptcounter++;
                                Console.WriteLine("Receipt Exist");
                                Console.WriteLine("Create Another Receipt");
                                

                                
                  
                                using (StreamWriter sw = File.CreateText(@"C:\Users\Public\Receipt" + receiptcounter + ".txt"))
                                {
                                    for (index = 0; index < orderNameCapacity.Length; index++)
                                    {
                                        if (orderPriceCapacity[index] <= 0)
                                        {
                                            sw.WriteLine("\t\t\t\t\t\t\t\t\tTOTAL");
                                            sw.WriteLine("\t\t\t\t\t\t\t\t___________________");
                                            sw.WriteLine("\t\t\t\t\t\t\t\t\t" + totalorder);
                                            sw.WriteLine("payment:" + "PHP " + money + ".00");
                                            sw.WriteLine("Change:" + "PHP " + (money - totalorder)+ ".00");
                                            Console.WriteLine("payment:" + "PHP "+ money + ".00");
                                            Console.WriteLine("change:" + "PHP " +(money - totalorder) + ".00");
                                            break;
                                        }
                                        sw.WriteLine("[" + index + "]" + orderNameCapacity[index] + "\t\t\t\t\t" + "PHP "+orderPriceCapacity[index] + ".00");
                                        
                                    }
                                }
                                Console.WriteLine("the receipt has been generated  C:|Users|Public|Receipt" + receiptcounter +".txt");

                                totalorder = 0;
                                for (index = 0; index < orderNameCapacity.Length; index++)
                                {
                                    orderNameCapacity[index] = null;
                                    orderPriceCapacity[index] = 0;
                                }    
                                
                                counter = 0;
                                Console.WriteLine("1. Go Back to Main Screen");

                                while (true)
                                {
                                    Console.Write("choose the number in above statement:");
                                    globalquestion = Convert.ToString(Console.ReadLine());

                                    if (globalquestion == "1")
                                    {
                                        Console.Clear();
                                        main();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input");
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                            }
                        } else if (money < totalorder) {
                            Console.WriteLine("Insufficient payment");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }



                    }
                    
                }
            }
        }
        public static void main()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("");
            Console.WriteLine("Order is now:" + counter);
            Console.WriteLine("1. TRANSACTION");
            Console.WriteLine("2. STOCK");
            Console.WriteLine("3. SALES");
            Console.WriteLine("4. RECEIPT");
            Console.WriteLine("5. LOGOUT");
  
            while (true)
            {
                Console.Write("Enter a Number: ");
                mainS = Convert.ToString(Console.ReadLine());
                if (mainS == "1")
                {
                    Console.Clear();
                    brand();
                    break;    
                }
                else if (mainS == "2")
                {
                    Console.Clear();
                    ST();
                    break;
                }
                else if (mainS == "3")
                {
                    Console.Clear();
                    Sales();
                    break;
                }
                else if (mainS == "4")
                {
                    Console.Clear();
                    getReceipt();
                    break;
                } else if (mainS == "5") {
                    Console.Clear();
                    LogOut();
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT !");

                    // main();
                }
            }
        }

        public static void LogOut()
        {
            Console.Clear();
            Console.WriteLine("1 .Yes");
            Console.WriteLine("2. No");
            for (; ; )
            {
                Console.Write("Do you want to log out:?");
                globalquestion = Convert.ToString(Console.ReadLine());

                if (globalquestion == "1")
                {
                    balance = 0;
                    Console.Clear();
                    Login();
                    break;
                }
                else if (globalquestion == "2")
                {
                    Console.Clear();
                    main();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!!");
                }
            }
        }
        public static void Login()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 .Yes");
            Console.WriteLine("2. No");
            while(true) {
                Console.Write("Go back:?");
                globalquestion = Convert.ToString(Console.ReadLine());

                if (globalquestion == "1")
                {
                    Console.Clear();
                    security();
                    break;
                } else if (globalquestion == "2") {
                    break;
                } else {
                    Console.WriteLine("Invalid input!");
                }
            }
            login:
            Console.Clear();
            Console.WriteLine("Please Log in\n");
            Console.Write("UserName: ");
            UserName = Convert.ToString(Console.ReadLine());
            Console.Write("Password:");
            Pass();


            if ((UserName == "Admin" || UserName == "admin" || UserName == "ADMIN") &&
                (Password == pass || Password == "ADMIN" || Password == "admin" || (PasswordTrue == "admin" || PasswordTrue == "Admin" || PasswordTrue == "ADMIN")))
            {
                Console.WriteLine("LOG-IN SUCCESSFULLY!");
                Console.WriteLine("Press Any key to continue...");
                Console.ReadLine();
                main();

            }
            else
            {
                Console.Write("INVALID ACCOUNT");
                Console.ReadLine();
                goto login;
            }
        }

        public static void forgotpassword () {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1 .Yes");
            Console.WriteLine("2. Generate Password");
            while(true) {
                Console.Write("log in?:");
                globalquestion = Convert.ToString(Console.ReadLine());
                if (globalquestion == "1") {
                    Console.Clear();
                    Login();
                    break;
                }
                else if (globalquestion == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            
            string path = @"C:\Users\Public\Password.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Username:" + pass);
                    sw.WriteLine("Password:" + pass);

                }
                Console.WriteLine("the Password has been generated  C:|Users|Public|Password.txt");
                
                passwordcounter++;
            }
            else if (File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(@"C:\Users\Public\Password" + passwordcounter + ".txt"))
                {
                    sw.WriteLine("Username:" + UserName);
                    sw.WriteLine("Password:" + pass);

                }
                Console.WriteLine("the Password has been generated  C:|Users|Public|Password"+ passwordcounter +".txt");
            }
            Console.WriteLine("1 . Back");
            while(true) {
                Console.Write("Go Back To Log in:");
                globalquestion = Convert.ToString(Console.ReadLine());
                if (globalquestion == "1")
                {
                    Console.Clear();
                    Login();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
                               
        }
        public static void security() {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("          SiGNATURE CLOTHES");
            Console.WriteLine("              (for girl)");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1. Forgot Password?");
            Console.WriteLine("2. login");

            while (true) {
                Console.Write("choose a number on above statement:");
                globalquestion = Convert.ToString(Console.ReadLine());
                if (globalquestion == "1") {
                    Console.Clear();
                    forgotpassword();
                    break;
                } else if (globalquestion == "2") {
                    Console.Clear();
                    Login();
                    break;
                } else {
                    Console.WriteLine("Invalid input!!");
                }
            }
        }
        static void Main(string[] args)
        {
            
            security();
        }
    }
}
