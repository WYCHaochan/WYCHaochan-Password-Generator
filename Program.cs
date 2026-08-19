using System.Security.Cryptography;
int password_length;
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
while (true)
{
    Console.WriteLine("");
    password_length = GetPasswordLength();
    Console.WriteLine("");
    is_special_char = GetIsSpecialChar();
    Console.WriteLine("");
    number_time = GetNumberTime();
    Console.WriteLine("");
    OutputInfo(password_length, is_special_char, number_time);
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
                if (bit <= password_length)
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
    Console.WriteLine();
    Console.WriteLine("请牢记您的密码,如果重新生成将会清除当前密码显示");
    Console.WriteLine();
    Console.Write("要继续生成新的一组密码吗(Y为是,N为否,留空默认为N)");
    input = (Console.ReadLine())?.ToUpper();
    if (input == "Y")
    {
        pool = "";
        bit = 0;
        password_gen = "";
        gen_time = 0;
        Console.Clear();
        Console.Write("好的,欢迎您再次使用 皓叶草密码生成器!");

    }
    else if (input == "N")
    {
        Console.Write("好的,下次再见!");
        break;
    }
    else if (input == "")
    {
        Console.Write("好的,下次再见!");
        break;
    }
    else
    {
        Console.Write("您的输入不合法,请重新输入!");
    }

    static int GetPasswordLength()
    {
        string? input;
        while (true)
        {
            Console.Write("请输入要生成的位数(请输入数字(4-96),留空默认为8位,最少4位,最多96位): ");
            input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                if (result >= 4 && result <= 96)
                {
                    Console.WriteLine($"您的密码位数将生成{result}位");
                    return result;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"您输入的{result}位数暂不支持!");
                }
            }
            else if (input == "")
            {
                Console.WriteLine("您的密码位数将生成8位");
                return 8;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("位数输入错误,请重试!");
            }
        }
    }
    static bool GetIsSpecialChar()
    {
        string? input;
        while (true)
        {
            Console.Write("密码中是否要包含特殊字符(Y为是,N为否,留空默认为N): ");
            input = (Console.ReadLine())?.ToUpper();
            if (input == "Y")
            {
                Console.WriteLine("好的,生成的密码将包含特殊字符");
                return true;
            }
            else if (input == "N")
            {
                Console.WriteLine("好的,生成的密码将不包含特殊字符");
                return false;
            }
            else if (input == "")
            {
                Console.WriteLine("好的,生成的密码将不包含特殊字符");
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("您的输入不合法,请重试!");
            }
        }
    }
    static int GetNumberTime()
    {
        string? input;
        while (true)
        {
            Console.Write("请输入生成次数(数字(1-32),留空为1次): ");
            input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                if (result >= 1 && result <= 32)
                {
                    Console.WriteLine($"好的,将生成{result}次密码");
                    return result;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"您的输入次数{result}超出合理范围,请重试!");
                }

            }
            else if (input == "")
            {
                Console.WriteLine("好的,将生成1次密码");
                return 1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("次数输入错误,请重试!");
            }
        }
    }
    void OutputInfo(int password_length,bool is_spcial_char,int number_time)
    {
        Console.WriteLine("======生成密码配置如下======");
        Console.WriteLine($"生成密码长度: {password_length}位");
        Console.WriteLine($"包含特殊字符: {is_spcial_char}");
        Console.WriteLine($"生成密码次数: {number_time}次");
        Console.WriteLine();
    }
}

