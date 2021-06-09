using System;
using MySql.Data.MySqlClient;


namespace JajanBoba
{
    class MenuUserInterface
    {
        public static void MainMenu()
        {
            Console.WriteLine("\tMain Menu");
            Console.WriteLine("1. Tambah pesanan pelanggan");
            Console.WriteLine("2. Riwayat database Pesanan");
            Console.WriteLine("3. Log Out");
            Console.Write("Masukkan pilihan :");
        }

        public static void DrinkMenu()
        {
            Connect conn = new Connect();
            using (conn.Connection)
            {
                try
                {
                    conn.Connection.Open();

                    MySqlCommand command = conn.Connection.CreateCommand();
                    command.CommandText = System.Data.CommandType.Text.ToString();
                    command.CommandText = "Select * from tb_menu";

                    MySqlDataReader reader = command.ExecuteReader();

                    var data = "\tMenu Minuman\nNo\tNama Minuman\t\tUkuran";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            data += Environment.NewLine + reader.GetInt32(0) + " |\t" + reader.GetString(1) + "\t| "
                            + reader.GetString(2);
                        }
                    }
                    Console.WriteLine(data);

                    conn.Connection.Close();
                    Console.WriteLine("Masukkan minuman pilihan Customer : ");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    System.Console.WriteLine("Error!" + ex.Message.ToString());
                }

            }

        }
        public string OptionExe(out int totalPrice)
        {
            string drinkOrder = "";
            DrinkMenu();
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BigSize cup1 = new BigSize();
                    cup1.AddDrink(new DrinkFlavor(Flavor.Milktea));
                    cup1.AddTopping(new Pearl());
                    Console.WriteLine(cup1.OrderInfo());
                    drinkOrder = "Milktea with Pearl Big Size";
                    totalPrice = cup1.CalculateDrinkPrice();
                    break;
                case "2":
                    BigSize cup2 = new BigSize();
                    cup2.AddDrink(new DrinkFlavor(Flavor.Thaitea));
                    cup2.AddTopping(new Pudding());
                     Console.WriteLine(cup2.OrderInfo());
                    drinkOrder = "Thaitea with Pudding Big Size";
                    totalPrice = cup2.CalculateDrinkPrice();
                    break;
                case "3":
                    BigSize cup3 = new BigSize();
                    cup3.AddDrink(new DrinkFlavor(Flavor.Matcha));
                    cup3.AddTopping(new GrassJelly());
                    Console.WriteLine(cup3.OrderInfo());
                    drinkOrder = "Matcha with Grass Jelly Big Size";
                    totalPrice = cup3.CalculateDrinkPrice();
                    break;
                case "4":
                    RegularSize cup4 = new RegularSize();
                    cup4.AddDrink(new DrinkFlavor(Flavor.Milktea));
                    cup4.AddTopping(new Pearl());
                    Console.WriteLine(cup4.OrderInfo());
                    drinkOrder = "Milktea with Pearl Regular Size";
                    totalPrice = cup4.CalculateDrinkPrice();
                    break;
                case "5":
                    RegularSize cup5 = new RegularSize();
                    cup5.AddDrink(new DrinkFlavor(Flavor.Thaitea));
                    cup5.AddTopping(new Pudding());
                    Console.WriteLine(cup5.OrderInfo());
                    drinkOrder = "Thaitea with Pudding Regular Size";
                    totalPrice = cup5.CalculateDrinkPrice();
                    break;
                case "6":
                    RegularSize cup6 = new RegularSize();
                    cup6.AddDrink(new DrinkFlavor(Flavor.Matcha));
                    cup6.AddTopping(new GrassJelly());
                    Console.WriteLine(cup6.OrderInfo());
                    drinkOrder = "Matcha with Grass Jelly Regular Size";
                    totalPrice = cup6.CalculateDrinkPrice();
                    break;

                case "7":
                    SmallSize cup7 = new SmallSize();
                    cup7.AddDrink(new DrinkFlavor(Flavor.Milktea));
                    cup7.AddTopping(new Pearl());
                    Console.WriteLine(cup7.OrderInfo());
                    drinkOrder = "Milktea with Pearl Small Size";
                    totalPrice = cup7.CalculateDrinkPrice();
                    break;

                case "8":
                    SmallSize cup8 = new SmallSize();
                    cup8.AddDrink(new DrinkFlavor(Flavor.Thaitea));
                    cup8.AddTopping(new Pudding());
                    Console.WriteLine(cup8.OrderInfo());
                    drinkOrder = "Thaitea with Pudding Small Size";
                    totalPrice = cup8.CalculateDrinkPrice();
                    break;
                case "9":
                    SmallSize cup9 = new SmallSize();
                    cup9.AddDrink(new DrinkFlavor(Flavor.Matcha));
                    cup9.AddTopping(new GrassJelly());
                    Console.WriteLine(cup9.OrderInfo());
                    drinkOrder = "Matcha with Grass Jelly Small Size";
                    totalPrice = cup9.CalculateDrinkPrice();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia");
                    drinkOrder = "0";
                    totalPrice = 0;
                    break;

            }
            return drinkOrder;
        }
        public void OptionExe2()
        {

            while (true)
            {
                MainMenu();

                var option2 = Console.ReadLine();

                switch (option2)
                {
                    case "1":
                        Console.Clear();
                        int totalPrice = 0;
                        var customerOrder = new Customer();
                        Console.Write("Masukan nama pelanggan :");
                        customerOrder.Name = Console.ReadLine();
                        customerOrder.DrinkOrder = OptionExe(out totalPrice);

                        if (customerOrder.DrinkOrder == "0" && totalPrice ==0)
                        {
                            Console.WriteLine("Pesanan gagal ditambahkan");

                        }
                        else
                        {
                            Console.WriteLine("Masukkan uang pelanggan :");
                            int uang = Convert.ToInt32(Console.ReadLine());
                            if (uang < totalPrice)
                            {
                                while (uang < totalPrice)
                                {
                                    Console.WriteLine("Masukkan uang pelanggan :");
                                    uang = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            if (uang >= totalPrice)
                            {
                                CalculateChangeMoney cal = new CalculateChangeMoney();
                                uang = cal.CalculateChange(uang, totalPrice);
                                Console.WriteLine($"Uang kembalian : {uang}");
                            }
                            Data input = new Data();
                            input.Input(customerOrder.Name, customerOrder.DrinkOrder, totalPrice);
                        }

                        break;
                    case "2":
                        Console.Clear();
                        Data data = new Data();
                        data.Output();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Log Out dari Akun");
                        Login login = new Login();
                        login.login();
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak tersedia");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

    }
}