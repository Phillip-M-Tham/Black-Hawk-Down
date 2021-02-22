using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackHawkDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("October 3, 1993: Mogadishu, Somalia Operation Gothic Serpent");
            Console.WriteLine("HIT ENTER TO INIT FRIENDLY FORCES");
            Console.ReadKey();
            //inits Area of operation- 160 friendlys and all vecs,160 m16s, 2000 insurgents, 2000 aks
            List<Vehicles> myvecs = new List<Vehicles>();
            string[,] OperationIrine = new string[300, 200];
            OperationIrine = initmap(OperationIrine);
            Blackhawk Super61 = new Blackhawk("S61");
            Super61.move(1, 1, OperationIrine);
            Blackhawk Super62 = new Blackhawk("S62");
            Super62.move(1, 2, OperationIrine);
            Blackhawk Super63 = new Blackhawk("S63");
            Super63.move(1, 3, OperationIrine);
            Blackhawk Super64 = new Blackhawk("S64");
            Super64.move(1, 4, OperationIrine);
            Blackhawk Super65 = new Blackhawk("S65");
            Super65.move(1, 5, OperationIrine);
            Blackhawk Super66 = new Blackhawk("S66");
            Super66.move(1, 6, OperationIrine);
            Blackhawk Super67 = new Blackhawk("S67");
            Super67.move(1, 7, OperationIrine);
            Blackhawk Super68 = new Blackhawk("S68");
            Super68.move(1, 8, OperationIrine);

            myvecs.Add(Super61);
            myvecs.Add(Super62);
            myvecs.Add(Super63);
            myvecs.Add(Super64);
            myvecs.Add(Super65);
            myvecs.Add(Super66);
            myvecs.Add(Super67);
            myvecs.Add(Super68);

            //LittleBird
            LittleBird Star41 = new LittleBird("St41");
            LittleBird Star42 = new LittleBird("St42");
            LittleBird Star43 = new LittleBird("St43");
            LittleBird Star44 = new LittleBird("St44");
            LittleBird Barber51 = new LittleBird("Bbr51");
            LittleBird Barber52 = new LittleBird("Bbr52");
            LittleBird Barber53 = new LittleBird("Bbr53");
            LittleBird Barber54 = new LittleBird("Bbr54");
            Star41.move(3, 1, OperationIrine);
            Star42.move(3, 2, OperationIrine);
            Star43.move(3, 3, OperationIrine);
            Star44.move(3, 4, OperationIrine);
            Barber51.move(3, 5, OperationIrine);
            Barber52.move(3, 6, OperationIrine);
            Barber53.move(3, 7, OperationIrine);
            Barber54.move(3, 8, OperationIrine);

            myvecs.Add(Star41);
            myvecs.Add(Star42);
            myvecs.Add(Star43);
            myvecs.Add(Star44);
            myvecs.Add(Barber51);
            myvecs.Add(Barber52);
            myvecs.Add(Barber53);
            myvecs.Add(Barber54);

            //Humvees
            M1025 H1 = new M1025("H1");
            H1.move(5, 1, OperationIrine);
            M1025 H2 = new M1025("H2");
            H2.move(5, 2, OperationIrine);
            M1025 H3 = new M1025("H3");
            H3.move(5, 3, OperationIrine);
            M1025 H4 = new M1025("H4");
            H4.move(5, 4, OperationIrine);
            M1025 H5 = new M1025("H5");
            H5.move(5, 5, OperationIrine);
            M1025 H6 = new M1025("H6");
            H6.move(5, 6, OperationIrine);
            M1025 H7 = new M1025("H7");
            H7.move(5, 7, OperationIrine);
            M1025 H8 = new M1025("H8");
            H8.move(5, 8, OperationIrine);
            M1025 H9 = new M1025("H9");
            H9.move(5, 9, OperationIrine);

            myvecs.Add(H1);
            myvecs.Add(H2);
            myvecs.Add(H3);
            myvecs.Add(H4);
            myvecs.Add(H5);
            myvecs.Add(H6);
            myvecs.Add(H7);
            myvecs.Add(H8);
            myvecs.Add(H9);

            //Heavy Trucks
            M939 T1 = new M939("T1");
            M939 T2 = new M939("T2");
            M939 T3 = new M939("T3");
            T1.move(7, 1, OperationIrine);
            T2.move(7, 2, OperationIrine);
            T3.move(7, 3, OperationIrine);

            myvecs.Add(T1);
            myvecs.Add(T2);
            myvecs.Add(T3);
            updateMapAllvecs(myvecs, OperationIrine);

            //init Rifles
            M16[] friendlyrifles = Initfriendlyrifles();
            //init friendlys
            List<Ranger> friendlys = Initfriendlys(OperationIrine, friendlyrifles);
            Console.WriteLine($"There are {friendlys.Count()} Rangers, there are {Super61.DisplayCount()} Blackhawks, there are {Star41.DisplayCount()} LittleBirds, there are {H1.DisplayCount()} humvees, there are {T1.displaycount()} 5 Tons");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            printMap(OperationIrine);
            Console.WriteLine("HIT ENTER TO LOAD UP BLACKHAWKS");
            Console.ReadLine();

            //we can divide rangers into separate easier to control groups
            //BlackHawk teams
            List<Ranger> Super61Pilots = SplitRangers(friendlys, 0, 2);
            List<Ranger> Super62Pilots = SplitRangers(friendlys, 2, 4);
            List<Ranger> Super63Pilots = SplitRangers(friendlys, 4, 6);
            List<Ranger> Super64Pilots = SplitRangers(friendlys, 6, 8);
            List<Ranger> Super66Pilots = SplitRangers(friendlys, 158, 160);
            List<Ranger> Stack1 = SplitRangers(friendlys, 8, 21);
            List<Ranger> Stack2 = SplitRangers(friendlys, 21, 34);
            List<Ranger> Stack3 = SplitRangers(friendlys, 34, 47);
            List<Ranger> Stack4 = SplitRangers(friendlys, 47, 60);
            LoadBlackHawkPilots(Super61, Super61Pilots, OperationIrine);
            LoadBlackHawkPilots(Super62, Super62Pilots, OperationIrine);
            LoadBlackHawkPilots(Super63, Super63Pilots, OperationIrine);
            LoadBlackHawkPilots(Super64, Super64Pilots, OperationIrine);
            LoadBlackHawkPilots(Super66, Super66Pilots, OperationIrine);
            LoadBlackHawkStacks(Super61, Stack1, OperationIrine);
            LoadBlackHawkStacks(Super62, Stack2, OperationIrine);
            LoadBlackHawkStacks(Super63, Stack3, OperationIrine);
            LoadBlackHawkStacks(Super64, Stack4, OperationIrine);

            printMap(OperationIrine);
            Console.WriteLine("HIT ENTER TO LOAD UP LITTLEBIRDS");
            Console.ReadLine();

            //LittleBird teams
            List<Ranger> Star41Pilots = SplitRangers(friendlys, 60, 62);
            List<Ranger> Star42Pilots = SplitRangers(friendlys, 62, 64);
            List<Ranger> Star43Pilots = SplitRangers(friendlys, 64, 66);
            List<Ranger> Star44Pilots = SplitRangers(friendlys, 66, 68);
            List<Ranger> Stack5 = SplitRangers(friendlys, 68, 72);
            List<Ranger> Stack6 = SplitRangers(friendlys, 72, 76);
            List<Ranger> Stack7 = SplitRangers(friendlys, 76, 80);
            List<Ranger> Stack8 = SplitRangers(friendlys, 80, 84);
            LoadLittleBirdPilots(Star41, Star41Pilots, OperationIrine);
            LoadLittleBirdPilots(Star42, Star42Pilots, OperationIrine);
            LoadLittleBirdPilots(Star43, Star43Pilots, OperationIrine);
            LoadLittleBirdPilots(Star44, Star44Pilots, OperationIrine);
            LoadLittleBirdStack(Star41, Stack5, OperationIrine);
            LoadLittleBirdStack(Star42, Stack6, OperationIrine);
            LoadLittleBirdStack(Star43, Stack7, OperationIrine);
            LoadLittleBirdStack(Star44, Stack8, OperationIrine);

            printMap(OperationIrine);
            Console.WriteLine("HIT ENTER TO LOAD UP HUMVEES");
            Console.ReadLine();


            //Humvee teams
            List<Ranger> H1Stack = SplitRangers(friendlys, 84, 89);
            List<Ranger> H2Stack = SplitRangers(friendlys, 89, 94);
            List<Ranger> H3Stack = SplitRangers(friendlys, 94, 99);
            List<Ranger> H4Stack = SplitRangers(friendlys, 99, 104);
            List<Ranger> H5Stack = SplitRangers(friendlys, 104, 109);
            List<Ranger> H6Stack = SplitRangers(friendlys, 109, 114);
            List<Ranger> H7Stack = SplitRangers(friendlys, 114, 119);
            List<Ranger> H8Stack = SplitRangers(friendlys, 119, 124);
            List<Ranger> H9Stack = SplitRangers(friendlys, 124, 129);
            LoadHumveeStack(H1, H1Stack, OperationIrine);
            LoadHumveeStack(H2, H2Stack, OperationIrine);
            LoadHumveeStack(H3, H3Stack, OperationIrine);
            LoadHumveeStack(H4, H4Stack, OperationIrine);
            LoadHumveeStack(H5, H5Stack, OperationIrine);
            LoadHumveeStack(H6, H6Stack, OperationIrine);
            LoadHumveeStack(H7, H7Stack, OperationIrine);
            LoadHumveeStack(H8, H8Stack, OperationIrine);
            LoadHumveeStack(H9, H9Stack, OperationIrine);

            printMap(OperationIrine);
            Console.WriteLine("HIT ENTER TO LOAD UP M939s");
            Console.ReadLine();

            //M939 teams
            List<Ranger> Truck1Stack = SplitRangers(friendlys, 129, 138);//9
            List<Ranger> Truck2Stack = SplitRangers(friendlys, 138, 148);//10
            List<Ranger> Truck3Stack = SplitRangers(friendlys, 148, 158);
            LoadTruckStacks(T1, Truck1Stack, OperationIrine);
            LoadTruckStacks(T2, Truck2Stack, OperationIrine);
            LoadTruckStacks(T3, Truck3Stack, OperationIrine);

            printMap(OperationIrine);


            Console.WriteLine("HIT ENTER TO INIT OPFOR");
            Console.ReadLine();

            //Init Aks and enemy
            AK[] EnemyRifles = InitEnemyRifles();
            RPG7[] EnemyRPGS = InitRPGs();
            List<Insurgent> Militia = InitEnemyForces(OperationIrine, EnemyRifles, EnemyRPGS);
            Insurgent MFA = new Insurgent("MFA");
            AK AK74 = new AK("AK74");
            MFA.pickupgun(AK74);
            MFA.move(200, 120, OperationIrine);


            List<Insurgent> TStack1 = SplitEnemys(Militia, 0, 1800);
            List<Insurgent> TStack2 = SplitEnemys(Militia, 180, 1820);
            List<Insurgent> TStack3 = SplitEnemys(Militia, 360, 1840);
            List<Insurgent> TStack4 = SplitEnemys(Militia, 540, 1860);
            List<Insurgent> TStack5 = SplitEnemys(Militia, 720, 1880);
            List<Insurgent> TStack6 = SplitEnemys(Militia, 900, 1900);
            List<Insurgent> TStack7 = SplitEnemys(Militia, 1080, 1920);
            List<Insurgent> TStack8 = SplitEnemys(Militia, 1260, 1940);
            List<Insurgent> TStack9 = SplitEnemys(Militia, 1440, 1960);
            List<Insurgent> TStack10 = SplitEnemys(Militia, 1620, 1980);

            List<Person> Allpeeps = new List<Person>();
            foreach (var r in friendlys)
            {
                Allpeeps.Add(r);
            }
            foreach (var t in Militia)
            {
                Allpeeps.Add(t);
            }

            ScatterEnemy(TStack1, OperationIrine);
            printMap(OperationIrine);

            //Start Advance
            Console.WriteLine("AT 1530 ALL LOADED VEHICLES START THE RAID");
            Super61.move(Super61.coordinatex + 10, Super61.coordinatey + 5, OperationIrine);
            Super62.move(Super62.coordinatex + 9, Super62.coordinatey + 4, OperationIrine);
            Super63.move(Super63.coordinatex + 8, Super63.coordinatey + 3, OperationIrine);
            Super64.move(Super64.coordinatex + 7, Super64.coordinatey + 2, OperationIrine);
            Super66.move(Super66.coordinatex + 6, Super64.coordinatey + 1, OperationIrine);
            Star41.move(Star41.coordinatex, Star41.coordinatey + 20, OperationIrine);
            Star42.move(Star42.coordinatex, Star42.coordinatey + 20, OperationIrine);
            Star43.move(Star43.coordinatex, Star43.coordinatey + 20, OperationIrine);
            Star44.move(Star44.coordinatex, Star44.coordinatey + 20, OperationIrine);
            H1.move(H1.coordinatex, H1.coordinatey + 15, OperationIrine);
            H2.move(H2.coordinatex, H2.coordinatey + 15, OperationIrine);
            H3.move(H3.coordinatex, H3.coordinatey + 15, OperationIrine);
            H4.move(H4.coordinatex, H4.coordinatey + 15, OperationIrine);
            H5.move(H5.coordinatex, H5.coordinatey + 15, OperationIrine);
            H6.move(H6.coordinatex, H6.coordinatey + 15, OperationIrine);
            H7.move(H7.coordinatex, H7.coordinatey + 15, OperationIrine);
            H8.move(H8.coordinatex, H8.coordinatey + 15, OperationIrine);
            H9.move(H9.coordinatex, H9.coordinatey + 15, OperationIrine);
            printMap(OperationIrine);

            Console.WriteLine("HIT ENTER TO CONTINUE TO TARGET BUILDING");
            Console.ReadLine();
            Super61.move(Super61.coordinatex + 20, Super61.coordinatey + 10, OperationIrine);
            Super62.move(Super62.coordinatex + 18, Super62.coordinatey + 8, OperationIrine);
            Super63.move(Super63.coordinatex + 16, Super63.coordinatey + 6, OperationIrine);
            Super64.move(Super64.coordinatex + 14, Super64.coordinatey + 4, OperationIrine);
            Super66.move(Super66.coordinatex + 12, Super64.coordinatey + 2, OperationIrine);
            Star41.move(Star41.coordinatex, Star41.coordinatey + 40, OperationIrine);
            Star42.move(Star42.coordinatex, Star42.coordinatey + 40, OperationIrine);
            Star43.move(Star43.coordinatex, Star43.coordinatey + 40, OperationIrine);
            Star44.move(Star44.coordinatex, Star44.coordinatey + 40, OperationIrine);
            H1.move(H1.coordinatex, H1.coordinatey + 35, OperationIrine);
            H2.move(H2.coordinatex, H2.coordinatey + 35, OperationIrine);
            H3.move(H3.coordinatex, H3.coordinatey + 35, OperationIrine);
            H4.move(H4.coordinatex, H4.coordinatey + 35, OperationIrine);
            H5.move(H5.coordinatex, H5.coordinatey + 35, OperationIrine);
            H6.move(H6.coordinatex, H6.coordinatey + 35, OperationIrine);
            H7.move(H7.coordinatex, H7.coordinatey + 35, OperationIrine);
            H8.move(H8.coordinatex, H8.coordinatey + 35, OperationIrine);
            H9.move(H9.coordinatex, H9.coordinatey + 35, OperationIrine);
            printMap(OperationIrine);

            //Turning right for vecs
            Super61.move(Super61.coordinatex + 20, Super61.coordinatey + 10, OperationIrine);
            Super62.move(Super62.coordinatex + 18, Super62.coordinatey + 8, OperationIrine);
            Super63.move(Super63.coordinatex + 16, Super63.coordinatey + 6, OperationIrine);
            Super64.move(Super64.coordinatex + 14, Super64.coordinatey + 4, OperationIrine);
            Super66.move(Super66.coordinatex + 12, Super66.coordinatey + 2, OperationIrine);
            Star41.move(Star41.coordinatex + 37, Star41.coordinatey, OperationIrine);
            Star42.move(Star42.coordinatex + 38, Star42.coordinatey, OperationIrine);
            Star43.move(Star43.coordinatex + 39, Star43.coordinatey, OperationIrine);
            Star44.move(Star44.coordinatex + 40, Star44.coordinatey, OperationIrine);
            H1.move(H1.coordinatex + 27, H1.coordinatey, OperationIrine);
            H2.move(H2.coordinatex + 28, H2.coordinatey, OperationIrine);
            H3.move(H3.coordinatex + 29, H3.coordinatey, OperationIrine);
            H4.move(H4.coordinatex + 30, H4.coordinatey, OperationIrine);
            H5.move(H5.coordinatex + 31, H5.coordinatey, OperationIrine);
            H6.move(H6.coordinatex + 32, H6.coordinatey, OperationIrine);
            H7.move(H7.coordinatex + 33, H7.coordinatey, OperationIrine);
            H8.move(H8.coordinatex + 34, H8.coordinatey, OperationIrine);
            H9.move(H9.coordinatex + 35, H9.coordinatey, OperationIrine);
            printMap(OperationIrine);

            Console.WriteLine("HIT ENTER TO CONTINUE TO TARGET BUILDING");
            Console.ReadLine();

            Super61.move(Super61.coordinatex + 20, Super61.coordinatey + 10, OperationIrine);
            Super62.move(Super62.coordinatex + 18, Super62.coordinatey + 8, OperationIrine);
            Super63.move(Super63.coordinatex + 16, Super63.coordinatey + 6, OperationIrine);
            Super64.move(Super64.coordinatex + 14, Super64.coordinatey + 4, OperationIrine);
            Super66.move(Super66.coordinatex + 12, Super66.coordinatey + 2, OperationIrine);
            Star41.move(41, Star41.coordinatey, OperationIrine);
            Star42.move(42, Star42.coordinatey, OperationIrine);
            Star43.move(43, Star43.coordinatey, OperationIrine);
            Star44.move(44, Star44.coordinatey, OperationIrine);
            H1.move(32, 59, OperationIrine);
            H2.move(33, 59, OperationIrine);
            H3.move(34, 59, OperationIrine);
            H4.move(35, 59, OperationIrine);
            H5.move(36, 59, OperationIrine);
            H6.move(37, 59, OperationIrine);
            H7.move(38, 59, OperationIrine);
            H8.move(39, 59, OperationIrine);
            H9.move(40, 59, OperationIrine);
            printMap(OperationIrine);

            Super61.move(Super61.coordinatex + 20, Super61.coordinatey + 10, OperationIrine);
            Super62.move(Super62.coordinatex + 18, Super62.coordinatey + 8, OperationIrine);
            Super63.move(Super63.coordinatex + 16, Super63.coordinatey + 6, OperationIrine);
            Super64.move(Super64.coordinatex + 14, Super64.coordinatey + 4, OperationIrine);
            Super66.move(Super66.coordinatex + 12, Super66.coordinatey + 2, OperationIrine);
            Star41.move(61, 64, OperationIrine);
            Star42.move(62, 64, OperationIrine);
            Star43.move(63, 64, OperationIrine);
            Star44.move(64, 64, OperationIrine);
            H1.move(52, 59, OperationIrine);
            H2.move(53, 59, OperationIrine);
            H3.move(54, 59, OperationIrine);
            H4.move(55, 59, OperationIrine);
            H5.move(56, 59, OperationIrine);
            H6.move(57, 59, OperationIrine);
            H7.move(58, 59, OperationIrine);
            H8.move(59, 59, OperationIrine);
            H9.move(60, 59, OperationIrine);

            printMap(OperationIrine);


            Super61.move(Super61.coordinatex + 20, Super61.coordinatey + 10, OperationIrine);
            Super62.move(Super62.coordinatex + 18, Super62.coordinatey + 8, OperationIrine);
            Super63.move(Super63.coordinatex + 16, Super63.coordinatey + 6, OperationIrine);
            Super64.move(Super64.coordinatex + 14, Super64.coordinatey + 4, OperationIrine);
            Super66.move(Super66.coordinatex + 12, Super66.coordinatey + 2, OperationIrine);
            Star41.move(81, 64, OperationIrine);
            Star42.move(82, 64, OperationIrine);
            Star43.move(83, 64, OperationIrine);
            Star44.move(84, 64, OperationIrine);
            H1.move(72, 59, OperationIrine);
            H2.move(73, 59, OperationIrine);
            H3.move(74, 59, OperationIrine);
            H4.move(75, 59, OperationIrine);
            H5.move(76, 59, OperationIrine);
            H6.move(77, 59, OperationIrine);
            H7.move(78, 59, OperationIrine);
            H8.move(79, 59, OperationIrine);
            H9.move(80, 59, OperationIrine);

            printMap(OperationIrine);

            Console.WriteLine("HIT ENTER TO CONTINUE TO TARGET BUILDING");
            Console.ReadLine();

            Super61.move(127, 61, OperationIrine);
            Super62.move(128, 61, OperationIrine);
            Super63.move(129, 61, OperationIrine);
            Super64.move(130, 61, OperationIrine);
            Super66.move(131, 61, OperationIrine);
            Star41.move(101, 64, OperationIrine);
            Star42.move(102, 64, OperationIrine);
            Star43.move(103, 64, OperationIrine);
            Star44.move(104, 64, OperationIrine);
            H1.move(92, 59, OperationIrine);
            H2.move(93, 59, OperationIrine);
            H3.move(94, 59, OperationIrine);
            H4.move(95, 59, OperationIrine);
            H5.move(96, 59, OperationIrine);
            H6.move(97, 59, OperationIrine);
            H7.move(98, 59, OperationIrine);
            H8.move(99, 59, OperationIrine);
            H9.move(100, 59, OperationIrine);

            printMap(OperationIrine);

            Super61.move(147, 61, OperationIrine);
            Super62.move(148, 61, OperationIrine);
            Super63.move(149, 61, OperationIrine);
            Super64.move(150, 61, OperationIrine);
            Super66.move(151, 61, OperationIrine);
            Star41.move(121, 64, OperationIrine);
            Star42.move(122, 64, OperationIrine);
            Star43.move(123, 64, OperationIrine);
            Star44.move(124, 64, OperationIrine);
            H1.move(122, 59, OperationIrine);
            H2.move(123, 59, OperationIrine);
            H3.move(124, 59, OperationIrine);
            H4.move(125, 59, OperationIrine);
            H5.move(126, 59, OperationIrine);
            H6.move(127, 59, OperationIrine);
            H7.move(128, 59, OperationIrine);
            H8.move(129, 59, OperationIrine);
            H9.move(130, 59, OperationIrine);

            printMap(OperationIrine);

            //Engagement starts
            Console.WriteLine("AT 1542 THEY REACH THE TARGET BUILDING AND ENGAGE THE ENEMY");
            Console.ReadLine();
            H1.move(142, 109, OperationIrine);
            H2.move(143, 109, OperationIrine);
            H3.move(144, 109, OperationIrine);
            H4.move(145, 109, OperationIrine);
            H5.move(146, 109, OperationIrine);
            H6.move(147, 109, OperationIrine);
            H7.move(148, 109, OperationIrine);
            H8.move(149, 109, OperationIrine);
            H9.move(150, 109, OperationIrine);
            Super61.move(MFA.coordinatex + 7, MFA.coordinatey + 7, OperationIrine);
            Super62.move(MFA.coordinatex + 7, MFA.coordinatey - 7, OperationIrine);
            Super63.move(MFA.coordinatex - 7, MFA.coordinatey + 7, OperationIrine);
            Super64.move(MFA.coordinatex - 13, MFA.coordinatey - 7, OperationIrine);
            Super66.move(MFA.coordinatex - 12, MFA.coordinatey + 12, OperationIrine);
            Star41.move(MFA.coordinatex + 3, MFA.coordinatey - 3, OperationIrine);
            Star42.move(MFA.coordinatex + 3, MFA.coordinatey + 3, OperationIrine);
            Star43.move(MFA.coordinatex - 3, MFA.coordinatey - 3, OperationIrine);
            Star44.move(MFA.coordinatex - 3, MFA.coordinatey + 3, OperationIrine);
            printMap(OperationIrine);

            foreach (var v in Stack1)
            {
                v.Rappel(Super61, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                v.Rappel(Super62, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                v.Rappel(Super63, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                v.Rappel(Super64, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                v.DismountLittleBirdPassenger(Star41, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
            }
            foreach (var v in Stack6)
            {
                v.DismountLittleBirdPassenger(Star42, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
            }
            foreach (var v in Stack7)
            {
                v.DismountLittleBirdPassenger(Star43, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
            }
            foreach (var v in Stack8)
            {
                v.DismountLittleBirdPassenger(Star44, OperationIrine);
                Person target = findnearestMilita(v, TStack1);
            }
            //updateAlldead(Allpeeps, OperationIrine);
            printMap(OperationIrine);
            Console.WriteLine("AT 1552 THE CONVOY ARRIVES AT THE OLYMPIC HOTEL");
            Console.ReadLine();
            H1.move(167, 120, OperationIrine);
            H2.move(168, 120, OperationIrine);
            H3.move(169, 120, OperationIrine);
            H4.move(170, 120, OperationIrine);
            H5.move(171, 120, OperationIrine);
            H6.move(172, 120, OperationIrine);
            H7.move(173, 120, OperationIrine);
            H8.move(174, 120, OperationIrine);
            H9.move(175, 120, OperationIrine);
            Star41.move(190, 165, OperationIrine);
            Star41.hover();
            Super61.move(200, 170, OperationIrine);
            Super61.hover();
            Star42.move(160, 65, OperationIrine);
            Star42.hover();
            Super62.move(170, 70, OperationIrine);
            Super62.hover();
            Star43.move(160, 135, OperationIrine);
            Star43.hover();
            Super63.move(170, 140, OperationIrine);
            Super63.hover();
            Star44.move(190, 65, OperationIrine);
            Star44.hover();
            Super64.move(200, 70, OperationIrine);
            Super64.hover();
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H7Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H8Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H9Stack)
            {
                Person target = findnearestMilita(r, TStack1);
                r.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);

            ScatterEnemy(TStack2, OperationIrine);
            H1.move(199, 118, OperationIrine);
            H2.move(199, 119, OperationIrine);
            H3.move(199, 120, OperationIrine);
            H4.move(199, 121, OperationIrine);
            H5.move(199, 122, OperationIrine);
            H6.move(199, 123, OperationIrine);
            H7.move(199, 124, OperationIrine);
            H8.move(199, 125, OperationIrine);
            H9.move(199, 126, OperationIrine);
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H7Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H8Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H9Stack)
            {
                Person target = findnearestMilita(r, TStack2);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, TStack2);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);
            Console.WriteLine("PRIVATE FIRST CLASS BLACKBURN FALLS OUT OF A BLACKHAWK AND 3 HUMVEES ESCORT HIM BACK TO BASE");
            Console.ReadLine();
            H7.move(175, 110, OperationIrine);
            H8.move(174, 110, OperationIrine);
            H9.move(173, 110, OperationIrine);
            ScatterEnemy(TStack9, OperationIrine);
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H7Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H8Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H9Stack)
            {
                Person target = findnearestMilita(r, TStack9);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, TStack9);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);


            Console.WriteLine("AT 1620 SUPER61 WAS SHOT DOWN BY A RPG-7");
            Console.ReadLine();

            foreach (var militia in TStack1)
            {
                if (militia.status != "KIA")
                {
                    foreach (var rocket in EnemyRPGS)
                    {
                        if (rocket.name == militia.primarygun.name)
                        {
                            if (Super61.status != "destroyed")
                            {
                                rocket.DestroyVec(Super61, OperationIrine);
                            }
                        }
                    }
                }
            }
            ScatterEnemy(TStack3, OperationIrine);
            ScatterEnemy(TStack4, OperationIrine);
            printMap(OperationIrine);

            //Console.ReadLine();
            H7.move(150, 110, OperationIrine);
            H8.move(149, 110, OperationIrine);
            H9.move(148, 110, OperationIrine);
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, TStack3);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, TStack4);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, TStack3);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, TStack4);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, TStack3);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, TStack4);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H7Stack)
            {
                Person target = findnearestMilita(r, TStack3);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H8Stack)
            {
                Person target = findnearestMilita(r, TStack4);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H9Stack)
            {
                Person target = findnearestMilita(r, TStack3);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, TStack4);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, TStack3);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, TStack4);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, TStack3);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, TStack4);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, TStack3);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, TStack4);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, TStack3);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);

            H7.move(125, 110, OperationIrine);
            H8.move(124, 110, OperationIrine);
            H9.move(123, 110, OperationIrine);
            ScatterEnemy(TStack5, OperationIrine);
            ScatterEnemy(TStack6, OperationIrine);


            printMap(OperationIrine);
            Console.WriteLine("AT 1640 SUPER64 WAS SHOT DOWN BY A RPG-7");
            Console.ReadLine();
            H7.move(100, 110, OperationIrine);
            H8.move(99, 110, OperationIrine);
            H9.move(98, 110, OperationIrine);
            Super64.move(210, 170, OperationIrine);
            foreach (var rockets in EnemyRPGS)
            {
                if (Super64.status == "destroyed")
                {
                    break;
                }
                if (rockets.Owner.status != "KIA")
                {
                    rockets.DestroyVec(Super64, OperationIrine);
                }
            }
            printMap(OperationIrine);
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, TStack5);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, TStack5);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, TStack5);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, TStack5);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, TStack6);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, TStack6);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, TStack4);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, TStack3);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, TStack3);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, TStack5);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, TStack6);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, TStack5);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, TStack6);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, TStack5);
                v.primarygun.shoot(target, OperationIrine);
            }
            //consolidate enemyforces
            List<Insurgent> Day1Survs = new List<Insurgent>();
            foreach (var t in TStack1)
            {
                if (t.status != "KIA")
                {
                    Day1Survs.Add(t);
                }
            }
            foreach (var t in TStack2)
            {
                if (t.status != "KIA")
                {
                    Day1Survs.Add(t);
                }
            }
            foreach (var t in TStack3)
            {
                if (t.status != "KIA")
                {
                    Day1Survs.Add(t);
                }
            }
            foreach (var t in TStack4)
            {
                if (t.status != "KIA")
                {
                    Day1Survs.Add(t);
                }
            }
            foreach (var t in TStack5)
            {
                if (t.status != "KIA")
                {
                    Day1Survs.Add(t);
                }
            }
            foreach (var t in TStack6)
            {
                if (t.status != "KIA")
                {
                    Day1Survs.Add(t);
                }
            }
            Console.WriteLine($"Day1 surivor count is {Day1Survs.Count()}");
            //consolidate friendlys
            List<Ranger> NeedsHelp = new List<Ranger>();
            foreach (var ranger in Stack1)
            {
                NeedsHelp.Add(ranger);
            }
            foreach (var ranger in Stack2)
            {
                NeedsHelp.Add(ranger);
            }
            foreach (var ranger in Stack3)
            {
                NeedsHelp.Add(ranger);
            }
            foreach (var ranger in Stack4)
            {
                NeedsHelp.Add(ranger);
            }
            foreach (var ranger in Stack5)
            {
                NeedsHelp.Add(ranger);
            }
            foreach (var ranger in Stack6)
            {
                NeedsHelp.Add(ranger);
            }
            foreach (var ranger in Stack7)
            {
                NeedsHelp.Add(ranger);
            }
            foreach (var ranger in Stack8)
            {
                NeedsHelp.Add(ranger);
            }
            ScatterEnemy(Day1Survs, OperationIrine);
            ScatterFriendlys(NeedsHelp, OperationIrine);
            H1.move(150, 110, OperationIrine);
            H2.move(151, 110, OperationIrine);
            H3.move(152, 110, OperationIrine);
            H4.move(153, 110, OperationIrine);
            H5.move(154, 110, OperationIrine);
            H6.move(155, 110, OperationIrine);
            H7.move(100, 110, OperationIrine);
            H8.move(99, 110, OperationIrine);
            H9.move(98, 110, OperationIrine);
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);

            int count = 0;
            //FIGHT THROUGH NIGHT
            foreach (var t in Day1Survs)
            {
                if (count >= 15)
                {
                    break;
                }
                if (t.status != "KIA")
                {
                    Person target = findnearestRanger(t, NeedsHelp);
                    t.primarygun.shoot(target, OperationIrine);
                    count++;
                }
            }
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, Day1Survs);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, Day1Survs);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);
            Console.WriteLine("0000 FIGHTING CONTINUES AROUND CRASH SITE 2");
            Console.ReadLine();
            H1.move(2, 10, OperationIrine);
            H2.move(3, 10, OperationIrine);
            H3.move(4, 10, OperationIrine);
            H4.move(5, 10, OperationIrine);
            H5.move(6, 10, OperationIrine);
            H6.move(7, 10, OperationIrine);
            H7.move(8, 10, OperationIrine);
            H8.move(9, 10, OperationIrine);
            H9.move(10, 10, OperationIrine);
            Star41.move(2, 12, OperationIrine);
            Star42.move(3, 12, OperationIrine);
            Star43.move(4, 12, OperationIrine);
            Star44.move(5, 12, OperationIrine);
            Super62.move(2, 14, OperationIrine);
            Super63.move(3, 14, OperationIrine);
            List<Insurgent> Day2Survive = new List<Insurgent>();
            foreach (var t in TStack9)
            {
                Day2Survive.Add(t);
            }
            foreach (var t in Day1Survs)
            {
                Day2Survive.Add(t);
            }
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);
            Console.WriteLine("0100 HEAVY FIGHTING CONTINUES AROUND CRASH SITE 2");
            Console.ReadLine();
            T1.move(83, 150, OperationIrine);
            T2.move(84, 150, OperationIrine);
            T3.move(85, 150, OperationIrine);
            H1.move(86, 150, OperationIrine);
            H2.move(87, 150, OperationIrine);
            H3.move(88, 150, OperationIrine);
            H4.move(89, 150, OperationIrine);
            H5.move(90, 150, OperationIrine);
            H6.move(91, 150, OperationIrine);
            H7.move(92, 150, OperationIrine);
            H8.move(93, 150, OperationIrine);
            H9.move(94, 150, OperationIrine);
            Star41.move(95, 150, OperationIrine);
            Star42.move(96, 150, OperationIrine);
            Star43.move(97, 150, OperationIrine);
            Star44.move(98, 150, OperationIrine);
            Super62.move(99, 150, OperationIrine);
            Super63.move(100, 150, OperationIrine);
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);
            Console.WriteLine("0200 RELIEF CONVOY ARRIVES AT CRASH SITE 2");
            Console.ReadLine();
            ScatterEnemy(Day2Survive, OperationIrine);
            T1.move(183, 160, OperationIrine);
            T2.move(184, 160, OperationIrine);
            T3.move(185, 160, OperationIrine);
            H1.move(186, 160, OperationIrine);
            H2.move(187, 160, OperationIrine);
            H3.move(188, 160, OperationIrine);
            H4.move(189, 160, OperationIrine);
            H5.move(190, 160, OperationIrine);
            H6.move(191, 160, OperationIrine);
            H7.move(192, 160, OperationIrine);
            H8.move(193, 160, OperationIrine);
            H9.move(194, 160, OperationIrine);
            Star41.move(195, 160, OperationIrine);
            Star42.move(196, 160, OperationIrine);
            Star43.move(197, 160, OperationIrine);
            Star44.move(198, 160, OperationIrine);
            Super62.move(199, 160, OperationIrine);
            Super63.move(200, 160, OperationIrine);
            foreach (var r in H1Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H2Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H3Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H4Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H5Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H6Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H7Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H8Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var r in H9Stack)
            {
                Person target = findnearestMilita(r, Day2Survive);
                r.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);
            Console.WriteLine("0400 FRIENDLY FORCES ARE IN THE MIDDLE OF MOGADISHU MILE, MOVING TOWARDS RZ ON FOOT");
            Console.ReadKey();
            T1.move(83, 160, OperationIrine);
            T2.move(84, 160, OperationIrine);
            T3.move(85, 160, OperationIrine);
            H1.move(86, 160, OperationIrine);
            H2.move(87, 160, OperationIrine);
            H3.move(88, 160, OperationIrine);
            H4.move(89, 160, OperationIrine);
            H5.move(90, 160, OperationIrine);
            H6.move(91, 160, OperationIrine);
            H7.move(92, 160, OperationIrine);
            H8.move(93, 160, OperationIrine);
            H9.move(94, 160, OperationIrine);
            Star41.move(95, 160, OperationIrine);
            Star42.move(96, 160, OperationIrine);
            Star43.move(97, 160, OperationIrine);
            Star44.move(98, 160, OperationIrine);
            Super62.move(99, 160, OperationIrine);
            Super63.move(100, 160, OperationIrine);
            ScatterFriendlys2(NeedsHelp, OperationIrine);
            foreach (var v in Stack1)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack2)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack3)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack4)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack5)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack6)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack7)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            foreach (var v in Stack8)
            {
                Person target = findnearestMilita(v, Day2Survive);
                v.primarygun.shoot(target, OperationIrine);
            }
            printMap(OperationIrine);

            Console.WriteLine("RANGERS REACH RZ AT 0630 OCTOBER 4 PRESS ENTER TO FINISH");
            Console.ReadKey();
        }

        private static void ScatterFriendlys2(List<Ranger> needsHelp, string[,] AO)
        {
            Random _random = new Random();

            foreach (var rangers in needsHelp)
            {
                if (rangers.status != "KIA")
                {
                    int ranX = _random.Next(110 - 15, 110 + 15);
                    int ranY = _random.Next(120 - 10, 120 + 10);
                    rangers.move(ranX, ranY, AO);
                }
            }
        }

        private static Person findnearestRanger(Insurgent t, List<Ranger> needsHelp)
        {
            Person Target = new Person();
            List<Ranger> ValidTargets = new List<Ranger>();
            List<double> distances = new List<double>();
            double distancetotarget = 0;
            double mindistance = 0;
            foreach (var target in needsHelp)
            {
                if (target.status != "KIA")
                {
                    distancetotarget = Math.Sqrt(((target.coordinatex - t.coordinatex) * (target.coordinatex - t.coordinatex)) + ((target.coordinatey - t.coordinatey) * (target.coordinatey - t.coordinatey)));
                    distances.Add(distancetotarget);
                    ValidTargets.Add(target);
                }
            }
            mindistance = distances.Min();
            foreach (var trgt in ValidTargets)
            {
                if (Math.Sqrt(((trgt.coordinatex - t.coordinatex) * (trgt.coordinatex - t.coordinatex)) + ((trgt.coordinatey - t.coordinatey) * (trgt.coordinatey - t.coordinatey))) == mindistance && t.status != "KIA")
                {
                    Target = trgt;
                    break;
                }
            }
            return Target;
        }

        private static void ScatterFriendlys(List<Ranger> needsHelp, string[,] AO)
        {
            Random _random = new Random();

            foreach (var rangers in needsHelp)
            {
                if (rangers.status != "KIA")
                {
                    int ranX = _random.Next(210 - 15, 210 + 15);
                    int ranY = _random.Next(170 - 10, 170 + 10);
                    rangers.move(ranX, ranY, AO);
                }
            }
        }

        private static void updateAlldead(List<Person> KIA, string[,] AO)
        {
            foreach (var dead in KIA)
            {
                for (int i = 0; i < 300; i++)
                {
                    for (int j = 0; j < 200; j++)
                    {
                        if (dead.coordinatex == i && dead.coordinatey == j && dead.status == "KIA")
                        {
                            AO[i, j] = "X";
                        }
                    }
                }
            }
        }

        private static Person findnearestMilita(Person ranger, List<Insurgent> militia)
        {
            Person Target = new Person();
            List<Insurgent> ValidTargets = new List<Insurgent>();
            List<double> distances = new List<double>();
            double distancetotarget = 0;
            double mindistance = 0;
            foreach (var target in militia)
            {
                if (target.status != "KIA")
                {
                    distancetotarget = Math.Sqrt(((target.coordinatex - ranger.coordinatex) * (target.coordinatex - ranger.coordinatex)) + ((target.coordinatey - ranger.coordinatey) * (target.coordinatey - ranger.coordinatey)));
                    distances.Add(distancetotarget);
                    ValidTargets.Add(target);
                }
            }
            mindistance = distances.Min();
            foreach (var t in ValidTargets)
            {
                if (Math.Sqrt(((t.coordinatex - ranger.coordinatex) * (t.coordinatex - ranger.coordinatex)) + ((t.coordinatey - ranger.coordinatey) * (t.coordinatey - ranger.coordinatey))) == mindistance && t.status != "KIA")
                {
                    Target = t;
                    break;
                }
            }
            return Target;
        }

        private static void ScatterEnemy(List<Insurgent> stack, string[,] AO)
        {
            Random _random = new Random();

            foreach (var ters in stack)
            {
                if (ters.status != "KIA")
                {
                    int ranX = _random.Next(200 - 50, 200 + 50);
                    int ranY = _random.Next(120 - 90, 120 + 50);
                    ters.move(ranX, ranY, AO);
                }
            }
        }

        private static List<Insurgent> SplitEnemys(List<Insurgent> militia, int start, int secondstart)
        {
            var subteam = new List<Insurgent>();
            for (int count = start; count < start + 180; count++)
            {
                subteam.Add(militia.ElementAt(count));
            }
            for (int count2 = secondstart; count2 < secondstart + 20; count2++)
            {
                subteam.Add(militia.ElementAt(count2));
            }
            return subteam;
        }

        private static RPG7[] InitRPGs()
        {
            RPG7[] launchers = new RPG7[200];
            for (int count = 0; count < 200; count++)
            {
                launchers[count] = new RPG7($"RPG7{count}");
            }
            return launchers;
        }

        private static void LoadTruckStacks(M939 truck, List<Ranger> stack, string[,] AO)
        {
            stack.ElementAt(0).Mount5TonOperator(truck, AO);
            stack.ElementAt(1).Mount5TonAOperator(truck, AO);
            foreach (var ranger in stack)
            {
                if (ranger.name != truck.Operator.name || ranger.name != truck.AOperator.name)
                {
                    ranger.Mount5TonPassenger(truck, AO);
                }
            }
        }

        private static void LoadHumveeStack(M1025 humvee, List<Ranger> stack, string[,] AO)
        {
            stack.ElementAt(0).MountHumveeOperator(humvee, AO);
            stack.ElementAt(1).MountHumveeAOPerator(humvee, AO);
            stack.ElementAt(2).MountGunner(humvee, AO);
            stack.ElementAt(3).MountHumveePassenger(humvee, AO);
            stack.ElementAt(4).MountHumveePassenger(humvee, AO);
        }

        private static void LoadLittleBirdStack(LittleBird helo, List<Ranger> stack, string[,] AO)
        {
            foreach (var ranger in stack)
            {
                ranger.MountLittleBirdPassenger(helo, AO);
            }
        }

        private static void LoadLittleBirdPilots(LittleBird helo, List<Ranger> Rangers, string[,] AO)
        {
            Rangers.ElementAt(0).MountLittleBirdOperator(helo, AO);
            Rangers.ElementAt(1).MountLittleBirdAOperator(helo, AO);
        }

        private static void LoadBlackHawkStacks(Blackhawk hawk, List<Ranger> stack, string[,] AO)
        {
            foreach (var ranger in stack)
            {
                ranger.MountBlackHawkPassenger(hawk, AO);
            }
        }

        private static void LoadBlackHawkPilots(Blackhawk hawk, List<Ranger> Rangers, string[,] AO)
        {
            Rangers.ElementAt(0).MountBlackHawkOperator(hawk, AO);
            Rangers.ElementAt(1).MountBlackHawkAOperator(hawk, AO);
        }

        private static List<Ranger> SplitRangers(List<Ranger> friendlys, int start, int stop)
        {
            var subteams = new List<Ranger>();
            for (int i = start; i < stop; i++)
            {
                subteams.Add(friendlys.ElementAt(i));
            }
            return subteams;
        }

        private static List<Insurgent> InitEnemyForces(string[,] AO, AK[] aks, RPG7[] rockets)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            var enemys = new List<Insurgent>();
            for (int i = 1; i < 2001; i++)
            {
                enemys.Add(new Insurgent($"I{i}"));
            }
            int x, y;
            int riflecount = 0;
            int rocketcount = 0;
            x = 280;
            y = 1;
            foreach (var militiamen in enemys)
            {
                if (y > 150)
                {
                    x++;
                    y = 0;
                }
                if (riflecount < 1800)
                {
                    militiamen.pickupgun(aks[riflecount]);
                }
                else
                {
                    militiamen.pickupgun(rockets[rocketcount]);
                    rocketcount++;
                }
                militiamen.move(x, y, AO);
                y++;
                riflecount++;
            }
            Console.ResetColor();
            return enemys;
        }

        private static AK[] InitEnemyRifles()
        {
            AK[] rifles = new AK[1800];
            for (int i = 0; i < 1800; i++)
            {
                rifles[i] = new AK($"AK47{i}");
            }
            Console.WriteLine($" There are {rifles.Count()} AKs");
            return rifles;
        }

        private static void updateMapAllvecs(List<Vehicles> myvecs, string[,] AO)
        {
            foreach (var vec in myvecs)
            {
                UpdateMapVs(vec, AO);
            }
        }

        private static M16[] Initfriendlyrifles()
        {
            M16[] rifles = new M16[160];
            for (int i = 0; i < 160; i++)
            {
                rifles[i] = new M16($"M16A4{i}");
            }
            Console.WriteLine($" There are {rifles.Count()} m16s");
            return rifles;
        }

        private static List<Ranger> Initfriendlys(string[,] AO, M16[] frifles)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var friendlys = new List<Ranger>();
            for (int i = 1; i < 161; i++)
            {
                friendlys.Add(new Ranger($"R{i}"));
            }
            int x, y;
            int riflecount = 0;
            x = 9;
            y = 1;
            foreach (var ranger in friendlys)
            {
                ranger.pickupgun(frifles[riflecount]);
                if (y > 31)
                {
                    y = 1;
                    x++;
                }
                ranger.move(x, y, AO);
                y++;
                riflecount++;
            }
            Console.ResetColor();
            return friendlys;
        }

        public static void UpdateMapPs(Person p, string[,] AO)
        {
            for (int row = 0; row < 300; row++)
            {
                for (int column = 0; column < 200; column++)
                {
                    if (row == p.coordinatex)
                    {
                        if (column == p.coordinatey)
                        {
                            if (p.myvec == null)
                            {
                                AO[row, column] = p.name;
                            }
                            else
                            {
                                AO[row, column] = "";
                            }
                        }
                    }
                }
            }
        }

        private static void printMap(string[,] AO)
        {
            Console.WriteLine("\n");
            for (int row = 0; row < 300; row++)
            {
                for (int column = 0; column < 200; column++)
                {
                    Console.Write(AO[row, column] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void UpdateMapVs(Vehicles v, string[,] AO)
        {
            for (int row = 0; row < 300; row++)
            {
                for (int column = 0; column < 200; column++)
                {
                    if (row == v.coordinatex)
                    {
                        if (column == v.coordinatey)
                        {
                            AO[row, column] = v.name;
                        }
                    }
                }
            }
        }

        private static string[,] initmap(string[,] AO)
        {
            for (int row = 0; row < 150; row++)
            {
                for (int column = 0; column < 100; column++)
                {
                    AO[row, column] = "";
                }
            }
            return AO;
        }
    }
}

