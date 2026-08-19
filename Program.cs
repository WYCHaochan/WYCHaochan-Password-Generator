using System.Security.Cryptography;
int password_bit;
bool is_special_char;
int number_time;
string letter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
string digital = "0123456789";
string special_char = "@#$%&*!";
int bit = 0;
string password_gen = "";
int bit_is;
int gen_time = 0;
string? input;
string pool = "";
Console.WriteLine("欢迎使用 皓叶草密码生成器！");
Console.WriteLine("");
while (true)
{
    Console.Write("请输入要生成的位数(请输入数字(4-96),留空默认为8位,最少4位,最多96位): ");
    input = Console.ReadLine();
    if (int.TryParse(input, out int result))
    {
        if (result >= 4 && result <= 96)
        {
            password_bit = result;
            Console.WriteLine($"您的密码位数将生成{password_bit}位");
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"您输入的{result}位数暂不支持!");
        }
    }
    else if (input == "")
    {
        password_bit = 8;
        Console.WriteLine($"您的密码位数将生成{password_bit}位");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("位数输入错误,请重试!");
    }
}
Console.WriteLine("");
while (true)
{
    Console.Write("密码中是否要包含特殊字符(Y为是,N为否,留空默认为N): ");
    input = (Console.ReadLine())?.ToUpper();
    if (input == "Y")
    {
        is_special_char = true;
        Console.WriteLine("好的,生成的密码将包含特殊字符");
        break;
    }
    else if (input == "N")
    {
        is_special_char = false;
        Console.WriteLine("好的,生成的密码将不包含特殊字符");
        break;
    }
    else if (input == "")
    {
        is_special_char = false;
        Console.WriteLine("好的,生成的密码将不包含特殊字符");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("您的输入不合法,请重试!");
    }
}
Console.WriteLine("");
while (true)
{
    Console.Write("请输入生成次数(数字(1-32),留空为1次): ");
    input = Console.ReadLine();
    if (int.TryParse(input, out int result))
    {
        if(result>=1 && result <= 32)
        {
        number_time = result;
        Console.WriteLine($"好的,将生成{number_time}次密码");
        break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"您的输入次数{result}超出合理范围,请重试!");
        }
        
    }
    else if (input == "")
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
if (is_special_char)
{
    pool = letter + special_char + digital;
}
else
{
    pool = digital + letter;
}
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
                    bit_is = RandomNumberGenerator.GetInt32(0, pool.Length);
                    password_gen += pool[bit_is];
                }
                else
                {
                    break;
                }
            }
        }
        else
        {
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

