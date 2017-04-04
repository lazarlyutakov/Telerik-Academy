using System;

class jumpJump
{
    static void Main()
    {
        string jumpInstr = Console.ReadLine();

        for (int i = 0; i < jumpInstr.Length; i++)
        {
            if ((jumpInstr[i] - '0') == 0)
            {
                Console.WriteLine("Too drunk to go on after {0}!", i);
                break;
            }
            else if (jumpInstr[i] == '^')
            {
                Console.WriteLine("Jump, Jump, DJ Tomekk kommt at {0}!", i);
                break;
            }
            if ((jumpInstr[i] - '0') % 2 == 0)
            {
                i += (jumpInstr[i] - '0' - 1);

                if (i >= jumpInstr.Length)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", i + 1);
                    break;
                }
            }
            else if ((jumpInstr[i] - '0') % 2 != 0)
            {
                i = (i - (jumpInstr[i] - '0')) - 1;

                if (i < 0)
                {
                    Console.WriteLine("Fell off the dancefloor at {0}!", i + 1);
                    break;
                }
            }
        }
    }
}

