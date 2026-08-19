using System.Security.Cryptography;
int password_bit;
bool is_special_char;
int number_time;
string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
string digital = "0123456789";
string special_char = "@#$%&*!";
int bit=0;
string password_gen="";
int bit_is;
int gen_time = 0;
Console.WriteLine("欢迎使用 皓叶草密码生成器！");
Console.WriteLine("");
while (true)
{
    Console.Write("请输入要生成的位数(罗马数字,留空为8位): ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        password_bit = result;
        Console.WriteLine($"您的密码位数将生成{password_bit}位");
        break;
    }
    else if (Console.ReadLine() == "")
    {
        password_bit = 8;
        Console.WriteLine($"您的密码位数将生成{password_bit}位");
        break;
    }
    else { 
        Console.Clear();
        Console.WriteLine("位数输入错误,请重试!");
    }
}
Console.WriteLine("");
while (true)
{
    Console.Write("密码中是否要包含特殊字符(Y为是,N为否): ");
    if (Console.ReadLine().ToUpper() == "Y")
    {
        is_special_char = true;
        Console.WriteLine("好的,生成的密码将包含特殊字符");
        break;
    }
    else
    {
        is_special_char= false;
        Console.WriteLine("好的,生成的密码将不包含特殊字符");
        break;
    }
}
Console.WriteLine("");
while (true)
{
    Console.Write("请输入生成次数(罗马数字,留空为1次): ");
    if (int.TryParse(Console.ReadLine(), out int result))
    {
        number_time = result;
        Console.WriteLine($"好的,将生成{number_time}次密码");
        break;
    }
    else if (Console.ReadLine() == "")
    {
        number_time = 1;
        Console.WriteLine($"好的,将生成{number_time}次密码");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("次数输入错误,请重试!");
    }
    
}
Console.WriteLine("");
while (true)
{
    gen_time += 1;
    if (gen_time <= number_time)
    {
        while (true)
{
    bit += 1;
    if (bit <= password_bit)
    {
        int bit_type = RandomNumberGenerator.GetInt32(1, 11);
        if (is_special_char)
        {
            switch (bit_type)
            {
                case 1:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 2:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 3:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 4:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 5:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                case 6:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                case 7:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                case 8:
                    bit_is = RandomNumberGenerator.GetInt32(0, special_char.Length);
                    password_gen += special_char[bit_is];
                    break;
                case 9:
                    bit_is = RandomNumberGenerator.GetInt32(0, special_char.Length);
                    password_gen += special_char[bit_is];
                    break;
                case 10:
                    bit_is = RandomNumberGenerator.GetInt32(0, special_char.Length);
                    password_gen += special_char[bit_is];
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (bit_type)
            {
                case 1:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 2:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 3:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 4:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 5:
                    bit_is = RandomNumberGenerator.GetInt32(0, letter.Length);
                    password_gen += letter[bit_is];
                    break;
                case 6:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                case 7:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                case 8:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                case 9:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                case 10:
                    bit_is = RandomNumberGenerator.GetInt32(0, digital.Length);
                    password_gen += digital[bit_is];
                    break;
                default:
                    break;
            }
        }
    }
    else
    {
        break;
    }

}
    }
    else
    {
        Console.WriteLine(password_gen);
        break;
    }
    if (gen_time == 1)
    {
        Console.WriteLine("密码生成完毕,您的密码为: ");
    }
Console.WriteLine(password_gen);
    password_gen = "";
    bit = 0;
}
Console.WriteLine("请牢记您的密码,欢迎您下次使用!");

